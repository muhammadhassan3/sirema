using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace sirema.Config
{
    internal class Connection : Config
    {

        NpgsqlCommand cmd;
        NpgsqlConnection con;
        NpgsqlDataAdapter adapter;

        public Connection()
        {
            con = new NpgsqlConnection(
                connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=sirema"
            );
            cmd = new NpgsqlCommand();
            adapter = new NpgsqlDataAdapter();
        }

        void open()
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }catch(Exception e)
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
            catch(Exception e) { Console.WriteLine(e.Message); }
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
