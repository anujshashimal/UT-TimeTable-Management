﻿using System;
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


            string conString = @"Data Source=DESKTOP-2FO46M3;Initial Catalog=TimeTableDB;Integrated Security=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection1()
        {


            string conString = @"Data Source=DESKTOP-2FO46M3;Initial Catalog=TimeTableDB;Integrated Security=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection2()
        {


            string conString = @"Data Source=DESKTOP-2FO46M3;Initial Catalog=TimeTableDB;Integrated Security=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public SqlConnection getDBConnection3()
        {


            string conString = @"Data Source=DESKTOP-2FO46M3;Initial Catalog=TimeTableDB;Integrated Security=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }


    }






}
