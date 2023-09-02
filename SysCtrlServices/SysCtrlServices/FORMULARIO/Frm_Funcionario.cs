using SysCtrlExercise;
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
    public partial class Frm_Funcionario : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        public Funcionario obj_Funcionario_Atual = new Funcionario();

        public Frm_Funcionario()
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
        *       Descrição: Responsavel por Popular o ListBox com os Registros de Funcionarios
        *       Cadastrados no Banco de Dados do BD
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gGabriel (Monstro)
        ********************************************************************/
        private void PopulaLista()
        {
            //Instancia da classe BDFuncionario
            BDFuncionario obj_BDFuncionario = new BDFuncionario();

            //Instancia da Classe List
            List<Funcionario> obj_Lista = new List<Funcionario>();


            // Limpar o ListBox do Formulario Funcionario
            lbox_Funcionarios.Items.Clear();

            //Receber a Lista de dados BD
            obj_Lista = obj_BDFuncionario.FindAll();

            // verificar se a algo dentro da lista
            if (obj_Lista != null)
            {
                for (int i = 0; i < obj_Lista.Count; i++)
                {
                    lbox_Funcionarios.Items.Add(obj_Lista[i].Cod_Funcionario.ToString() + "-" + obj_Lista[i].Nm_Funcionario);
                }
            }

        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.LimpaForm(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Funcionario.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Funcionario.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BDFuncionario obj_BDFuncionario = new BDFuncionario();

            DialogResult dlg_Resp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlg_Resp == DialogResult.Yes) // se for igual a sim vai excluir como desejado
            {
                if (obj_BDFuncionario.Excluir(obj_Funcionario_Atual)) //Pergunta se o objeto foi exluido e informar na tela
                {
                    MessageBox.Show("O Funcionario " + obj_Funcionario_Atual.Nm_Funcionario + " foi Excluido com Sucesso.", "Exclusão",
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

            if (obj_Funcionario_Atual.Cod_Funcionario != -1)
            {
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaForm(obj_Funcionario_Atual);
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

            BDFuncionario obj_BDFuncionario = new BDFuncionario();

            obj_Funcionario_Atual = PopulaObjeto(); //Pega da tela e joga para o Objeto | O objeto leva para o Banco de dados

            if (obj_Funcionario_Atual.Cod_Funcionario != -1) // se for diferente de -1 vai fazer as alterações abaixo // verifica se o objeto existe
            {
                if (obj_BDFuncionario.Alterar(obj_Funcionario_Atual))
                {
                    MessageBox.Show("O Funcionario " + obj_Funcionario_Atual.Nm_Funcionario + " foi Alterado com sucesso.", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
                }
            }
            else // sitema de incluir
            {
                obj_Funcionario_Atual.Cod_Funcionario = obj_BDFuncionario.Incluir(obj_Funcionario_Atual);
                PopulaForm(obj_Funcionario_Atual);

                MessageBox.Show("O Funcionario " + obj_Funcionario_Atual.Nm_Funcionario + " foi Incluido com Sucesso.", "Inclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
            }

            obj_FuncGeral.HabilitaForm(this, false);
            obj_FuncGeral.StatusBtn(this, 2); // esta liberado apenas o stats 2 que é o btn_Novo btn_alterar e btn_Excluir
            PopulaLista();
        }



        private void lbox_Funcionarios_Click(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                BDFuncionario obj_BDFuncionario = new BDFuncionario();
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

                obj_Funcionario_Atual.Cod_Funcionario = Convert.ToInt16(s_Lin.Substring(0, i_Pos));
                obj_Funcionario_Atual = obj_BDFuncionario.FindByCod(obj_Funcionario_Atual);
                PopulaForm(obj_Funcionario_Atual);
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
        private Funcionario PopulaObjeto()
        {
            //Instancia do objeto
            Funcionario obj_Funcionario = new Funcionario();


            if (tbox_Cod_Funcionario.Text != "")
            {
                obj_Funcionario.Cod_Funcionario = Convert.ToInt16(tbox_Cod_Funcionario.Text);
            }

            obj_Funcionario.Nm_Funcionario = tbox_Nm_Funcionario.Text;
            obj_Funcionario.CPF_Funcionario = tbox_CPF_Funcionario.Text;
            obj_Funcionario.CNH_Funcionario = tbox_CNH_Funcionario.Text;
            obj_Funcionario.Cel_Funcionario = tbox_Cel_Funcionario.Text;
            obj_Funcionario.Cid_Funcionario = tbox_Cid_Funcionario.Text;
            obj_Funcionario.Bai_Funcionario = tbox_Bai_Funcionario.Text;
            obj_Funcionario.End_Funcionario = tbox_End_Funcionario.Text;

            if (ckbox_Manha.Checked)
            {
                obj_Funcionario.Per_Funcionario += "1";
            }
            else
            {
                obj_Funcionario.Per_Funcionario += "0";
            }

            if (ckbox_Tarde.Checked)
            {
                obj_Funcionario.Per_Funcionario += "1";
            }
            else
            {
                obj_Funcionario.Per_Funcionario += "0";
            }

            if (ckbox_Noite.Checked)
            {
                obj_Funcionario.Per_Funcionario += "1";
            }
            else
            {
                obj_Funcionario.Per_Funcionario += "0";
            }

            return obj_Funcionario;

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
        private void PopulaForm(Funcionario pobj_Funcionario)
        {
            tbox_Cod_Funcionario.Text = pobj_Funcionario.Cod_Funcionario.ToString();
            tbox_Nm_Funcionario.Text = pobj_Funcionario.Nm_Funcionario;
            tbox_CPF_Funcionario.Text = pobj_Funcionario.CPF_Funcionario;
            tbox_CNH_Funcionario.Text = pobj_Funcionario.CNH_Funcionario;
            tbox_Cel_Funcionario.Text = pobj_Funcionario.Cel_Funcionario;
            tbox_Cid_Funcionario.Text = pobj_Funcionario.Cid_Funcionario;
            tbox_Bai_Funcionario.Text = pobj_Funcionario.Bai_Funcionario;
            tbox_End_Funcionario.Text = pobj_Funcionario.End_Funcionario;

            ckbox_Manha.Checked = pobj_Funcionario.Per_Funcionario.Substring(0, 1) == "1";
            ckbox_Tarde.Checked = pobj_Funcionario.Per_Funcionario.Substring(1, 1) == "1";
            ckbox_Noite.Checked = pobj_Funcionario.Per_Funcionario.Substring(2, 1) == "1";

        }


    }

}
