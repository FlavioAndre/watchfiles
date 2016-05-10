namespace filesWatches
{
    partial class frmPrincipal
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
                this.notifyIconMonitor.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.grpBoxLog = new System.Windows.Forms.GroupBox();
            this.mnuMonitor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMonitor = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpBoxLog.SuspendLayout();
            this.mnuMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(637, 330);
            this.txtLog.TabIndex = 0;
            // 
            // grpBoxLog
            // 
            this.grpBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxLog.Controls.Add(this.txtLog);
            this.grpBoxLog.Location = new System.Drawing.Point(5, 12);
            this.grpBoxLog.Name = "grpBoxLog";
            this.grpBoxLog.Size = new System.Drawing.Size(649, 355);
            this.grpBoxLog.TabIndex = 1;
            this.grpBoxLog.TabStop = false;
            this.grpBoxLog.Text = "Log de eventos";
            // 
            // mnuMonitor
            // 
            this.mnuMonitor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.toolStripSeparator2,
            this.mnuShow,
            this.mnuHide,
            this.toolStripSeparator1,
            this.mnuSair});
            this.mnuMonitor.Name = "mnuMonitor";
            this.mnuMonitor.Size = new System.Drawing.Size(153, 148);
            this.mnuMonitor.Text = "Monitoramento de arquivos";
            // 
            // mnuStart
            // 
            this.mnuStart.Checked = true;
            this.mnuStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(152, 22);
            this.mnuStart.Text = "Start";
            this.mnuStart.ToolTipText = "Iniciar o monitoramento dos arquivos";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(152, 22);
            this.mnuStop.Text = "Stop";
            this.mnuStop.ToolTipText = "Parar o monitoramento dos arquivos";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(152, 22);
            this.mnuShow.Text = "Show";
            this.mnuShow.ToolTipText = "Mostrar o formulário do monitoramento";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuHide
            // 
            this.mnuHide.Checked = true;
            this.mnuHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuHide.Name = "mnuHide";
            this.mnuHide.Size = new System.Drawing.Size(152, 22);
            this.mnuHide.Text = "Hide";
            this.mnuHide.ToolTipText = "Esconder formulário do monitoramento";
            this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(152, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.ToolTipText = "Sair da Aplicação de monitoramento de arquivos";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // notifyIconMonitor
            // 
            this.notifyIconMonitor.BalloonTipTitle = "Monitoramento";
            this.notifyIconMonitor.ContextMenuStrip = this.mnuMonitor;
            this.notifyIconMonitor.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMonitor.Icon")));
            this.notifyIconMonitor.Text = "Monitoramento de arquivos";
            this.notifyIconMonitor.Visible = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 379);
            this.Controls.Add(this.grpBoxLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Monitoramento de arquivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Shown += new System.EventHandler(this.mnuHide_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.grpBoxLog.ResumeLayout(false);
            this.grpBoxLog.PerformLayout();
            this.mnuMonitor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox grpBoxLog;
        private System.Windows.Forms.ContextMenuStrip mnuMonitor;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.NotifyIcon notifyIconMonitor;
    }
}

