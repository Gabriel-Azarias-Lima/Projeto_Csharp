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
    public partial class Frm_Cliente : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        public Cliente obj_Cliente_Atual = new Cliente();

        public Frm_Cliente()
        {
            InitializeComponent();
            //ToDo: gGabriel - 17/05/2023
            obj_FuncGeral.StatusBtn(this, 1); //obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaForm(this, false);
            PopulaLista(); //informando que esta feita
        }

        /********************************************************************
        *  Nome da Classe: PopulaLista
        *       Parametro:
        *       Descrição: Responsavel por Popular o ListBox com os Registros de Clientes
        *       Cadastrados no Banco de Dados do BD
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gGabriel (Monstro)
        ********************************************************************/
        private void PopulaLista()
        {
            //Instancia da classe BDCliente
            BDCliente obj_BDCliente = new BDCliente();

            //Instancia da Classe List
            List<Cliente> obj_Lista = new List<Cliente>();


            // Limpar o ListBox do Formulario Cliente
            lbox_Clientes.Items.Clear();

            //Receber a Lista de dados BD
            obj_Lista = obj_BDCliente.FindAll();

            // verificar se a algo dentro da lista
            if (obj_Lista != null)
            {
                for (int i = 0; i < obj_Lista.Count; i++)
                {
                    lbox_Clientes.Items.Add(obj_Lista[i].Cod_Cliente.ToString() + "-" + obj_Lista[i].Nm_Cliente);
                }
            }

        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.LimpaForm(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Cliente.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Cliente.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BDCliente obj_BDCliente = new BDCliente();

            DialogResult dlg_Resp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlg_Resp == DialogResult.Yes) // se for igual a sim vai excluir como desejado
            {
                if (obj_BDCliente.Excluir(obj_Cliente_Atual)) //Pergunta se o objeto foi exluido e informar na tela
                {
                    MessageBox.Show("O Cliente " + obj_Cliente_Atual.Nm_Cliente + " foi Excluido com Sucesso.", "Exclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
                }

                obj_FuncGeral.LimpaForm(this); // Limpa a tela dos textbox
                obj_FuncGeral.HabilitaForm(this, false); // não permite que ele mexa na tela depois de apagado
                obj_FuncGeral.StatusBtn(this, 1); // esta liberado apenas o stats 1 que é o btn_Novo
                PopulaLista(); // Aplica a opção de popular a lista
            }
        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, false); //não permite que ele mexa na tela

            if (obj_Cliente_Atual.Cod_Cliente != -1)
            {
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaForm(obj_Cliente_Atual);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1); // esta liberado apenas o stats 1 que é o btn_Novo
                obj_FuncGeral.LimpaForm(this); //Limpa a tela dos textbox
            }
        }


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            // MATERIA QUE VAMOS TER EM UMA OUTRA UC
            // ToDo mFacine (23/05/2023): validar os campos antes de gravar

            BDCliente obj_BDCliente = new BDCliente();

            obj_Cliente_Atual = PopulaObjeto(); //Pega da tela e joga para o Objeto | O objeto leva para o Banco de dados

            if (obj_Cliente_Atual.Cod_Cliente != -1) // se for diferente de -1 vai fazer as alterações abaixo // verifica se o objeto existe
            {
                if (obj_BDCliente.Alterar(obj_Cliente_Atual))
                {
                    MessageBox.Show("O Cliente " + obj_Cliente_Atual.Nm_Cliente + " foi Alterado com sucesso.", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
                }
            }
            else // sitema de incluir
            {
                obj_Cliente_Atual.Cod_Cliente = obj_BDCliente.Incluir(obj_Cliente_Atual);
                PopulaForm(obj_Cliente_Atual);

                MessageBox.Show("O Cliente " + obj_Cliente_Atual.Nm_Cliente + " foi Incluido com Sucesso.", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
            }

            obj_FuncGeral.HabilitaForm(this, false);
            obj_FuncGeral.StatusBtn(this, 2); // esta liberado apenas o stats 2 que é o btn_Novo btn_alterar e btn_Excluir
            PopulaLista();
        }



        private void lbox_Clientes_Click(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                BDCliente obj_BDCliente = new BDCliente();
                string s_Lin = ((ListBox)sender).Items[((ListBox)sender).SelectedIndex].ToString();

                int i_Pos = 0;

                for (int i = 0; i < s_Lin.Length; i++) //calculando a posição dos itens que estaram dentro da listbox pelo -
                {
                    if (s_Lin.Substring(i, 1) == "-")
                    {
                        i_Pos = i;
                        break;
                    }

                }

                obj_Cliente_Atual.Cod_Cliente = Convert.ToInt16(s_Lin.Substring(0, i_Pos));
                obj_Cliente_Atual = obj_BDCliente.FindByCod(obj_Cliente_Atual);
                PopulaForm(obj_Cliente_Atual);
                obj_FuncGeral.HabilitaForm(this, false);
                obj_FuncGeral.StatusBtn(this, 2); // esta liberado apenas o stats 2 que é o btn_Novo btn_alterar e btn_Excluir
            }
        }



        /********************************************************************
        *  Nome da Classe: PopulaObjeto
        *       Parametro:
        *       Descrição: Responsavel por popular o objeto Atual
        *       Cadastrados no Banco de Dados do BD
        *     Dt. Criação: 22/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gGabriel (Monstro)
        ********************************************************************/
        private Cliente PopulaObjeto()
            {
                //Instancia do objeto
                Cliente obj_Cliente = new Cliente();


                if (tbox_Cod_Cliente.Text != "")
                {
                    obj_Cliente.Cod_Cliente = Convert.ToInt16(tbox_Cod_Cliente.Text);
                }

                obj_Cliente.Nm_Cliente = tbox_Nm_Cliente.Text;
                obj_Cliente.Cel_Cliente = tbox_Cel_Cliente.Text;
                obj_Cliente.Cid_Cliente = tbox_Cid_Cliente.Text;
                obj_Cliente.Bai_Cliente = tbox_Bai_Cliente.Text;
                obj_Cliente.End_Cliente = tbox_End_Cliente.Text;

                return obj_Cliente;

            }

            /********************************************************************
            *  Nome da Classe: PopulaForm
            *       Parametro:
            *       Descrição: Responsavel por popular o Formulario
            *       Cadastrados no Banco de Dados do BD
            *     Dt. Criação: 22/05/2023
            *   Dt. Alteração: --/--/---- ( -- )
            *      Criada por: gGabriel (Monstro)
            ********************************************************************/
            private void PopulaForm(Cliente pobj_Cliente)
            {
                tbox_Cod_Cliente.Text = pobj_Cliente.Cod_Cliente.ToString();
                tbox_Nm_Cliente.Text = pobj_Cliente.Nm_Cliente;
                tbox_Cel_Cliente.Text = pobj_Cliente.Cel_Cliente;
                tbox_Cid_Cliente.Text = pobj_Cliente.Cid_Cliente;
                tbox_Bai_Cliente.Text = pobj_Cliente.Bai_Cliente;
                tbox_End_Cliente.Text = pobj_Cliente.End_Cliente;

            }

        
    }

}

