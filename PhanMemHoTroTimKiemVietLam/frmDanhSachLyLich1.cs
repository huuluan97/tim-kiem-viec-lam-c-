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
    public partial class frmDanhSachLyLich1 : Form
    {
        public frmDanhSachLyLich1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

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
        private void frmDanhSachLyLich1_Load(object sender, EventArgs e)
        {

        }
    }
}
