using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.DBConnection
{
    class DbConn
    {
        public SqlConnection getDBConnection()
        {

            //    string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FT_FB.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets = True";
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets = True";
            String newSt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuj\Desktop\Sprint2\UT-TimeTable-Management\TimeTableManagement\TimeTableManagement\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets=True";

            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection1()
        {

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets = True";
            String newSt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuj\Desktop\Sprint2\UT-TimeTable-Management\TimeTableManagement\TimeTableManagement\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets=True";

            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection2()
        {

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets = True";
            String newSt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuj\Desktop\Sprint2\UT-TimeTable-Management\TimeTableManagement\TimeTableManagement\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets=True";

            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public SqlConnection getDBConnection3()
        {

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets = True";
            String newSt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuj\Desktop\Sprint2\UT-TimeTable-Management\TimeTableManagement\TimeTableManagement\DBNew.mdf;Integrated Security=True;MultipleActiveResultSets=True";

            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }


    }






}
