using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.session_controller;
using TimeTableManagement.Model.SessionModel;

namespace TimeTableManagement.Forms
{
    public partial class CreateSession : Form
    {
        ArrayList lec = new ArrayList();
        public CreateSession()
        {
            InitializeComponent();


            session lecturer = new session();
            lecturerlist.DataSource = lecturer.getLectures();

            subNamelist.DataSource = lecturer.getSubjects();
           

            sessionList.DataSource = lecturer.getSessiondatatoTable();

            findSessionList.DataSource = lecturer.getSessiondatatoTable();




        }

        private void Addlecture_Click(object sender, EventArgs e)
        {

            lec.Add(lecturerlist.Text);
                lecList.Items.Add(lecturerlist.Text);
            






        }

        private void subNamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            session subcode = new session();
            subcodeList.DataSource = subcode.getSubCode(subNamelist.Text.ToString());
        }

        private void lecList_DoubleClick(object sender, EventArgs e)
        {
            /*lecList.SelectedItems.
            MessageBox.Show(lecList.SelectedItems.ToString());*/
        }

        private void Createsessions_Click(object sender, EventArgs e)
        {
            if(type.Text != "" &&  Gid.Text!="" && Scount.Text != "" && subNamelist.Text!= "" && subcodeList.Text != ""  && lecList.Items.Count != 0 )
            {
                
                foreach (DataGridViewRow row in sessionList.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(subcodeList.Text) && row.Cells[2].Value.ToString().Equals(type.Text) )
                    {
                        System.Windows.Forms.MessageBox.Show("This session already added !", "Warning").ToString();
                        return;
                    }
                   
                  
                }
                
                    sessionModel sessionmodel = new sessionModel();
                    sessionmodel.SubName = subNamelist.Text;
                    sessionmodel.subCode = subcodeList.Text;
                    sessionmodel.Type = type.Text;
                    sessionmodel.groupId = Int32.Parse(Gid.Text);

                    sessionmodel.subgId = subBox.Text;
                    sessionmodel.studentcount = Int32.Parse(Scount.Text);

                    /* for(int i = 1; i <= lecList.Items.Count; i++)
                     {*/
                    sessionmodel.lecturers = lec;

                    //}


                    session session = new session();
                    session.insertSessions(sessionmodel);

                    sessionList.DataSource = session.getSessiondatatoTable();
                
               
                   
               
               

            }
            else
            {

                string ans = System.Windows.Forms.MessageBox.Show("Please fill all the require fields !", "Warning").ToString();
            }

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(type.Text != "Practical")
            {
                subBox.Hide();
                sublbl.Hide();
            }
            else
            {
                sublbl.Show();
                subBox.Show();
            }
        }

        private void lecturerbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            session lec = new session();

            lecturerbox.DataSource = lec.getLectures();

            subjectBox.DataSource = lec.getSubjects();

            GroupBox.DataSource = lec.getGroupID();

            sessionList.DataSource = lec.getSessiondatatoTable();

        }

        private void searchSession_Click(object sender, EventArgs e)
        {

            session searchsession = new session();

            sessionModel sessionModel = new sessionModel();
            sessionModel.SubName = subjectBox.Text;
            sessionModel.groupId = Int32.Parse(GroupBox.Text);
            sessionModel.lec = lecturerbox.Text;

            //System.Windows.Forms.MessageBox.Show(sessionModel.lec.ToString());

            findSessionList.DataSource= searchsession.SearchSession(sessionModel);



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
