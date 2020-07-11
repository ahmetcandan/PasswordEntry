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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PasswordDTO password = (PasswordDTO)cbApplication.SelectedItem;
            StringSendKeys(password.UserName);
            SendKeys.Send("{TAB}");
            StringSendKeys(password.Password);
            SendKeys.Send("{ENTER}");
            timer1.Stop();
        }

        private void StringSendKeys(string data)
        {
            foreach (var c in data)
            {
                switch (c)
                {
                    case '+':
                        SendKeys.Send("{+}");
                        break;
                    case '{':
                        SendKeys.Send("{{}");
                        break;
                    case '}':
                        SendKeys.Send("{}}");
                        break;
                    default:
                        SendKeys.Send(c.ToString());
                        break;
                }
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.DataAccess = new DataAccess();
            refreshComboApplication();
        }

        private void refreshComboApplication()
        {
            cbApplication.Items.Clear();
            menuAppList.Items.Clear();
            foreach (var item in Program.DataAccess.Passwords)
            {
                cbApplication.Items.Add(item);
                menuAppList.Items.Add(item);
            }
        }

        private void passwordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasswords frm = new frmPasswords();
            frm.ShowDialog();
            refreshComboApplication();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int interval = 1000;
            if (int.TryParse(txtInterval.Text, out interval))
            {
                if (cbApplication.Text.Length > 0)
                {
                    timer1.Interval = interval;
                    timer1.Start();
                }
                else
                    errorProvider1.SetError(cbApplication, "Choose a value.");
            }
            else
                errorProvider1.SetError(txtInterval, "Enter a numerical value.");
        }

        bool exit = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = true;
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exit)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void menuAppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbApplication.SelectedItem = menuAppList.SelectedItem;
            btnEntry_Click(sender, e);
        }
    }
}
