namespace Assignment.UI
{
    partial class MarkManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkManagement));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtFindMaSV = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            labelDiemTB = new Label();
            txtTinHoc = new TextBox();
            txtGDTC = new TextBox();
            txtTiengAnh = new TextBox();
            txtMaSV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            labelName = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel2 = new Panel();
            dataViewMark = new DataGridView();
            btnLogOut = new Button();
            labelId = new Label();
            btnNew = new Button();
            label8 = new Label();
            btnSkip = new Button();
            panel3 = new Panel();
            btnHide = new Button();
            btnExit = new Button();
            pBoxIcon = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataViewMark).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(135, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản lý điểm sinh viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtFindMaSV);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(39, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(438, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 50);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFindMaSV
            // 
            txtFindMaSV.Location = new Point(122, 49);
            txtFindMaSV.Name = "txtFindMaSV";
            txtFindMaSV.Size = new Size(262, 27);
            txtFindMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã SV:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtTinHoc);
            panel1.Controls.Add(txtGDTC);
            panel1.Controls.Add(txtTiengAnh);
            panel1.Controls.Add(txtMaSV);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(39, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 315);
            panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelDiemTB);
            groupBox2.Location = new Point(322, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(106, 125);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điểm TB:";
            // 
            // labelDiemTB
            // 
            labelDiemTB.AutoSize = true;
            labelDiemTB.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiemTB.ForeColor = Color.Blue;
            labelDiemTB.Location = new Point(21, 48);
            labelDiemTB.Name = "labelDiemTB";
            labelDiemTB.Size = new Size(0, 40);
            labelDiemTB.TabIndex = 0;
            // 
            // txtTinHoc
            // 
            txtTinHoc.Location = new Point(136, 183);
            txtTinHoc.Name = "txtTinHoc";
            txtTinHoc.Size = new Size(169, 27);
            txtTinHoc.TabIndex = 9;
            txtTinHoc.KeyPress += txtTinHoc_KeyPress;
            // 
            // txtGDTC
            // 
            txtGDTC.Location = new Point(136, 233);
            txtGDTC.Name = "txtGDTC";
            txtGDTC.Size = new Size(169, 27);
            txtGDTC.TabIndex = 8;
            txtGDTC.KeyPress += txtGDTC_KeyPress;
            // 
            // txtTiengAnh
            // 
            txtTiengAnh.Location = new Point(136, 133);
            txtTiengAnh.Name = "txtTiengAnh";
            txtTiengAnh.Size = new Size(169, 27);
            txtTiengAnh.TabIndex = 7;
            txtTiengAnh.KeyPress += txtTiengAnh_KeyPress;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(136, 83);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(169, 27);
            txtMaSV.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 240);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 5;
            label7.Text = "Giáo Dục TC:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 190);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 4;
            label6.Text = "Tin Học:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 140);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 3;
            label5.Text = "Tiếng Anh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 90);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã SV:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = Color.Blue;
            labelName.Location = new Point(136, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 40);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 0;
            label3.Text = "Họ Tên SV:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(501, 443);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 43);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 345);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 43);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(501, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 43);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataViewMark);
            panel2.Location = new Point(39, 635);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 142);
            panel2.TabIndex = 7;
            // 
            // dataViewMark
            // 
            dataViewMark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataViewMark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataViewMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataViewMark.DefaultCellStyle = dataGridViewCellStyle2;
            dataViewMark.Dock = DockStyle.Fill;
            dataViewMark.Location = new Point(0, 0);
            dataViewMark.MultiSelect = false;
            dataViewMark.Name = "dataViewMark";
            dataViewMark.RowHeadersWidth = 51;
            dataViewMark.RowTemplate.Height = 29;
            dataViewMark.Size = new Size(584, 142);
            dataViewMark.TabIndex = 0;
            dataViewMark.SelectionChanged += dataViewMark_SelectionChanged;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(501, 556);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(122, 43);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(42, 46);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 20);
            labelId.TabIndex = 9;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(501, 296);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(122, 43);
            btnNew.TabIndex = 10;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(39, 612);
            label8.Name = "label8";
            label8.Size = new Size(200, 20);
            label8.TabIndex = 11;
            label8.Text = "3 sinh viên có điểm cao nhất:";
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(501, 492);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(122, 43);
            btnSkip.TabIndex = 12;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(btnHide);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(pBoxIcon);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(657, 66);
            panel3.TabIndex = 27;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.Right;
            btnHide.BackColor = Color.LightCyan;
            btnHide.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnHide.Location = new Point(555, 11);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(48, 40);
            btnHide.TabIndex = 2;
            btnHide.Text = "-";
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.LightCyan;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(609, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 40);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pBoxIcon
            // 
            pBoxIcon.BackColor = Color.LightCyan;
            pBoxIcon.Dock = DockStyle.Left;
            pBoxIcon.Image = Properties.Resources.fpt_university_logo;
            pBoxIcon.Location = new Point(0, 0);
            pBoxIcon.Name = "pBoxIcon";
            pBoxIcon.Size = new Size(136, 66);
            pBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxIcon.TabIndex = 0;
            pBoxIcon.TabStop = false;
            // 
            // MarkManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 819);
            Controls.Add(panel3);
            Controls.Add(btnSkip);
            Controls.Add(label8);
            Controls.Add(btnNew);
            Controls.Add(labelId);
            Controls.Add(btnLogOut);
            Controls.Add(panel2);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MarkManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mark Management";
            FormClosed += MarkManagement_FormClosed;
            Load += MarkManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataViewMark).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtFindMaSV;
        private Label label2;
        private Button btnSearch;
        private Panel panel1;
        private Label label3;
        private TextBox txtMaSV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label labelName;
        private TextBox txtTinHoc;
        private TextBox txtGDTC;
        private TextBox txtTiengAnh;
        private GroupBox groupBox2;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel2;
        private Label labelDiemTB;
        private DataGridView dataViewMark;
        private Button btnLogOut;
        private Label labelId;
        private Button btnNew;
        private Label label8;
        private Button btnSkip;
        private Panel panel3;
        private Button btnHide;
        private Button btnExit;
        private PictureBox pBoxIcon;
    }
}