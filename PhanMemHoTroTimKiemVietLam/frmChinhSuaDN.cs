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
    public partial class frmChinhSuaDN : Form
    {
        public frmChinhSuaDN()
        {
            InitializeComponent();
        }

        private void txtChuDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
              //  string s = txtTenNN.Text.ToString();
                var query = from b in db1.DoanhNghieps
                            
                    select b;
                //  foreach (var item in query)
                //{


                dgvChinhSuaDN.DataSource = query.ToList();
                Rename();
                // }
                dgvChinhSuaDN.Columns["NganhNghe"].Visible = false;
                dgvChinhSuaDN.Columns["LyLichXinViecs"].Visible = false;
                //var query2 = from b in db1.DoanhNghieps
                //    select b.maNN;
                //cbxCSMNN.DataSource = query2.ToList();
                var query2 =( from b2 in db1.NganhNghes
                    select b2.maNN).Distinct();
                cbxMaNN.DataSource = query2.ToList();
               // var query3= (from b3 in db1)
                //string s1 = cbxMaNN.Text;
                //var query3 = from b3 in db1.NganhNghes
                //    from b4 in db1.DoanhNghieps
                //    where b3.maNN == b4.maNN
                //    select b3.tenNN;
                //txtTenNN.Text = query3.ToList().ToString();
                var query4 = (from b3 in db1.NganhNghes
                    select b3.tenNN).Distinct();
                cbxTenNN.DataSource = query4.ToList();


            }
         
        }

        //  private void LoadCombobox()
        private void XuLuDataGridview(int e)
        {
            if (dgvChinhSuaDN.SelectedRows.Count > 0)
            {
                txtMaDN.Text = dgvChinhSuaDN.Rows[e].Cells[0].Value.ToString();
                txtTenDN.Text = dgvChinhSuaDN.Rows[e].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvChinhSuaDN.Rows[e].Cells[2].Value.ToString();
                txtPhone.Text = dgvChinhSuaDN.Rows[e].Cells[3].Value.ToString();
                txtMail.Text = dgvChinhSuaDN.Rows[e].Cells[4].Value.ToString();
                txtChuDN.Text = dgvChinhSuaDN.Rows[e].Cells[5].Value.ToString();
                txtQuanDN.Text = dgvChinhSuaDN.Rows[e].Cells[6].Value.ToString();
                //txtMaNN.Text = dgvChinhSuaDN.Rows[e].Cells[7].Value.ToString();
                cbxMaNN.Text = dgvChinhSuaDN.Rows[e].Cells[7].Value.ToString();
                //XuLyTRungCBX();
                using (var db1 = new TroGiupViecLamEntities())
                {
                    var c3 = (from d in db1.NganhNghes
                        where d.maNN == cbxMaNN.Text
                        select d.tenNN).SingleOrDefault();
                    cbxTenNN.Text = c3.ToString();
//first trả về đối tượng đầu tiên thỏa mản có trong kết quả truy vấn.nếu không tìm thấy có sẽ có Exception
//FirstOrDefaut giống như first ngoại trừ không có giá trị thỏa mản sẽ trả về giá trị mặc định của kiểu dữ liệu
//Single trả về đối tượng thỏa mản điều kiện và duy nhất nếu không duy nhất hoặc không tìm thấy sẽ văng exception
//SingleOrDefault tuơng tự như như Single ngoại trừ không tìm thấy sẽ trả về giá trị mặt định
                }

            }
        }

        private void frmChinhSuaDN_Load(object sender, EventArgs e)
        {
            refresh();

            // XuLuDataGridview();
            //XuLyCombox();
        }

        private void dgvChinhSuaDN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            XuLuDataGridview(e.RowIndex);
        }

        private void btnRemoveDN_Click(object sender, EventArgs e)
        {

        }

        private void Rename()
        {
            dgvChinhSuaDN.Columns[0].HeaderText
                = @"Mã DN";
            dgvChinhSuaDN.Columns[1].HeaderText = "Tên Doanh Nghiệp";
            dgvChinhSuaDN.Columns[2].HeaderText = "Địa Chỉ";
            dgvChinhSuaDN.Columns[3].HeaderText = "Số Điện Thoại";
            dgvChinhSuaDN.Columns[4].HeaderText = "Email";
            dgvChinhSuaDN.Columns[5].HeaderText = "Chủ Doanh Nghiệp";
            dgvChinhSuaDN.Columns[6].HeaderText = "Quận DN";
            dgvChinhSuaDN.Columns[7].HeaderText = "Mã Ngành Nghề";
        }
        private void btnDele_Click(object sender, EventArgs e)
        {
            {

              //  dgvChinhSuaDN.Update();
              //  dgvChinhSuaDN.Refresh();
                var dlt = dgvChinhSuaDN.SelectedRows[0].Cells[0].Value.ToString();
                using (var db1 = new TroGiupViecLamEntities())
                {
                    var data = db1.DoanhNghieps.First(c => c.maDN == dlt);
                    db1.DoanhNghieps.Remove(data);

                    db1.SaveChanges();
                    var query = from b in db1.DoanhNghieps
                                select b;
                    //  foreach (var item in query)
                    //{
                    dgvChinhSuaDN.DataSource = query.ToList();
                    // }
                 //   dgvChinhSuaDN.Columns["NganhNghe"].Visible = false;
                   // dgvChinhSuaDN.Columns["LyLichXinViecs"].Visible = false;
                   refresh();
                    //    }
                    //    dgvChinhSuaDN.Update();
                    //    dgvChinhSuaDN.Refresh();
                    //}
                }

                //private void XuLyTRungCBX()
                //{
                //    //for (int i = 0; i < cbxCSMNN.Items.Count-1; i++)
                //    //{
                //    //    for (int y=i+1;y<cbxCSMNN.Items.Count; y++)
                //    //    {
                //    //        if (cbxCSMNN.Items[i].ToString() == cbxCSMNN.Items[y].ToString())
                //    //        {
                //    //            for (int k = y; k < cbxCSMNN.Items.Count - 1; ++k)
                //    //                cbxCSMNN.Items[k] = cbxCSMNN.Items[k + 1];


                //    //   if (cbxCSMNN != null)
                //    //  {
                //    //      var cbx = (from ab in cbxCSMNN
                //    //                select  ab
                //    //        );
                //    // }
                //    //        }
                //    //    }
                //    //}

                //    //down vote
                //    for (int i = 0; i < cbxCSMNN.Items.Count; i++)
                //    {
                //        for (int y = 0; y < cbxCSMNN.Items.Count; y++)
                //        {
                //            if (y != i && cbxCSMNN.Items[i].ToString() == cbxCSMNN.Items[y].ToString())
                //            {
                //                cbxCSMNN.Items.RemoveAt(i);
                //                break;
                //            }
                //        }
                //    }
            }

            // private void dgvChinhSuaDN_RowEnter(object sender, DataGridViewCellEventArgs e)
            //  {
            //    XuLuDataGridview(e);
            //}6

            //private void XuLyComBobox()
            //{
            //    using (var db1= new TroGiupViecLamEntities())
            //    {
            //        foreach (DoanhNghiep dn1 in db1.DoanhNghieps)
            //        {
            //          //  TreeNode node = new TreeNode(nn.maNN) { Tag = nn.maNN };
            //           // trvDSNN.Nodes.Add(node);
            //           ComboBox cbx = new ComboBox(dn1.maDN) {Tag = dn1.maNN};
            //        }
            //    {

            //}
            //private void cbxCSMNN_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    using (var db1 = new TroGiupViecLamEntities())
            //    {


            //        if (cbxCSMNN.SelectedIndex != 0)
            //        {
            //            string mann = cbxCSMNN.Text;
            //            var query = (from b in db1.DoanhNghieps
            //                where b.maNN == cbxCSMNN.Text
            //                select b.ToString());
            //            //   MessageBox.Show(e.ToString());
            //            dgvChinhSuaDN.DataSource = query.ToString();

            //        }

            //    }
            // }

            //private void XuLyCombox()
            //{
            //    using (var db1 = new TroGiupViecLamEntities())
            //    {
            //        var query2 = (from c in db1.DoanhNghieps
            //            select c.maNN).Distinct();
            //        cbxCSMNN.DataSource = query2.ToList();
            //    }
            //}

            //private void btnRemoveDN_Click(object sender, EventArgs e)
            //{
            //    var dlt = dgvChinhSuaDN.SelectedRows[0].Cells[0].Value.ToString();
            //    using (var db1 = new TroGiupViecLamEntities())
            //    {
            //        var data = db1.DoanhNghieps.First(c => c.maDN == dlt);
            //        db1.DoanhNghieps.Remove(data);

            //        //dgvChinhSuaDN.Update();
            //        //dgvChinhSuaDN.Refresh();
            //        //db1.SaveChanges();

            //    }
            //    dgvChinhSuaDN.Update();
            //    dgvChinhSuaDN.Refresh();
            //}

            //private void XoaDN()
            //{
            //    using (var db1= new TroGiupViecLamEntities())
            //    {
            //        if (dgvChinhSuaDN.SelectedRows.Count != 0)
            //        {
            //            //string ma = v\
            //            //  db1.doanhnghieps.remove()
            //            string ma = Convert.ToString(dgvChinhSuaDN.SelectedCells[0].Value.ToString());
            //            DoanhNghiep dn = db1.DoanhNghieps.Where(p => p.maNN == ma).SingleOrDefault();
            //            db1.DoanhNghieps.Remove(dn);
            //            db1.SaveChanges();
            //            dgvChinhSuaDN.Update();

            //            //dgvchinhsuadn.refresh();

            //        }
            //    }
        }

        private void cbxMaNN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_dn(DoanhNghiep _dn)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                db1.DoanhNghieps.Add(_dn);
                db1.SaveChanges();
            }
        }

        private bool ktTrung(string ma)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                var s = db1.DoanhNghieps.Where(p => p.maDN.Equals(ma)).ToList();
                if (s.Any())
                    return false;
                return true;
            }
        }
        private void btnThemDN_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db1 = new TroGiupViecLamEntities() )
                {
                    if (ktTrung(txtMaDN.Text) == true)
                    {
                        DoanhNghiep dn = new DoanhNghiep();
                        dn.maDN = txtMaDN.Text;
                        dn.tenDN = txtTenDN.Text;
                        dn.diaC = txtDiaChi.Text;
                        dn.soDT = txtPhone.Text;
                        dn.eMail = txtMail.Text;
                        dn.chuDN = txtChuDN.Text;
                        dn.quanDN = txtQuanDN.Text;
                        dn.maNN = cbxMaNN.Text;
                        add_dn(dn);
                        MessageBox.Show("Thêm thành công.");
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại.\n");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Thêm thất bại.\n" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatDN_Click(object sender, EventArgs e)
        {

        }
    }
}
    


