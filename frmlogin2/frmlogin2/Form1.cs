using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmlogin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtpassword.Text;
            if(user =="" || pass == "")
            {
                MessageBox.Show("tên đăng nhập và mật khẩu không đuọc để trống");
            }else if( user=="admin" && pass == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                frmHome frmhome = new  frmHome();
                frmhome.ShowDialog();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
