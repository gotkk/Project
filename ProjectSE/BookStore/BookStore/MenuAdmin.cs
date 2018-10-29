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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void pictCustomer_Click(object sender, EventArgs e)
        {
            Customer frmCustomer = new Customer();
            frmCustomer.ShowDialog();
        }

        private void pictLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogA = MessageBox.Show("คุณแน่ใจที่จะออกจากระบบหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogA == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogA == DialogResult.No)
            {
                //nothing
            }
        }

        private void pictUser_Click(object sender, EventArgs e)
        {
            User user = new BookStore.User();
            user.ShowDialog();
        }

        //menu button color
        private static Color mp = Color.LightGoldenrodYellow;
        private static Color mpl = Color.White;
        private void mpCustomer(object sender, EventArgs e)
        {
            pictCustomer.BackColor = mp;
        }

        private void mplCustomer(object sender, EventArgs e)
        {
            pictCustomer.BackColor = mpl;
        }

        private void mpStore(object sender, EventArgs e)
        {
            pictStore.BackColor = mp;
        }

        private void mplStore(object sender, EventArgs e)
        {
            pictStore.BackColor = mpl;
        }

        private void mpSale(object sender, EventArgs e)
        {
            pictSale.BackColor = mp;
        }

        private void mplSale(object sender, EventArgs e)
        {
            pictSale.BackColor = mpl;
        }

        private void mpUser(object sender, EventArgs e)
        {
            pictUser.BackColor = mp;
        }

        private void mplUser(object sender, EventArgs e)
        {
            pictUser.BackColor = mpl;
        }

        private void mpLogout(object sender, EventArgs e)
        {
            pictLogout.BackColor = Color.Gray;
        }

        private void mplLogout(object sender, EventArgs e)
        {
            pictLogout.BackColor = Color.Orange;
        }
    }
}
