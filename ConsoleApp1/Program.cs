using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\wwwli\\Desktop\\DB.mdb";

            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            OleDbCommand command = new OleDbCommand("select * from tb_user", connection);
            OleDbDataReader res = command.ExecuteReader();
            if (res.HasRows)
            {
                while(res.Read())
                //res.Read();
                {
                    string strusr = res["username"].ToString();
                    string strpsd = res["password"].ToString();
                    Console.WriteLine(strusr + " ---------- " + strpsd);
                    Console.WriteLine();
                }
            }
            
            //OleDbCommand command = new OleDbCommand("update [tb_user] set [password]='sss' where [username]='admin'", connection);
            /*OleDbCommand command = new OleDbCommand("insert into tb_user values ('testlizn','xzciloveyou')", connection);
            int res = command.ExecuteNonQuery();
            if (res > 0)
            {
                System.Console.WriteLine("success");
            }
            else
            {
                System.Console.WriteLine("unsuccess");

            }*/

        }
    }
}
