namespace pusshy
{
    partial class frmpusshy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpusshy));
            this.gridHosts = new System.Windows.Forms.DataGridView();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuRightColumnClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRightRowClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridHosts)).BeginInit();
            this.menuRightColumnClick.SuspendLayout();
            this.menuRightRowClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridHosts
            // 
            this.gridHosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host,
            this.login,
            this.pwd,
            this.cert,
            this.descr});
            this.gridHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHosts.Location = new System.Drawing.Point(0, 0);
            this.gridHosts.Name = "gridHosts";
            this.gridHosts.Size = new System.Drawing.Size(584, 81);
            this.gridHosts.TabIndex = 0;
            this.gridHosts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHosts_CellDoubleClick);
            this.gridHosts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridHosts_CellFormatting);
            this.gridHosts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridHosts_EditingControlShowing);
            this.gridHosts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridHosts_MouseDown);
            // 
            // host
            // 
            this.host.HeaderText = "HOST";
            this.host.Name = "host";
            // 
            // login
            // 
            this.login.HeaderText = "LOGIN";
            this.login.Name = "login";
            // 
            // pwd
            // 
            this.pwd.HeaderText = "PWD";
            this.pwd.Name = "pwd";
            this.pwd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cert
            // 
            this.cert.HeaderText = "CERT";
            this.cert.Name = "cert";
            // 
            // descr
            // 
            this.descr.HeaderText = "DESCR";
            this.descr.Name = "descr";
            // 
            // menuRightColumnClick
            // 
            this.menuRightColumnClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showAllToolStripMenuItem});
            this.menuRightColumnClick.Name = "menuRightClick";
            this.menuRightColumnClick.Size = new System.Drawing.Size(121, 54);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // menuRightRowClick
            // 
            this.menuRightRowClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.menuRightRowClick.Name = "menuRightRowClick";
            this.menuRightRowClick.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmpusshy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 81);
            this.Controls.Add(this.gridHosts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmpusshy";
            this.Text = "pusshy v0.1 - K.Andreev 03/2019";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmpusshy_FormClosed);
            this.Load += new System.EventHandler(this.frmpusshy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHosts)).EndInit();
            this.menuRightColumnClick.ResumeLayout(false);
            this.menuRightRowClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHosts;
        private System.Windows.Forms.ContextMenuStrip menuRightColumnClick;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cert;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.ContextMenuStrip menuRightRowClick;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
    }
}

