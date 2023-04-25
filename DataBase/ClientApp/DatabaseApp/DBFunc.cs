using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DatabaseApp
{

    public class MyData
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Requisites { get; set; }
        public string ContactPerson { get; set; }
        public int Id { get; set; }
    }


    internal class DBFunc
    {
        static string connectionString = "Server=127.0.0.1;Port=5432;Database=arenda_db;User Id=postgres;Password=1;";


        public void SaveToCsv(IEnumerable<string> columnNames, IEnumerable<IEnumerable<string>> data, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Записываем заголовки столбцов в файл, кроме последнего столбца
                foreach (var columnName in columnNames.Take(columnNames.Count() - 1))
                {
                    writer.Write(columnName);
                    if (columnName != columnNames.ElementAt(columnNames.Count() - 2))
                    {
                        writer.Write(",");
                    }
                }
                writer.Write(writer.NewLine);

                // Записываем данные в файл, пропуская последний столбец
                foreach (var row in data)
                {
                    foreach (var value in row.Take(row.Count() - 1))
                    {
                        writer.Write(value != null ? value.ToString() : "");
                        if (value != row.ElementAt(row.Count() - 2))
                        {
                            writer.Write(",");
                        }
                    }
                    if (row != data.Last())
                    {
                        writer.Write(writer.NewLine);
                    }
                }
            }
        }








        public void LoadDataFromCsvToPostgres(string filePath = "output.csv")
        {
            filePath = Path.Combine(Application.StartupPath, filePath);

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = 
                        $@"CREATE TEMP TABLE temp_client (name text, adress text, phone text, requisites text, contact_name text);
                         COPY temp_client (name, adress, phone, requisites, contact_name) FROM '{filePath}' DELIMITER ',' CSV HEADER;
                         INSERT INTO клиент (name, adress, phone, requisites, contact_name) 
                         SELECT t.name, t.adress, t.phone, t.requisites, t.contact_name
                         FROM temp_client t
                         ON CONFLICT DO NOTHING;";
                    command.ExecuteNonQuery();
                }
            }
        }





        public DataTable GetDataFromSQL()
        {
            string query = "SELECT * FROM \"клиент\"";
            using (var connection = GetPostgresConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.FillSchema(dataTable, SchemaType.Source);
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        public static NpgsqlConnection GetPostgresConnection(string connectionString)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void DeleteRecordById(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM \"клиент\" WHERE id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int InsertDataToPostgreSQL(MyData data)
        {
            using (var connection = GetPostgresConnection(connectionString))
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO \"клиент\" (name, adress, phone, requisites, contact_name) VALUES (@name, @adress, @phone, @requisites, @contact_name)";
                    command.Parameters.AddWithValue("@name", data.Name);
                    command.Parameters.AddWithValue("@adress", data.Adress);
                    command.Parameters.AddWithValue("@phone", data.Phone);
                    command.Parameters.AddWithValue("@requisites", data.Requisites);
                    command.Parameters.AddWithValue("@contact_name", data.ContactPerson);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }


}

