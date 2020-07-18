using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleProgram.Universal
{
    class SqlDatabase
    {
        public static string Server = "3.227.166.251";
        public static string Database = "U06EtK";
        public static string Uid = "U06EtK";
        public static string Password = "53688740958";

        public static string ConnectionString => $"SERVER={Server}; DATABASE={Database}; Uid ={Uid}; Pwd={Password}; SslMode=None; Convert Zero Datetime = true";
    }
}
