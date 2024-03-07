using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.Config
{
    
    internal class MySqlConn: Config
    {
        MySqlCommand cmd;
        MySqlConnection con;
        MySqlDataAdapter adapter;
        const string link = "server=localhost;port=3306;uid=root;pwd=;database=sirema";

        public MySqlConn()
        {
            con = new MySqlConnection(
                link
            );
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        void open()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        void close()
        {
            con.Close();
        }

        public override int exec(string query)
        {
            open();
            int result = -1;
            try
            {
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { close(); }
            return result;
        }

        public override DataTable execQuery(string query)
        {
            open();
            DataTable result = new DataTable();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { close(); }
            return result;
        }
    }
}
