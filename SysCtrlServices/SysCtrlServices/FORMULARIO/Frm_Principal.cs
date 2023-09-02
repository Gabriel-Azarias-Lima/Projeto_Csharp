using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCtrlServices
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp_Principal = MessageBox.Show("Deseja mesmo Sair?", "Gerenciador de Serviços", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp_Principal == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void tm_Principal_Tick(object sender, EventArgs e)
        {
            tsslb_Data.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            tsslb_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cliente obj_Frm_Cliente = new Frm_Cliente();
            obj_Frm_Cliente.ShowDialog();
        }

        private void equipeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Equipe obj_Frm_Equipe = new Frm_Equipe();
            obj_Frm_Equipe.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Funcionario obj_Frm_Funcionario = new Frm_Funcionario();
            obj_Frm_Funcionario.ShowDialog();
        }
    }
}
