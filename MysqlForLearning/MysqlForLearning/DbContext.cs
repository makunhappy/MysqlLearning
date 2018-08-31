using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using MySql.Data.Types;

namespace MysqlForLearning
{
    public class DbContext
    {
        private string connectString = "";
        public DbContext()
        {
        }
        public void SetConnectStrnig(string con)
        {
            connectString = con;
        }
        public void GetData(string sql)
        {
            using (MySqlConnection con = new MySqlConnection(this.connectString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(sql, con))
                {
                    var dr= command.ExecuteReader();
                    while (dr.Read())//判断数据表中是否含有数据
                    {
                        Console.Write(dr[0].ToString() + ",");//输出用户标识
                        Console.WriteLine(dr[1].ToString());//输出用户密码
                    }
                    dr.Close();
                }
            }
        }
    }
}
