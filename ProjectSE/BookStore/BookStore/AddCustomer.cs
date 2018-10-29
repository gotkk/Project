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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            ConnectionDB.connectsql();
        }

        private void pictOK_Click(object sender, EventArgs e)
        {
            checkDatatoAdd();
        }

        private void pictCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void checkDatatoAdd()
        {
            if (tbCusID.Text == "" || tbTitle.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbAddress.Text == "" || tbTel.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbCusID.Text.Length < 13)
            {
                MessageBox.Show("กรุณากรอกรหัสลูกค้าให้ครบ 13 หลัก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check cusID Used to in db
            DataTable checkdatacusID = ConnectionDB.executsql("SELECT * FROM Customer WHERE CusID='" + tbCusID.Text + "'");
            if (checkdatacusID.Rows.Count > 0)
            {
                MessageBox.Show("รหัสลูกค้านี้ถูกใช้ไปแล้ว กรุณากรอกรหัสลูกค้าใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCusID.Clear();
                tbCusID.Focus();
                return;
            }

            ConnectionDB.executsql("INSERT INTO Customer (CusID,Title,FirstName,LastName,Address,Tel) VALUES('" + tbCusID.Text + "','" + tbTitle.Text + "','" + tbFirstName.Text + "','" + tbLastName.Text + "','" + tbAddress.Text + "','" + tbTel.Text + "')");
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                checkDatatoAdd();
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

       
    }
}
