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
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Model.lahirumodel;

namespace TimeTableManagement.Forms
{
    public partial class Managesessions : Form
    {

        NotAvaliablesession notavaliableCon = new NotAvaliablesession();
        Notavaliablemodel notavaliablemod = new Notavaliablemodel();


        consecutivesession consecutivecon = new consecutivesession();
        consecutivemodel consecutivemodel = new consecutivemodel();



        parallelsessioncon   parallecon = new parallelsessioncon();
        parallelmodel paramodel = new parallelmodel();


        public Managesessions()
        {
            InitializeComponent();
          

        }

        private void academicyearsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Academicyrdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            notavaliablemod.type = typecombobox.Text;
            notavaliablemod.type_name = typelistcomboBox.Text;
            notavaliablemod.day = daycomboBox.Text;
            notavaliablemod.timefrom = startTimetxt.Text + "." + starttimecomboBox.Text;
            notavaliablemod.timeto = endTimetxt.Text + "." + endtimecomboBox.Text;
            notavaliablemod.not_avaliable = Avaliabletxt.Text;

            notavaliableCon.insertNotavaliableDetails(notavaliablemod);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void typecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typecombobox.SelectedIndex == 0)
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                SqlDataReader dr = notavaliableCon.load_lecturename_allvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(0).ToString());
                }

            }
            else if (typecombobox.SelectedIndex == 1)
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                SqlDataReader dr = notavaliableCon.load_Group_Id_allvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(0).ToString());
                }


            }
            else if (typecombobox.SelectedIndex == 2 )
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                SqlDataReader dr = notavaliableCon.load_Sub_Group_Id_allvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(0).ToString());
                }

             
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void endTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total =0 ;


            SqlDataReader dr = consecutivecon.load_sesssion_details();



            while (dr.Read())
            {
                if (subjectcomboBox.Text.Equals(dr.GetValue(1).ToString()))
                {
                    subjectcodetxt.Text = dr.GetValue(2).ToString();
                    groupidtxt.Text = dr.GetValue(4).ToString();
                    subgroupidtxt.Text = dr.GetValue(5).ToString();

                    if(dr.GetValue(3).ToString() == "Lecture")
                    {

                        tag1txt.Text = dr.GetValue(3).ToString();
                        tag1timeduration.Text = dr.GetValue(7).ToString();
                        total = total + Int32.Parse(tag1timeduration.Text);

                    }
                     if (dr.GetValue(3).ToString() == "Tutorial")
                    {

                        tag2txt.Text = dr.GetValue(3).ToString();
                        tag2timeduration.Text = dr.GetValue(7).ToString();
                        total = total + Int32.Parse(tag2timeduration.Text);


                    }
           
                       
                    thrstxt.Text = total.ToString();
                }

              


            }

          



        }

        private void subjectcomboBox_MouseClick(object sender, MouseEventArgs e)
        {

           
        }

        private void subjectcomboBox_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void subjectcomboBox_DragLeave(object sender, EventArgs e)
        {
          
        }

        private void subjectcomboBox_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void subjectcomboBox_Click(object sender, EventArgs e)
        {
                subjectcodetxt.Text = "";
                groupidtxt.Text = "";
                subgroupidtxt.Text = "";
                tag1txt.Text = "";
                tag1timeduration.Text = "";
                tag2txt.Text = "";
                tag2timeduration.Text = "";
                thrstxt.Text = "";
            



        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            SqlDataReader dr1 = consecutivecon.load_subject_details();
            while (dr1.Read())
            {
                subjectcomboBox.Items.Add(dr1.GetValue(0).ToString());
            }


            SqlDataReader dr = parallecon.loadtagdetailsvalues();

            while (dr.Read())
            {
                type_combo_box.Items.Add(dr.GetValue(0).ToString());
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (subjectcomboBox.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                consecutivemodel.subject = subjectcomboBox.Text.ToString();
                consecutivemodel.subjectcode = subjectcodetxt.Text.ToString();
                consecutivemodel.groupid = groupidtxt.Text.ToString();
                consecutivemodel.subgroupid = subgroupidtxt.Text.ToString();
                consecutivemodel.Tag1 = tag1txt.Text.ToString();
                consecutivemodel.Tag2 = tag2txt.Text.ToString();
               // consecutivemodel.Tag3 = tag3txt.Text.ToString();

                consecutivemodel.Tag1timeduration = Convert.ToInt32(tag1timeduration.Text);
                consecutivemodel.Tag2timeduration = Convert.ToInt32(tag2timeduration.Text);
             //   consecutivemodel.Tag3timeduration = Convert.ToInt32(tag3timeduration.Text);

                consecutivemodel.total_hours = Convert.ToInt32(thrstxt.Text);

                consecutivecon.insertConcecutiveDetails(consecutivemodel);


                tag1txt.Text = "";
                tag2txt.Text = "";
             //   tag3txt.Text = "";
                tag1timeduration.Text = "";
                tag2timeduration.Text = "";
            //    tag3timeduration.Text = "";
                subjectcodetxt.Text = "";
                groupidtxt.Text = "";
                subgroupidtxt.Text = "";
                subjectcomboBox.Text = "";
                thrstxt.Text = "";

            }




        }

        private void subjectcodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tag1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_DropDown(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_TextUpdate(object sender, EventArgs e)
        {
            int total = 0;

            SqlDataReader dr = consecutivecon.load_sesssion_details();

            while (dr.Read())
            {
                if (subjectcomboBox.Text.Equals(dr.GetValue(1).ToString()))
                {
                    subjectcodetxt.Text = dr.GetValue(2).ToString();
                    groupidtxt.Text = dr.GetValue(4).ToString();
                    subgroupidtxt.Text = dr.GetValue(5).ToString();

                    if (dr.GetValue(3).ToString() == "lecture")
                    {

                        tag1txt.Text = dr.GetValue(3).ToString();
                        tag1timeduration.Text = dr.GetValue(7).ToString();
                        total = total + Int32.Parse(tag1timeduration.Text);

                    }
                    if (dr.GetValue(3).ToString() == "tutorial")
                    {

                        tag2txt.Text = dr.GetValue(3).ToString();
                        tag2timeduration.Text = dr.GetValue(7).ToString();
                        total = total + Int32.Parse(tag2timeduration.Text);


                    }


                    thrstxt.Text = total.ToString();
                }




            }

        }

        private void subgroupidcombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Subject_name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = parallecon.load_subject_details();

            while (dr.Read())
            {
                if (Subject_name_combo.Text.Equals(dr.GetValue(0).ToString()))
                {
                    subject_cod_txt.Text = dr.GetValue(1).ToString();


                }


            }



        }

        private void Subject_name_combo_Click(object sender, EventArgs e)
        {
            Subject_name_combo.Items.Clear();
            SqlDataReader dr1 = parallecon.load_subject_details();
            while (dr1.Read())
            {
               Subject_name_combo.Items.Add(dr1.GetValue(0).ToString());
            }

        }

        private void Subject_name_combo_TextUpdate(object sender, EventArgs e)
        {
            SqlDataReader dr = parallecon.load_subject_details();

            while (dr.Read())
            {
                if (Subject_name_combo.Text.Equals(dr.GetValue(0).ToString()))
                {
                    subject_cod_txt.Text = dr.GetValue(1).ToString();
                  

                }


            }



        }





    }


}
