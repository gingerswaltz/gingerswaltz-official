using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace DatabaseApp
{
    internal class DBFunc
    {


   public DataTable GetDataFromSQL(string connectionString, string query)
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


}
}
