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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ConnectionDB.connectsql();
            LoadData();
            SetColumnDGV();
        }
        
        private void LoadData()
        {
            // DataGridviewLoadData
            DataTable loaddata = ConnectionDB.executsql("SELECT * FROM Customer");
            dgvCustomer.DataSource = loaddata;
            dgvCustomer.Columns[0].HeaderText = "รหัสลูกค้า";
            dgvCustomer.Columns[1].HeaderText = "คำนำหน้า";
            dgvCustomer.Columns[2].HeaderText = "ชื่อ";
            dgvCustomer.Columns[3].HeaderText = "นามสกุล";
            dgvCustomer.Columns[4].HeaderText = "ที่อยู่";
            dgvCustomer.Columns[5].HeaderText = "เบอร์โทร";
        }

        private void SetColumnDGV()
        {
            DataGridViewColumn column0 = dgvCustomer.Columns[0];
            column0.Width = 120;
            DataGridViewColumn column1 = dgvCustomer.Columns[1];
            column1.Width = 90;
            DataGridViewColumn column2 = dgvCustomer.Columns[2];
            column2.Width = 160;
            DataGridViewColumn column3 = dgvCustomer.Columns[3];
            column3.Width = 160;
            DataGridViewColumn column5 = dgvCustomer.Columns[5];
            column5.Width = 140;
        }

        private void SearchCustomer()
        {
            //Search
            DataTable searchData = ConnectionDB.executsql("SELECT * FROM Customer WHERE CusID LIKE'%" + tbSearch.Text + "%' OR Title LIKE'%" + tbSearch.Text + "%' OR FirstName LIKE'%" + tbSearch.Text + "%' OR LastName LIKE'%" + tbSearch.Text + "%' OR Address LIKE'%" + tbSearch.Text + "%' OR Tel LIKE'%" + tbSearch.Text + "%'");
            if (tbSearch.Text == "")
            {
                LoadData();
            }
            else
            {
                dgvCustomer.DataSource = searchData;
            }
        }

        private void pictMagnifier_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        private void pressKeySearch(object sender, KeyPressEventArgs e)
        {
            SearchCustomer();
        }

        private void pressKeyUDSearch(object sender, KeyEventArgs e)
        {
            SearchCustomer();
        }

        private void pictAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addDataa = new AddCustomer();
            addDataa.ShowDialog();
            LoadData();
        }

        private void pictDelete_Click(object sender, EventArgs e)
        {
            // Delete Only 1 row Select
            if (dgvCustomer.SelectedRows.Count > 1)
            {
                MessageBox.Show("กรุณาเลือกแค่ 1 แถวที่จะลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("คุณแน่ใจที่จะลบข้อมูลของลูกค้าที่เลือกหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ConnectionDB.executsql("DELETE FROM Customer WHERE CusID = '" + dgvCustomer.SelectedCells[0].Value.ToString() + "'");
                LoadData();
            }
        }

        private void pictEdit_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer();
            editCustomer.tbCusID.Text = this.dgvCustomer.SelectedCells[0].Value.ToString();
            editCustomer.tbTitle.Text = this.dgvCustomer.SelectedCells[1].Value.ToString();
            editCustomer.tbFirstName.Text = this.dgvCustomer.SelectedCells[2].Value.ToString();
            editCustomer.tbLastName.Text = this.dgvCustomer.SelectedCells[3].Value.ToString();
            editCustomer.tbAddress.Text = this.dgvCustomer.SelectedCells[4].Value.ToString();
            editCustomer.tbTel.Text = this.dgvCustomer.SelectedCells[5].Value.ToString();
            editCustomer.ShowDialog();
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
