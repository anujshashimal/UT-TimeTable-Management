using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using System.Windows.Forms;
using System.Data;
using TimeTableManagement.Model.TimeTableModel;

namespace TimeTableManagement.Controller.TimeTableCon
{
    class NumberOfWorkingDaysCon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public NumberOfWorkingDaysCon()
        {
            con = DBConnection.getDBConnection2();
        }



        public void insertNumberOfWorkingDays(NumberOfWorkingDaysModel numberOfWorkingDaysModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO NumberOfWorkingDays(Weekday,Weekend)  VALUES ('" + numberOfWorkingDaysModel.WeekdayDays + "','" + numberOfWorkingDaysModel.WeekendDays + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadnumberOfWorkingDayvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from NumberOfWorkingDays";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();
            dr.Close();

            return dr;

        }

        public void updateNumberOfWorkingDays(NumberOfWorkingDaysModel numberOfWorkingDaysModel)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE NumberOfWorkingDays SET Weekday='" + numberOfWorkingDaysModel.WeekdayDays + "', Weekend='" + numberOfWorkingDaysModel.WeekendDays + "' WHERE id = '" + numberOfWorkingDaysModel.Id + "'";
            SqlCommand com = new SqlCommand(sql, con);
            
            string ans = MessageBox.Show("Are sure to Update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records Updated" + ret, "Information");


            }
            con.Close();
        }

        public void DeleteNumberOfWorkingDays(NumberOfWorkingDaysModel numberOfWorkingDaysModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  NumberOfWorkingDays  WHERE id ='" + numberOfWorkingDaysModel.Id + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }

        public DataTable getdatatoTable()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT * from NumberOfWorkingDays";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }
    }
}
