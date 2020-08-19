using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagement.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studSubmitbtn_Click(object sender, EventArgs e)
        {
            String validausername = Convert.ToString(username.Text);
            String validpassword = password.Text;

            if (validausername.Equals("admin") && validpassword.Equals("admin"))
            {

                MessageBox.Show("Login Successful","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Admindashboard admindashboard = new Admindashboard();
                admindashboard.ShowDialog();
            
            }
            else if((validausername != "admin") || (validpassword !="admin"))
            {

                MessageBox.Show("Login Incorrect! Please Enter valid username & password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
            else if((validausername.Equals("")) || (validpassword.Equals("")))
            {
                MessageBox.Show("Please Enter username password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
