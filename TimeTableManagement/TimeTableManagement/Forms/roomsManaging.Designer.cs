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
            this.aroomType = new System.Windows.Forms.ComboBox();
            this.assignRoom = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomManagingSource = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.sessionType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomManagingSource)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
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
            this.panel2.Size = new System.Drawing.Size(1026, 211);
            this.panel2.TabIndex = 56;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 28);
            this.comboBox1.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(503, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 73;
            this.label7.Text = "Not available time";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // roomsManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 675);
            this.Controls.Add(this.panel1);
            this.Name = "roomsManaging";
            this.Text = "roomsManaging";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomManagingSource)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox atag2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sessionType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox faculty;
        private System.Windows.Forms.Label label9;
    }
}