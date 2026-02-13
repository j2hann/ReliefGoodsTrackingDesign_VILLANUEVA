using System.Drawing;
using System.Windows.Forms;

namespace ReliefGoodsTrackingDesign_VILLANUEVA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtOfficer = new TextBox();
            lblCenterName = new Label();
            txtLocation = new TextBox();
            lblLocation = new Label();
            txtCenterName = new TextBox();
            lblOfficer = new Label();
            groupBox2 = new GroupBox();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            txtItemName = new TextBox();
            lblItemName = new Label();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            lblDate = new Label();
            dtpReceived = new DateTimePicker();
            groupBox3 = new GroupBox();
            this.lblBarangay = new Label();
            this.lblStatus = new Label();
            txtBarangay = new TextBox();
            label3 = new Label();
            cboStatus = new ComboBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            colCenterName = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colOfficer = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colDateReceived = new DataGridViewTextBoxColumn();
            colBarangay = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOfficer);
            groupBox1.Controls.Add(lblCenterName);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(lblLocation);
            groupBox1.Controls.Add(txtCenterName);
            groupBox1.Controls.Add(lblOfficer);
            groupBox1.Location = new Point(26, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Relief Center Information";
            // 
            // txtOfficer
            // 
            txtOfficer.Location = new Point(255, 123);
            txtOfficer.Name = "txtOfficer";
            txtOfficer.Size = new Size(151, 30);
            txtOfficer.TabIndex = 6;
            // 
            // lblCenterName
            // 
            lblCenterName.AutoSize = true;
            lblCenterName.Location = new Point(29, 43);
            lblCenterName.Name = "lblCenterName";
            lblCenterName.Size = new Size(158, 23);
            lblCenterName.TabIndex = 1;
            lblCenterName.Text = "Relief Center Name";
            lblCenterName.Click += lblCenterName_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(255, 81);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(151, 30);
            txtLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(31, 84);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(75, 23);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "Location";
            // 
            // txtCenterName
            // 
            txtCenterName.Location = new Point(255, 40);
            txtCenterName.Name = "txtCenterName";
            txtCenterName.Size = new Size(151, 30);
            txtCenterName.TabIndex = 4;
            // 
            // lblOfficer
            // 
            lblOfficer.AutoSize = true;
            lblOfficer.Location = new Point(30, 126);
            lblOfficer.Name = "lblOfficer";
            lblOfficer.Size = new Size(143, 23);
            lblOfficer.TabIndex = 3;
            lblOfficer.Text = "Officer-in-Charge";
            lblOfficer.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpReceived);
            groupBox2.Controls.Add(lblDate);
            groupBox2.Controls.Add(nudQuantity);
            groupBox2.Controls.Add(cboCategory);
            groupBox2.Controls.Add(lblCategory);
            groupBox2.Controls.Add(txtItemName);
            groupBox2.Controls.Add(lblItemName);
            groupBox2.Controls.Add(lblQuantity);
            groupBox2.Location = new Point(26, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 218);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Goods Inventory Entry";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Food Packs", "Drinking Water", "Medical Supplies", "Clothing", "Hygiene Kits" });
            cboCategory.Location = new Point(229, 39);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(190, 31);
            cboCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(29, 47);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(119, 23);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Item Category";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(229, 82);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(190, 30);
            txtItemName.TabIndex = 5;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(29, 89);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(96, 23);
            lblItemName.TabIndex = 2;
            lblItemName.Text = "Item Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(30, 130);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(76, 23);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(229, 123);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(190, 30);
            nudQuantity.TabIndex = 8;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 174);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(118, 23);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date Received";
            lblDate.Click += label4_Click;
            // 
            // dtpReceived
            // 
            dtpReceived.Location = new Point(229, 168);
            dtpReceived.Name = "dtpReceived";
            dtpReceived.Size = new Size(190, 30);
            dtpReceived.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboStatus);
            groupBox3.Controls.Add(this.lblBarangay);
            groupBox3.Controls.Add(this.lblStatus);
            groupBox3.Controls.Add(txtBarangay);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(26, 448);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(447, 142);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Distribution Status";
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.Location = new Point(29, 46);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new Size(173, 23);
            this.lblBarangay.TabIndex = 1;
            this.lblBarangay.Text = "Destination Barangay";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(29, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(150, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Distribution Status";
            // 
            // txtBarangay
            // 
            txtBarangay.Location = new Point(255, 43);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(151, 30);
            txtBarangay.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 177);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 3;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "In Storage", "Ready for Distribution", "Distributed" });
            cboStatus.Location = new Point(255, 85);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 31);
            cboStatus.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCenterName, colLocation, colOfficer, colCategory, colItemName, colQuantity, colDateReceived, colBarangay, colStatus });
            dataGridView1.Location = new Point(529, 33);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(820, 557);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(529, 609);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(748, 609);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update Record";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(961, 609);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1174, 609);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(175, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // colCenterName
            // 
            colCenterName.HeaderText = "Center Name";
            colCenterName.MinimumWidth = 6;
            colCenterName.Name = "colCenterName";
            colCenterName.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colOfficer
            // 
            colOfficer.HeaderText = "Officer-in-Charge";
            colOfficer.MinimumWidth = 6;
            colOfficer.Name = "colOfficer";
            colOfficer.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Item Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colItemName
            // 
            colItemName.HeaderText = "Item Name";
            colItemName.MinimumWidth = 6;
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colDateReceived
            // 
            colDateReceived.HeaderText = "Date Received";
            colDateReceived.MinimumWidth = 6;
            colDateReceived.Name = "colDateReceived";
            colDateReceived.ReadOnly = true;
            // 
            // colBarangay
            // 
            colBarangay.HeaderText = "Destination Barangay";
            colBarangay.MinimumWidth = 6;
            colBarangay.Name = "colBarangay";
            colBarangay.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Distribution Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 658);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Disaster Relief Goods Tracking System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblCenterName;
        private Label lblLocation;
        private Label lblOfficer;
        private TextBox txtOfficer;
        private TextBox txtLocation;
        private TextBox txtCenterName;
        private GroupBox groupBox2;
        private ComboBox cboCategory;
        private Label lblCategory;
        private TextBox txtItemName;
        private Label lblItemName;
        private Label lblQuantity;
        private Label lblDate;
        private NumericUpDown nudQuantity;
        private DateTimePicker dtpReceived;
        private GroupBox groupBox3;

        private Label lblBarangay;
        private Label lblStatus;

        private TextBox txtBarangay;
        private Label label3;
        private ComboBox cboStatus;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnExit;
        private DataGridViewTextBoxColumn colCenterName;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colOfficer;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colDateReceived;
        private DataGridViewTextBoxColumn colBarangay;
        private DataGridViewTextBoxColumn colStatus;
    }

}
