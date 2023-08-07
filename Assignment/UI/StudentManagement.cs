using Assignment.Core.Models;
using Assignment.Core.Repository;
using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Net.Mail;

namespace Assignment.UI
{
    public partial class StudentManagement : Form
    {
        private IStudentRepo StudentService;
        private IUserRepo UserService;
        public StudentManagement(IUserRepo user, IStudentRepo student)
        {
            InitializeComponent();
            UserService = user;
            StudentService = student;
        }

        #region Events

        /// <summary>
        /// Sự kiện Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearField();
            pBoxHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            dataViewStudent.ReadOnly = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnImage Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filePath = open.FileName;
                    Image image = Image.FromFile(filePath);
                    pBoxHinh.Image = image;
                }
            }
        }

        /// <summary>
        /// Sự kiện btnRemove Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            pBoxHinh.Image = null;
        }

        /// <summary>
        /// Sự kiện btnNew Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearField();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnSkip.Enabled = true;
        }

        /// <summary>
        /// Sự kiên btnSave Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Mã sinh viên đang rỗng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmail.Text != string.Empty)
            {
                bool email = CheckMailValid(txtEmail.Text);
                if (!email)
                {
                    MessageBox.Show("Mail không hợp lệ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                txtEmail.Text = string.Empty;
            }
            bool gender;
            if (rBtnMale.Checked)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            Image image = pBoxHinh.Image;
            byte[]? bytes;
            if (image != null)
            {
                bytes = ImageToByteArray(image);
            }
            else
            {
                bytes = null;
            }
            var student = new Student
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
                SoDT = txtSoDT.Text,
                GioiTinh = gender,
                DiaChi = rTXTDiaChi.Text,
                Hinh = bytes,
            };
            bool result = StudentService.AddStudent(student);
            ShowStatus(result, "ADD");
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnSkip Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkip_Click(object sender, EventArgs e)
        {
            ClearField();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnUpdate Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                bool email = CheckMailValid(txtEmail.Text);
                if (!email)
                {
                    MessageBox.Show("Mail không hợp lệ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                txtEmail.Text = string.Empty;
            }
            bool gender;
            if (rBtnMale.Checked)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            var image = pBoxHinh.Image;
            byte[]? bytes;
            if (image == null)
            {
                bytes = null;
            }
            else
            {
                bytes = ImageToByteArray(image);
            }
            var student = new Student
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
                SoDT = txtSoDT.Text,
                GioiTinh = gender,
                DiaChi = rTXTDiaChi.Text,
                Hinh = bytes,
            };
            bool result = StudentService.UpdateStudent(student);
            ShowStatus(result, "UPDATE");
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnDelete Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = StudentService.DeleteStudent(txtMaSV.Text);
            ShowStatus(result, "DELETE");
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Sự kiện data view selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dataViewStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataViewStudent.SelectedRows[0];
                if (row.Cells[0].Value.ToString() != string.Empty)
                {
                    txtMaSV.ReadOnly = true;
                    txtMaSV.Text = row.Cells[0].Value.ToString();
                    txtHoTen.Text = row.Cells[1].Value.ToString();
                    txtEmail.Text = row.Cells[2].Value.ToString();
                    txtSoDT.Text = row.Cells[3].Value.ToString();
                    if ((bool)row.Cells[4].Value == true)
                    {
                        rBtnMale.Checked = true;
                    }
                    else
                    {
                        rBtnFemale.Checked = true;
                    }
                    rTXTDiaChi.Text = row.Cells[5].Value.ToString();
                    if (row.Cells[6].Value.ToString() == string.Empty)
                    {
                        pBoxHinh.Image = null;
                    }
                    else
                    {
                        pBoxHinh.Image = ByteArrayToImage((byte[]?)row.Cells[6].Value);
                    }
                    btnNew.Enabled = false;
                    btnSave.Enabled = false;
                    btnSkip.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtMaSV.ReadOnly = false;
                    txtMaSV.Text = string.Empty;
                    txtHoTen.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtSoDT.Text = string.Empty;
                    rBtnMale.Checked = false;
                    rBtnFemale.Checked = false;
                    rTXTDiaChi.Text = string.Empty;
                    pBoxHinh.Image = null;
                    btnNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnSkip.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }

        }

        /// <summary>
        /// Sự kiện text box txtSoDt Key Press(Validate)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Sự kiện picture box pBoxHinh Paint(tạo khung viền cho picture box)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxHinh_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pBoxHinh.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        /// <summary>
        /// Sự kiện btnLogOut Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất tài khoản? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Sự kiện Form Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new Login(UserService, StudentService);
            form.Show();
        }

        /// <summary>
        /// Sự kiện button button btnHide Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// Sự kiện button btnExit Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Phương thức Image To Byte Array (chuyển đổi hình ảnh sang mảng byte)
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Phương thức Byte Array To Image (chuyển đổi mảng byte sang Image)
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private Image ByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        /// <summary>
        /// Phương thức Load Data (đổ data vào data view)
        /// </summary>
        private void LoadData()
        {
            dataViewStudent.DataSource = StudentService.GetAllStudent();
        }

        /// <summary>
        /// Phương thức Clear Field làm mới các control đưa về trạng thái mặc định
        /// </summary>
        private void ClearField()
        {
            txtMaSV.ReadOnly = false;
            txtMaSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSoDT.Text = string.Empty;
            rBtnMale.Checked = false;
            rBtnFemale.Checked = false;
            rTXTDiaChi.Text = string.Empty;
            pBoxHinh.Image = null;
            dataViewStudent.ClearSelection();
        }

        /// <summary>
        /// Phương thức Check Mail Valid (Kiểm tra mail hợp lệ)
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        private bool CheckMailValid(string Email)
        {
            try
            {
                MailAddress mail = new MailAddress(Email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Phương thức Show Status (Thông báo trạng thái cho người dùng)
        /// </summary>
        /// <param name="result"></param>
        /// <param name="action"></param>
        private void ShowStatus(bool result, string action)
        {
            if (result)
            {
                if (action.ToUpper() == "ADD")
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (action.ToUpper() == "ADD")
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ClearField();
            LoadData();
        }
        #endregion



    }
}
