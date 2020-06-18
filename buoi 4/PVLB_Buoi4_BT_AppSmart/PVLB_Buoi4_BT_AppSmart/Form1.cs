using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVLB_Buoi4_BT_AppSmart
{
    public partial class Form1 : Form
    {
        ModuleHandle CauHinh = new ModuleHandle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTK.Text.Trim()))
            {
                MessageBox.Show("Khoong duoc bo trong "+ lbTK.Text.ToLower());
                this.txtTK.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMK.Text))
            {
                MessageBox.Show("Khoong duoc bo trong " + lbTK.Text.ToLower());
                this.txtMK.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
                ProcessConfig();
            if (kq == 1)
            {
                MessageBox.Show("Chuoi cau hinh khong ton tai");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuoi cau hinh khong phu hop");
                ProcessConfig();
            }
        }
        public void ProcessConfig()
        {
            int result;
            result = CauHinh.Check_User(txtTK.Text, txtMK.Text);
            if (result == 1)
            {
                MessageBox.Show("Sai" + lbTK.Text + " Hoac " + lbMK.Text);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Tai Khoan Bi Khoa");
                return;
            }
            if (Program.homeMainForm == null || Program.homeMainForm.IsDisposed)
                Program.homeMainForm = new HomeForm();
            this.Visible = false;
            Program.homeMainForm.Show();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (Program.registerForm == null || Program.registerForm.IsDisposed)
                Program.registerForm = new RegisterForm();
            this.Visible = false;
            Program.registerForm.Show();
        }
    }
}
