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
    public partial class RegisterForm : Form
    {
        ModuleHandle CauHinh = new ModuleHandle();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cboServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboServerName.DataSource = CauHinh.getServerName();
            cboServerName.DisplayMember = "ServerName";
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = CauHinh.getDatabaseName(cboServerName.Text , txtUserName.Text , txtPassWord.Text);
            cboDatabase.DisplayMember = "DatabaseName";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cboServerName.Text, txtUserName.Text, txtPassWord.Text,cboDatabase.Text);
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }
    }
}
