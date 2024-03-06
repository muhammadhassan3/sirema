using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirema.Config
{
    abstract class Config
    {
        //insert, update, delete method
        public abstract int exec(string query);

        //select method
        public abstract DataTable execQuery(string query);
    }
}
