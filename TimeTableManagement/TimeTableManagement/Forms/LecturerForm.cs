using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.LectureController;
using TimeTableManagement.Model.LecturerModel;

namespace TimeTableManagement.Forms
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
            LectureController lectureController = new LectureController();
            lecturerTble.DataSource= lectureController.getdatatoTable();
            //lecturerTble.DataBindings();
           
        }

        private void EId_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addLec_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();

            if (nametxt.Text != "" && eidtxt.Text != "" && factxt.Text != "" && depttxt.Text != "" && centertxt.Text != "" && buildingtxt.Text != "" && leveltxt.Text != ""  && ranktxt.Text != "")
            {

                lecturer.lecName = nametxt.Text;
                lecturer.eid = eidtxt.Text;
                lecturer.faculty = factxt.Text;
                lecturer.department = depttxt.Text;
                lecturer.center = centertxt.Text;
                lecturer.buildng = buildingtxt.Text;
                lecturer.level = leveltxt.Text;
                lecturer.rank = ranktxt.Text;

                ranktxt.Text = lecturer.level + "." + lecturer.eid;

                LectureController leccrl = new LectureController();
                leccrl.insertLecturerDetails(lecturer);

                nametxt.Text = "";
                eidtxt.Text = "";
                factxt.Text = "";
                depttxt.Text = "";
                centertxt.Text = "";
                buildingtxt.Text = "";
                leveltxt.Text = "";
                ranktxt.Text = "";

                lecturerTble.DataSource = leccrl.getdatatoTable();
               
            }
            else
            {

                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void leveltxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ranktxt.Text = leveltxt.Text + "." +eidtxt.Text;
        }

        private void lecturerTble_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                DataGridViewRow data = this.lecturerTble.Rows[e.RowIndex];
                nametxt.Text = data.Cells["name"].Value.ToString();
                eidtxt.Text = data.Cells["Eid"].Value.ToString();
                factxt.Text = data.Cells["faculty"].Value.ToString();
                depttxt.Text = data.Cells["depertment"].Value.ToString();
                centertxt.Text = data.Cells["center"].Value.ToString();
                buildingtxt.Text = data.Cells["building"].Value.ToString();
                leveltxt.Text = data.Cells["level"].Value.ToString();
                ranktxt.Text = data.Cells["rank"].Value.ToString();

                eidtxt.ReadOnly = true;

                 addLec.Enabled = false;

            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            eidtxt.Text = "";
            factxt.Text = "";
            depttxt.Text = "";
            centertxt.Text = "";
            buildingtxt.Text = "";
            leveltxt.Text = "";
            ranktxt.Text = "";
            eidtxt.ReadOnly = false;
            addLec.Enabled = true;


        }

        private void delLec_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            lecturer.eid = eidtxt.Text;

            LectureController lectureController = new LectureController();
            lectureController.DeleteLecturer(lecturer);

            nametxt.Text = "";
            eidtxt.Text = "";
            factxt.Text = "";
            depttxt.Text = "";
            centertxt.Text = "";
            buildingtxt.Text = "";
            leveltxt.Text = "";
            ranktxt.Text = "";
            eidtxt.ReadOnly = false;
             addLec.Enabled = true;
           
            lecturerTble.DataSource = lectureController.getdatatoTable();
        }

        private void editLec_Click(object sender, EventArgs e)
        {

            if (nametxt.Text != "" && eidtxt.Text != "" && factxt.Text != "" && depttxt.Text != "" && centertxt.Text != "" && buildingtxt.Text != "" && leveltxt.Text != "" && ranktxt.Text != "")
            {
                Lecturer lecturer = new Lecturer();

                lecturer.lecName = nametxt.Text;
                lecturer.eid = eidtxt.Text;
                lecturer.faculty = factxt.Text;
                lecturer.department = depttxt.Text;
                lecturer.center = centertxt.Text;
                lecturer.buildng = buildingtxt.Text;
                lecturer.level = leveltxt.Text;
                lecturer.rank = ranktxt.Text;

                ranktxt.Text = lecturer.level + "." + lecturer.eid;

                LectureController ctrl = new LectureController();
                ctrl.UpdateLecturer(lecturer);

                nametxt.Text = "";
                eidtxt.Text = "";
                factxt.Text = "";
                depttxt.Text = "";
                centertxt.Text = "";
                buildingtxt.Text = "";
                leveltxt.Text = "";
                ranktxt.Text = "";
                eidtxt.ReadOnly = false;

                lecturerTble.DataSource = ctrl.getdatatoTable();
                addLec.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
