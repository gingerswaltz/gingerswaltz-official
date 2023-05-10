// todo: 
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.IdentityModel.Tokens;
using Npgsql; // nuget пакет, позволяющий работать с Postgres
using System.Data;
using System.Globalization;
using System.Diagnostics;

namespace DatabaseApp
{

    public class ClientData
    {
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string requisites { get; set; }
        public string contact_name { get; set; }

    }


    public class DBFunc
    {
        string FilePath = "output.csv";

        string connectionString;


        public void SetFilePath(string filePath)
        {
            if (!filePath.IsNullOrEmpty())
            {
                FilePath = filePath + ".csv";
            }
            else FilePath = "output.csv";

        }


        public string GetFilePath()
        {
            return FilePath;
        }
        void SetConnectionAdress(string ip, string port, string dbname, string username, string password)
        {
            connectionString = $"Server={ip};Port={port};Database={dbname};User Id={username};Password={password};";
        }


        public DBFunc(string ip = "127.0.0.1", string port = "5432", string dbname = "arenda_castrated", string username = "postgres", string password = "1") // конструктор для задания подключения по выбору
        {
            SetConnectionAdress(ip, port, dbname, username, password);

        }
        public void SaveToCsv(DataTable table)
        {
            using (var writer = new StreamWriter(FilePath))
            {
                // Записываем заголовки столбцов в файл
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write(column.ColumnName);
                    if (column != table.Columns[table.Columns.Count - 1])
                    {
                        writer.Write(";");
                    }
                }
                writer.Write(writer.NewLine);

                // Записываем данные в файл
                foreach (DataRow row in table.Rows)
                {
                    foreach (var value in row.ItemArray)
                    {
                        writer.Write(value != null ? value.ToString() : "");
                        if (value != row.ItemArray[row.ItemArray.Length - 1])
                        {
                            writer.Write(";");
                        }
                    }
                    writer.Write(writer.NewLine);
                }
            }
        }



        public List<DataRow> Search(string name)
        {
            var result = new List<DataRow>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand($"SELECT * FROM \"клиент\" WHERE name = '{name}'", connection);
                var adapter = new NpgsqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        result.Add(row);
                    }
                }
            }

            return result;
        }





        public void LoadDataFromCsvToPostgres()
        {
            using (var reader = new StreamReader(FilePath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                };
                using (var csv = new CsvReader(reader, config))
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    var records = csv.GetRecords<ClientData>(); // ClientData - класс, представляющий записи из CSV
                    foreach (var record in records)
                    {
                        var command = new NpgsqlCommand("INSERT INTO \"клиент\" (name, contact_name, phone, adress, requisites) VALUES (@p1, @p2, @p3, @p4, @p5) ON CONFLICT DO NOTHING", connection);
                        command.Parameters.AddWithValue("@p1", record.name);
                        command.Parameters.AddWithValue("@p2", record.contact_name);
                        command.Parameters.AddWithValue("@p3", record.phone);
                        command.Parameters.AddWithValue("@p4", record.adress);
                        command.Parameters.AddWithValue("@p5", record.requisites);

                        command.ExecuteNonQuery();
                    }
                }
            }

        }



        public DataTable GetDataFromSQL()
        {
            string query = "SELECT * FROM \"клиент\"";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    /// NpgsqlDataAdapter это класс в библиотеке Npgsql, который используется для заполнения DataSet или DataTable данными из источника данных PostgreSQL.
                    ///  Он позволяет выполнять запросы к базе данных и получать результаты в виде таблиц, 
                    ///  которые могут быть использованы в приложении для отображения данных в пользовательском интерфейсе.
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable(); // Создание нового экземпляра класса DataTable, который будет содержать результаты выборки.
                        adapter.FillSchema(dataTable, SchemaType.Source); // добавлениe схемы таблицы в экземпляр класса DataTable. SchemaType.Source указывает, что схема будет соответствовать источнику данных.
                        adapter.Fill(dataTable); //  для заполнения таблицы данными.
                        return dataTable;
                    }
                }
            }
        }


        public DataTable GetUpdatedDataFromPostgres()
        {
            var dataTable = new DataTable();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                var command = new NpgsqlCommand("SELECT * FROM \"клиент\"", connection);
                var adapter = new NpgsqlDataAdapter(command);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public void DeleteRecordById(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))// Эта строка создает новое подключение к базе данных PostgreSQL
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())//  Эта строка создает новый объект NpgsqlCommand, который представляет SQL-команду, которую мы хотим выполнить. 
                {
                    cmd.Connection = conn; // Эта строка устанавливает соединение для объекта cmd, указывая, что он будет использовать ранее созданное подключение conn.
                    cmd.CommandText = "DELETE FROM \"клиент\" WHERE id = @id"; // Эта строка устанавливает текст SQL-запроса, который будет выполнен
                    cmd.Parameters.AddWithValue("id", id); //  Эта строка добавляет параметр к команде. В данном случае, параметр "id" соответствует значению переменной id. 
                    cmd.ExecuteNonQuery(); // возврат количества затронутых строк
                }
            }
        }

        public void InsertDataToPostgreSQL(ClientData data)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    //  задаем текст SQL-команды для выполнения. В данном случае это SQL-запрос на вставку новых данных в таблицу "клиент".
                    command.CommandText = $"INSERT INTO \"клиент\" (name, adress, phone, requisites, contact_name) VALUES (@name, @adress, @phone, @requisites, @contact_name)";
                    command.Parameters.AddWithValue("@name", data.name);
                    command.Parameters.AddWithValue("@adress", data.adress);
                    command.Parameters.AddWithValue("@phone", data.phone);
                    command.Parameters.AddWithValue("@requisites", data.requisites);
                    command.Parameters.AddWithValue("@contact_name", data.contact_name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable SortById()
        {
            string query = "SELECT * FROM \"клиент\" ORDER BY ID ASC;";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

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





    }
}





