using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.lahirumodel;


namespace TimeTableManagement.Controller.lahiruconn
{
    class consecutivesession
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public consecutivesession()
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

            string query = "SELECT SubName  from SubjectTable ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;



        }


        public void insertConcecutiveDetails(consecutivemodel consecutivemodel )
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO  Consecutivetbl(subject,subjectcode,groupid,subgroupid,Tag1,Tag1timeduration,Tag2,Tag2timeduration,Tag3,Tag3timeduration,Totalhours)  VALUES ('" + consecutivemodel.subject + "','" + consecutivemodel.subjectcode + "','" + consecutivemodel.groupid + "','" + consecutivemodel.subgroupid + "','" + consecutivemodel.Tag1 + "','" + consecutivemodel.Tag1timeduration + "','" + consecutivemodel.Tag2 + "','" + consecutivemodel.Tag2timeduration + "','" + consecutivemodel.Tag3 + "','" + consecutivemodel.Tag3timeduration + "','" + consecutivemodel.total_hours + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }









        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }








    }
}
