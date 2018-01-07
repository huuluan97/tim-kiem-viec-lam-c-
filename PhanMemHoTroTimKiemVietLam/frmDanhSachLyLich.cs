using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBoxIcon;

namespace PhanMemHoTroTimKiemVietLam
{
    
    public partial class frmDanhSachLyLich : Form
    {
        
        public frmDanhSachLyLich()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       // private void
        private void frmDanhSachLyLich_Load(object sender, EventArgs e)
        {
            LoadCv();

        }
        private void Rename1()
        {
            dgrDSLL.Columns[0].HeaderText
                = @"Mã CV";
            dgrDSLL.Columns[1].HeaderText = "Họ và Tên";
            dgrDSLL.Columns[2].HeaderText = "Quê Quán";
            dgrDSLL.Columns[3].HeaderText = "Địa Chỉ Thường Trú";
            dgrDSLL.Columns[4].HeaderText = "Địa Chỉ Tạm Trú";
            dgrDSLL.Columns[5].HeaderText = "Số Điện Thoại";
            dgrDSLL.Columns[6].HeaderText = "CMND";
            dgrDSLL.Columns[7].HeaderText = "Sức Khỏe";
            dgrDSLL.Columns[8].HeaderText = "Email";
            dgrDSLL.Columns[9].HeaderText = "Mã DN";
        }

        private void XuLyDataGr(int e)
        {
            if (dgrDSLL.SelectedRows.Count > 0)
            {
                txtMaCV.Text = dgrDSLL.Rows[e].Cells[0].Value.ToString();
                txtHoTen.Text = dgrDSLL.Rows[e].Cells[1].Value.ToString();
                txtQueQuan.Text = dgrDSLL.Rows[e].Cells[2].Value.ToString();
                txtDCTHT.Text = dgrDSLL.Rows[e].Cells[3].Value.ToString();
                txtDCTT.Text = dgrDSLL.Rows[e].Cells[4].Value.ToString();
                txtSDT.Text = dgrDSLL.Rows[e].Cells[5].Value.ToString();
                txtCMND.Text = dgrDSLL.Rows[e].Cells[6].Value.ToString();
                txtSucKhoe.Text = dgrDSLL.Rows[e].Cells[7].Value.ToString();
                txtMail.Text = dgrDSLL.Rows[e].Cells[8].Value.ToString();
                //txtMaDN.Text = dgrDSLL.Rows[e].Cells[9].Value.ToString();
                cbxMaDN.Text = dgrDSLL.Rows[e].Cells[9].Value.ToString();
            }
        }
        private void LoadCv()
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                var cv = from d in db1.LyLichXinViecs
                         select d;
                dgrDSLL.DataSource = cv.ToList();
                dgrDSLL.Columns["DoanhNghiep"].Visible = false;
                var cv1 = (from d1 in db1.DoanhNghieps
                    select d1.maDN).Distinct();
                
