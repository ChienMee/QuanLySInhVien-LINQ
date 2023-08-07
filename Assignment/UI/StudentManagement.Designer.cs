namespace Assignment.UI
{
    partial class StudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagement));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSoDT = new TextBox();
            pBoxHinh = new PictureBox();
            rBtnMale = new RadioButton();
            rBtnFemale = new RadioButton();
            rTXTDiaChi = new RichTextBox();
            btnImage = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            dataViewStudent = new DataGridView();
            btnLogOut = new Button();
            btnRemove = new Button();
            btnSkip = new Button();
            btnNew = new Button();
            panel2 = new Panel();
            btnHide = new Button();
            btnExit = new Button();
            pBoxIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxHinh).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataViewStudent).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(223, 68);
            label1.Name = "label1";
            label1.Size = new Size(309, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 136);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã SV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 176);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 216);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 256);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Số ĐT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 298);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 5;
            label6.Text = "Giới Tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 338);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(170, 133);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(252, 27);
            txtMaSV.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(170, 173);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(252, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(170, 253);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(252, 27);
            txtSoDT.TabIndex = 10;
            txtSoDT.KeyPress += txtSoDT_KeyPress;
            // 
            // pBoxHinh
            // 
            pBoxHinh.Location = new Point(497, 120);
            pBoxHinh.Name = "pBoxHinh";
            pBoxHinh.Size = new Size(128, 160);
            pBoxHinh.TabIndex = 13;
            pBoxHinh.TabStop = false;
            pBoxHinh.Paint += pBoxHinh_Paint;
            // 
            // rBtnMale
            // 
            rBtnMale.AutoSize = true;
            rBtnMale.Location = new Point(170, 296);
            rBtnMale.Name = "rBtnMale";
            rBtnMale.Size = new Size(62, 24);
            rBtnMale.TabIndex = 14;
            rBtnMale.TabStop = true;
            rBtnMale.Text = "Nam";
            rBtnMale.UseVisualStyleBackColor = true;
            // 
            // rBtnFemale
            // 
            rBtnFemale.AutoSize = true;
            rBtnFemale.Location = new Point(249, 296);
            rBtnFemale.Name = "rBtnFemale";
            rBtnFemale.Size = new Size(50, 24);
            rBtnFemale.TabIndex = 15;
            rBtnFemale.TabStop = true;
            rBtnFemale.Text = "Nữ";
            rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rTXTDiaChi
            // 
            rTXTDiaChi.Location = new Point(170, 338);
            rTXTDiaChi.Name = "rTXTDiaChi";
            rTXTDiaChi.Size = new Size(252, 135);
            rTXTDiaChi.TabIndex = 16;
            rTXTDiaChi.Text = "";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(464, 286);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(93, 32);
            btnImage.TabIndex = 17;
            btnImage.Text = "Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(451, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 39);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 39);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(563, 338);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 39);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataViewStudent);
            panel1.Location = new Point(10, 506);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 253);
            panel1.TabIndex = 21;
            // 
            // dataViewStudent
            // 
            dataViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewStudent.Dock = DockStyle.Fill;
            dataViewStudent.Location = new Point(0, 0);
            dataViewStudent.MultiSelect = false;
            dataViewStudent.Name = "dataViewStudent";
            dataViewStudent.ReadOnly = true;
            dataViewStudent.RowHeadersWidth = 51;
            dataViewStudent.RowTemplate.Height = 29;
            dataViewStudent.Size = new Size(776, 253);
            dataViewStudent.TabIndex = 0;
            dataViewStudent.SelectionChanged += dataViewStudent_SelectionChanged;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(563, 428);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(106, 39);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(563, 286);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(93, 32);
            btnRemove.TabIndex = 23;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(451, 428);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(106, 39);
            btnSkip.TabIndex = 24;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(451, 338);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(106, 39);
            btnNew.TabIndex = 25;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btnHide);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(pBoxIcon);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 59);
            panel2.TabIndex = 26;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.LightCyan;
            btnHide.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnHide.Location = new Point(689, 12);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(48, 40);
            btnHide.TabIndex = 2;
            btnHide.Text = "-";
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCyan;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(743, 12);
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
            pBoxIcon.Size = new Size(136, 59);
            pBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxIcon.TabIndex = 0;
            pBoxIcon.TabStop = false;
            // 
            // StudentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 798);
            Controls.Add(panel2);
            Controls.Add(btnNew);
            Controls.Add(btnSkip);
            Controls.Add(btnRemove);
            Controls.Add(btnLogOut);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnImage);
            Controls.Add(rTXTDiaChi);
            Controls.Add(rBtnFemale);
            Controls.Add(rBtnMale);
            Controls.Add(pBoxHinh);
            Controls.Add(txtSoDT);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            FormClosed += StudentManagement_FormClosed;
            Load += StudentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxHinh).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataViewStudent).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtSoDT;
        private PictureBox pBoxHinh;
        private RadioButton rBtnMale;
        private RadioButton rBtnFemale;
        private RichTextBox rTXTDiaChi;
        private Button btnImage;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel1;
        private DataGridView dataViewStudent;
        private Button btnLogOut;
        private Button btnRemove;
        private Button btnSkip;
        private Button btnNew;
        private Panel panel2;
        private Button btnHide;
        private Button btnExit;
        private PictureBox pBoxIcon;
    }
}