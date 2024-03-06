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

        public int simpanData()
        {
            int result = -1;

            return result;
        }
    }
}