                cbxMaDN.DataSource = cv1.ToList();
                Rename1();


            }
        }

        private void dgrDSLL_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            XuLyDataGr(e.RowIndex);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
           
                var dlt = dgrDSLL.SelectedRows[0].Cells[0].Value.ToString();
                using (var db1 = new TroGiupViecLamEntities())
                {
                    var data = db1.LyLichXinViecs.First(c => c.maCV == dlt);
                    db1.LyLichXinViecs.Remove(data);

                    db1.SaveChanges();
                    var query = from b in db1.LyLichXinViecs
                                select b;
                    //  foreach (var item in query)
                    //{
                    dgrDSLL.DataSource = query.ToList();
                    // }
                    //  dgvChinhSuaDN.Columns["NganhNghe"].Visible = false;
                    //  dgvChinhSuaDN.Columns["LyLichXinViecs"].Visible = false;


                    //    }
                    //    dgvChinhSuaDN.Update();
                    //    dgvChinhSuaDN.Refresh();
                    //}
                  //  dgrDSLL.Columns["DoanhNghieps"].Visible = false;
                    //dgrDSLL.Update();
                    dgrDSLL.Refresh();
                }
            
           
            
        }

        private bool KtTrung(string ma)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                var s = db1.LyLichXinViecs.Where(p => p.maCV.Equals(ma)).ToList();
                if (s.Any())
                    return false;
                return true;
            }
        }

        private void add_CV(LyLichXinViec _llxinvien)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                //db1.Entry(_llxinvien).State = System.Data.Entity.EntityState.Modified;
                db1.LyLichXinViecs.Add(_llxinvien);
                db1.SaveChanges();
            }
        }

        private void chinhsuadn(LyLichXinViec _l1xivc)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                db1.Entry(_l1xivc).State = System.Data.Entity.EntityState.Modified;
                db1.SaveChanges();
            }
        }
        private bool capnhatcv(LyLichXinViec _ll23xv)
        {
            try
            {
                using (var db1 = new TroGiupViecLamEntities())
                {
                    //  db1.Entry(_ll23xv).State =EntityState.Modified;
                   string mavc = dgrDSLL.SelectedRows[0].Cells[0].Value.ToString();
                  //  db1.LyLichXinViecs.Attach();
                    db1.Entry(_ll23xv).State = _ll23xv.maCV == mavc ? EntityState.Added : EntityState.Modified;
                    db1.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void edit_cv(LyLichXinViec _newllxv)
        {
         
                using (var db1 = new TroGiupViecLamEntities())
                {
                  //  string mavc = dgrDSLL.Rows[0].Cells[0].Value.ToString();
                    
                 LyLichXinViec _llxinviec = db1.LyLichXinViecs;   
                   
                    //  db1.SaveChanges();
                    //LyLichXinViec _llxinviec = db1.LyLichXinViecs.FirstOrDefault(c => c.maCV == _newllxv.maCV);
                //    _llxinviec.maCV = _newllxv.maCV;
                _llxinviec.tenNV = _newllxv.tenNV;
                _llxinviec.queQuan = _newllxv.queQuan;
                _llxinviec.dcThuongTru = _newllxv.dcThuongTru;
                _llxinviec.dcTamTru = _newllxv.dcTamTru;
                _llxinviec.soDT = _newllxv.soDT;
                _llxinviec.cmND = _newllxv.cmND;
                _llxinviec.sucKhoe = _newllxv.sucKhoe;
                _llxinviec.eMail = _newllxv.eMail;
                _llxinviec.maDN = _newllxv.maDN;
                
                //  return true;

              //  db1.Entry(_newllxv).State = System.Data.Entity.EntityState.Modified;
              //  db1.LyLichXinViecs.Attach()
                    capnhatcv(_llxinviec);
              LoadCv();
              //  db1.SaveChanges();
            }
           


        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db1= new TroGiupViecLamEntities())
                {
                    if (KtTrung(txtMaCV.Text) == true)
                    {
                        LyLichXinViec ll1 = new LyLichXinViec();
                        
                        ll1.maCV = txtMaCV.Text;
                        ll1.tenNV = txtHoTen.Text;
                        ll1.queQuan = txtQueQuan.Text;
                        ll1.cmND = txtCMND.Text;
                        ll1.dcThuongTru = txtDCTHT.Text;
                        ll1.dcTamTru = txtDCTT.Text;
                        ll1.soDT = txtSDT.Text;
                        ll1.sucKhoe = txtSucKhoe.Text;
                       // ll1.maDN = cbxMaDN.SelectedItem.ToString();
                        ll1.eMail = txtMail.Text;
                        ll1.maDN = cbxMaDN.Text;
                        add_CV(ll1);
                        MessageBox.Show("Thêm thành công");
                        LoadCv();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Thêm thất bại\n" + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db1 = new TroGiupViecLamEntities())
                {
                   string mavc = dgrDSLL.SelectedRows[0].Cells[0].Value.ToString();
                    LyLichXinViec lll = db1.LyLichXinViecs.Find(mavc);
                   // MessageBox.Show(mavc);
                    //LyLichXinViec ll1 = new LyLichXinViec();
                    //ll1.maCV = txtMaCV.Text;
                    lll.tenNV = txtHoTen.Text;
                    lll.queQuan = txtQueQuan.Text;
                    lll.cmND = txtCMND.Text;
                    lll.dcThuongTru = txtDCTHT.Text;
                    lll.dcTamTru = txtDCTT.Text;
                    lll.soDT = txtSDT.Text;
                    lll.sucKhoe = txtSucKhoe.Text;
                    // ll1.maDN = cbxMaDN.SelectedItem.ToString();
                    lll.eMail = txtMail.Text;
                    lll.maDN = cbxMaDN.Text;
                    //  edit_cv(ll1);
                 //   chinhsuadn(lll);
                    capnhatcv(lll);
                    LoadCv();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cập nhật thất bại.\n" + ex.Message);
            }
            //using (var db1 = new TroGiupViecLamEntities())
            //{
            //    LyLichXinViec _l = new LyLichXinViec();

            //  //  _l.maCV = txtMaCV.Text;
            //    _l.tenNV = txtHoTen.Text;
            //    _l.queQuan = txtQueQuan.Text;
            //    _l.cmND = txtCMND.Text;
            //    _l.dcThuongTru = txtDCTHT.Text;
            //    _l.dcTamTru = txtDCTT.Text;
            //    _l.soDT = txtSDT.Text;
            //    _l.sucKhoe = txtSucKhoe.Text;
            //    // ll1.maDN = cbxMaDN.SelectedItem.ToString();
            //    _l.eMail = txtMail.Text;
            //    _l.maDN = cbxMaDN.Text;

            //    capnhatcv(_l);
            //    db1.LyLichXinViecs.Attach(_l);
            //    LoadCv();
            //}

        }

        private void dgrDSLL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
