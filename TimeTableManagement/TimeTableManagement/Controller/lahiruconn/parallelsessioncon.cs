using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagement.DBConnection;

namespace TimeTableManagement.Controller.lahiruconn
{
    class parallelsessioncon
    {


        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public  parallelsessioncon()
        {
            con = DBConnection.getDBConnection();
        }

        public SqlDataReader load_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Session ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public SqlDataReader load_subject_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT SubName,SubCode  from SubjectTable ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;



        }

        public SqlDataReader loadtagdetailsvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Tag_Name from  Tag_table";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }









        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }




    }





}
