using sirema.Config;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.Model
{
    internal class Jurusan
    {
        private string kodeJurusan;
        private string namaJurusan;
        Connection connection;
        DataTable tmp;

        string query;

        public Jurusan()
        {
            kodeJurusan = string.Empty;
            namaJurusan= string.Empty;
            connection = new Connection();
            query = string.Empty;
            tmp = new DataTable();
        }

        public string KodeJurusan
        {
            set { kodeJurusan = value;}
        }

        public string NamaJurusan
        {
            set { namaJurusan = value; }
        }

        public bool isExist(string kode)
        {
            bool result = false;
            query = "select * from jurusan where kode_jurusan = '" + kode+"'";

            tmp = connection.execQuery(query);

            if(tmp.Rows.Count > 0)
            {
                result = true;
            }

            return result;
        }

        public int addData()
        {
            int result = -1;
            query = $"insert into jurusan(kode_jurusan, nama_jurusan) values('{kodeJurusan}','{namaJurusan}')";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Data gagal disimpan");
                }
            }catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }
        public int updateData()
        {
            int result = -1;
            query = $"update jurusan set nama_jurusan = '{namaJurusan}' where kode_jurusan='{kodeJurusan}'";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Data gagal disimpan");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        public int deleteData()
        {
            int result = -1;
            query = $"delete from jurusan where kode_jurusan='{kodeJurusan}'";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Data gagal disimpan");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        public DataTable getAll()
        {
            query = "select * from jurusan";
            tmp = connection.execQuery(query);
            return tmp;
        }

        public string getNextId()
        {
            int result = -1;
            query = "select coalesce(cast(max(kode_jurusan) as int)+1,1) from jurusan";
            tmp = connection.execQuery(query);
            
            if(tmp.Rows.Count > 0)
            {
                foreach(DataRow row in tmp.Rows)
                {
                    result = int.Parse(row[0].ToString());
                }
            }
            return result.ToString("00.");
        }

        public DataTable findDataByName(string name)
        {
            query = $"select * from jurusan where lower(nama_jurusan) like '%{name.ToLower()}%'";
            tmp = connection.execQuery(query);
            return tmp;
        }
    }
}
