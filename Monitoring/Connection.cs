using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Monitoring
{
    class Connection
    {
        
        static string strConn = "Server=localhost;Database=ids;Uid=root;Pwd=;";
        static MySqlConnection conn = new MySqlConnection(strConn);
        private DataSet ds;

        public DataSet SelectData(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "log");
                return ds;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
                return ds;
        }


        public void InsertData()
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO members (id, pwd, name) " +
                                "VALUES ('gon', '111', '김삿갓')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    
    
    }
}
