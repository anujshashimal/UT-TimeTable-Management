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
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;

namespace TimeTableManagement.Forms
{
    public partial class location : Form
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public location()
        {
        InitializeComponent();
            con = DBConnection.getDBConnection();

        }
        public static String academicyrsemshldupdatevalue;


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
            dr.Close();
        }

        private void location_Load(object sender, EventArgs e)
        {
            locationdataGridView.DataSource = LocationConn.GetLocationvalues();

            roomDatagridView.DataSource = LocationConn.GetRoomvalues();

            String val = "BUI";
            int value = 00000;
            value = value + 1;
            locationID.Text = val + value.ToString("00000");

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
            dr.Close();
            roomDatagridView.DataSource = LocationConn.GetRoomvalues();

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            String academicyrsemshldupdatevalue = buildingNameT.Text;
            SqlDataReader dr = LocationConn.loadRoomvalues();
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            while (dr.Read())
            {
                String buildingNme = Convert.ToString(dr["buildingName"]);
                if (academicyrsemshldupdatevalue.Equals(buildingNme))
                {
                    String buldingName = buildingNameT.Text;
                    string query = "DELETE  FROM RoomTable  WHERE  buildingName='" + buldingName + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    com.ExecuteNonQuery();
                }
            }

            dr.Close();
            roomDatagridView.DataSource = LocationConn.GetRoomvalues();

        }

        private void deleteB1_Click(object sender, EventArgs e)
        {

        }

        private void roomDatagridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
            var currentRow = roomDatagridView.CurrentRow;

            var selectedName = currentRow.Cells[0].Value;
            var selectedName1 = currentRow.Cells[1].Value;
            var selectedName2 = currentRow.Cells[2].Value;
            var selectedName3 = currentRow.Cells[3].Value;
            var selectedName4 = currentRow.Cells[4].Value;

            buildingNameT.Text = selectedName.ToString();
            roomIDT.Text = selectedName1.ToString();
            roomNameT.Text = selectedName2.ToString();
            roomCapacity.Text = selectedName3.ToString();
            roomCapacityT.Text = selectedName4.ToString();

        }
    }
}
