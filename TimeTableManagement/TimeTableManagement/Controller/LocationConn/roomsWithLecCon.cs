using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using TimeTableManagement.Controller.session_controller;
using System.Collections;

namespace TimeTableManagement.Controller.LocationConn
{
    class roomsWithLecCon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public roomsWithLecCon()
        {
            con = DBConnection.getDBConnection();
        }
        session lecturer = new session();


        public ArrayList LoadTagsWithRooms(String tagType)
        {
            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "select roomName from RoomTable where roomType = '" + tagType + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;

        }

    }
}
