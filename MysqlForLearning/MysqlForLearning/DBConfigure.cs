using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlForLearning
{
    public static class DBConfigure
    {
        public static string GetMaster()
        {
            return $"Server={masterIp};Database={database}; User={user};Password={password};";
        }
        public static string GetSlave()
        {
            return $"Server={slaveIp};Database={database}; User={user};Password={password};";
        }
        private static string slaveIp = "45.32.172.100";
        private static string masterIp = "65.49.207.14";
        private static string user = "test";
        private static string password = "test";
        private static string database = "mytest";

    }
}
