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
    public partial class StaticsRelated : Form
    {
        public StaticsRelated()
        {
            InitializeComponent();
        }

        private void StaticsRelated_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet2.RoomTable' table. You can move, or remove it, as needed.
            this.roomTableTableAdapter1.Fill(this.myDBDataSet2.RoomTable);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
