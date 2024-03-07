using sirema.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.Model
{
    internal class Prodi
    {
        private string kodeProdi;
        private string namaProdi;
        private string kodeJurusan;
        PostgresConnection connection;
        DataTable tmp;

        string query;

        public Prodi()
        { 
            kodeJurusan = string.Empty;
            kodeProdi = string.Empty;
            namaProdi = string.Empty;
            connection = new PostgresConnection();
            query = string.Empty;
            tmp = new DataTable();
        }

        public string KodeProdi
        {
            set { kodeProdi = value; }
        }

        public string NamaProdi
        {
            set { namaProdi = value; }
        }

        public string KodeJurusan
        {
            set { kodeJurusan = value; }
        }


        public bool isExist(string kode)
        {
            bool result = false;
            query = "select * from prodi where kode_prodi = '" + kode + "'";

            tmp = connection.execQuery(query);

            if (tmp.Rows.Count > 0)
            {
                result = true;
            }

            return result;
        }

        public int addProdi()
        {
            int result = -1;
            query = $"insert into prodi(kode_prodi, nama_prodi, kode_jurusan) values ('{kodeProdi}','{namaProdi}','{kodeJurusan}')";

            try
            {
                result = connection.exec(query) ;

                if( result < 0)
                {
                    throw new Exception("Data gagal disimpan");
                }
            }catch (Exception ex)
            {

            }
            return result;
        }

        public int updateData(string namaProdi, string kodeJurusan)
        {
            int result = -1;
            query = $"update prodi set nama_prodi = '{namaProdi}', kode_jurusan ='{kodeJurusan}' where kode_prodi='{kodeProdi}'";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Data gagal diubah");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        public int deleteData()
        {
            int result = -1;
            query = $"delete from prodi where kode_prodi='{kodeProdi}'";

            try
            {
                result = connection.exec(query);
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }

        public DataTable getAll()
        {
            query = "select * from prodi";
            tmp = connection.execQuery(query);
            return tmp;
        }

        public string getNextId()
        {
            int result = -1;
            query = "select coalesce(cast(max(kode_prodi) as int)+1,1) from prodi";
            tmp = connection.execQuery(query);

            if (tmp.Rows.Count > 0)
            {
                foreach (DataRow row in tmp.Rows)
                {
                    result = int.Parse(row[0].ToString());
                }
            }
            return result.ToString("00.");
        }

        public DataTable findDataByName(string name)
        {
            query = $"select * from prodi where lower(nama_prodi) like '%{name.ToLower()}%'";
            tmp = connection.execQuery(query);
            return tmp;
        }
    }
}
