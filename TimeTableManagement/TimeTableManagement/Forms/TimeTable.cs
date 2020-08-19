using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TimeTableManagement.Controller.TimeTableCon;
using TimeTableManagement.Model.TimeTableModel;

namespace TimeTableManagement.Forms
{
    public partial class TimeTable : Form
    {
        NumberOfWorkingDaysCon numberOfWorkingDaysCon = new NumberOfWorkingDaysCon();
        WorkingDaysCon workingDaysCon = new WorkingDaysCon();
        WorkingDaysModel workingDaysModel = new WorkingDaysModel();
        NumberOfWorkingDaysModel numberOfWorkingDaysModel = new NumberOfWorkingDaysModel();
        WorkingTimeModel workingTimeModel = new WorkingTimeModel();
        WorkingTimeCon workingTimeCon = new WorkingTimeCon();
        TimeSloatModel timeSloatModel = new TimeSloatModel();
        TimeSloatCon timeSloatCon = new TimeSloatCon();
        public static String numberOfWorkingDaysValue;
        public TimeTable()
        {
            InitializeComponent();
            NumberOfWorkingDaysCon numberOfWorkingDaysCon = new NumberOfWorkingDaysCon();
            dataNumberOfWorkingDays.DataSource = numberOfWorkingDaysCon.getdatatoTable();
            dataWorkingDays.DataSource = workingDaysCon.getdatatoTable();
            dataWorkingTime.DataSource = workingTimeCon.getdatatoTable();
            dateTimeSloat.DataSource = timeSloatCon.getdatatoTable();
            btnDeleteNumOfWorkingDays.Enabled = false;
            btnUpdateNumOfWorkingDays.Enabled = false;
            btnUpdateWorkingDays.Enabled = false;
            btnDeleteWorkingDays.Enabled = false;
            btnDeleteWorkingTime.Enabled = false;
            btnUpdateWorkingTime.Enabled = false;
            btnTimeSloatDelete.Enabled = false;
            btnTimeSloatUpdate.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Form activeform = null;
        //private object workingTimeModel;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberOfWorkingDaysModel.WeekdayDays = Convert.ToInt32(numWeekday.Value);
            numberOfWorkingDaysModel.WeekendDays = Convert.ToInt32(numWeekend.Value);
            numberOfWorkingDaysCon.insertNumberOfWorkingDays(numberOfWorkingDaysModel);
            dataNumberOfWorkingDays.DataSource = numberOfWorkingDaysCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            numWeekday.Value = 0;
            numWeekend.Value = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataNumberOfWorkingDays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataNumberOfWorkingDays_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdateNumOfWorkingDays_Click(object sender, EventArgs e)
        {
            
            numberOfWorkingDaysModel.Id = Convert.ToInt32(txtNumberOfWorkingDaysId.Text);
            numberOfWorkingDaysModel.WeekdayDays = Convert.ToInt32(numWeekday.Value);
            numberOfWorkingDaysModel.WeekendDays = Convert.ToInt32(numWeekend.Value);
            numberOfWorkingDaysCon.updateNumberOfWorkingDays(numberOfWorkingDaysModel);
            dataNumberOfWorkingDays.DataSource = numberOfWorkingDaysCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            numWeekday.Value = 0;
            numWeekend.Value = 0;
            btnDeleteNumOfWorkingDays.Enabled = false;
            btnUpdateNumOfWorkingDays.Enabled = false;
            btnAddNumOfWorkingDays.Enabled = true;
        }

        private void dataNumberOfWorkingDays_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dataNumberOfWorkingDays.Rows[e.RowIndex];
                txtNumberOfWorkingDaysId.Text = data.Cells["id"].Value.ToString();
                numWeekday.Value = Convert.ToDecimal(data.Cells["Weekday"].Value);
                numWeekend.Value = Convert.ToDecimal(data.Cells["Weekend"].Value);
                btnDeleteNumOfWorkingDays.Enabled = true;
                btnUpdateNumOfWorkingDays.Enabled = true;
                btnAddNumOfWorkingDays.Enabled = false;
            }
        }

