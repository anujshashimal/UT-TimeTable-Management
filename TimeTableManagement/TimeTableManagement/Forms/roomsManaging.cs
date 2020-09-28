using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.LocationConn;
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Model.locationModel;
using TimeTableManagement.Controller.session_controller;

namespace TimeTableManagement.Forms
{
    public partial class roomsManaging : Form
    {
        public roomsManaging()
        {
            InitializeComponent();
            roomsConn roomsConn = new roomsConn();
            roomsWithLecCon rql = new roomsWithLecCon();
            session lecturer = new session();

            consecutivesession consecutivesession = new consecutivesession();

            assignRoom.DataSource = roomsConn.getRooms();
            asubjectCode.DataSource = roomsConn.getSession();
            roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();
            notAvailableGridView.DataSource = roomsConn.load_not_available_details();
            lecWithRoomsGrid.DataSource = roomsConn.load_Lec_with_rooms();
            faculty.DataSource = roomsConn.getFaultyRooms();
            rfaculty.DataSource = roomsConn.getFaultyRooms();
            electurenme.DataSource = lecturer.getLectures();
            //           lroomtype.DataSource = roomsConn.
            loadLecturerPreferedTags();
            loadSessionItems();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedNme = assignRoom.Text.ToString(); 
            aroomType.DataSource = roomsConn.getRoomsType(selectedNme);


        }

        private void locBtn2_Click(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            roomModel roomsModel = new roomModel();
            String selectedSessionType = sessionType.Text.ToString();

            roomsModel.roomName = assignRoom.Text;
            roomsModel.subjectCode = asubjectCode.Text;
            roomsModel.facultyNme = faculty.Text;
            roomsConn.updateSessionTable(roomsModel, notavltime.Text.ToString(), selectedSessionType);
            roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();


        }

        private void asubjectCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String getSelectedSubject = asubjectCode.Text.ToString();
            atags.DataSource = roomsConn.getSessionType(getSelectedSubject);
            atag2.DataSource = roomsConn.getTag2Type(getSelectedSubject);

            String selectedSessionType = sessionType.Text.ToString();
            String selectedSubject = asubjectCode.Text.ToString();
            atags.DataSource = roomsConn.getSessionTypeTag(selectedSessionType, selectedSubject, aroomType.Text.ToString());
        }

        private void aroomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();

            String selectedLabNme = aroomType.Text.ToString();
            atags.DataSource = roomsConn.getSessionType(selectedLabNme);

        }

        private void atag2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomManagingSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = roomManagingSource.CurrentRow;

            var selectedName = currentRow.Cells[0].Value;
            var selectedName1 = currentRow.Cells[1].Value;


        }

        private void sessionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedSessionType = sessionType.Text.ToString();
            asubjectCode.DataSource = roomsConn.getSessionTypeTable(selectedSessionType);
            if (selectedSessionType.Equals("Normal")){
                atag2.Hide();
                label1.Hide();
                roomManagingSource.DataSource = roomsConn.load_normal_sesssion_details();
            }
            else
            {
                atag2.Show();
                label1.Show();
               // comboBox1.Show();
               // label7.Show();
            }
            if (selectedSessionType.Equals("Normal"))
            {
                roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();
            }else if(selectedSessionType.Equals("Consecutive"))
            {
                roomManagingSource.DataSource = roomsConn.load_normal_sesssion_details();

            }
            else if (selectedSessionType.Equals("Parallel"))
            {
                roomManagingSource.DataSource = roomsConn.load_parallel_sesssion_details();

            }



        }
        void loadSessionItems()
        {
            sessionType.Items.Add("Normal");
            sessionType.Items.Add("Consecutive");
            sessionType.Items.Add("Parallel");



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedFaculty = faculty.Text.ToString();
            assignRoom.DataSource = roomsConn.getRoomsByFaculty(selectedFaculty);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedFaculty = rfaculty.Text.ToString(); 
            rName.DataSource = roomsConn.getRoomsByFaculty(selectedFaculty);


        }

        private void notAvailableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void releaceBtn_Click(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            roomsConn.insertNotAvailableTimes(rName.Text.ToString(), rfaculty.Text.ToString(), rntime.Text.ToString());
            notAvailableGridView.DataSource = roomsConn.load_not_available_details();
            rrrname.DataSource = roomsConn.getNotAvailableRooms();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void rrbtn_Click(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedRoomName = rrrname.Text.ToString();

            roomsConn.DeleteNotAvailableRooms(selectedRoomName);
            notAvailableGridView.DataSource = roomsConn.load_not_available_details();
            rrrname.DataSource = roomsConn.getNotAvailableRooms();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rntime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomsManaging_Load(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedFaculty = rfaculty.Text.ToString();
            rrrname.DataSource = roomsConn.getNotAvailableRooms();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String lecName = electurenme.Text.ToString();
            String roomType = lroomtype.Text.ToString();
            String roomName = lroomName.Text.ToString();
            roomsWithLecCon rwl = new roomsWithLecCon();
            roomsConn roomsConn = new roomsConn();

            rwl.insertLecWithPrefereedRoom(lecName, roomType, roomName);
            lecWithRoomsGrid.DataSource = roomsConn.load_Lec_with_rooms();
        }


        void loadLecturerPreferedTags()
        {
            lroomtype.Items.Add("Lecture");
            lroomtype.Items.Add("Tutorial");
            lroomtype.Items.Add("Lab");
        }

        private void lroomName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedRoomType = lroomtype.Text.ToString();
            roomsWithLecCon rwl = new roomsWithLecCon();
            lroomName.DataSource = rwl.LoadTagsWithRooms(selectedRoomType);

        }
    }
}
