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
    class TimeSloatCon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public TimeSloatCon()
        {
            con = DBConnection.getDBConnection2();
        }

        public void insertTimeSloat(TimeSloatModel timeSloatModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO TimeSlots(Type,startTime,endTime)  VALUES ('" + timeSloatModel.Type + "','" + timeSloatModel.StartTime + "' ,'" + timeSloatModel.EndTime + "')";
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
            string query = "SELECT * from TimeSlots";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public void updateTimeSloat(TimeSloatModel timeSloatModel)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE TimeSlots SET Type='" + timeSloatModel.Type + "', startTime='" + timeSloatModel.StartTime + "' , endTime='" + timeSloatModel.EndTime + "' WHERE id = '" + timeSloatModel.Id + "'";
            SqlCommand com = new SqlCommand(sql, con);

            string ans = System.Windows.MessageBox.Show("Are sure to Update this record?", "Warning", (MessageBoxButton)MessageBoxButtons.YesNo, (MessageBoxImage)MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.MessageBox.Show("No of records Updated" + ret, "Information");


            }
            con.Close();
        }

        public void DeleteTimeSloat(TimeSloatModel timeSloatModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  TimeSlots  WHERE id ='" + timeSloatModel.Id + "'";
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
