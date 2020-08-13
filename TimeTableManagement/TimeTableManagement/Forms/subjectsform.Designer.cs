namespace TimeTableManagement.Forms
{
    partial class subjectsform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.offyear = new System.Windows.Forms.ComboBox();
            this.offSem = new System.Windows.Forms.ComboBox();
            this.subName = new System.Windows.Forms.TextBox();
            this.subCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lecHrs = new System.Windows.Forms.ComboBox();
            this.labHrs = new System.Windows.Forms.ComboBox();
            this.tuteHrs = new System.Windows.Forms.ComboBox();
            this.evalHrs = new System.Windows.Forms.ComboBox();
            this.subAdd = new System.Windows.Forms.Button();
            this.subEdit = new System.Windows.Forms.Button();
            this.subDel = new System.Windows.Forms.Button();
            this.subClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subTbl = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.subClear);
            this.panel1.Controls.Add(this.subDel);
            this.panel1.Controls.Add(this.subEdit);
            this.panel1.Controls.Add(this.subAdd);
            this.panel1.Controls.Add(this.evalHrs);
            this.panel1.Controls.Add(this.tuteHrs);
            this.panel1.Controls.Add(this.labHrs);
            this.panel1.Controls.Add(this.lecHrs);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.subCode);
            this.panel1.Controls.Add(this.subName);
            this.panel1.Controls.Add(this.offSem);
            this.panel1.Controls.Add(this.offyear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 441);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offered Year\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Offered Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject Code";
            // 
            // offyear
            // 
            this.offyear.FormattingEnabled = true;
            this.offyear.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.offyear.Location = new System.Drawing.Point(154, 9);
            this.offyear.Name = "offyear";
            this.offyear.Size = new System.Drawing.Size(357, 21);
            this.offyear.TabIndex = 5;
            // 
            // offSem
            // 
            this.offSem.FormattingEnabled = true;
            this.offSem.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.offSem.Location = new System.Drawing.Point(154, 46);
            this.offSem.Name = "offSem";
            this.offSem.Size = new System.Drawing.Size(357, 21);
            this.offSem.TabIndex = 6;
            // 
            // subName
            // 
            this.subName.Location = new System.Drawing.Point(154, 86);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(357, 20);
            this.subName.TabIndex = 7;
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(154, 125);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(357, 20);
            this.subCode.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "# of Lec Hrs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(288, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "# of Tute Hrs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(3, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "# of Lab Hrs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(288, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "# of Eval Hrs";
            // 
            // lecHrs
            // 
            this.lecHrs.FormattingEnabled = true;
            this.lecHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lecHrs.Location = new System.Drawing.Point(154, 166);
            this.lecHrs.Name = "lecHrs";
            this.lecHrs.Size = new System.Drawing.Size(116, 21);
            this.lecHrs.TabIndex = 13;
            // 
            // labHrs
            // 
            this.labHrs.FormattingEnabled = true;
            this.labHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.labHrs.Location = new System.Drawing.Point(154, 201);
            this.labHrs.Name = "labHrs";
            this.labHrs.Size = new System.Drawing.Size(116, 21);
            this.labHrs.TabIndex = 14;
            // 
            // tuteHrs
            // 
            this.tuteHrs.FormattingEnabled = true;
            this.tuteHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tuteHrs.Location = new System.Drawing.Point(395, 166);
            this.tuteHrs.Name = "tuteHrs";
            this.tuteHrs.Size = new System.Drawing.Size(116, 21);
            this.tuteHrs.TabIndex = 15;
            // 
            // evalHrs
            // 
            this.evalHrs.FormattingEnabled = true;
            this.evalHrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.evalHrs.Location = new System.Drawing.Point(395, 201);
            this.evalHrs.Name = "evalHrs";
            this.evalHrs.Size = new System.Drawing.Size(116, 21);
            this.evalHrs.TabIndex = 16;
            // 
            // subAdd
            // 
            this.subAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subAdd.Location = new System.Drawing.Point(556, 17);
            this.subAdd.Name = "subAdd";
            this.subAdd.Size = new System.Drawing.Size(164, 38);
            this.subAdd.TabIndex = 17;
            this.subAdd.Text = "Add";
            this.subAdd.UseVisualStyleBackColor = false;
            this.subAdd.Click += new System.EventHandler(this.subAdd_Click);
            // 
            // subEdit
            // 
            this.subEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subEdit.Location = new System.Drawing.Point(556, 66);
            this.subEdit.Name = "subEdit";
            this.subEdit.Size = new System.Drawing.Size(164, 38);
            this.subEdit.TabIndex = 18;
            this.subEdit.Text = "Edit";
            this.subEdit.UseVisualStyleBackColor = false;
            this.subEdit.Click += new System.EventHandler(this.subEdit_Click);
            // 
            // subDel
            // 
            this.subDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDel.Location = new System.Drawing.Point(556, 114);
            this.subDel.Name = "subDel";
            this.subDel.Size = new System.Drawing.Size(164, 38);
            this.subDel.TabIndex = 19;
            this.subDel.Text = "Delete";
            this.subDel.UseVisualStyleBackColor = false;
            this.subDel.Click += new System.EventHandler(this.subDel_Click);
            // 
            // subClear
            // 
            this.subClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subClear.Location = new System.Drawing.Point(556, 166);
            this.subClear.Name = "subClear";
            this.subClear.Size = new System.Drawing.Size(164, 38);
            this.subClear.TabIndex = 20;
            this.subClear.Text = "Clear";
            this.subClear.UseVisualStyleBackColor = false;
            this.subClear.Click += new System.EventHandler(this.subClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subTbl);
            this.panel2.Location = new System.Drawing.Point(3, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 198);
            this.panel2.TabIndex = 21;
            // 
            // subTbl
            // 
            this.subTbl.AllowUserToAddRows = false;
            this.subTbl.AllowUserToDeleteRows = false;
            this.subTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subTbl.Location = new System.Drawing.Point(4, 3);
            this.subTbl.Name = "subTbl";
            this.subTbl.ReadOnly = true;
            this.subTbl.Size = new System.Drawing.Size(733, 192);
            this.subTbl.TabIndex = 0;
            this.subTbl.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subTbl_CellContentDoubleClick);
            // 
            // subjectsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "subjectsform";
            this.Text = "subjectsform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView subTbl;
        private System.Windows.Forms.Button subClear;
        private System.Windows.Forms.Button subDel;
        private System.Windows.Forms.Button subEdit;
        private System.Windows.Forms.Button subAdd;
        private System.Windows.Forms.ComboBox evalHrs;
        private System.Windows.Forms.ComboBox tuteHrs;
        private System.Windows.Forms.ComboBox labHrs;
        private System.Windows.Forms.ComboBox lecHrs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subCode;
        private System.Windows.Forms.TextBox subName;
        private System.Windows.Forms.ComboBox offSem;
        private System.Windows.Forms.ComboBox offyear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}