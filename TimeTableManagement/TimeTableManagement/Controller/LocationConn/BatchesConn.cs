using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using System.Data;
using System.Collections;
using System.Windows;

namespace TimeTableManagement.Controller.LocationConn
{
    class BatchesConn
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public BatchesConn()
        {
            con = DBConnection.getDBConnection();
        }

        public ArrayList getBatches()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select GroupID from Session";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;
        }

        public ArrayList getSubjectAccourdingToSession(String session)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal")) { 
            DataTable dataTable = new DataTable();
            string query = "select Subject from Session";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;
            }else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Consecutivetbl";

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



        public ArrayList getTheGroupIDsUsingSubjectnmeSession(String session, String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal"))
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine("adwjnakwdnkj" + subjectName);
                string query = "select GroupID from Session where Subject = '" + subjectName + "'";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Consecutivetbl";

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

        public ArrayList getTheSubGroupIDsUsingSubjectnmeSession(String session, String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal"))
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine("adwjnakwdnkj" + subjectName);
                string query = "select subgroup from Session where Subject = '" + subjectName + "'";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select subgroup from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select subgroup from Consecutivetbl";

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

        public ArrayList getTheTagTypeUsingSubjectnmeSession(String session, String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal"))
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine("adwjnakwdnkj" + subjectName);
                string query = "select type from Session where Subject = '" + subjectName + "'";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select type from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select type from Consecutivetbl";

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

        public ArrayList getAllGroupIds()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

                string query = "select Group_number from Group_number_table";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;           
    
        }

        public ArrayList getAllSubGroupIds()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "select Sub_group_number from Sub_group_numbers";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;

        }


        public void SR_updateGroupsWithAssignedRoom(String selectedGroupName, String selectedSubGroupName, String selectedSessionType, String selectedTagType, String selectedroomName)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            if (selectedSessionType.Equals("Normal"))
            {

                SqlDataReader dr = loadAllNormalSessions();

                while (dr.Read())
                {
                    String GroupID = Convert.ToString(dr["GroupID"]);
                    if (selectedGroupName.Equals(GroupID))
                    {

                        string sql = "UPDATE Session SET roomName='" + selectedroomName + "' WHERE GroupID = '" + selectedGroupName + "' AND type = '" + selectedTagType + "'";

                        SqlCommand com = new SqlCommand(sql, con);

                        MessageBox.Show("Updated Normal Session!");
                        com.ExecuteNonQuery();
                    }
                } 
            }
            else if (selectedSessionType.Equals("Consecutive"))
            {
                SqlDataReader dr = loadAllNormalSessions();

                while (dr.Read())
                {
                    String GroupID = Convert.ToString(dr["GroupID"]);
                    if (selectedGroupName.Equals(GroupID))
                    {

                        string sql = "UPDATE Consecutivetbl SET roomName='" + selectedroomName + "' WHERE groupid = '" + selectedGroupName + "' AND Tag1 = '" + selectedTagType + "'";

                        SqlCommand com = new SqlCommand(sql, con);

                        MessageBox.Show("Updated Consecutive Session!");
                        com.ExecuteNonQuery();
                    }
                }

            }
            else if (selectedSessionType.Equals("Parallel"))
            {
                SqlDataReader dr = loadAllNormalSessions();
                Console.WriteLine("AWaaaaaaa" + selectedGroupName);
                Console.WriteLine("AWaaaaaaa" + selectedroomName);
                Console.WriteLine("AWaaaaaaa" + selectedTagType);

                while (dr.Read())
                {
                    String GroupID = Convert.ToString(dr["GroupID"]);
                    if (selectedGroupName.Equals(GroupID))
                    {

                        string sql = "UPDATE Parallel_tbl SET roomName='" + selectedroomName + "' WHERE Group_Id = '" + selectedGroupName + "' AND Type = '" + selectedTagType + "'";

                        SqlCommand com = new SqlCommand(sql, con);

                        MessageBox.Show("Updated Parallel Session!");
                        com.ExecuteNonQuery();
                    }
                }
            }
        }


        public SqlDataReader loadAllNormalSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Session";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadAllConseSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Consecutivetbl";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadAllParallelSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Parallel";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public ArrayList getSubjectYear(String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "select offYear from SubjectTable where SubName = '" + subjectName + "'";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;

        }

        public ArrayList getBatchIDs(String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "select GroupID from Session where Subject = '" + subjectName + "'";

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
