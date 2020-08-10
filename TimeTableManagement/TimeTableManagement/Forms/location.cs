using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.LocationConn;
using TimeTableManagement.Model.locationModel;

namespace TimeTableManagement.Forms
{
    public partial class location : Form
    {
        public location()
        {
        InitializeComponent();
        }


        private Form activeform = null;
        public void OpenChildForm(Form childform)
        {

            if (activeform != null)
                activeform = null;
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();


        }

        LocationConn LocationConn = new LocationConn();
        locationModel locationModel = new locationModel();
        public static String academicyrsemshldupdatevalue;
        public static String programmeupdatevalue;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void academicyearsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locBtn2_Click(object sender, EventArgs e)
        {

            locationModel.locationPID = locationID.Text;
            locationModel.locationPName = buildingName.Text;

            LocationConn.insertLocationDetails(locationModel);

            SqlDataReader dr = LocationConn.loadLocavalues();
            locationdataGridView.DataSource = LocationConn.GetLocationvalues();


            dr.Close();
        }

        private void location_Load(object sender, EventArgs e)
        {
            locationdataGridView.DataSource = LocationConn.GetLocationvalues();

            roomDatagridView.DataSource = LocationConn.GetRoomvalues();
            SqlDataReader dr2 = LocationConn.loadRoomvalues();

        }

        private void locationdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addB_Click(object sender, EventArgs e)
        {
            locationModel.buildingName = buildingNameT.Text;
            locationModel.roomID = roomIDT.Text;
            locationModel.roomName = roomNameT.Text;
            locationModel.roomCapacity = roomCapacity.Text;
            locationModel.roomType = roomCapacityT.Text;

            LocationConn.insertRoomDetails(locationModel);

            SqlDataReader dr = LocationConn.loadRoomvalues();
            roomDatagridView.DataSource = LocationConn.GetRoomvalues();


            dr.Close();
        }

        
    }
}
