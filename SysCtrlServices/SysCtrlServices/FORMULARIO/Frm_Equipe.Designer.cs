namespace SysCtrlServices
{
    partial class Frm_Equipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Equipe));
            this.pnl_Detalhes = new System.Windows.Forms.Panel();
            this.btn_IncluirList = new System.Windows.Forms.Button();
            this.btn_ExcluirList = new System.Windows.Forms.Button();
            this.lview_ItemEquipe = new System.Windows.Forms.ListView();
            this.lb_Nm_Funcionario = new System.Windows.Forms.Label();
            this.btn_Funcionario = new System.Windows.Forms.Button();
            this.tbox_Cod_Funcionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Carg_ItemEquipe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Desc_Equipe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_Nm_Equipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Cod_Equipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_Equipes = new System.Windows.Forms.ListBox();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.pnl_Detalhes.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detalhes
            // 
            this.pnl_Detalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_Detalhes.Controls.Add(this.btn_IncluirList);
            this.pnl_Detalhes.Controls.Add(this.btn_ExcluirList);
            this.pnl_Detalhes.Controls.Add(this.lview_ItemEquipe);
            this.pnl_Detalhes.Controls.Add(this.lb_Nm_Funcionario);
            this.pnl_Detalhes.Controls.Add(this.btn_Funcionario);
            this.pnl_Detalhes.Controls.Add(this.tbox_Cod_Funcionario);
            this.pnl_Detalhes.Controls.Add(this.label5);
            this.pnl_Detalhes.Controls.Add(this.tbox_Carg_ItemEquipe);
            this.pnl_Detalhes.Controls.Add(this.label4);
            this.pnl_Detalhes.Controls.Add(this.tbox_Desc_Equipe);
            this.pnl_Detalhes.Controls.Add(this.label3);
            this.pnl_Detalhes.Controls.Add(this.tbox_Nm_Equipe);
            this.pnl_Detalhes.Controls.Add(this.label2);
            this.pnl_Detalhes.Controls.Add(this.tbox_Cod_Equipe);
            this.pnl_Detalhes.Controls.Add(this.label1);
            this.pnl_Detalhes.Controls.Add(this.lbox_Equipes);
            this.pnl_Detalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhes.Location = new System.Drawing.Point(0, 44);
            this.pnl_Detalhes.Name = "pnl_Detalhes";
            this.pnl_Detalhes.Size = new System.Drawing.Size(706, 525);
            this.pnl_Detalhes.TabIndex = 9;
            // 
            // btn_IncluirList
            // 
            this.btn_IncluirList.FlatAppearance.BorderSize = 0;
            this.btn_IncluirList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IncluirList.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncluirList.Image")));
            this.btn_IncluirList.Location = new System.Drawing.Point(575, 307);
            this.btn_IncluirList.Name = "btn_IncluirList";
            this.btn_IncluirList.Size = new System.Drawing.Size(35, 35);
            this.btn_IncluirList.TabIndex = 61;
            this.btn_IncluirList.UseVisualStyleBackColor = true;
            this.btn_IncluirList.Click += new System.EventHandler(this.btn_IncluirList_Click);
            // 
            // btn_ExcluirList
            // 
            this.btn_ExcluirList.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirList.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirList.Image")));
            this.btn_ExcluirList.Location = new System.Drawing.Point(625, 307);
            this.btn_ExcluirList.Name = "btn_ExcluirList";
            this.btn_ExcluirList.Size = new System.Drawing.Size(35, 35);
            this.btn_ExcluirList.TabIndex = 60;
            this.btn_ExcluirList.UseVisualStyleBackColor = true;
            this.btn_ExcluirList.Click += new System.EventHandler(this.btn_ExcluirList_Click);
            // 
            // lview_ItemEquipe
            // 
            this.lview_ItemEquipe.HideSelection = false;
            this.lview_ItemEquipe.Location = new System.Drawing.Point(174, 346);
            this.lview_ItemEquipe.Name = "lview_ItemEquipe";
            this.lview_ItemEquipe.Size = new System.Drawing.Size(486, 148);
            this.lview_ItemEquipe.TabIndex = 59;
            this.lview_ItemEquipe.UseCompatibleStateImageBehavior = false;
            // 
            // lb_Nm_Funcionario
            // 
            this.lb_Nm_Funcionario.BackColor = System.Drawing.Color.White;
            this.lb_Nm_Funcionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Nm_Funcionario.Location = new System.Drawing.Point(411, 315);
            this.lb_Nm_Funcionario.Name = "lb_Nm_Funcionario";
            this.lb_Nm_Funcionario.Size = new System.Drawing.Size(140, 18);
            this.lb_Nm_Funcionario.TabIndex = 58;
            this.lb_Nm_Funcionario.Tag = "1";
            // 
            // btn_Funcionario
            // 
            this.btn_Funcionario.FlatAppearance.BorderSize = 0;
            this.btn_Funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Funcionario.Image = ((System.Drawing.Image)(resources.GetObject("btn_Funcionario.Image")));
            this.btn_Funcionario.Location = new System.Drawing.Point(376, 310);
            this.btn_Funcionario.Name = "btn_Funcionario";
            this.btn_Funcionario.Size = new System.Drawing.Size(29, 29);
            this.btn_Funcionario.TabIndex = 57;
            this.btn_Funcionario.UseVisualStyleBackColor = true;
            this.btn_Funcionario.Click += new System.EventHandler(this.btn_Funcionario_Click);
            // 
            // tbox_Cod_Funcionario
            // 
            this.tbox_Cod_Funcionario.Location = new System.Drawing.Point(312, 314);
            this.tbox_Cod_Funcionario.Name = "tbox_Cod_Funcionario";
            this.tbox_Cod_Funcionario.Size = new System.Drawing.Size(39, 20);
            this.tbox_Cod_Funcionario.TabIndex = 14;
            this.tbox_Cod_Funcionario.Leave += new System.EventHandler(this.tbox_Cod_Funcionario_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Funcionário";
            // 
            // tbox_Carg_ItemEquipe
            // 
            this.tbox_Carg_ItemEquipe.Location = new System.Drawing.Point(174, 314);
            this.tbox_Carg_ItemEquipe.Name = "tbox_Carg_ItemEquipe";
            this.tbox_Carg_ItemEquipe.Size = new System.Drawing.Size(105, 20);
            this.tbox_Carg_ItemEquipe.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cargo";
            // 
            // tbox_Desc_Equipe
            // 
            this.tbox_Desc_Equipe.Location = new System.Drawing.Point(174, 144);
            this.tbox_Desc_Equipe.Multiline = true;
            this.tbox_Desc_Equipe.Name = "tbox_Desc_Equipe";
            this.tbox_Desc_Equipe.Size = new System.Drawing.Size(486, 111);
            this.tbox_Desc_Equipe.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição";
            // 
            // tbox_Nm_Equipe
            // 
            this.tbox_Nm_Equipe.Location = new System.Drawing.Point(174, 95);
            this.tbox_Nm_Equipe.Name = "tbox_Nm_Equipe";
            this.tbox_Nm_Equipe.Size = new System.Drawing.Size(280, 20);
            this.tbox_Nm_Equipe.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da Equipe";
            // 
            // tbox_Cod_Equipe
            // 
            this.tbox_Cod_Equipe.Enabled = false;
            this.tbox_Cod_Equipe.Location = new System.Drawing.Point(174, 47);
            this.tbox_Cod_Equipe.Name = "tbox_Cod_Equipe";
            this.tbox_Cod_Equipe.Size = new System.Drawing.Size(42, 20);
            this.tbox_Cod_Equipe.TabIndex = 6;
            this.tbox_Cod_Equipe.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // lbox_Equipes
            // 
            this.lbox_Equipes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbox_Equipes.FormattingEnabled = true;
            this.lbox_Equipes.Location = new System.Drawing.Point(0, 0);
            this.lbox_Equipes.Name = "lbox_Equipes";
            this.lbox_Equipes.Size = new System.Drawing.Size(120, 525);
            this.lbox_Equipes.TabIndex = 4;
            this.lbox_Equipes.Click += new System.EventHandler(this.lbox_Equipes_Click);
            // 
            // pnl_Botoes
            // 
            this.pnl_Botoes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_Botoes.Controls.Add(this.btn_Cancelar);
            this.pnl_Botoes.Controls.Add(this.btn_Confirmar);
            this.pnl_Botoes.Controls.Add(this.btn_Excluir);
            this.pnl_Botoes.Controls.Add(this.btn_Alterar);
            this.pnl_Botoes.Controls.Add(this.btn_Novo);
            this.pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 569);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(706, 51);
            this.pnl_Botoes.TabIndex = 8;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(602, 16);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Location = new System.Drawing.Point(521, 16);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(174, 16);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.btn_Alterar.Location = new System.Drawing.Point(93, 16);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.White;
            this.btn_Novo.Location = new System.Drawing.Point(12, 16);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_Titulo.Controls.Add(this.lb_Titulo);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(706, 44);
            this.pnl_Titulo.TabIndex = 7;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lb_Titulo.ForeColor = System.Drawing.Color.White;
            this.lb_Titulo.Location = new System.Drawing.Point(257, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(197, 26);
            this.lb_Titulo.TabIndex = 4;
            this.lb_Titulo.Text = "Cadastrar Equipe";
            // 
            // Frm_Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 620);
            this.Controls.Add(this.pnl_Detalhes);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Equipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Detalhes.ResumeLayout(false);
            this.pnl_Detalhes.PerformLayout();
            this.pnl_Botoes.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detalhes;
        private System.Windows.Forms.Button btn_IncluirList;
        private System.Windows.Forms.Button btn_ExcluirList;
        private System.Windows.Forms.ListView lview_ItemEquipe;
        private System.Windows.Forms.Label lb_Nm_Funcionario;
        private System.Windows.Forms.Button btn_Funcionario;
        private System.Windows.Forms.TextBox tbox_Cod_Funcionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Carg_ItemEquipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_Desc_Equipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_Nm_Equipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Cod_Equipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_Equipes;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label lb_Titulo;
    }
}