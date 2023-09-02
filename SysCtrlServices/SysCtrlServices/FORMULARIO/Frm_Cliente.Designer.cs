﻿namespace SysCtrlServices
{
    partial class Frm_Cliente
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
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Detalhes = new System.Windows.Forms.Panel();
            this.tbox_End_Cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_Bai_Cliente = new System.Windows.Forms.TextBox();
            this.tbox_Cid_Cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_Cel_Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_Nm_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Cod_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_Clientes = new System.Windows.Forms.ListBox();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.pnl_Detalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_Titulo.Controls.Add(this.lb_Titulo);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(489, 44);
            this.pnl_Titulo.TabIndex = 1;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lb_Titulo.ForeColor = System.Drawing.Color.White;
            this.lb_Titulo.Location = new System.Drawing.Point(145, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(198, 26);
            this.lb_Titulo.TabIndex = 4;
            this.lb_Titulo.Text = "Cadastrar Cliente";
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
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 388);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(489, 51);
            this.pnl_Botoes.TabIndex = 2;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(402, 16);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(321, 16);
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
            // pnl_Detalhes
            // 
            this.pnl_Detalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_Detalhes.Controls.Add(this.tbox_End_Cliente);
            this.pnl_Detalhes.Controls.Add(this.label6);
            this.pnl_Detalhes.Controls.Add(this.tbox_Bai_Cliente);
            this.pnl_Detalhes.Controls.Add(this.tbox_Cid_Cliente);
            this.pnl_Detalhes.Controls.Add(this.label5);
            this.pnl_Detalhes.Controls.Add(this.label4);
            this.pnl_Detalhes.Controls.Add(this.tbox_Cel_Cliente);
            this.pnl_Detalhes.Controls.Add(this.label3);
            this.pnl_Detalhes.Controls.Add(this.tbox_Nm_Cliente);
            this.pnl_Detalhes.Controls.Add(this.label2);
            this.pnl_Detalhes.Controls.Add(this.tbox_Cod_Cliente);
            this.pnl_Detalhes.Controls.Add(this.label1);
            this.pnl_Detalhes.Controls.Add(this.lbox_Clientes);
            this.pnl_Detalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhes.Location = new System.Drawing.Point(0, 44);
            this.pnl_Detalhes.Name = "pnl_Detalhes";
            this.pnl_Detalhes.Size = new System.Drawing.Size(489, 344);
            this.pnl_Detalhes.TabIndex = 3;
            // 
            // tbox_End_Cliente
            // 
            this.tbox_End_Cliente.Location = new System.Drawing.Point(174, 294);
            this.tbox_End_Cliente.Name = "tbox_End_Cliente";
            this.tbox_End_Cliente.Size = new System.Drawing.Size(261, 20);
            this.tbox_End_Cliente.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Endereço";
            // 
            // tbox_Bai_Cliente
            // 
            this.tbox_Bai_Cliente.Location = new System.Drawing.Point(174, 244);
            this.tbox_Bai_Cliente.Name = "tbox_Bai_Cliente";
            this.tbox_Bai_Cliente.Size = new System.Drawing.Size(261, 20);
            this.tbox_Bai_Cliente.TabIndex = 14;
            // 
            // tbox_Cid_Cliente
            // 
            this.tbox_Cid_Cliente.Location = new System.Drawing.Point(174, 194);
            this.tbox_Cid_Cliente.Name = "tbox_Cid_Cliente";
            this.tbox_Cid_Cliente.Size = new System.Drawing.Size(261, 20);
            this.tbox_Cid_Cliente.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cidade";
            // 
            // tbox_Cel_Cliente
            // 
            this.tbox_Cel_Cliente.Location = new System.Drawing.Point(174, 144);
            this.tbox_Cel_Cliente.Name = "tbox_Cel_Cliente";
            this.tbox_Cel_Cliente.Size = new System.Drawing.Size(261, 20);
            this.tbox_Cel_Cliente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Celular";
            // 
            // tbox_Nm_Cliente
            // 
            this.tbox_Nm_Cliente.Location = new System.Drawing.Point(174, 95);
            this.tbox_Nm_Cliente.Name = "tbox_Nm_Cliente";
            this.tbox_Nm_Cliente.Size = new System.Drawing.Size(261, 20);
            this.tbox_Nm_Cliente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // tbox_Cod_Cliente
            // 
            this.tbox_Cod_Cliente.Enabled = false;
            this.tbox_Cod_Cliente.Location = new System.Drawing.Point(174, 47);
            this.tbox_Cod_Cliente.Name = "tbox_Cod_Cliente";
            this.tbox_Cod_Cliente.Size = new System.Drawing.Size(42, 20);
            this.tbox_Cod_Cliente.TabIndex = 6;
            this.tbox_Cod_Cliente.Tag = "1";
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
            // lbox_Clientes
            // 
            this.lbox_Clientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbox_Clientes.FormattingEnabled = true;
            this.lbox_Clientes.Location = new System.Drawing.Point(0, 0);
            this.lbox_Clientes.Name = "lbox_Clientes";
            this.lbox_Clientes.Size = new System.Drawing.Size(120, 344);
            this.lbox_Clientes.TabIndex = 4;
            this.lbox_Clientes.Click += new System.EventHandler(this.lbox_Clientes_Click);
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 439);
            this.Controls.Add(this.pnl_Detalhes);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Botoes.ResumeLayout(false);
            this.pnl_Detalhes.ResumeLayout(false);
            this.pnl_Detalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Panel pnl_Detalhes;
        private System.Windows.Forms.ListBox lbox_Clientes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox tbox_End_Cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_Bai_Cliente;
        private System.Windows.Forms.TextBox tbox_Cid_Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_Cel_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_Nm_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Cod_Cliente;
        private System.Windows.Forms.Label label1;
    }
}