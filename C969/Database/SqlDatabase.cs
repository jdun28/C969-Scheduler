using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleProgram.Database
{
    class SqlDatabase
    {
        public readonly string Server = "3.227.166.251";
        public readonly string Database = "U06Etk";
        public readonly string Uname = "U06Etk";
        public readonly string DbPass = "53688740958";

        public string ConnectionString
        {
            get { return $"SERVER={Server}; DATABASE={Database}; Username ={Uname}; Password={DbPass};" + "SslMode = None; Convert Zero Datetime = True;"; }
        }

    }
}
