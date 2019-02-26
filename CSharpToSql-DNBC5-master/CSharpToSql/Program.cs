using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSharpToSql {
    class Program {
       // DSI-WORKSTATION\SQLEXPRESS
        static void Main(string[] args) {
           // var user = new User();
            var user = new User(0, "xxx8", "xxx2", "UserX", "UserX", "5135552323", "info@user.com", true, true);
            var returnCode = User.InsertUser(user);
            User[] users = User.GetAllUsers();
            foreach(var u in users) {
                if(u == null) {
                    continue;
                }
                Console.WriteLine(u);
            }
            const int ID = 8;
            User userpk = User.GetUserByPrimaryKey(ID);
            Console.WriteLine(userpk);

            userpk.Password = "ABCXYZ";
            var updateSuccess = User.UpdateUser(userpk);
            if (updateSuccess)
            {
                Console.WriteLine("Update Successful");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }

            var deleteSuccess = User.DeleteUser(ID);
            if (deleteSuccess == false)
            {
                Console.WriteLine("Delete Failed");
            }
            deleteSuccess = User.DeleteUser(6);
            if (!deleteSuccess)
            {
                Console.WriteLine("non-existent Id");
            }

            Console.ReadKey();
        }
    }
}
