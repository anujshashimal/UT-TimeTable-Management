using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using System.Windows.Forms;
using System.Data;

namespace TimeTableManagement.Controller.LocationConn
{
    class LocationConn
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public LocationConn()
        {
            con = DBConnection.getDBConnection();
        }


        //Insert queries

        public void insertLocationDetails(locationModel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "INSERT INTO LocationTimeTable(locationID,locationName)  VALUES ('" + studentMod.locationPID + "','" + studentMod.locationPName + "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public void insertRoomDetails(locationModel studentMod)
        {
            if (con.State.ToString() != "Open")
            {con.Open();}

            string query = "INSERT INTO RoomTable(buildingName,roomID,roomName, roomCapacity,roomType)  VALUES ('" + studentMod.buildingName + "','" + studentMod.roomID + "','" + studentMod.roomName + "','" + studentMod.roomCapacity + "','" + studentMod.roomType +"')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        //Delete Queries
        public void DeleteLocationDet(locationModel studentMod)
        {
            if (con.State.ToString() != "Open")
            {con.Open();}

            string query = "DELETE  FROM   RoomTable  WHERE  roomID='" + studentMod.roomID + "'";
            SqlCommand com = new SqlCommand(query, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");
            }

            con.Close();

        }

        public SqlDataReader loadLocavalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from LocationTimeTable";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();
            dr.Close();

            return dr;

        }

        public SqlDataReader loadRoomvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from RoomTable";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();
            dr.Close();

            return dr;

        }

        public DataTable GetLocationvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  LocationTimeTable";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable GetRoomvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  RoomTable";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }


        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

  

    }
}
