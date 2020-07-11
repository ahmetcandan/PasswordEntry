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
    public partial class frmPasswords : Form
    {
        public frmPasswords()
        {
            InitializeComponent();
        }

        private void lvPasswords_DoubleClick(object sender, EventArgs e)
        {
            if (lvPasswords.SelectedItems.Count == 1)
            {
                string appCode = lvPasswords.SelectedItems[0].Text;
                frmPassword frm = new frmPassword(appCode);
                frm.ShowDialog();
                refreshList();
            }
        }

        private void frmPasswords_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            lvPasswords.Items.Clear();
            foreach (var psw in Program.DataAccess.Passwords)
            {
                var li = new ListViewItem();
                li.Text = psw.ApplicationCode;
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "ApplicationName",
                    Text = psw.ApplicationName
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "UserName",
                    Text = psw.UserName
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "Password",
                    Text = "########"
                });
                lvPasswords.Items.Add(li);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.ShowDialog();
            refreshList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvPasswords_DoubleClick(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            editToolStripMenuItem.Enabled = lvPasswords.SelectedItems.Count == 1;
        }
    }
}
