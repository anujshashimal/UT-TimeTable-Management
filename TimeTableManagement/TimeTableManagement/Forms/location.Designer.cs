namespace TimeTableManagement.Forms
{
    partial class location
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
            this.buildingName = new System.Windows.Forms.TextBox();
            this.locationID = new System.Windows.Forms.TextBox();
            this.deleteB1 = new System.Windows.Forms.Button();
            this.updateB1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.locationdataGridView = new System.Windows.Forms.DataGridView();
            this.locBtn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomCapacity = new System.Windows.Forms.TextBox();
            this.roomCapacityT = new System.Windows.Forms.TextBox();
            this.roomNameT = new System.Windows.Forms.TextBox();
            this.roomIDT = new System.Windows.Forms.TextBox();
            this.buildingNameT = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomDatagridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationdataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 581);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buildingName);
            this.tabPage1.Controls.Add(this.locationID);
            this.tabPage1.Controls.Add(this.deleteB1);
            this.tabPage1.Controls.Add(this.updateB1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.locBtn2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buildingName
            // 
            this.buildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingName.Location = new System.Drawing.Point(167, 66);
            this.buildingName.Name = "buildingName";
            this.buildingName.Size = new System.Drawing.Size(301, 26);
            this.buildingName.TabIndex = 69;
            // 
            // locationID
            // 
            this.locationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationID.Location = new System.Drawing.Point(167, 22);
            this.locationID.Name = "locationID";
            this.locationID.Size = new System.Drawing.Size(301, 26);
            this.locationID.TabIndex = 68;
            this.locationID.TextChanged += new System.EventHandler(this.locationID_TextChanged);
            // 
            // deleteB1
            // 
            this.deleteB1.BackColor = System.Drawing.Color.Red;
            this.deleteB1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.deleteB1.Location = new System.Drawing.Point(501, 114);
            this.deleteB1.Name = "deleteB1";
            this.deleteB1.Size = new System.Drawing.Size(263, 41);
            this.deleteB1.TabIndex = 67;
            this.deleteB1.Text = "Delete";
            this.deleteB1.UseVisualStyleBackColor = false;
            this.deleteB1.Click += new System.EventHandler(this.deleteB1_Click);
            // 
            // updateB1
            // 
            this.updateB1.BackColor = System.Drawing.Color.OrangeRed;
            this.updateB1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.updateB1.Location = new System.Drawing.Point(501, 68);
            this.updateB1.Name = "updateB1";
            this.updateB1.Size = new System.Drawing.Size(263, 37);
            this.updateB1.TabIndex = 66;
            this.updateB1.Text = "Update";
            this.updateB1.UseVisualStyleBackColor = false;
            this.updateB1.Click += new System.EventHandler(this.updateB1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.locationdataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 364);
            this.panel2.TabIndex = 49;
            // 
            // locationdataGridView
            // 
            this.locationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationdataGridView.Location = new System.Drawing.Point(0, 0);
            this.locationdataGridView.Name = "locationdataGridView";
            this.locationdataGridView.Size = new System.Drawing.Size(895, 364);
            this.locationdataGridView.TabIndex = 0;
            this.locationdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locationdataGridView_CellContentClick);
            // 
            // locBtn2
            // 
            this.locBtn2.BackColor = System.Drawing.Color.OrangeRed;
            this.locBtn2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.locBtn2.Location = new System.Drawing.Point(501, 22);
            this.locBtn2.Name = "locBtn2";
            this.locBtn2.Size = new System.Drawing.Size(263, 39);
            this.locBtn2.TabIndex = 45;
            this.locBtn2.Text = "Add";
            this.locBtn2.UseVisualStyleBackColor = false;
            this.locBtn2.Click += new System.EventHandler(this.locBtn2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Building Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Location ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomCapacity);
            this.tabPage2.Controls.Add(this.roomCapacityT);
            this.tabPage2.Controls.Add(this.roomNameT);
            this.tabPage2.Controls.Add(this.roomIDT);
            this.tabPage2.Controls.Add(this.buildingNameT);
            this.tabPage2.Controls.Add(this.deleteB);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.addB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomCapacity
            // 
            this.roomCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacity.Location = new System.Drawing.Point(131, 126);
            this.roomCapacity.Name = "roomCapacity";
            this.roomCapacity.Size = new System.Drawing.Size(344, 26);
            this.roomCapacity.TabIndex = 73;
            // 
            // roomCapacityT
            // 
            this.roomCapacityT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityT.Location = new System.Drawing.Point(131, 165);
            this.roomCapacityT.Name = "roomCapacityT";
            this.roomCapacityT.Size = new System.Drawing.Size(344, 26);
            this.roomCapacityT.TabIndex = 72;
            // 
            // roomNameT
            // 
            this.roomNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameT.Location = new System.Drawing.Point(131, 88);
            this.roomNameT.Name = "roomNameT";
            this.roomNameT.Size = new System.Drawing.Size(344, 26);
            this.roomNameT.TabIndex = 74;
            // 
            // roomIDT
            // 
            this.roomIDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIDT.Location = new System.Drawing.Point(131, 52);
            this.roomIDT.Name = "roomIDT";
            this.roomIDT.Size = new System.Drawing.Size(344, 26);
            this.roomIDT.TabIndex = 71;
            // 
            // buildingNameT
            // 
            this.buildingNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameT.Location = new System.Drawing.Point(131, 14);
            this.buildingNameT.Name = "buildingNameT";
            this.buildingNameT.Size = new System.Drawing.Size(344, 26);
            this.buildingNameT.TabIndex = 70;
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.Red;
            this.deleteB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.deleteB.Location = new System.Drawing.Point(503, 117);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(232, 45);
            this.deleteB.TabIndex = 65;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(503, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 39);
            this.button1.TabIndex = 64;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.roomDatagridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 299);
            this.panel3.TabIndex = 63;
            // 
            // roomDatagridView
            // 
            this.roomDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDatagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDatagridView.Location = new System.Drawing.Point(0, 0);
            this.roomDatagridView.Name = "roomDatagridView";
            this.roomDatagridView.Size = new System.Drawing.Size(895, 299);
            this.roomDatagridView.TabIndex = 0;
            this.roomDatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDatagridView_DoubleClick);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "Room type";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "Room Capacity";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Room Name";
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.OrangeRed;
            this.addB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addB.Location = new System.Drawing.Point(503, 14);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(232, 39);
            this.addB.TabIndex = 54;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Room ID";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Building Name";
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 581);
            this.Controls.Add(this.panel1);
            this.Name = "location";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "location";
            this.Load += new System.EventHandler(this.location_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locationdataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDatagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button locBtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView locationdataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView roomDatagridView;
        private System.Windows.Forms.Button deleteB1;
        private System.Windows.Forms.Button updateB1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox locationID;
        private System.Windows.Forms.TextBox buildingName;
        private System.Windows.Forms.TextBox roomCapacity;
        private System.Windows.Forms.TextBox roomCapacityT;
        private System.Windows.Forms.TextBox roomNameT;
        private System.Windows.Forms.TextBox roomIDT;
        private System.Windows.Forms.TextBox buildingNameT;
    }
}