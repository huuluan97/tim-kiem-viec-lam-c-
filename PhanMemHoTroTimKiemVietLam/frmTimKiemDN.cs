using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemHoTroTimKiemVietLam
{
    public partial class frmTimKiemDN : Form
    {
        public frmTimKiemDN()
            
        {
          //  LoadDn();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                string s1 = cbxQuan.SelectedItem.ToString();
                string s2 = cbxNganhNghe.SelectedItem.ToString();
                var query3 = from c3 in db1.DoanhNghieps
                    where c3.maNN == s2.ToString() && c3.quanDN == s1.ToString()
                    select c3;
                dgvDN.DataSource = query3.ToList();
               // dgvDN.Refresh();
                if (dgvDN == null)
                {
                    MessageBox.Show(@"Không có doanh nghiệp nào");
                }

            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            var frmDSLL = new frmDanhSachLyLich();
            this.Hide();
            frmDSLL.ShowDialog();
            this.Show();
        }

        private void LoadDn()
        {
            using (var db = new TroGiupViecLamEntities())
            {
                var query2 = from b in db.DoanhNghieps
                                //  where b.maNN == XuLyTreeView().ToString()
                                orderby  b.maDN ascending 
                            select b;
                //  foreach (var item in query)
                //{
                
                dgvDN.DataSource = query2.ToList();
                Rename();
            dgvDN.Columns["NganhNghe"].Visible = false;
               dgvDN.Columns["LyLichXinViecs"].Visible = false;
               
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTimKiemDN_Load(object sender, EventArgs e)
        {
            LoadDn();
            loadCbx();
            //TimKiem();
        }
        private void Rename()
        {
            dgvDN.Columns[0].HeaderText
                = @"Mã DN";
            dgvDN.Columns[1].HeaderText = "Tên Doanh Nghiệp";
            dgvDN.Columns[2].HeaderText = "Địa Chỉ";
            dgvDN.Columns[3].HeaderText = "Số Điện Thoại";
          dgvDN.Columns[4].HeaderText = "Email";
            dgvDN.Columns[5].HeaderText = "Chủ Doanh Nghiệp";
            dgvDN.Columns[6].HeaderText = "Quận DN";
            dgvDN.Columns[7].HeaderText = "Mã Ngành Nghề";
        }
        // private void TimKiem()
        //   {

        //   }
        private void loadCbx()
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                var cbx1 = (from c in db1.DoanhNghieps
                    select c.maNN).Distinct();
                var cbc2 = (from c2 in db1.DoanhNghieps
                    select c2.quanDN).Distinct();
                cbxNganhNghe.DataSource = cbx1.ToList();
                cbxQuan.DataSource = cbc2.ToList();
            }
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXemTatca_Click(object sender, EventArgs e)
        {
            LoadDn();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
