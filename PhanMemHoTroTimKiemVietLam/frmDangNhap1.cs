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
    public partial class frmDangNhap1 : Form
    {
        public frmDangNhap1()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            using (var db1 = new TroGiupViecLamEntities())
            {
                //string s = txtTaiKhoan.Text.Trim();
                //var query = (from c in db1.TAIKHOANs
                //    select c.tenTK);
                //if (txtTaiKhoan.Text.Trim() == query.ToString())
                //{
                //    MessageBox.Show(@"Đăng nhập thành công.");
                //    var frmMai = new frmMain();
                //    this.Hide();
                //    frmMai.ShowDialog();
                //    this.Show();

                //}
                // try
                // {
                bool a = false;
                foreach (var user in db1.TAIKHOANs)
                    {
                    
                    if (user.tenTK.Replace(" ", "") == txtTaiKhoan.Text && user.passTK.Replace(" ", "") == txtMatKhau.Text)
                        {
                           MessageBox.Show("Đăng nhập thành công.");
                            var frmMai = new frmMain();
                            this.Hide();
                            frmMai.ShowDialog();
                            this.Show();
                        return;
                        }

                   
                    // }
                    // }
                    // catch (Exception ex)
                    //{

                    //   MessageBox.Show("Đăng nhập thất bại.\n" + ex.Message );
                }
                if (!a)
                {
                    MessageBox.Show("Bạn nhập sai hoặc chưa đăng ký tài khoản");
                }

           
               
            }
        }

        private void btnDkTK_Click(object sender, EventArgs e)
        {
           var frmDK = new frmDKTK();
            this.Hide();
            frmDK.ShowDialog();
            this.Show();
        }

        private void frmDangNhap1_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(@"Bạn có muốn thoát", @"Thông báo.", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmDK = new frmDKTK();
            this.Hide();
            frmDK.ShowDialog();
            this.Show();
        }
    }
}
