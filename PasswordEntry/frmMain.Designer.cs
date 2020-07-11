namespace PasswordEntry
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbApplication = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passwordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntry = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAppList = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "m.sn";
            // 
            // cbApplication
            // 
            this.cbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplication.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApplication.FormattingEnabled = true;
            this.cbApplication.Location = new System.Drawing.Point(12, 81);
            this.cbApplication.Name = "cbApplication";
            this.cbApplication.Size = new System.Drawing.Size(216, 24);
            this.cbApplication.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 26);
            // 
            // passwordsToolStripMenuItem
            // 
            this.passwordsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordsToolStripMenuItem.Name = "passwordsToolStripMenuItem";
            this.passwordsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.passwordsToolStripMenuItem.Text = "Passwords";
            this.passwordsToolStripMenuItem.Click += new System.EventHandler(this.passwordsToolStripMenuItem_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEntry.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnEntry.Location = new System.Drawing.Point(12, 10);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(98, 29);
            this.btnEntry.TabIndex = 5;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.BackColor = System.Drawing.Color.Black;
            this.txtInterval.Font = new System.Drawing.Font("Hermit", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterval.ForeColor = System.Drawing.Color.Lime;
            this.txtInterval.Location = new System.Drawing.Point(12, 47);
            this.txtInterval.MaxLength = 5;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(58, 26);
            this.txtInterval.TabIndex = 6;
            this.txtInterval.Text = "1000";
            this.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.menuNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Password Entry";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuNotify
            // 
            this.menuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.menuAppList,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuNotify.Name = "menuNotify";
            this.menuNotify.Size = new System.Drawing.Size(182, 103);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // menuAppList
            // 
            this.menuAppList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuAppList.Name = "menuAppList";
            this.menuAppList.Size = new System.Drawing.Size(121, 23);
            this.menuAppList.SelectedIndexChanged += new System.EventHandler(this.menuAppList_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(248, 129);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.cbApplication);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(264, 168);
            this.MinimumSize = new System.Drawing.Size(264, 168);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbApplication;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem passwordsToolStripMenuItem;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip menuNotify;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox menuAppList;
    }
}

