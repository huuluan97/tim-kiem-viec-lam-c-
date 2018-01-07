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
    public partial class frmDKTK : Form
    {
        public frmDKTK()
        {
            InitializeComponent();
        }

        private void taoTK(TAIKHOAN _tk)
        {
            using (var db1 = new TroGiupViecLamEntities() )
            {
                db1.TAIKHOANs.Add(_tk);
                db1.SaveChanges();
            }
        }
        private void frmDKTK_Load(object sender, EventArgs e)
        {

        }

        private bool ktTrung(string tentk)
        {
            using (var db1 = new TroGiupViecLamEntities())
            {
                var s = db1.TAIKHOANs.Where(p => p.tenTK.Equals(tentk)).ToList();
                if (s.Any())
                    return false;
                return true;
            }
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            bool a = false;
           
                using (var db1 = new TroGiupViecLamEntities())
                {
                    if (ktTrung(txtTenTK.Text) == true)
                    {
                        TAIKHOAN tk = new TAIKHOAN();
                        tk.tenTK = txtTenTK.Text;
                        tk.passTK = txtMatKhau.Text;
                        taoTK(tk);
                        MessageBox.Show("Đăng kí thành công.");
                        txtTenTK.Clear();
                        txtMatKhau.Clear();
                    }
              

            }
           
           
           
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("" + "cc");
        }
    }
}
