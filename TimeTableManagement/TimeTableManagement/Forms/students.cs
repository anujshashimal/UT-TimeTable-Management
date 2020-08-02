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
    public partial class students : Form
    {

        Studentcon studentCon = new Studentcon();
        studentmodel studentmod = new studentmodel();
        public static String academicyrsemshldupdatevalue;
    
        public students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            studentmod.Academicyearsemester1 = academicyearsem.Text;
            studentCon.insertAcademicyearsemesterDetails(studentmod);
           
            SqlDataReader dr = studentCon.loadacademicyrsemestervalues();
            while (dr.Read())
            {
                academicyearsem.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // academicyrsemshldupdatevalue_index = academicyearsem.Items.IndexOf(academicyearsem.Text);
            //// Console.WriteLine(academicyrsemshldupdatevalue_index.ToString());
            academicyrsemshldupdatevalue =  academicyearsem.Text;
           textBox1.Text = academicyrsemshldupdatevalue.ToString();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                SqlDataReader dr = studentCon.loadacademicyrsemesterallvalues();
           
                
           while (dr.Read())
            {
                String academicyrsem = Convert.ToString(dr["AcademicYrsem"]);
                int academicindexprimarykey = Convert.ToInt32(dr["AcademicYrsemId"]);
                
                if (academicyrsemshldupdatevalue.Equals(academicyrsem))
                {
                    textBox1.Text = academicyearsem.Text;
                    studentmod.Academicyearsemester1 = academicyearsem.Text;
                    studentmod.Academicyearsemester_id1 = academicindexprimarykey;
                   
                     
                }
            }

            studentCon.updateacademicyrandsem(studentmod);
            academicyearsem.Items.Clear();
            SqlDataReader dr1 = studentCon.loadacademicyrsemestervalues();
            while (dr1.Read())
            {
                academicyearsem.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();



        }

        private void students_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadacademicyrsemestervalues();
            while(dr.Read())
            {
                academicyearsem.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();






        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlDataReader dr = studentCon.loadacademicyrsemesterallvalues();


            while (dr.Read())
            {
                String academicyrsem = Convert.ToString(dr["AcademicYrsem"]);
                int academicindexprimarykey = Convert.ToInt32(dr["AcademicYrsemId"]);

                if (academicyrsemshldupdatevalue.Equals(academicyrsem))
                {
                    studentmod.Academicyearsemester1 = academicyearsem.Text;
                    studentmod.Academicyearsemester_id1 = academicindexprimarykey;


                }
            }


            studentCon.DeleteAcademicyearsem(studentmod);
            academicyearsem.Items.Clear();
            SqlDataReader dr1 = studentCon.loadacademicyrsemestervalues();
            while (dr1.Read())
            {
                academicyearsem.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
