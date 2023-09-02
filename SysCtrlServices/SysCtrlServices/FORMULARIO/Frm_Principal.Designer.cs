namespace SysCtrlServices
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mstrip_Principal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm_Principal = new System.Windows.Forms.Timer(this.components);
            this.pbox_Principal = new System.Windows.Forms.PictureBox();
            this.mstrip_Principal.SuspendLayout();
            this.sstrip_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // mstrip_Principal
            // 
            this.mstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.agendamentoToolStripMenuItem1,
            this.equipeToolStripMenuItem1,
            this.serviçoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.mstrip_Principal.Name = "mstrip_Principal";
            this.mstrip_Principal.Size = new System.Drawing.Size(1218, 24);
            this.mstrip_Principal.TabIndex = 0;
            this.mstrip_Principal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.funcionárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem1
            // 
            this.agendamentoToolStripMenuItem1.Name = "agendamentoToolStripMenuItem1";
            this.agendamentoToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.agendamentoToolStripMenuItem1.Text = "Agendamento";
            // 
            // equipeToolStripMenuItem1
            // 
            this.equipeToolStripMenuItem1.Name = "equipeToolStripMenuItem1";
            this.equipeToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.equipeToolStripMenuItem1.Text = "Equipe";
            this.equipeToolStripMenuItem1.Click += new System.EventHandler(this.equipeToolStripMenuItem1_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sstrip_Principal
            // 
            this.sstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel1,
            this.tsslb_Data,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tsslb_Hora,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel5,
            this.tsslb_Usuario,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel8});
            this.sstrip_Principal.Location = new System.Drawing.Point(0, 253);
            this.sstrip_Principal.Name = "sstrip_Principal";
            this.sstrip_Principal.Size = new System.Drawing.Size(1218, 22);
            this.sstrip_Principal.TabIndex = 1;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(80, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "Data:";
            // 
            // tsslb_Data
            // 
            this.tsslb_Data.AutoSize = false;
            this.tsslb_Data.Name = "tsslb_Data";
            this.tsslb_Data.Size = new System.Drawing.Size(70, 17);
            this.tsslb_Data.Text = "__/__/____";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // tsslb_Hora
            // 
            this.tsslb_Hora.AutoSize = false;
            this.tsslb_Hora.Name = "tsslb_Hora";
            this.tsslb_Hora.Size = new System.Drawing.Size(70, 17);
            this.tsslb_Hora.Text = "__:__:____";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.AutoSize = false;
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel5.Text = "Usuário:";
            // 
            // tsslb_Usuario
            // 
            this.tsslb_Usuario.AutoSize = false;
            this.tsslb_Usuario.Name = "tsslb_Usuario";
            this.tsslb_Usuario.Size = new System.Drawing.Size(70, 17);
            this.tsslb_Usuario.Text = "Anônimo";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.AutoSize = false;
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(264, 17);
            this.toolStripStatusLabel7.Text = "Sistema de Controle de Serviços - SysCtrlServices";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel8.Text = "Creator: gAzarias_Lima";
            // 
            // tm_Principal
            // 
            this.tm_Principal.Enabled = true;
            this.tm_Principal.Tick += new System.EventHandler(this.tm_Principal_Tick);
            // 
            // pbox_Principal
            // 
            this.pbox_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_Principal.Image = global::SysCtrlServices.Properties.Resources.ImagemFrmPrincipal;
            this.pbox_Principal.Location = new System.Drawing.Point(0, 24);
            this.pbox_Principal.Name = "pbox_Principal";
            this.pbox_Principal.Size = new System.Drawing.Size(1218, 229);
            this.pbox_Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Principal.TabIndex = 2;
            this.pbox_Principal.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 275);
            this.Controls.Add(this.pbox_Principal);
            this.Controls.Add(this.sstrip_Principal);
            this.Controls.Add(this.mstrip_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mstrip_Principal;
            this.Name = "Frm_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstrip_Principal.ResumeLayout(false);
            this.mstrip_Principal.PerformLayout();
            this.sstrip_Principal.ResumeLayout(false);
            this.sstrip_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrip_Principal;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Usuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.PictureBox pbox_Principal;
        private System.Windows.Forms.Timer tm_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equipeToolStripMenuItem1;
    }
}

