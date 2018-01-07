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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(@"Bạn có muốn thoát", @"Thông báo.", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == @"user" && txtPass.Text.Trim() == @"123")
            {
                var frmMai = new frmMain();
                this.Hide();
                frmMai.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show(@"Bạn nhập sai vui lòng nhập lại");
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

