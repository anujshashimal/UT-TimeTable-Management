namespace TimeTableManagement.Forms
{
    partial class students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Tagcombobox = new System.Windows.Forms.ComboBox();
            this.Tagaddbutton = new System.Windows.Forms.Button();
            this.Tageditbutton = new System.Windows.Forms.Button();
            this.tagdeletebutton = new System.Windows.Forms.Button();
            this.TagdataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.academicyearsem = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Programme_comboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Groupnumber_comboBox = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupId_comboBox = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Sub_group_number_comboBox = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Sub_group_comboBox = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.Academicyrdatagrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.Programmedatagrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupidgridview = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.subgroupiddatagridview = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagdataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Academicyrdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Programmedatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupidgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subgroupiddatagridview)).BeginInit();
            this.Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.TagdataGridView);
            this.tabPage2.Controls.Add(this.tagdeletebutton);
            this.tabPage2.Controls.Add(this.Tageditbutton);
            this.tabPage2.Controls.Add(this.Tagaddbutton);
            this.tabPage2.Controls.Add(this.Tagcombobox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tag";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tag Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Tagcombobox
            // 
            this.Tagcombobox.FormattingEnabled = true;
            this.Tagcombobox.Location = new System.Drawing.Point(212, 65);
            this.Tagcombobox.Name = "Tagcombobox";
            this.Tagcombobox.Size = new System.Drawing.Size(178, 27);
            this.Tagcombobox.TabIndex = 35;
            this.Tagcombobox.SelectedIndexChanged += new System.EventHandler(this.Tagcombobox_SelectedIndexChanged);
            // 
            // Tagaddbutton
            // 
            this.Tagaddbutton.Location = new System.Drawing.Point(511, 26);
            this.Tagaddbutton.Name = "Tagaddbutton";
            this.Tagaddbutton.Size = new System.Drawing.Size(75, 29);
            this.Tagaddbutton.TabIndex = 36;
            this.Tagaddbutton.Text = "Add";
            this.Tagaddbutton.UseVisualStyleBackColor = true;
            this.Tagaddbutton.Click += new System.EventHandler(this.Tagaddbutton_Click);
            // 
            // Tageditbutton
            // 
            this.Tageditbutton.Location = new System.Drawing.Point(511, 93);
            this.Tageditbutton.Name = "Tageditbutton";
            this.Tageditbutton.Size = new System.Drawing.Size(75, 29);
            this.Tageditbutton.TabIndex = 37;
            this.Tageditbutton.Text = "Edit";
            this.Tageditbutton.UseVisualStyleBackColor = true;
            this.Tageditbutton.Click += new System.EventHandler(this.Tageditbutton_Click);
            // 
            // tagdeletebutton
            // 
            this.tagdeletebutton.Location = new System.Drawing.Point(511, 164);
            this.tagdeletebutton.Name = "tagdeletebutton";
            this.tagdeletebutton.Size = new System.Drawing.Size(75, 28);
            this.tagdeletebutton.TabIndex = 38;
            this.tagdeletebutton.Text = "Delete";
            this.tagdeletebutton.UseVisualStyleBackColor = true;
            this.tagdeletebutton.Click += new System.EventHandler(this.tagdeletebutton_Click);
            // 
            // TagdataGridView
            // 
            this.TagdataGridView.AllowUserToAddRows = false;
            this.TagdataGridView.AllowUserToDeleteRows = false;
            this.TagdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagdataGridView.Location = new System.Drawing.Point(130, 217);
            this.TagdataGridView.Name = "TagdataGridView";
            this.TagdataGridView.Size = new System.Drawing.Size(237, 236);
            this.TagdataGridView.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.subgroupiddatagridview);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupidgridview);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.Programmedatagrid);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Academicyrdatagrid);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.Sub_group_comboBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.Sub_group_number_comboBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.GroupId_comboBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.Groupnumber_comboBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.Programme_comboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.academicyearsem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Academic Year and  Semester";
            // 
            // academicyearsem
            // 
            this.academicyearsem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.academicyearsem.FormattingEnabled = true;
            this.academicyearsem.Location = new System.Drawing.Point(284, 41);
            this.academicyearsem.Name = "academicyearsem";
            this.academicyearsem.Size = new System.Drawing.Size(136, 27);
            this.academicyearsem.TabIndex = 34;
            this.academicyearsem.SelectedIndexChanged += new System.EventHandler(this.academicyearsem_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 35;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 37;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Programme";
            // 
            // Programme_comboBox
            // 
            this.Programme_comboBox.FormattingEnabled = true;
            this.Programme_comboBox.Location = new System.Drawing.Point(284, 100);
            this.Programme_comboBox.Name = "Programme_comboBox";
            this.Programme_comboBox.Size = new System.Drawing.Size(136, 27);
            this.Programme_comboBox.TabIndex = 39;
            this.Programme_comboBox.SelectedIndexChanged += new System.EventHandler(this.Programme_comboBox_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(439, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 40;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(532, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 29);
            this.button5.TabIndex = 41;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(627, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 29);
            this.button6.TabIndex = 42;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Group number";
            // 
            // Groupnumber_comboBox
            // 
            this.Groupnumber_comboBox.FormattingEnabled = true;
            this.Groupnumber_comboBox.Location = new System.Drawing.Point(284, 152);
            this.Groupnumber_comboBox.Name = "Groupnumber_comboBox";
            this.Groupnumber_comboBox.Size = new System.Drawing.Size(136, 27);
            this.Groupnumber_comboBox.TabIndex = 44;
            this.Groupnumber_comboBox.SelectedIndexChanged += new System.EventHandler(this.Groupnumber_comboBox_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(439, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 26);
            this.button7.TabIndex = 45;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(532, 150);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 29);
            this.button8.TabIndex = 46;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(627, 150);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 29);
            this.button9.TabIndex = 47;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Group Id";
            // 
            // GroupId_comboBox
            // 
            this.GroupId_comboBox.FormattingEnabled = true;
            this.GroupId_comboBox.Location = new System.Drawing.Point(284, 207);
            this.GroupId_comboBox.Name = "GroupId_comboBox";
            this.GroupId_comboBox.Size = new System.Drawing.Size(136, 27);
            this.GroupId_comboBox.TabIndex = 49;
            this.GroupId_comboBox.SelectedIndexChanged += new System.EventHandler(this.GroupId_comboBox_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(612, 211);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 32);
            this.button10.TabIndex = 50;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Sub -Group-number";
            // 
            // Sub_group_number_comboBox
            // 
            this.Sub_group_number_comboBox.FormattingEnabled = true;
            this.Sub_group_number_comboBox.Location = new System.Drawing.Point(284, 289);
            this.Sub_group_number_comboBox.Name = "Sub_group_number_comboBox";
            this.Sub_group_number_comboBox.Size = new System.Drawing.Size(136, 27);
            this.Sub_group_number_comboBox.TabIndex = 52;
            this.Sub_group_number_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sub_group_number_comboBox_SelectedIndexChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(439, 287);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 29);
            this.button11.TabIndex = 53;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(532, 287);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 29);
            this.button12.TabIndex = 54;
            this.button12.Text = "Edit";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(627, 289);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 27);
            this.button13.TabIndex = 55;
            this.button13.Text = "Delete";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Sub -Group-Id";
            // 
            // Sub_group_comboBox
            // 
            this.Sub_group_comboBox.FormattingEnabled = true;
            this.Sub_group_comboBox.Location = new System.Drawing.Point(284, 344);
            this.Sub_group_comboBox.Name = "Sub_group_comboBox";
            this.Sub_group_comboBox.Size = new System.Drawing.Size(136, 27);
            this.Sub_group_comboBox.TabIndex = 57;
            this.Sub_group_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sub_group_comboBox_SelectedIndexChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(665, 344);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(87, 27);
            this.button14.TabIndex = 58;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(439, 211);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(167, 32);
            this.button15.TabIndex = 59;
            this.button15.Text = "Submit Group Id";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(440, 344);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(193, 27);
            this.button16.TabIndex = 60;
            this.button16.Text = "Submit Sub Group Id";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Academicyrdatagrid
            // 
            this.Academicyrdatagrid.AllowUserToAddRows = false;
            this.Academicyrdatagrid.AllowUserToDeleteRows = false;
            this.Academicyrdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Academicyrdatagrid.Location = new System.Drawing.Point(31, 432);
            this.Academicyrdatagrid.Name = "Academicyrdatagrid";
            this.Academicyrdatagrid.Size = new System.Drawing.Size(222, 150);
            this.Academicyrdatagrid.TabIndex = 61;
            this.Academicyrdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "Academic Year and  Semester";
            // 
            // Programmedatagrid
            // 
            this.Programmedatagrid.AllowUserToAddRows = false;
            this.Programmedatagrid.AllowUserToDeleteRows = false;
            this.Programmedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Programmedatagrid.Location = new System.Drawing.Point(270, 432);
            this.Programmedatagrid.Name = "Programmedatagrid";
            this.Programmedatagrid.ReadOnly = true;
            this.Programmedatagrid.Size = new System.Drawing.Size(222, 150);
            this.Programmedatagrid.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(329, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 64;
            this.label11.Text = "Programme";
            // 
            // groupidgridview
            // 
            this.groupidgridview.AllowUserToAddRows = false;
            this.groupidgridview.AllowUserToDeleteRows = false;
            this.groupidgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupidgridview.Location = new System.Drawing.Point(509, 432);
            this.groupidgridview.Name = "groupidgridview";
            this.groupidgridview.ReadOnly = true;
            this.groupidgridview.Size = new System.Drawing.Size(222, 150);
            this.groupidgridview.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(575, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Group Id";
            // 
            // subgroupiddatagridview
            // 
            this.subgroupiddatagridview.AllowUserToAddRows = false;
            this.subgroupiddatagridview.AllowUserToDeleteRows = false;
            this.subgroupiddatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subgroupiddatagridview.Location = new System.Drawing.Point(737, 432);
            this.subgroupiddatagridview.Name = "subgroupiddatagridview";
            this.subgroupiddatagridview.ReadOnly = true;
            this.subgroupiddatagridview.Size = new System.Drawing.Size(216, 150);
            this.subgroupiddatagridview.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(808, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Sub Group Id";
            // 
            // Student
            // 
            this.Student.Controls.Add(this.tabPage1);
            this.Student.Controls.Add(this.tabPage2);
            this.Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(0, 0);
            this.Student.Name = "Student";
            this.Student.SelectedIndex = 0;
            this.Student.Size = new System.Drawing.Size(982, 620);
            this.Student.TabIndex = 0;
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 620);
            this.Controls.Add(this.Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "students";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TagdataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Academicyrdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Programmedatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupidgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subgroupiddatagridview)).EndInit();
            this.Student.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TagdataGridView;
        private System.Windows.Forms.Button tagdeletebutton;
        private System.Windows.Forms.Button Tageditbutton;
        private System.Windows.Forms.Button Tagaddbutton;
        private System.Windows.Forms.ComboBox Tagcombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView subgroupiddatagridview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView groupidgridview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Programmedatagrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Academicyrdatagrid;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ComboBox Sub_group_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox Sub_group_number_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox GroupId_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox Groupnumber_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Programme_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox academicyearsem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Student;
    }
}