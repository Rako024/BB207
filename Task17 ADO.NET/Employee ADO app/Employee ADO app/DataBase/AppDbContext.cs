using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ADO_app.DataBase
{
    internal class AppDbContext
    {
        string con = "server=DESKTOP-TOI5CDD;Database=Employee;Trusted_Connection=true;Integrated security=true;TrustServerCertificate=true";
        SqlConnection sqlConnection;
        public AppDbContext()
        {
            sqlConnection = new SqlConnection(con);
        }
        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }

        public DataTable Query(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlConnection.Close();
            return dt;

        }

    }
}
