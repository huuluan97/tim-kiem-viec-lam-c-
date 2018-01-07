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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void Rename1()
        {
            dgvCV.Columns[0].HeaderText
                = @"Mã CV";
            dgvCV.Columns[1].HeaderText = "Họ và Tên";
           dgvCV.Columns[2].HeaderText = "Quê Quán";
            dgvCV.Columns[3].HeaderText = "Địa Chỉ Thường Trú";
            dgvCV.Columns[4].HeaderText = "Địa Chỉ Tạm Trú";
            dgvCV.Columns[5].HeaderText = "Số Điện Thoại";
            dgvCV.Columns[6].HeaderText = "CMND";
            dgvCV.Columns[7].HeaderText = "Sức Khỏe";
            dgvCV.Columns[8].HeaderText = "Email";
            dgvCV.Columns[9].HeaderText = "Mã DN";
        }
        private void loadData()
        {
            using (var db = new TroGiupViecLamEntities())
            {
                var query = (from b in db.DoanhNghieps

                          //  where b.maNN == XuLyTreeView().ToString()
                            select b);
                //  foreach (var item in query)
                //{

                dgvDoanhNghiep.DataSource = query.ToList();
                // dgvDoanhNghiep
                // }
                Rename();
                dgvDoanhNghiep.Columns["NganhNghe"].Visible = false;
                 dgvDoanhNghiep.Columns["LyLichXinViecs"].Visible = false;
                //  var query2 = from b in db1.DoanhNghieps
                //   select b.maNN;
                //  cbxCSMNN.DataSource = query2.ToList();
            }
        }
        //private void refresh2()
        //{
        //    using (var db = new TroGiupViecLamEntities())
        //    {
        //        var query = from b in db.DoanhNghieps
        //                    where b.maNN
        //                    select b;
        //        //  foreach (var item in query)
        //        //{

        //        dgvDoanhNghiep.DataSource = query.ToList();
        //        // dgvDoanhNghiep
        //        // }
        //        dgvDoanhNghiep.Columns["NganhNghe"].Visible = false;
        //        dgvDoanhNghiep.Columns["LyLichXinViecs"].Visible = false;
        //        //  var query2 = from b in db1.DoanhNghieps
        //        //   select b.maNN;
        //        //  cbxCSMNN.DataSource = query2.ToList();
        //    }
        //}

        //public void XuLyListBox()
        //{
        //    lstNganhNghe.Items.Clear();

        //     using  (var db2 = new TroGiupViecLamEntities() )
        //    {
        //        var query2 = from b1 in db2.NganhNghes
        //            select b1.maNN;
        //       // List<string> list = new List<string>();
        //      // foreach (var s in query2)
        //       //     list.Add(s);
        //      //  ListBox lisb = new ListBox(list);
        //    }
        //}
        private void XuLuDataGridview(int e)
        {
            if (dgvDoanhNghiep.SelectedRows.Count > 0)
            {
                txtMaDN.Text = dgvDoanhNghiep.Rows[e].Cells[0].Value.ToString();
                txtTenDN.Text = dgvDoanhNghiep.Rows[e].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDoanhNghiep.Rows[e].Cells[2].Value.ToString();
                txtPhone.Text = dgvDoanhNghiep.Rows[e].Cells[3].Value.ToString();
                txtMail.Text = dgvDoanhNghiep.Rows[e].Cells[4].Value.ToString();
                txtChuDN.Text = dgvDoanhNghiep.Rows[e].Cells[5].Value.ToString();
                txtQuanDN.Text = dgvDoanhNghiep.Rows[e].Cells[6].Value.ToString();
                cbxMaNN.Text = dgvDoanhNghiep.Rows[e].Cells[7].Value.ToString();
            }
        }

        private void XulyDGVXinViec(int e)
        {
            if (dgvCV.SelectedRows.Count > 0)
            {
                txtMaCV.Text = dgvCV.Rows[e].Cells[0].Value.ToString();
                txtHoTen.Text = dgvCV.Rows[e].Cells[1].Value.ToString();
                txtQueQuan.Text = dgvCV.Rows[e].Cells[2].Value.ToString();
                txtDCTHT.Text = dgvCV.Rows[e].Cells[3].Value.ToString();
                txtDCTT.Text = dgvCV.Rows[e].Cells[4].Value.ToString();
                txtSDT.Text = dgvCV.Rows[e].Cells[5].Value.ToString();
                txtCMND.Text = dgvCV.Rows[e].Cells[6].Value.ToString();
                txtSucKhoe.Text = dgvCV.Rows[e].Cells[7].Value.ToString();
                txtMailCV.Text = dgvCV.Rows[e].Cells[8].Value.ToString();
                txtMaDNCV.Text = dgvCV.Rows[e].Cells[9].Value.ToString();
                

            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCv();
            loadData();
            XuLyTreeView();

        }
        private void Rename()
        {
            dgvDoanhNghiep.Columns[0].HeaderText
                = @"Mã DN";
            dgvDoanhNghiep.Columns[1].HeaderText = "Tên Doanh Nghiệp";
            dgvDoanhNghiep.Columns[2].HeaderText = "Địa Chỉ";
            dgvDoanhNghiep.Columns[3].HeaderText = "Số Điện Thoại";
            dgvDoanhNghiep.Columns[4].HeaderText = "Email";
          dgvDoanhNghiep.Columns[5].HeaderText = "Chủ Doanh Nghiệp";
            dgvDoanhNghiep.Columns[6].HeaderText = "Quận DN";
            dgvDoanhNghiep.Columns[7].HeaderText = "Mã Ngành Nghề";
        }

        private void LoadCv()
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                var cv = from d in db1.LyLichXinViecs
                    select d;
                dgvCV.DataSource = cv.ToList();
                Rename1();
                dgvCV.Columns["DoanhNghiep"].Visible = false;

            }
        }

        private void XuLyTreeView()
        {
            trvDSNN.Nodes.Clear();
            using (var db = new TroGiupViecLamEntities())
            {
               // var query2 = from b2 in db2.NganhNghes
                 //   select b2.maNN;
                foreach (NganhNghe nn in db.NganhNghes)
                {
                    TreeNode node = new TreeNode(nn.maNN) {Tag = nn.maNN};
                    trvDSNN.Nodes.Add(node);
                }
            }
        }

        private void Loadtv()
        {
            
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutPSJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Tập đoàn Phần mềm đa quốc gia đầu tiên trên thế giới.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        //private void panel1_MouseHover(object sender, EventArgs e)
        //{
        //    panel1.BackColor = Color.DarkGray;
        //}

        //private void panel1_MouseLeave(object sender, EventArgs e)
        //{
        //    panel1.BackColor = Color.AliceBlue;
        //}

        private void chinhSưaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvDoanhNghiep_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            XuLuDataGridview(e.RowIndex);
        }

      //  private void lstNganhNghe_SelectedIndexChanged(object sender, EventArgs e)
     //   {
       //     if (lstNganhNghe.SelectedIndex > 0)
       //     {
        //        string mann = lstNganhNghe.SelectedIndex.ToString();
         //       using (var db3 = new TroGiupViecLamEntities() )
         //       {
         //           var add1 = from n in db3.NganhNghes
          //              where n.maNN == mann
          //              select n;
                    //dgvDoanhNghiep.DataSource = add1;
          //      }

           // }
      //  }

        private void mnsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trvDSNN_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //{
                using (var db = new TroGiupViecLamEntities())
                {
                    if (trvDSNN.SelectedNode != null)
                    {
                        string mannn = trvDSNN.SelectedNode.Tag.ToString();
                        
                       // dgvDoanhNghiep.DataSource = 
                      var add = from n in db.DoanhNghieps
                                    where n.maNN == mannn
                            select n;
                     
                        dgvDoanhNghiep.DataSource = add.ToList();
                    }
                  //  refresh1();
                    //  db.SaveChanges();

               // }
            }
        }


        //var frmMai = new frmMain();
        //        this.Hide();
        //frmMai.ShowDialog();
        //        this.Show();
        private void btnTimKiemDN_Click(object sender, EventArgs e)
        {
            var frmTimKiem = new frmTimKiemDN();
            this.Hide();
            frmTimKiem.ShowDialog();
            this.Show();
        }

        private void btnCapNhatLL_Click(object sender, EventArgs e)
        {
            var frmLLCV = new frmDanhSachLyLich();
            this.Hide();
            frmLLCV.ShowDialog();
            this.Show();
        }

        private void dgvCV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            XulyDGVXinViec(e.RowIndex);
        }

        private void thayĐôiDoanhNghiêpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CSDD = new frmChinhSuaDN();
            this.Hide();
            CSDD.ShowDialog();
            this.Show();
        }
    }
}
