using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            ConnectionDB.connectsql();
            this.ActiveControl = tbPassword;
            this.Opacity = 50;
        }

        private void pictOK_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void pictCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditData()
        {
            ConnectionDB.executsql("UPDATE UserShop SET Password='"+tbPassword.Text+"', Title='" + tbTitle.Text + "',FirstName='" + tbFirstName.Text + "',LastName='" + tbLastName.Text + "',Address='" + tbAddress.Text + "',Tel='" + tbTel.Text + "' WHERE UserID='" + tbUserID.Text + "'");
            MessageBox.Show("แก้ไขข้อมูลพนักงานแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void pressNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditData();
            }
        }

        //button zoom
        private void mpOK(object sender, EventArgs e)
        {
            pictOK.Size = new System.Drawing.Size(60, 60);
        }

        private void mplOK(object sender, EventArgs e)
        {
            pictOK.Size = new System.Drawing.Size(50, 50);
        }

        private void mpCancel(object sender, EventArgs e)
        {
            pictCancel.Size = new System.Drawing.Size(60, 60);
        }

        private void mplCancel(object sender, EventArgs e)
        {
            pictCancel.Size = new System.Drawing.Size(50, 50);
        }

        private void dontPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("ไม่สามารถแก้ไขรหัสพนักงานได้","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
    }
}
