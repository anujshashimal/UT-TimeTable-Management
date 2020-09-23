﻿using System;
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

namespace TimeTableManagement.Forms
{
    public partial class roomsManaging : Form
    {
        public roomsManaging()
        {
            InitializeComponent();
            roomsConn roomsConn = new roomsConn();
            consecutivesession consecutivesession = new consecutivesession();

            assignRoom.DataSource = roomsConn.getRooms();
            asubjectCode.DataSource = roomsConn.getSession();
            roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();
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

            roomsModel.roomName = assignRoom.Text;
            roomsModel.subjectCode = asubjectCode.Text;
            roomsConn.updateSessionTable(roomsModel);
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

                comboBox1.Hide();
                label7.Hide();
            }
            else
            {
                atag2.Show();
                label1.Show();

                comboBox1.Show();
                label7.Show();
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
    }
}