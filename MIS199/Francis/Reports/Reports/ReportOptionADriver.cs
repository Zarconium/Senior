using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Reports
{
    class ReportOptionADriver
    {
        MySqlConnection conn;

        public ReportOptionADriver(string server, string user, string password, string persistSecurityInfo, string database)
        {
            string connStr = "server=" + server + ";User Id=" + user + ";password=" + password + ";Persist Security Info=" + persistSecurityInfo + ";database=" + database + "";
            conn = new MySqlConnection(connStr);
            conn.Open();
            conn.Close();
        }

        public DataSet Set1()
        {
            DataSet result = new DataSet();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM audit_finding_t", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM audit_finding_t", conn);

            conn.Open();
            adapter.Fill(result);
            conn.Close();

            return result;
        }

        public DataTable Table1()
        {
            DataTable result = new DataTable();

            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM audit_finding_t", conn);

            conn.Open();
            ad.Fill(result);
            result.TableName = "Sample Table Name";
            conn.Close();

            return result;
        }
    }
}
