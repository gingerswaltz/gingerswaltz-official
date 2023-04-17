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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
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


    public int InsertDataToPostgreSQL()
        {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string insertQuery = $"INSERT INTO \"оплата\" VALUES ({},{}, {})";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@value1", column1Value);
                command.Parameters.AddWithValue("@value2", column2Value);
                command.Parameters.AddWithValue("@value3", column3Value);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;
            }
        }
    }


}
}
