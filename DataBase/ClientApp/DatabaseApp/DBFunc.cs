using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace DatabaseApp
{

    public class MyData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Requisites { get; set; }
        public string ContactPerson { get; set; }
        public int Id { get; set; }
    }


    internal class DBFunc
    {
        string connectionString = "Server=127.0.0.1;Port=5432;Database=arenda;User Id=postgres;Password=1;";
        string query = "SELECT * FROM \"клиент\"";

        public DataTable GetDataFromSQL()
    {
        using (var connection = GetPostgresConnection(connectionString))
        {
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
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


        public static int InsertDataToPostgreSQL(string connectionString, string tableName, MyData data)
        {
            using (var connection = GetPostgresConnection(connectionString))
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO {tableName} (name, address, phone, requisites, contact_person, id) VALUES (@name, @address, @phone, @requisites, @contactPerson, @id)";
                    command.Parameters.AddWithValue("@name", data.Name);
                    command.Parameters.AddWithValue("@address", data.Address);
                    command.Parameters.AddWithValue("@phone", data.Phone);
                    command.Parameters.AddWithValue("@requisites", data.Requisites);
                    command.Parameters.AddWithValue("@contactPerson", data.ContactPerson);
                    command.Parameters.AddWithValue("@id", data.Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }


}

