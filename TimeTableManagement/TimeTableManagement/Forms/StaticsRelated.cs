﻿using System;
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
            // TODO: This line of code loads data into the 'myDBDataSet1.LecturerTbl' table. You can move, or remove it, as needed.
            this.lecturerTblTableAdapter.Fill(this.myDBDataSet1.LecturerTbl);
            // TODO: This line of code loads data into the 'myDBDataSet.RoomTable' table. You can move, or remove it, as needed.
            this.roomTableTableAdapter.Fill(this.myDBDataSet.RoomTable);
            // TODO: This line of code loads data into the 'myDBDataSet7.SubjectTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'myDBDataSet6.LecturerTbl' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'myDBDataSet5.RoomTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'myDBDataSet4.LecturerTbl' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'myDBDataSet3.SubjectTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'myDBDataSet2.RoomTable' table. You can move, or remove it, as needed.

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