        private void dataNumberOfWorkingDays_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteNumOfWorkingDays_Click(object sender, EventArgs e)
        {
            numberOfWorkingDaysModel.Id = Convert.ToInt32(txtNumberOfWorkingDaysId.Text);
            numberOfWorkingDaysCon.DeleteNumberOfWorkingDays(numberOfWorkingDaysModel);
            dataNumberOfWorkingDays.DataSource = numberOfWorkingDaysCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            numWeekday.Value = 0;
            numWeekend.Value = 0;
            btnDeleteNumOfWorkingDays.Enabled = false;
            btnUpdateNumOfWorkingDays.Enabled = false;
            btnAddNumOfWorkingDays.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNumberOfWorkingDaysId.Text = "";
            numWeekday.Value = 0;
            numWeekend.Value = 0;
            btnDeleteNumOfWorkingDays.Enabled = false;
            btnUpdateNumOfWorkingDays.Enabled = false;
            btnAddNumOfWorkingDays.Enabled = true;
        }

        private void dataWorkingDays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            workingDaysModel.Id = Convert.ToInt32(workingDaysId.Text);
            workingDaysModel.Day = Convert.ToString(txtWorkingDay.Text);
            workingDaysModel.Type = Convert.ToString(txtType.Text);
            workingDaysCon.updateWorkingDays(workingDaysModel);
            dataWorkingDays.DataSource = workingDaysCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            txtWorkingDay.Text = "";
            txtType.Text = "";
            btnDeleteWorkingDays.Enabled = false;
            btnUpdateWorkingDays.Enabled = false;
            btnAddWorkingDays.Enabled = true;
        }

        private void btnAddWorkingDays_Click(object sender, EventArgs e)
        {
            workingDaysModel.Day = Convert.ToString(txtWorkingDay.Text);
            workingDaysModel.Type = Convert.ToString(txtType.Text);
            workingDaysCon.insertWorkingDays(workingDaysModel);
            dataWorkingDays.DataSource = workingDaysCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            txtWorkingDay.Text = "";
            txtType.Text = "";
        }

        private void dataWorkingDays_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dataWorkingDays.Rows[e.RowIndex];
                workingDaysId.Text = data.Cells["id"].Value.ToString();
                txtWorkingDay.Text = data.Cells["day"].Value.ToString();
                txtType.Text = data.Cells["type"].Value.ToString();
                btnUpdateWorkingDays.Enabled = true;
                btnDeleteWorkingDays.Enabled = true;
                btnAddWorkingDays.Enabled = false;
            }
        }

        private void btnDeleteWorkingDays_Click(object sender, EventArgs e)
        {
            workingDaysModel.Id = Convert.ToInt32(workingDaysId.Text);
            workingDaysCon.DeleteWorkingDays(workingDaysModel);
            dataWorkingDays.DataSource = workingDaysCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            txtWorkingDay.Text = "";
            txtType.Text = "";
            btnUpdateWorkingDays.Enabled = false;
            btnDeleteWorkingDays.Enabled = false;
            btnAddWorkingDays.Enabled = true;
        }

        private void btnClearWorkingDays_Click(object sender, EventArgs e)
        {
            txtNumberOfWorkingDaysId.Text = "";
            txtWorkingDay.Text = "";
            txtType.Text = "";
            btnUpdateWorkingDays.Enabled = false;
            btnDeleteWorkingDays.Enabled = false;
            btnAddWorkingDays.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWorkingTime_Click(object sender, EventArgs e)
        {
            workingTimeModel.Day = Convert.ToString(txtDayWorkingTime.Text);
            workingTimeModel.WorkingTime = float.Parse(workingTime.Text);
            workingTimeCon.insertWorkingTime(workingTimeModel);
            dataWorkingTime.DataSource = workingTimeCon.getdatatoTable();
            txtNumberOfWorkingDaysId.Text = "";
            txtWorkingDay.Text = "";
            txtDayWorkingTime.Text = "";
        }

        private void dataWorkingTime_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dataWorkingTime.Rows[e.RowIndex];
                WorkingTimeId.Text = data.Cells["id"].Value.ToString();
                txtDayWorkingTime.Text = data.Cells["Day"].Value.ToString();
                workingTime.Text = data.Cells["WorkingTime"].Value.ToString();
                btnUpdateWorkingTime.Enabled = true;
                btnDeleteWorkingTime.Enabled = true;
                btnAddWorkingTime.Enabled = false;
            }
        }

        private void btnUpdateWorkingTime_Click(object sender, EventArgs e)
        {
            workingTimeModel.Id = Convert.ToInt32(WorkingTimeId.Text);
            workingTimeModel.Day = Convert.ToString(txtDayWorkingTime.Text);
            workingTimeModel.WorkingTime = float.Parse(workingTime.Text);
            workingTimeCon.updateWorkingTime(workingTimeModel);
            dataWorkingTime.DataSource = workingTimeCon.getdatatoTable();
            WorkingTimeId.Text = "";
            txtDayWorkingTime.Text = "";
            workingTime.Text = "";
            btnDeleteWorkingTime.Enabled = false;
            btnUpdateWorkingTime.Enabled = false;
            btnAddWorkingTime.Enabled = true;
        }

        private void btnDeleteWorkingTime_Click(object sender, EventArgs e)
        {
            workingTimeModel.Id = Convert.ToInt32(WorkingTimeId.Text);
            workingTimeCon.DeleteWorkingTime(workingTimeModel);
            dataWorkingTime.DataSource = workingTimeCon.getdatatoTable();
            WorkingTimeId.Text = "";
            txtDayWorkingTime.Text = "";
            workingTime.Text = "";
            btnDeleteWorkingTime.Enabled = false;
            btnUpdateWorkingTime.Enabled = false;
            btnAddWorkingTime.Enabled = true;
        }

        private void btnClearWorkingTime_Click(object sender, EventArgs e)
        {
            WorkingTimeId.Text = "";
            txtDayWorkingTime.Text = "";
            workingTime.Text = "";
            btnDeleteWorkingTime.Enabled = false;
            btnUpdateWorkingTime.Enabled = false;
            btnAddWorkingTime.Enabled = true;
        }

        private void btnTimeSloatAdd_Click(object sender, EventArgs e)
        {
            timeSloatModel.Type = Convert.ToString(timeSlotType.Text);
            timeSloatModel.StartTime = float.Parse(startTime.Text);
            timeSloatModel.EndTime = float.Parse(endTime.Text);
            timeSloatCon.insertTimeSloat(timeSloatModel);
            dateTimeSloat.DataSource = timeSloatCon.getdatatoTable();
            TimeSloatId.Text = "";
            timeSlotType.Text = "";
            startTime.Text = "";
            endTime.Text = "";
        }

        private void btnTimeSloatUpdate_Click(object sender, EventArgs e)
        {
            timeSloatModel.Id = Convert.ToInt32(TimeSloatId.Text);
            timeSloatModel.Type = Convert.ToString(timeSlotType.Text);
            timeSloatModel.StartTime = float.Parse(startTime.Text);
            timeSloatModel.EndTime = float.Parse(endTime.Text);
            timeSloatCon.updateTimeSloat(timeSloatModel);
            dateTimeSloat.DataSource = timeSloatCon.getdatatoTable();
            TimeSloatId.Text = "";
            timeSlotType.Text = "";
            startTime.Text = "";
            endTime.Text = "";
            btnTimeSloatDelete.Enabled = false;
            btnTimeSloatUpdate.Enabled = false;
            btnTimeSloatAdd.Enabled = true;
        }

        private void btnTimeSloatDelete_Click(object sender, EventArgs e)
        {
            timeSloatModel.Id = Convert.ToInt32(TimeSloatId.Text);
            timeSloatCon.DeleteTimeSloat(timeSloatModel);
            dateTimeSloat.DataSource = timeSloatCon.getdatatoTable();
            TimeSloatId.Text = "";
            timeSlotType.Text = "";
            startTime.Text = "";
            endTime.Text = "";
            btnTimeSloatDelete.Enabled = false;
            btnTimeSloatUpdate.Enabled = false;
            btnTimeSloatAdd.Enabled = true;
        }

        private void dateTimeSloat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dateTimeSloat.Rows[e.RowIndex];
                TimeSloatId.Text = data.Cells["id"].Value.ToString();
                timeSlotType.Text = data.Cells["Type"].Value.ToString();
                startTime.Text = data.Cells["startTime"].Value.ToString();
                endTime.Text = data.Cells["endTime"].Value.ToString();
                btnTimeSloatUpdate.Enabled = true;
                btnTimeSloatDelete.Enabled = true;
                btnTimeSloatAdd.Enabled = false;
            }
        }

        private void btnTimeSlotClear_Click(object sender, EventArgs e)
        {
            TimeSloatId.Text = "";
            timeSlotType.Text = "";
            startTime.Text = "";
            endTime.Text = "";
            btnTimeSloatDelete.Enabled = false;
            btnTimeSloatUpdate.Enabled = false;
            btnTimeSloatAdd.Enabled = true;
        }
    }
}
