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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            ConnectionDB.connectsql();
            LoadData();
        }
        
        private void LoadData()
        {
            // DataGridviewLoadData
            DataTable loaddata = ConnectionDB.executsql("SELECT * FROM UserShop");
            dgvUser.DataSource = loaddata;
            dgvUser.Columns[0].HeaderText = "รหัสพนักงาน";
            dgvUser.Columns[1].HeaderText = "รหัสผ่าน";
            dgvUser.Columns[2].HeaderText = "คำนำหน้า";
            dgvUser.Columns[3].HeaderText = "ชื่อ";
            dgvUser.Columns[4].HeaderText = "นามสกุล";
            dgvUser.Columns[5].HeaderText = "ที่อยู่";
            dgvUser.Columns[6].HeaderText = "เบอร์โทร";
            var a = 6;
        }

        private void SearchUser()
        {
            //Search
            DataTable searchData = ConnectionDB.executsql("SELECT * FROM UserShop WHERE UserID LIKE'%" + tbSearch.Text + "%' OR Title LIKE'%" + tbSearch.Text + "%' OR FirstName LIKE'%" + tbSearch.Text + "%' OR LastName LIKE'%" + tbSearch.Text + "%' OR Tel LIKE'%" + tbSearch.Text + "%' OR Address LIKE'%" + tbSearch.Text + "%' OR Password LIKE'%" + tbSearch.Text + "%' ");
            if (tbSearch.Text == "")
            {
                LoadData();
            }
            else
            {
                dgvUser.DataSource = searchData;
            }
        }

        private void pictMagnifier_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        private void pressKeySearch(object sender, KeyPressEventArgs e)
        {
            SearchUser();
        }

        private void pressKeyUDSearch(object sender, KeyEventArgs e)
        {
            SearchUser();
        }

        private void pictAdd_Click(object sender, EventArgs e)
        {
            AddUser addDataa = new AddUser();
            addDataa.ShowDialog();
            LoadData();
        }

        private void pictDelete_Click(object sender, EventArgs e)
        {
            // Delete Only 1 row Select
            if (dgvUser.SelectedRows.Count > 1)
            {
                MessageBox.Show("กรุณาเลือกแค่ 1 แถวที่จะลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("คุณแน่ใจที่จะลบข้อมูลของพนักงานที่เลือกหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ConnectionDB.executsql("DELETE FROM UserShop WHERE UserID = '" + dgvUser.SelectedCells[0].Value.ToString() + "'");
                LoadData();
            }
        }

        private void pictEdit_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.tbUserID.Text = this.dgvUser.SelectedCells[0].Value.ToString();
            editUser.tbPassword.Text = this.dgvUser.SelectedCells[1].Value.ToString();
            editUser.tbTitle.Text = this.dgvUser.SelectedCells[2].Value.ToString();
            editUser.tbFirstName.Text = this.dgvUser.SelectedCells[3].Value.ToString();
            editUser.tbLastName.Text = this.dgvUser.SelectedCells[4].Value.ToString();
            editUser.tbAddress.Text = this.dgvUser.SelectedCells[5].Value.ToString();
            editUser.tbTel.Text = this.dgvUser.SelectedCells[6].Value.ToString();
            editUser.ShowDialog();
            LoadData();
        }

        private void pictHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // button color
        private static Color mp = Color.SteelBlue;
        private static Color mpl = Color.LightSkyBlue;
        private void mpAdd(object sender, EventArgs e)
        {
            pictAdd.BackColor = mp;
        }

        private void mplAdd(object sender, EventArgs e)
        {
            pictAdd.BackColor = mpl;
        }

        private void mpDelete(object sender, EventArgs e)
        {
            pictDelete.BackColor = mp;
        }

        private void mplDelete(object sender, EventArgs e)
        {
            pictDelete.BackColor = mpl;
        }

        private void mpEdit(object sender, EventArgs e)
        {
            pictEdit.BackColor = mp;
        }

        private void mplEdit(object sender, EventArgs e)
        {
            pictEdit.BackColor = mpl;
        }

        private void mpHome(object sender, EventArgs e)
        {
            pictHome.BackColor = mp;
        }

        private void mplHome(object sender, EventArgs e)
        {
            pictHome.BackColor = mpl;
        }

        private void mpSearch(object sender, EventArgs e)
        {
            pictMagnifier.BackColor = mp;
        }

        private void mplSearch(object sender, EventArgs e)
        {
            pictMagnifier.BackColor = mpl;
        }

        
    }
}
