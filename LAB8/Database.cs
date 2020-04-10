using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LAB8
{
    public sealed class Database
    {
        private static Database _instance = null;

        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private SqlCommand command;

        private Database()
        {
            string conString = "Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007";
            this.connection = new SqlConnection(conString);
        }

        public static Database Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }
                return _instance;
            }
        }

        public DataTable LoadData(string sql)
        {
            DataTable table = new DataTable();

            adapter = new SqlDataAdapter(sql, this.connection);
            adapter.Fill(table);

            return table;
        }

        public List<string> ReadData(string sql)
        {
            SqlDataReader sqlDataReader;
            List<string> data = new List<string>();
            command = new SqlCommand(sql, this.connection);

            this.connection.Open();
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read()) {
                data.Add(sqlDataReader["name"].ToString());
            }
            this.connection.Close();

            return data;
        }
    }
}
