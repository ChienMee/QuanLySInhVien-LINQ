using Assignment.Core.Models;
using Assignment.Core.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.UI
{
    public partial class MarkManagement : Form
    {
        private IUserRepo UserService;
        private IStudentRepo StudentService;
        public MarkManagement(IUserRepo userService, IStudentRepo studentService)
        {
            InitializeComponent();
            UserService = userService;
            StudentService = studentService;
        }

        #region Events

        /// <summary>
        /// Sự kiện Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkManagement_Load(object sender, EventArgs e)
        {
            dataViewMark.DataSource = StudentService.GetTop3Grade(StudentService.GetAllGrade());
            dataViewMark.ReadOnly = true;
            dataViewMark.Columns["Id"].Visible = false;
            dataViewMark.Columns["Điểm TB"].DefaultCellStyle.Format = "F2";
            labelId.Visible = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnSearch Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFindMaSV.Text == string.Empty)
            {
                MessageBox.Show("Hãy điền mã sinh viên cần tìm", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var student = StudentService.GetStudentById(txtFindMaSV.Text);
            if (student == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var grade = StudentService.GetGradeByStudentId(txtFindMaSV.Text);
                if (grade != null)
                {
                    labelId.Text = grade.Field<int>("Id").ToString();
                    labelName.Text = grade.Field<string>("Họ Tên");
                    txtMaSV.Text = txtFindMaSV.Text;
                    txtMaSV.ReadOnly = true;
                    txtTiengAnh.Text = grade.Field<float>("Tiếng Anh").ToString();
                    txtTinHoc.Text = grade.Field<float>("Tin học").ToString();
                    txtGDTC.Text = grade.Field<float>("GDTC").ToString();
                    float number = grade.Field<float>("Điểm TB");
                    float roundNumber = (float)Math.Round(number, 1);
                    labelDiemTB.Text = roundNumber.ToString();
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnSkip.Enabled = false;
                }
                else
                {
                    labelName.Text = student.HoTen.ToString();
                    txtMaSV.Text = txtFindMaSV.Text;
                    txtMaSV.ReadOnly = true;
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnSkip.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Sự kiện btnNew Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearField();
            txtMaSV.ReadOnly = false;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnSkip.Enabled = true;
        }

        /// <summary>
        /// Sự kiện btnUpdate Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (labelId.Text == string.Empty)
            {
                MessageBox.Show("Hãy chọn sinh viên cần chỉnh sửa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (double.Parse(txtTiengAnh.Text) < 0 || double.Parse(txtTiengAnh.Text) > 10)
            {
                MessageBox.Show("Điểm Tiếng Anh không hợp lệ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (double.Parse(txtTinHoc.Text) < 0 || double.Parse(txtTinHoc.Text) > 10)
            {
                MessageBox.Show("Điểm Tin Học không hợp lệ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (double.Parse(txtTinHoc.Text) < 0 || double.Parse(txtTinHoc.Text) > 10)
            {
                MessageBox.Show("Điểm GDTC không hợp lệ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var grade = new Grade
            {
                Id = int.Parse(labelId.Text),
                TiengAnh = float.Parse(txtTiengAnh.Text),
                TinHoc = float.Parse(txtTinHoc.Text),
                GDTC = float.Parse(txtGDTC.Text),
            };
            bool result = StudentService.UpdateGrade(grade);
            ShowStatus(result, "UPDATE");
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnDelete Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labelId.Text == string.Empty)
            {
                MessageBox.Show("Hãy chọn điểm cần xóa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool result = StudentService.DeleteGrade(int.Parse(labelId.Text));
            ShowStatus(result, "DELETE");
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
        }

        /// <summary>
        /// Sự kiện btnSave Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Mã sinh viên đang rỗng", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var eStudent = StudentService.GetStudentById(txtMaSV.Text);
            if (eStudent == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var grade = new Grade
            {
                MaSV = txtMaSV.Text,
                TiengAnh = float.Parse(txtTiengAnh.Text),
                TinHoc = float.Parse(txtTinHoc.Text),
                GDTC = float.Parse(txtGDTC.Text),
            };
            bool result = StudentService.AddGrade(grade);
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
        /// Sự kiện data view selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataViewMark_SelectionChanged(object sender, EventArgs e)
        {

            if (dataViewMark.SelectedRows.Count > 0)
            {
                var row = dataViewMark.SelectedRows[0];
                if (row.Cells[0].Value.ToString() != string.Empty)
                {
                    labelName.Text = row.Cells[1].Value.ToString();
                    txtMaSV.Text = row.Cells[0].Value.ToString();
                    txtTiengAnh.Text = row.Cells[2].Value.ToString();
                    txtTinHoc.Text = row.Cells[3].Value.ToString();
                    txtGDTC.Text = row.Cells[4].Value.ToString();
                    labelDiemTB.Text = row.Cells[5].Value.ToString();
                    if (row.Cells["id"].Value.ToString() != string.Empty)
                    {
                        int id = (int)row.Cells["id"].Value;
                        labelId.Text = id.ToString();
                    }
                    else
                    {
                        labelId.Text = string.Empty;
                    }
                    if (labelId.Text != string.Empty)
                    {
                        txtMaSV.ReadOnly = true;
                    }
                    else
                    {
                        txtMaSV.ReadOnly = false;
                    }
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnSkip.Enabled = false;
                }
                else
                {
                    btnNew.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnSkip.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Sự kiện btnLogOut Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Sự kiện text box txtTiengAnh Key Press (Validate)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTiengAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Sự kiện text box txtTinHoc Key Press (Validate)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTinHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Sự kiện txtGDTC Key Press (Validate)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGDTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Sự kiện Form Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new Login(UserService, StudentService);
            form.Show();
        }

        /// <summary>
        /// Sự kiện button btnHide Click
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
        private void ClearField()
        {
            txtFindMaSV.Text = string.Empty;
            labelId.Text = string.Empty;
            labelName.Text = string.Empty;
            txtMaSV.Text = string.Empty;
            txtTiengAnh.Text = string.Empty;
            txtTinHoc.Text = string.Empty;
            txtGDTC.Text = string.Empty;
            labelDiemTB.Text = string.Empty;
            txtMaSV.ReadOnly = false;
            dataViewMark.ClearSelection();
        }
        private void LoadData()
        {
            dataViewMark.DataSource = StudentService.GetTop3Grade(StudentService.GetAllGrade());
        }
        private void ShowStatus(bool result, string action)
        {
            if (result)
            {
                if (action == "ADD")
                {
                    MessageBox.Show("Thêm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (action == "UPDATE")
                {
                    MessageBox.Show("Cập nhật thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (action == "ADD")
                {
                    MessageBox.Show("Thêm thất bại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (action == "UPDATE")
                {
                    MessageBox.Show("Cập nhật thất bại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ClearField();
            LoadData();
        }
        #endregion

    }
}
