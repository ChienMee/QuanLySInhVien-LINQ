using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Assignment.Core.Repository;
using Assignment.UI;

namespace Assignment
{
    public partial class Login : Form
    {
        private IUserRepo Service;
        private IStudentRepo StudentService;
        public Login(IUserRepo service, IStudentRepo studentService)
        {
            InitializeComponent();
            Service = service;
            StudentService = studentService;
        }

        #region Events

        /// <summary>
        /// Sự kiện Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sự kiện btnLogin Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (Service.Login(username, password))
            {
                if (Service.GetUserRole(username) == "GV")
                {
                    var form = new MarkManagement(Service, StudentService);
                    MessageBox.Show("Đăng nhập thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    var form = new StudentManagement(Service, StudentService);
                    MessageBox.Show("Đăng nhập thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

        }

        /// <summary>
        /// Sự kiện btnCancel Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("you want to Exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Sự kiện Form Close (xảy ra khi form được đóng lại hoặc dừng ứng dụng)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Sự kiện picture box pBoxIcon Paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxIcon_Paint(object sender, PaintEventArgs e)
        {

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
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Visible = true;
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
    }


}