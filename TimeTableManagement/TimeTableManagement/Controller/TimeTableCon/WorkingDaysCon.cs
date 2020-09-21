using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.TimeTableModel;

namespace TimeTableManagement.Controller.TimeTableCon
{
    class WorkingDaysCon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public WorkingDaysCon()
        {
            con = DBConnection.getDBConnection2();
        }

        public void insertWorkingDays(WorkingDaysModel workingDaysModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO WorkingDays(day,type)  VALUES ('" + workingDaysModel.Day + "','" + workingDaysModel.Type + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            System.Windows.MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public DataTable getdatatoTable()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT * from WorkingDays";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public void updateWorkingDays(WorkingDaysModel workingDaysModel)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE WorkingDays SET day='" + workingDaysModel.Day + "', type='" + workingDaysModel.Type + "' WHERE id = '" + workingDaysModel.Id + "'";
            SqlCommand com = new SqlCommand(sql, con);

            string ans = System.Windows.MessageBox.Show("Are sure to Update this record?", "Warning", (MessageBoxButton)MessageBoxButtons.YesNo, (MessageBoxImage)MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.MessageBox.Show("No of records Updated" + ret, "Information");


            }
            con.Close();
        }

        public void DeleteWorkingDays(WorkingDaysModel workingDaysModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  WorkingDays  WHERE id ='" + workingDaysModel.Id + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = System.Windows.MessageBox.Show("Are sure to delete this record?", "Warning", (MessageBoxButton)MessageBoxButtons.YesNo, (MessageBoxImage)MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

    }
}
