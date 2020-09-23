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
using System.Collections;
using TimeTableManagement.Model.locationModel;
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Controller.LocationConn;

namespace TimeTableManagement.Controller.LocationConn
{
    class roomsConn
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();


        public roomsConn()
        {
            con = DBConnection.getDBConnection();

        }

        public ArrayList getRooms()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select roomName from RoomTable";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }

        public ArrayList getRoomsType(String name)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();

            string query = "select roomType from RoomTable where roomName = '" + name + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }
      
        public ArrayList getSession()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();

            string query = "select  subjectcode from Consecutivetbl";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }

        public ArrayList getSessionType(String name)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            Console.WriteLine( name);

            DataTable dataTable = new DataTable();

            string query = "select Tag1 from Consecutivetbl where subjectcode = '" + name + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }

            Console.WriteLine("awdwadaw",arrayList);

            return arrayList;
        }


        public ArrayList getTag2Type(String name)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            Console.WriteLine(name);

            DataTable dataTable = new DataTable();

            string query = "select Tag2 from Consecutivetbl where subjectcode = '" + name + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }

            Console.WriteLine("awdwadaw", arrayList);

            return arrayList;
        }

       public ArrayList updateSessionTable(roomModel roommodel)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            consecutivesession consecutivesession = new consecutivesession();

            SqlDataReader dr = consecutivesession.load_sesssion_details();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            while (dr.Read())
            {
           
                    string query = "update Consecutivetbl set roomName = '" + roommodel.roomName + "'where subjectCode = '" + roommodel.subjectCode + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    MessageBox.Show("Updated!");

                    com.ExecuteNonQuery();

                
            }

            roomsConn roomsConn = new roomsConn();

            Console.WriteLine("awdwadaw", arrayList);

            return arrayList;
        }

 

        public DataTable load_con_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from Consecutivetbl ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }


        public ArrayList getSessionTypeTable(String name)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            Console.WriteLine(name);

            DataTable dataTable = new DataTable();
            if (name.Equals("Normal"))
            {
                string query = "select subjectcode from Session";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }
            else if (name.Equals("Consecutive"))
            {
                string query = "select subjectcode from Consecutivetbl";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }
            else if (name.Equals("Parallel"))
            {
                string query = "select subjectcode from Consecutivetbl";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }

            Console.WriteLine("awdwadaw", arrayList);

            return arrayList;
        }


        public ArrayList getSessionTypeTag(String tagType, String subCode, String tabName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            Console.WriteLine("awdwafd");

            Console.WriteLine(subCode);
            Console.WriteLine(tagType);
            Console.WriteLine(tabName);
            Console.WriteLine("awdwafd");

            DataTable dataTable = new DataTable();
            if (tagType.Equals("Normal"))
            {
                string query = "select type from Session where subjectCode = '" + subCode + "' AND type= '" + tabName + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                Console.WriteLine(arrayList);

                MessageBox.Show("Updated!");

            }
            else if (tagType.Equals("Consecutive"))
            {
                string query = "select Tag1 from Consecutivetbl where subjectcode = '" + subCode + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                Console.WriteLine(arrayList);


            }
            else if (tagType.Equals("Parallel"))
            {
                string query = "select Tag1 from Consecutivetbl where subjectcode = '" + subCode + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }
            Console.WriteLine(arrayList);


            return arrayList;
        }
    }
}
