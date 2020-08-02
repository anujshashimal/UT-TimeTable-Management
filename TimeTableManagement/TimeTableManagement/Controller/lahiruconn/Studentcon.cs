using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.lahirumodel;
using System.Windows.Forms;

namespace TimeTableManagement.Controller.lahiruconn
{
    class Studentcon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public Studentcon()
        {
            con = DBConnection.getDBConnection1();
        }


        public void insertAcademicyearsemesterDetails(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Academicyrsemtable(AcademicYrsem)  VALUES ('" + studentMod.Academicyearsemester1+ "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadacademicyrsemestervalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT AcademicYrsem from Academicyrsemtable";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();
           
            return dr;

        }


        public SqlDataReader loadacademicyrsemesterallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Academicyrsemtable";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public void updateacademicyrandsem(studentmodel studentMod)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE  Academicyrsemtable  SET AcademicYrsem='" + studentMod.Academicyearsemester1 + "' WHERE AcademicYrsemId = '" + studentMod.Academicyearsemester_id1 + "'";
            SqlDataAdapter sad = new SqlDataAdapter(sql,con);
            sad.SelectCommand.ExecuteNonQuery();
            
            MessageBox.Show(" Record have been updated", "Information");

         

        }

        public void DeleteAcademicyearsem(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM   Academicyrsemtable  WHERE  AcademicYrsemId='" + studentMod.Academicyearsemester_id1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();



        }







        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }
    }
}
