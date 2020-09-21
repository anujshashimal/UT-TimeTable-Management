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
    class NotAvaliablesession
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();


        public NotAvaliablesession()
        {
            con = DBConnection.getDBConnection();


        }


        public SqlDataReader load_lecturename_allvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT name  from  LecturerTbl";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public SqlDataReader load_Group_Id_allvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Group_number  from  Group_id";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }
        public SqlDataReader load_Sub_Group_Id_allvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Subgroup_id_value  from  Sub_group_id_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public void insertNotavaliableDetails(Notavaliablemodel notavamodel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO  NotAvaliable_tbl(Type,Type_name,Day,Time_From,Time_To,Avaliability)  VALUES ('" + notavamodel.type + "','" + notavamodel.type_name + "','" + notavamodel.day + "','" + notavamodel.timefrom + "','" + notavamodel.timeto + "','" + notavamodel.not_avaliable + "')";
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
