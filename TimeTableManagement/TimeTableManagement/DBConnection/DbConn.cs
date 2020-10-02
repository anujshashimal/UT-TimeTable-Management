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
            string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aux - 138\Documents\FT_FB.mdf; Integrated Security = True; Connect Timeout = 30;MultipleActiveResultSets = True";


            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection1()
        {

            string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aux - 138\Documents\FT_FB.mdf; Integrated Security = True; Connect Timeout = 30;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection2()
        {

            string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aux - 138\Documents\FT_FB.mdf; Integrated Security = True; Connect Timeout = 30;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public SqlConnection getDBConnection3()
        {

            string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aux - 138\Documents\FT_FB.mdf; Integrated Security = True; Connect Timeout = 30;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }


    }






}
