using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); Console.WriteLine();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConnectionDB.connectsql();
        }

        private void checkLogin()
        {
            DataTable checkLogin = ConnectionDB.executsql("SELECT * FROM UserShop WHERE UserID = '" + tb_username.Text + "' AND Password = '" + tb_password.Text + "'");
           if (checkLogin.Rows.Count > 0)
            {
                MessageBox.Show("ยินดีต้อนรับคุณ " + checkLogin.Rows[0][3] + "  " + checkLogin.Rows[0][4] + " เข้าสู่ระบบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(tb_username.Text == "admin" || tb_username.Text == "Admin")
                {
                    // Menu1 Admin
                    this.Hide();
                    var menu = new MenuAdmin();
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();

                    //show username in menu
                    menu.textUserName.Text = tb_username.Text;
                }
                else
                {
                    // Menu2 User
                    this.Hide();
                    var menu = new MenuShop();
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();

                    //show username in menu
                    menu.textUserName.Text = tb_username.Text;
                }   
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง!!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb_password.Clear();
                tb_username.Clear();
                textPassword.Show();     //bug password
                tb_username.Focus(); //888
            }
        }

        private void enter_login(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            textUsername.Hide();
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if(tb_username.Text == "")
            {
                textUsername.Show();
            }
            
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            textPassword.Hide();
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if(tb_password.Text == "")
            {
                textPassword.Show();
            }
            
        }

        private void Click_Username(object sender, EventArgs e)
        {
            textUsername.Hide();
            tb_username.Focus();
        }

        private void Click_Pawword(object sender, EventArgs e)
        {
            textPassword.Hide();
            tb_password.Focus();
        }

        private void textLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void textExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // button color change
        private static Color mp = Color.LimeGreen;
        private static Color mpl = Color.LightSlateGray;
        private void mpLogin(object sender, EventArgs e)
        {
            mp = Color.LimeGreen;
            btnLogin.BackColor = mp;
            btnLogin.BorderColor = mp;
            textLogin.BackColor = mp;
        }

        private void mplLogin(object sender, EventArgs e)
        {
            btnLogin.BackColor = mpl;
            btnLogin.BorderColor = Color.Black;
            textLogin.BackColor = mpl ;
        }

        private void mpExit(object sender, EventArgs e)
        {
            mp = Color.Red;
            btnExit.BackColor = mp;
            btnExit.BorderColor = mp;
            textExit.BackColor = mp;
        }

        private void mplExit(object sender, EventArgs e)
        {
            btnExit.BackColor = mpl;
            btnExit.BorderColor = Color.Black;
            textExit.BackColor = mpl;
        }

        // to move panel when click panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
