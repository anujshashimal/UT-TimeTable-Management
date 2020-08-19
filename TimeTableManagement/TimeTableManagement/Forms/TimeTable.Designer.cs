namespace TimeTableManagement.Forms
{
    partial class TimeTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNumberOfWorkingDaysId = new System.Windows.Forms.TextBox();
            this.btnDeleteNumOfWorkingDays = new System.Windows.Forms.Button();
            this.btnUpdateNumOfWorkingDays = new System.Windows.Forms.Button();
            this.btnAddNumOfWorkingDays = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numWeekend = new System.Windows.Forms.NumericUpDown();
            this.numWeekday = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataNumberOfWorkingDays = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataWorkingDays = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearWorkingDays = new System.Windows.Forms.Button();
            this.btnDeleteWorkingDays = new System.Windows.Forms.Button();
            this.btnUpdateWorkingDays = new System.Windows.Forms.Button();
            this.btnAddWorkingDays = new System.Windows.Forms.Button();
            this.workingDaysId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkingDay = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataWorkingTime = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WorkingTimeId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearWorkingTime = new System.Windows.Forms.Button();
            this.btnDeleteWorkingTime = new System.Windows.Forms.Button();
            this.btnUpdateWorkingTime = new System.Windows.Forms.Button();
            this.btnAddWorkingTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDayWorkingTime = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimeSloat = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TimeSloatId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTimeSlotClear = new System.Windows.Forms.Button();
            this.btnTimeSloatDelete = new System.Windows.Forms.Button();
            this.btnTimeSloatUpdate = new System.Windows.Forms.Button();
            this.btnTimeSloatAdd = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.timeSlotType = new System.Windows.Forms.ComboBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.TextBox();
            this.workingTime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeekend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeekday)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumberOfWorkingDays)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkingDays)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkingTime)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeSloat)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 588);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.txtNumberOfWorkingDaysId);
            this.tabPage1.Controls.Add(this.btnDeleteNumOfWorkingDays);
            this.tabPage1.Controls.Add(this.btnUpdateNumOfWorkingDays);
            this.tabPage1.Controls.Add(this.btnAddNumOfWorkingDays);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numWeekend);
            this.tabPage1.Controls.Add(this.numWeekday);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Number of working days";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNumberOfWorkingDaysId
            // 
            this.txtNumberOfWorkingDaysId.Location = new System.Drawing.Point(566, 74);
            this.txtNumberOfWorkingDaysId.Name = "txtNumberOfWorkingDaysId";
            this.txtNumberOfWorkingDaysId.Size = new System.Drawing.Size(134, 20);
            this.txtNumberOfWorkingDaysId.TabIndex = 47;
            this.txtNumberOfWorkingDaysId.Visible = false;
            // 
            // btnDeleteNumOfWorkingDays
            // 
            this.btnDeleteNumOfWorkingDays.Location = new System.Drawing.Point(311, 158);
            this.btnDeleteNumOfWorkingDays.Name = "btnDeleteNumOfWorkingDays";
            this.btnDeleteNumOfWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNumOfWorkingDays.TabIndex = 46;
            this.btnDeleteNumOfWorkingDays.Text = "Delete";
            this.btnDeleteNumOfWorkingDays.UseVisualStyleBackColor = true;
            this.btnDeleteNumOfWorkingDays.Click += new System.EventHandler(this.btnDeleteNumOfWorkingDays_Click);
            // 
            // btnUpdateNumOfWorkingDays
            // 
            this.btnUpdateNumOfWorkingDays.Location = new System.Drawing.Point(206, 158);
            this.btnUpdateNumOfWorkingDays.Name = "btnUpdateNumOfWorkingDays";
            this.btnUpdateNumOfWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateNumOfWorkingDays.TabIndex = 45;
            this.btnUpdateNumOfWorkingDays.Text = "Update";
            this.btnUpdateNumOfWorkingDays.UseVisualStyleBackColor = true;
            this.btnUpdateNumOfWorkingDays.Click += new System.EventHandler(this.btnUpdateNumOfWorkingDays_Click);
            // 
            // btnAddNumOfWorkingDays
            // 
            this.btnAddNumOfWorkingDays.Location = new System.Drawing.Point(107, 158);
            this.btnAddNumOfWorkingDays.Name = "btnAddNumOfWorkingDays";
            this.btnAddNumOfWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumOfWorkingDays.TabIndex = 44;
            this.btnAddNumOfWorkingDays.Text = "Add";
            this.btnAddNumOfWorkingDays.UseVisualStyleBackColor = true;
            this.btnAddNumOfWorkingDays.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Weekend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Weekday";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numWeekend
            // 
            this.numWeekend.Location = new System.Drawing.Point(161, 97);
            this.numWeekend.Name = "numWeekend";
            this.numWeekend.Size = new System.Drawing.Size(207, 20);
            this.numWeekend.TabIndex = 41;
            // 
            // numWeekday
            // 
            this.numWeekday.Location = new System.Drawing.Point(161, 59);
            this.numWeekday.Name = "numWeekday";
            this.numWeekday.Size = new System.Drawing.Size(207, 20);
            this.numWeekday.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataNumberOfWorkingDays);
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 356);
            this.panel2.TabIndex = 39;
            // 
            // dataNumberOfWorkingDays
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNumberOfWorkingDays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataNumberOfWorkingDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNumberOfWorkingDays.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataNumberOfWorkingDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNumberOfWorkingDays.Location = new System.Drawing.Point(0, 0);
            this.dataNumberOfWorkingDays.Name = "dataNumberOfWorkingDays";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNumberOfWorkingDays.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataNumberOfWorkingDays.Size = new System.Drawing.Size(909, 356);
            this.dataNumberOfWorkingDays.TabIndex = 0;
            this.dataNumberOfWorkingDays.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNumberOfWorkingDays_CellContentClick_1);
            this.dataNumberOfWorkingDays.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNumberOfWorkingDays_CellContentDoubleClick);
            this.dataNumberOfWorkingDays.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNumberOfWorkingDays_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Number of working days";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataWorkingDays);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Working Days";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataWorkingDays
            // 
            this.dataWorkingDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWorkingDays.Location = new System.Drawing.Point(0, 222);
            this.dataWorkingDays.Name = "dataWorkingDays";
            this.dataWorkingDays.Size = new System.Drawing.Size(912, 342);
            this.dataWorkingDays.TabIndex = 44;
            this.dataWorkingDays.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataWorkingDays_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClearWorkingDays);
            this.panel3.Controls.Add(this.btnDeleteWorkingDays);
            this.panel3.Controls.Add(this.btnUpdateWorkingDays);
            this.panel3.Controls.Add(this.btnAddWorkingDays);
            this.panel3.Controls.Add(this.workingDaysId);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtWorkingDay);
            this.panel3.Controls.Add(this.txtType);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 215);
            this.panel3.TabIndex = 43;
            // 
            // btnClearWorkingDays
            // 
            this.btnClearWorkingDays.Location = new System.Drawing.Point(494, 168);
            this.btnClearWorkingDays.Name = "btnClearWorkingDays";
            this.btnClearWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnClearWorkingDays.TabIndex = 53;
            this.btnClearWorkingDays.Text = "Clear";
            this.btnClearWorkingDays.UseVisualStyleBackColor = true;
            this.btnClearWorkingDays.Click += new System.EventHandler(this.btnClearWorkingDays_Click);
            // 
            // btnDeleteWorkingDays
            // 
            this.btnDeleteWorkingDays.Location = new System.Drawing.Point(387, 168);
            this.btnDeleteWorkingDays.Name = "btnDeleteWorkingDays";
            this.btnDeleteWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWorkingDays.TabIndex = 52;
            this.btnDeleteWorkingDays.Text = "Delete";
            this.btnDeleteWorkingDays.UseVisualStyleBackColor = true;
            this.btnDeleteWorkingDays.Click += new System.EventHandler(this.btnDeleteWorkingDays_Click);
            // 
            // btnUpdateWorkingDays
            // 
            this.btnUpdateWorkingDays.Location = new System.Drawing.Point(282, 168);
            this.btnUpdateWorkingDays.Name = "btnUpdateWorkingDays";
            this.btnUpdateWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateWorkingDays.TabIndex = 51;
            this.btnUpdateWorkingDays.Text = "Update";
            this.btnUpdateWorkingDays.UseVisualStyleBackColor = true;
            this.btnUpdateWorkingDays.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddWorkingDays
            // 
            this.btnAddWorkingDays.Location = new System.Drawing.Point(183, 168);
            this.btnAddWorkingDays.Name = "btnAddWorkingDays";
            this.btnAddWorkingDays.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorkingDays.TabIndex = 50;
            this.btnAddWorkingDays.Text = "Add";
            this.btnAddWorkingDays.UseVisualStyleBackColor = true;
            this.btnAddWorkingDays.Click += new System.EventHandler(this.btnAddWorkingDays_Click);
            // 
            // workingDaysId
            // 
            this.workingDaysId.Location = new System.Drawing.Point(481, 59);
            this.workingDaysId.Name = "workingDaysId";
            this.workingDaysId.Size = new System.Drawing.Size(133, 20);
            this.workingDaysId.TabIndex = 49;
            this.workingDaysId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Type";
            // 
            // txtWorkingDay
            // 
            this.txtWorkingDay.Location = new System.Drawing.Point(154, 57);
            this.txtWorkingDay.Name = "txtWorkingDay";
            this.txtWorkingDay.Size = new System.Drawing.Size(203, 20);
            this.txtWorkingDay.TabIndex = 48;
            this.txtWorkingDay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Weekday",
            "Weekend"});
            this.txtType.Location = new System.Drawing.Point(154, 104);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(203, 21);
            this.txtType.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Working Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Day";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataWorkingTime);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(912, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Working Time";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataWorkingTime
            // 
            this.dataWorkingTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWorkingTime.Location = new System.Drawing.Point(-1, 261);
            this.dataWorkingTime.Name = "dataWorkingTime";
            this.dataWorkingTime.Size = new System.Drawing.Size(913, 298);
            this.dataWorkingTime.TabIndex = 3;
            this.dataWorkingTime.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataWorkingTime_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.workingTime);
            this.panel4.Controls.Add(this.WorkingTimeId);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnClearWorkingTime);
            this.panel4.Controls.Add(this.btnDeleteWorkingTime);
            this.panel4.Controls.Add(this.btnUpdateWorkingTime);
            this.panel4.Controls.Add(this.btnAddWorkingTime);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtDayWorkingTime);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 258);
            this.panel4.TabIndex = 2;
            // 
            // WorkingTimeId
            // 
            this.WorkingTimeId.Location = new System.Drawing.Point(456, 50);
            this.WorkingTimeId.Name = "WorkingTimeId";
            this.WorkingTimeId.Size = new System.Drawing.Size(133, 20);
            this.WorkingTimeId.TabIndex = 62;
            this.WorkingTimeId.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Working time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Day";
            // 
            // btnClearWorkingTime
            // 
            this.btnClearWorkingTime.Location = new System.Drawing.Point(493, 217);
            this.btnClearWorkingTime.Name = "btnClearWorkingTime";
            this.btnClearWorkingTime.Size = new System.Drawing.Size(75, 23);
            this.btnClearWorkingTime.TabIndex = 57;
            this.btnClearWorkingTime.Text = "Clear";
            this.btnClearWorkingTime.UseVisualStyleBackColor = true;
            this.btnClearWorkingTime.Click += new System.EventHandler(this.btnClearWorkingTime_Click);
            // 
            // btnDeleteWorkingTime
            // 
            this.btnDeleteWorkingTime.Location = new System.Drawing.Point(386, 217);
            this.btnDeleteWorkingTime.Name = "btnDeleteWorkingTime";
            this.btnDeleteWorkingTime.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWorkingTime.TabIndex = 56;
            this.btnDeleteWorkingTime.Text = "Delete";
            this.btnDeleteWorkingTime.UseVisualStyleBackColor = true;
            this.btnDeleteWorkingTime.Click += new System.EventHandler(this.btnDeleteWorkingTime_Click);
            // 
            // btnUpdateWorkingTime
            // 
            this.btnUpdateWorkingTime.Location = new System.Drawing.Point(281, 217);
            this.btnUpdateWorkingTime.Name = "btnUpdateWorkingTime";
            this.btnUpdateWorkingTime.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateWorkingTime.TabIndex = 55;
            this.btnUpdateWorkingTime.Text = "Update";
            this.btnUpdateWorkingTime.UseVisualStyleBackColor = true;
            this.btnUpdateWorkingTime.Click += new System.EventHandler(this.btnUpdateWorkingTime_Click);
            // 
            // btnAddWorkingTime
            // 
            this.btnAddWorkingTime.Location = new System.Drawing.Point(182, 217);
            this.btnAddWorkingTime.Name = "btnAddWorkingTime";
            this.btnAddWorkingTime.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorkingTime.TabIndex = 54;
            this.btnAddWorkingTime.Text = "Add";
            this.btnAddWorkingTime.UseVisualStyleBackColor = true;
            this.btnAddWorkingTime.Click += new System.EventHandler(this.btnAddWorkingTime_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Working time per day";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDayWorkingTime
            // 
            this.txtDayWorkingTime.FormattingEnabled = true;
            this.txtDayWorkingTime.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thruesday",
            "Friday",
            "Satureday",
            "Sunday"});
            this.txtDayWorkingTime.Location = new System.Drawing.Point(176, 89);
            this.txtDayWorkingTime.Name = "txtDayWorkingTime";
            this.txtDayWorkingTime.Size = new System.Drawing.Size(227, 21);
            this.txtDayWorkingTime.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dateTimeSloat);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(912, 559);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Time Slots";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimeSloat
            // 
            this.dateTimeSloat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateTimeSloat.Location = new System.Drawing.Point(1, 261);
            this.dateTimeSloat.Name = "dateTimeSloat";
            this.dateTimeSloat.Size = new System.Drawing.Size(913, 298);
            this.dateTimeSloat.TabIndex = 4;
            this.dateTimeSloat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dateTimeSloat_CellDoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.endTime);
            this.panel5.Controls.Add(this.startTime);
            this.panel5.Controls.Add(this.TimeSloatId);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.btnTimeSlotClear);
            this.panel5.Controls.Add(this.btnTimeSloatDelete);
            this.panel5.Controls.Add(this.btnTimeSloatUpdate);
            this.panel5.Controls.Add(this.btnTimeSloatAdd);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.timeSlotType);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(912, 258);
            this.panel5.TabIndex = 3;
            // 
            // TimeSloatId
            // 
            this.TimeSloatId.Location = new System.Drawing.Point(512, 73);
            this.TimeSloatId.Name = "TimeSloatId";
            this.TimeSloatId.Size = new System.Drawing.Size(133, 20);
            this.TimeSloatId.TabIndex = 63;
            this.TimeSloatId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "End time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Start time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Type";
            // 
            // btnTimeSlotClear
            // 
            this.btnTimeSlotClear.Location = new System.Drawing.Point(540, 217);
            this.btnTimeSlotClear.Name = "btnTimeSlotClear";
            this.btnTimeSlotClear.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSlotClear.TabIndex = 57;
            this.btnTimeSlotClear.Text = "Clear";
            this.btnTimeSlotClear.UseVisualStyleBackColor = true;
            this.btnTimeSlotClear.Click += new System.EventHandler(this.btnTimeSlotClear_Click);
            // 
            // btnTimeSloatDelete
            // 
            this.btnTimeSloatDelete.Location = new System.Drawing.Point(433, 217);
            this.btnTimeSloatDelete.Name = "btnTimeSloatDelete";
            this.btnTimeSloatDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSloatDelete.TabIndex = 56;
            this.btnTimeSloatDelete.Text = "Delete";
            this.btnTimeSloatDelete.UseVisualStyleBackColor = true;
            this.btnTimeSloatDelete.Click += new System.EventHandler(this.btnTimeSloatDelete_Click);
            // 
            // btnTimeSloatUpdate
            // 
            this.btnTimeSloatUpdate.Location = new System.Drawing.Point(328, 217);
            this.btnTimeSloatUpdate.Name = "btnTimeSloatUpdate";
            this.btnTimeSloatUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSloatUpdate.TabIndex = 55;
            this.btnTimeSloatUpdate.Text = "Update";
            this.btnTimeSloatUpdate.UseVisualStyleBackColor = true;
            this.btnTimeSloatUpdate.Click += new System.EventHandler(this.btnTimeSloatUpdate_Click);
            // 
            // btnTimeSloatAdd
            // 
            this.btnTimeSloatAdd.Location = new System.Drawing.Point(229, 217);
            this.btnTimeSloatAdd.Name = "btnTimeSloatAdd";
            this.btnTimeSloatAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSloatAdd.TabIndex = 54;
            this.btnTimeSloatAdd.Text = "Add";
            this.btnTimeSloatAdd.UseVisualStyleBackColor = true;
            this.btnTimeSloatAdd.Click += new System.EventHandler(this.btnTimeSloatAdd_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 23);
            this.label16.TabIndex = 45;
            this.label16.Text = "Working time per day";
            // 
            // timeSlotType
            // 
            this.timeSlotType.FormattingEnabled = true;
            this.timeSlotType.Items.AddRange(new object[] {
            "One hour time slots",
            "Thirty minute time slots"});
            this.timeSlotType.Location = new System.Drawing.Point(176, 89);
            this.timeSlotType.Name = "timeSlotType";
            this.timeSlotType.Size = new System.Drawing.Size(121, 21);
            this.timeSlotType.TabIndex = 5;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(174, 152);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(100, 20);
            this.startTime.TabIndex = 64;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(371, 149);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(100, 20);
            this.endTime.TabIndex = 65;
            // 
            // workingTime
            // 
            this.workingTime.Location = new System.Drawing.Point(176, 149);
            this.workingTime.Name = "workingTime";
            this.workingTime.Size = new System.Drawing.Size(100, 20);
            this.workingTime.TabIndex = 65;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 581);
            this.Controls.Add(this.panel1);
            this.Name = "TimeTable";
            this.Text = "TimeTable";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeekend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeekday)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNumberOfWorkingDays)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkingDays)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkingTime)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeSloat)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataNumberOfWorkingDays;
        private System.Windows.Forms.NumericUpDown numWeekend;
        private System.Windows.Forms.NumericUpDown numWeekday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDeleteNumOfWorkingDays;
        private System.Windows.Forms.Button btnUpdateNumOfWorkingDays;
        private System.Windows.Forms.Button btnAddNumOfWorkingDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkingDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataWorkingTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox txtDayWorkingTime;
        private System.Windows.Forms.TextBox txtNumberOfWorkingDaysId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox workingDaysId;
        private System.Windows.Forms.Button btnClearWorkingDays;
        private System.Windows.Forms.Button btnDeleteWorkingDays;
        private System.Windows.Forms.Button btnUpdateWorkingDays;
        private System.Windows.Forms.Button btnAddWorkingDays;
        private System.Windows.Forms.DataGridView dataWorkingDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearWorkingTime;
        private System.Windows.Forms.Button btnDeleteWorkingTime;
        private System.Windows.Forms.Button btnUpdateWorkingTime;
        private System.Windows.Forms.Button btnAddWorkingTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTimeSlotClear;
        private System.Windows.Forms.Button btnTimeSloatDelete;
        private System.Windows.Forms.Button btnTimeSloatUpdate;
        private System.Windows.Forms.Button btnTimeSloatAdd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox timeSlotType;
        private System.Windows.Forms.DataGridView dateTimeSloat;
        private System.Windows.Forms.TextBox WorkingTimeId;
        private System.Windows.Forms.TextBox TimeSloatId;
        private System.Windows.Forms.TextBox workingTime;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.TextBox startTime;
    }
}