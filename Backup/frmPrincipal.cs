using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filesWatches
{
    public partial class frmPrincipal : Form
    {
        private FileSystemWatcher monitor= null;
        private String sPathVaudis = "D:\\vaudis";
        private String sPathBackup = "";
        public frmPrincipal()
        {
            InitializeComponent();

            this.formataCaminho();
            this.criaDiretorioHoje();
            CheckForIllegalCrossThreadCalls = false;

            // Criar o object FileSystemoFileSystemWatcher e configurar suas propriedades

            monitor = new FileSystemWatcher();
            monitor.Path = sPathVaudis;

            monitor.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.CreationTime | NotifyFilters.LastWrite | NotifyFilters.Size;
            monitor.Filter = "*.*";

            // Adicionar os manipuladores de evento.
            
            monitor.Changed += new FileSystemEventHandler(onChanged);

            // Iniciar a monitoracao.
            monitor.IncludeSubdirectories = true;     // Monitora subdiretorios
            monitor.EnableRaisingEvents = true;
            
            

        }
        private  void onChanged(object sender, FileSystemEventArgs e)
        {
            String sExtension = Path.GetExtension(e.FullPath).ToLower();
            if (sExtension.Equals(".cpp") || sExtension.Equals(".h") || sExtension.Equals(".cs"))
            {
                String nomeArquivoFullPath = "";
                String nomeArquivo = Path.GetFileName(e.Name);
                String nomeDiretorio = Path.GetDirectoryName(e.Name);
                String caminhoArquivo = String.Format("{0}\\{1}", this.sPathBackup, nomeDiretorio);

                nomeArquivoFullPath = String.Format("{0}\\{1:HHmmss}_{2}", caminhoArquivo, File.GetLastWriteTime(e.FullPath), nomeArquivo);
                try
                {
                    if (!Directory.Exists(caminhoArquivo))
                    {
                        Directory.CreateDirectory(caminhoArquivo);
                    }
                    File.Copy(e.FullPath, nomeArquivoFullPath);
                    this.txtLog.Text += "Arquivo alterado: " + e.FullPath + " - " + " Evento : " + e.ChangeType + "" + Environment.NewLine + "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error ao copiar arquivo: " + ex.Message.ToString());
                }

            }
        }

   
        void formataCaminho()
        {
            this.sPathBackup = String.Format("{0}{1:yyyyMMdd}", "D:\\Profiles\\Backup\\",DateTime.Now);
        }


        void criaDiretorioHoje()        {

            if (this.sPathBackup == "")
                return;
            try
            {
                if (!Directory.Exists(this.sPathBackup))
                {
                    Directory.CreateDirectory(this.sPathBackup);
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            this.monitor.EnableRaisingEvents = true;
            this.mnuStart.Checked = true;
            this.mnuStart.CheckState = System.Windows.Forms.CheckState.Checked;

            this.mnuStop.Checked = false;
            this.mnuStop.CheckState = System.Windows.Forms.CheckState.Unchecked;

            this.txtLog.Text += "Start monitoramento... " + Environment.NewLine + "";

        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            this.monitor.EnableRaisingEvents = false;

            this.mnuStop.Checked = true;
            this.mnuStop.CheckState = System.Windows.Forms.CheckState.Checked;

            this.mnuStart.Checked = false;
            this.mnuStart.CheckState = System.Windows.Forms.CheckState.Unchecked;
            
            this.txtLog.Text += "Stop monitoramento... " + Environment.NewLine + "";
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.mnuShow.Checked = true;
            this.mnuShow.CheckState = System.Windows.Forms.CheckState.Checked;

            this.mnuHide.Checked = false;
            this.mnuHide.CheckState = System.Windows.Forms.CheckState.Unchecked;

            this.txtLog.Text += "Show form de monitoramento... " + Environment.NewLine + "";
        }

        private void mnuHide_Click(object sender, EventArgs e)
        {
            Hide();

            this.mnuHide.Checked = true;
            this.mnuHide.CheckState = System.Windows.Forms.CheckState.Checked;

            this.mnuShow.Checked = false;
            this.mnuShow.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.txtLog.Text += "Hide form de monitoramento... " + Environment.NewLine + "";
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fehcar a aplicação?", "Monitoramento",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}