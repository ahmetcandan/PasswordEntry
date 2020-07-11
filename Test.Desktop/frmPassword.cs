using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordEntry
{
    public partial class frmPassword : Form
    {
        PasswordDTO psw;

        public frmPassword(string appCode)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(appCode))
                psw = Program.DataAccess.Passwords.FirstOrDefault(c => c.ApplicationCode == appCode);
            else
                Close();
        }

        public frmPassword()
        {
            InitializeComponent();
            psw = new PasswordDTO();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            txtAppCode.Text = psw.ApplicationCode;
            txtAppName.Text = psw.ApplicationName;
            txtUserName.Text = psw.UserName;
            txtPassword.Text = psw.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            psw.ApplicationCode = txtAppCode.Text;
            psw.ApplicationName = txtAppName.Text;
            psw.UserName = txtUserName.Text;
            psw.Password = txtPassword.Text;
            if (!Program.DataAccess.Passwords.Any(c => c.ApplicationCode == psw.ApplicationCode))
                Program.DataAccess.Passwords.Add(psw);
            Program.DataAccess.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
