using sirema.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.Model
{
    public class User
    {
        private string userId;
        private string namaLengkap;
        private string status;

        private string query;
        private PostgresConnection connection;
        private DataTable tmp;

        public string UserId
        {
            set { userId = value; }
            get { return  userId; }
        }

        public string NamaLengkap
        {
            set { namaLengkap = value; }
            get {  return namaLengkap; }
        }

        public string Status
        {
            set { status = value; }
            get { return status; }
        }

        public User()
        {
            userId = string.Empty;
            namaLengkap = string.Empty;
            status = string.Empty;
            

            connection = new PostgresConnection();
            tmp = new DataTable();

            query = string.Empty;
        }

        public bool isExist(string username, string password)
        {
            bool result = false;
            query = $"select user_id from tbl_user where user_id='{username}' and password='{password}'";
            tmp = connection.execQuery(query);
            if (tmp.Rows.Count > 0)
            {
                result = true ;
            }
            return result;
        }

        public string login(string username, string password)
        {
            string result = string.Empty;
            if (isExist(username, password))
            {
                query = $"select user_id, nama_pengguna, status from tbl_user where user_id='{username}' and password='{password}'";
                tmp = connection.execQuery(query);

                if (tmp.Rows.Count > 0)
                {
                    foreach (DataRow row in tmp.Rows)
                    {
                        userId = row[0].ToString();
                        namaLengkap = row[1].ToString();
                        status = row[2].ToString();

                        result = namaLengkap;
                    }
                }
            }
            return result ;
        }
    }
}
