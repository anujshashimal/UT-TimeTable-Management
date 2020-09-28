namespace TimeTableManagement.Forms
{
    partial class roomsManaging
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sessionType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.aroomType = new System.Windows.Forms.ComboBox();
            this.assignRoom = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomManagingSource = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.atag2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notavltime = new System.Windows.Forms.ComboBox();
            this.asubjectCode = new System.Windows.Forms.ComboBox();
            this.agroupid = new System.Windows.Forms.ComboBox();
            this.atags = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.locBtn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rrrname = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rrbtn = new System.Windows.Forms.Button();
            this.rntime = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.notAvailableGridView = new System.Windows.Forms.DataGridView();
            this.rfaculty = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rName = new System.Windows.Forms.ComboBox();
            this.rreleaseRoom = new System.Windows.Forms.Label();
            this.releaceBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.electurenme = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lroomtype = new System.Windows.Forms.ComboBox();
            this.lroomName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomManagingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAvailableGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 673);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.faculty);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.sessionType);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.aroomType);
            this.tabPage1.Controls.Add(this.assignRoom);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.locBtn2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assign Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // faculty
            // 
            this.faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.FormattingEnabled = true;
            this.faculty.Location = new System.Drawing.Point(133, 43);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(387, 28);
            this.faculty.TabIndex = 70;
            this.faculty.SelectedIndexChanged += new System.EventHandler(this.faculty_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(22, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Faculty";
            // 
            // sessionType
            // 
            this.sessionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionType.FormattingEnabled = true;
            this.sessionType.Location = new System.Drawing.Point(133, 167);
            this.sessionType.Name = "sessionType";
            this.sessionType.Size = new System.Drawing.Size(387, 28);
            this.sessionType.TabIndex = 68;
            this.sessionType.SelectedIndexChanged += new System.EventHandler(this.sessionType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(22, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 67;
            this.label12.Text = "Session Type";
            // 
            // aroomType
            // 
            this.aroomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aroomType.FormattingEnabled = true;
            this.aroomType.Location = new System.Drawing.Point(133, 123);
            this.aroomType.Name = "aroomType";
            this.aroomType.Size = new System.Drawing.Size(387, 28);
            this.aroomType.TabIndex = 66;
            this.aroomType.SelectedIndexChanged += new System.EventHandler(this.aroomType_SelectedIndexChanged);
            // 
            // assignRoom
            // 
            this.assignRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignRoom.FormattingEnabled = true;
            this.assignRoom.Location = new System.Drawing.Point(133, 84);
            this.assignRoom.Name = "assignRoom";
            this.assignRoom.Size = new System.Drawing.Size(387, 28);
            this.assignRoom.TabIndex = 65;
            this.assignRoom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.roomManagingSource);
            this.panel3.Location = new System.Drawing.Point(0, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 195);
            this.panel3.TabIndex = 59;
            // 
            // roomManagingSource
            // 
            this.roomManagingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomManagingSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomManagingSource.Location = new System.Drawing.Point(0, 0);
            this.roomManagingSource.Name = "roomManagingSource";
            this.roomManagingSource.Size = new System.Drawing.Size(1042, 195);
            this.roomManagingSource.TabIndex = 0;
            this.roomManagingSource.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomManagingSource_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(773, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 43);
            this.button2.TabIndex = 58;
            this.button2.Text = "Delete Session";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(773, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 43);
            this.button1.TabIndex = 57;
            this.button1.Text = "Edit Session";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.atag2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.notavltime);
            this.panel2.Controls.Add(this.asubjectCode);
            this.panel2.Controls.Add(this.agroupid);
            this.panel2.Controls.Add(this.atags);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(6, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 220);
            this.panel2.TabIndex = 56;
            // 
            // atag2
            // 
            this.atag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atag2.FormattingEnabled = true;
            this.atag2.Location = new System.Drawing.Point(681, 65);
            this.atag2.Name = "atag2";
            this.atag2.Size = new System.Drawing.Size(300, 28);
            this.atag2.TabIndex = 72;
            this.atag2.SelectedIndexChanged += new System.EventHandler(this.atag2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(503, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tag 2";
            // 
            // notavltime
            // 
            this.notavltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notavltime.FormattingEnabled = true;
            this.notavltime.Location = new System.Drawing.Point(195, 153);
            this.notavltime.Name = "notavltime";
            this.notavltime.Size = new System.Drawing.Size(300, 28);
            this.notavltime.TabIndex = 69;
            // 
            // asubjectCode
            // 
            this.asubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asubjectCode.FormattingEnabled = true;
            this.asubjectCode.Location = new System.Drawing.Point(195, 21);
            this.asubjectCode.Name = "asubjectCode";
            this.asubjectCode.Size = new System.Drawing.Size(300, 28);
            this.asubjectCode.TabIndex = 68;
            this.asubjectCode.SelectedIndexChanged += new System.EventHandler(this.asubjectCode_SelectedIndexChanged);
            // 
            // agroupid
            // 
            this.agroupid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agroupid.FormattingEnabled = true;
            this.agroupid.Location = new System.Drawing.Point(195, 109);
            this.agroupid.Name = "agroupid";
            this.agroupid.Size = new System.Drawing.Size(300, 28);
            this.agroupid.TabIndex = 66;
            // 
            // atags
            // 
            this.atags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atags.FormattingEnabled = true;
            this.atags.Location = new System.Drawing.Point(195, 66);
            this.atags.Name = "atags";
            this.atags.Size = new System.Drawing.Size(300, 28);
            this.atags.TabIndex = 64;
            this.atags.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(17, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 23);
            this.label11.TabIndex = 63;
            this.label11.Text = "Not available time";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(18, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "Subject Code";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(16, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Group id/Subgroup id";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tag 1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(18, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Managing the rooms";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(18, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Select the one of these type";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Room type";
            // 
            // locBtn2
            // 
            this.locBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.locBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.locBtn2.Location = new System.Drawing.Point(773, 35);
            this.locBtn2.Name = "locBtn2";
            this.locBtn2.Size = new System.Drawing.Size(259, 43);
            this.locBtn2.TabIndex = 48;
            this.locBtn2.Text = "Update session";
            this.locBtn2.UseVisualStyleBackColor = false;
            this.locBtn2.Click += new System.EventHandler(this.locBtn2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Assign room name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rrrname);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.rrbtn);
            this.tabPage2.Controls.Add(this.rntime);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.rfaculty);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.rName);
            this.tabPage2.Controls.Add(this.rreleaseRoom);
            this.tabPage2.Controls.Add(this.releaceBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Release Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // rrrname
            // 
            this.rrrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrrname.FormattingEnabled = true;
            this.rrrname.Location = new System.Drawing.Point(191, 228);
            this.rrrname.Name = "rrrname";
            this.rrrname.Size = new System.Drawing.Size(387, 28);
            this.rrrname.TabIndex = 84;
            this.rrrname.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(13, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 23);
            this.label16.TabIndex = 83;
            this.label16.Text = "Room Name";
            // 
            // rrbtn
            // 
            this.rrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rrbtn.Location = new System.Drawing.Point(623, 222);
            this.rrbtn.Name = "rrbtn";
            this.rrbtn.Size = new System.Drawing.Size(259, 43);
            this.rrbtn.TabIndex = 82;
            this.rrbtn.Text = "Release Room";
            this.rrbtn.UseVisualStyleBackColor = false;
            this.rrbtn.Click += new System.EventHandler(this.rrbtn_Click);
            // 
            // rntime
            // 
            this.rntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rntime.FormattingEnabled = true;
            this.rntime.Location = new System.Drawing.Point(191, 127);
            this.rntime.Name = "rntime";
            this.rntime.Size = new System.Drawing.Size(318, 28);
            this.rntime.TabIndex = 81;
            this.rntime.SelectedIndexChanged += new System.EventHandler(this.rntime_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(13, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 23);
            this.label14.TabIndex = 80;
            this.label14.Text = "Not available time";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.notAvailableGridView);
            this.panel4.Location = new System.Drawing.Point(0, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 200);
            this.panel4.TabIndex = 79;
            // 
            // notAvailableGridView
            // 
            this.notAvailableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAvailableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notAvailableGridView.Location = new System.Drawing.Point(0, 0);
            this.notAvailableGridView.Name = "notAvailableGridView";
            this.notAvailableGridView.Size = new System.Drawing.Size(1043, 200);
            this.notAvailableGridView.TabIndex = 0;
            this.notAvailableGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notAvailableGridView_CellContentClick);
            // 
            // rfaculty
            // 
            this.rfaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfaculty.FormattingEnabled = true;
            this.rfaculty.Location = new System.Drawing.Point(191, 40);
            this.rfaculty.Name = "rfaculty";
            this.rfaculty.Size = new System.Drawing.Size(387, 28);
            this.rfaculty.TabIndex = 78;
            this.rfaculty.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(11, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 23);
            this.label13.TabIndex = 77;
            this.label13.Text = "Faculty";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(13, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 23);
            this.label15.TabIndex = 76;
            this.label15.Text = "Releasing rooms";
            // 
            // rName
            // 
            this.rName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rName.FormattingEnabled = true;
            this.rName.Location = new System.Drawing.Point(191, 81);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(387, 28);
            this.rName.TabIndex = 75;
            // 
            // rreleaseRoom
            // 
            this.rreleaseRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rreleaseRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rreleaseRoom.Location = new System.Drawing.Point(11, 86);
            this.rreleaseRoom.Name = "rreleaseRoom";
            this.rreleaseRoom.Size = new System.Drawing.Size(122, 23);
            this.rreleaseRoom.TabIndex = 74;
            this.rreleaseRoom.Text = "Room Name";
            // 
            // releaceBtn
            // 
            this.releaceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.releaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.releaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.releaceBtn.Location = new System.Drawing.Point(623, 40);
            this.releaceBtn.Name = "releaceBtn";
            this.releaceBtn.Size = new System.Drawing.Size(259, 43);
            this.releaceBtn.TabIndex = 72;
            this.releaceBtn.Text = "Add Room To Not Available Time";
            this.releaceBtn.UseVisualStyleBackColor = false;
            this.releaceBtn.Click += new System.EventHandler(this.releaceBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.electurenme);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lroomtype);
            this.tabPage3.Controls.Add(this.lroomName);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.lButton);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1042, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // electurenme
            // 
            this.electurenme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electurenme.FormattingEnabled = true;
            this.electurenme.Location = new System.Drawing.Point(138, 50);
            this.electurenme.Name = "electurenme";
            this.electurenme.Size = new System.Drawing.Size(387, 28);
            this.electurenme.TabIndex = 78;
            this.electurenme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(10, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 77;
            this.label7.Text = "Lecture name";
            // 
            // lroomtype
            // 
            this.lroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lroomtype.FormattingEnabled = true;
            this.lroomtype.Location = new System.Drawing.Point(138, 96);
            this.lroomtype.Name = "lroomtype";
            this.lroomtype.Size = new System.Drawing.Size(387, 28);
            this.lroomtype.TabIndex = 76;
            this.lroomtype.SelectedIndexChanged += new System.EventHandler(this.lroomtype_SelectedIndexChanged);
            // 
            // lroomName
            // 
            this.lroomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lroomName.FormattingEnabled = true;
            this.lroomName.Location = new System.Drawing.Point(138, 138);
            this.lroomName.Name = "lroomName";
            this.lroomName.Size = new System.Drawing.Size(387, 28);
            this.lroomName.TabIndex = 75;
            this.lroomName.SelectedIndexChanged += new System.EventHandler(this.lroomName_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(6, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 23);
            this.label17.TabIndex = 74;
            this.label17.Text = "Add Rooms to lecture";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(10, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 23);
            this.label18.TabIndex = 73;
            this.label18.Text = "Room type";
            // 
            // lButton
            // 
            this.lButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lButton.Location = new System.Drawing.Point(585, 50);
            this.lButton.Name = "lButton";
            this.lButton.Size = new System.Drawing.Size(259, 43);
            this.lButton.TabIndex = 72;
            this.lButton.Text = "Add lecturer to room";
            this.lButton.UseVisualStyleBackColor = false;
            this.lButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(10, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 23);
            this.label19.TabIndex = 71;
            this.label19.Text = "Room Number";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(0, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 240);
            this.panel5.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // roomsManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 675);
            this.Controls.Add(this.panel1);
            this.Name = "roomsManaging";
            this.Text = "roomsManaging";
            this.Load += new System.EventHandler(this.roomsManaging_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomManagingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notAvailableGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button locBtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView roomManagingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox notavltime;
        private System.Windows.Forms.ComboBox asubjectCode;
        private System.Windows.Forms.ComboBox agroupid;
        private System.Windows.Forms.ComboBox atags;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox assignRoom;
        private System.Windows.Forms.ComboBox aroomType;
        private System.Windows.Forms.ComboBox atag2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sessionType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView notAvailableGridView;
        private System.Windows.Forms.ComboBox rfaculty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox rName;
        private System.Windows.Forms.Label rreleaseRoom;
        private System.Windows.Forms.Button releaceBtn;
        private System.Windows.Forms.ComboBox rntime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox rrrname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button rrbtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox electurenme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lroomtype;
        private System.Windows.Forms.ComboBox lroomName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button lButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}