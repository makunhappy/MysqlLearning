using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlForLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext dbContext = new DbContext();
            dbContext.SetConnectStrnig(DBConfigure.GetSlave());
            dbContext.GetData("select * from Info");
            Console.Read();
        }
    }
}
