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
    public partial class Frm_Equipe : Form
    {

        FuncGeral obj_FuncGeral = new FuncGeral();
        Equipe obj_Equipe_Atual = new Equipe();

        public Frm_Equipe()
        {
            InitializeComponent();
            //ToDo: gGabriel - 17/05/2023
            obj_FuncGeral.StatusBtn(this, 1); //obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaForm(this, false);
            PopulaLista(); //informando que esta feita
            lview_Titulos();
        }

        private void lview_Titulos()
        {
            lview_ItemEquipe.View = View.Details;
            lview_ItemEquipe.Columns.Add("Cargo", 137);
            lview_ItemEquipe.Columns.Add("Funcionário", 80);
            lview_ItemEquipe.Columns.Add("Nome", 266);
        }

        /********************************************************************
        *  Nome da Classe: PopulaLista
        *       Parametro:
        *       Descrição: Responsavel por Popular o ListBox com os Registros de Equipes
        *       Cadastrados no Banco de Dados do BD
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        private void PopulaLista()
        {
            //Instancia da classe BDEquipe
            BDEquipe obj_BDEquipe = new BDEquipe();

            //Instancia da Classe List
            List<Equipe> obj_Lista = new List<Equipe>();


            // Limpar o ListBox do Formulario Equipe
            lbox_Equipes.Items.Clear();

            //Receber a Lista de dados BD
            obj_Lista = obj_BDEquipe.FindAll();

            // verificar se a algo dentro da lista
            if (obj_Lista != null)
            {
                for (int i = 0; i < obj_Lista.Count; i++)
                {
                    lbox_Equipes.Items.Add(obj_Lista[i].Cod_Equipe.ToString() + "-" + obj_Lista[i].Nm_Equipe);
                }
            }

        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.LimpaForm(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Equipe.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaForm(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Equipe.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            BDItemEquipe obj_BDItemEquipe = new BDItemEquipe();
            BDEquipe obj_BDEquipe = new BDEquipe();

            DialogResult dlg_Resp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlg_Resp == DialogResult.Yes) // se for igual a sim vai excluir como desejado
            {
                if (obj_BDEquipe.Excluir(obj_Equipe_Atual)) //Pergunta se o objeto foi exluido e informar na tela
                {
                    obj_Equipe_Atual.Lst_ItemEquipe[0].Cod_Equipe = obj_Equipe_Atual.Cod_Equipe;
                    obj_BDItemEquipe.ExcluirByEquipe(obj_Equipe_Atual.Lst_ItemEquipe[0]);

                    MessageBox.Show("A Equipe " + obj_Equipe_Atual.Nm_Equipe + " foi Excluida com Sucesso.", "Exclusão",
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

            if (obj_Equipe_Atual.Cod_Equipe != -1)
            {
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaForm(obj_Equipe_Atual);
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

            BDItemEquipe obj_BDItemEquipe = new BDItemEquipe();
            BDEquipe obj_BDEquipe = new BDEquipe();

            obj_Equipe_Atual = PopulaObjeto(); //Pega da tela e joga para o Objeto | O objeto leva para o Banco de dados

            if (obj_Equipe_Atual.Cod_Equipe != -1) // se for diferente de -1 vai fazer as alterações abaixo // verifica se o objeto existe
            {
                if (obj_BDEquipe.Alterar(obj_Equipe_Atual))
                {
                    obj_Equipe_Atual.Lst_ItemEquipe[0].Cod_Equipe = obj_Equipe_Atual.Cod_Equipe;
                    obj_BDItemEquipe.ExcluirByEquipe(obj_Equipe_Atual.Lst_ItemEquipe[0]);


                    for (int i = 0; i < obj_Equipe_Atual.Lst_ItemEquipe.Count; i++)
                    {
                        ItemEquipe obj_ItemEquipe = new ItemEquipe();

                        obj_ItemEquipe = obj_Equipe_Atual.Lst_ItemEquipe[i];


                        obj_BDItemEquipe.Incluir(obj_ItemEquipe);

                    }

                    MessageBox.Show("A Equipe " + obj_Equipe_Atual.Nm_Equipe + " foi Alterada com sucesso.", "Alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
                }
            }
            else // sitema de incluir
            {
                if(obj_Equipe_Atual.Nm_Equipe == obj_Equipe_Atual.Nm_Equipe)
                {
                    MessageBox.Show("Este item ja está na Lista");
                }
                else
                {
                    obj_Equipe_Atual.Cod_Equipe = obj_BDEquipe.Incluir(obj_Equipe_Atual);
                    PopulaForm(obj_Equipe_Atual);

                    obj_Equipe_Atual.Lst_ItemEquipe[0].Cod_Equipe = obj_Equipe_Atual.Cod_Equipe;
                    obj_BDItemEquipe.ExcluirByEquipe(obj_Equipe_Atual.Lst_ItemEquipe[0]);

                    for (int i = 0; i < obj_Equipe_Atual.Lst_ItemEquipe.Count; i++)
                    {
                        ItemEquipe obj_ItemEquipe = new ItemEquipe();

                        obj_ItemEquipe = obj_Equipe_Atual.Lst_ItemEquipe[i];


                        obj_BDItemEquipe.Incluir(obj_ItemEquipe);

                    }

                    MessageBox.Show("A Equipe " + obj_Equipe_Atual.Nm_Equipe + " foi Incluida com Sucesso.", "Inclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Information); // informação na tela com 1 botão OK
                }
                
            }

            obj_FuncGeral.HabilitaForm(this, false);
            obj_FuncGeral.StatusBtn(this, 2); // esta liberado apenas o stats 2 que é o btn_Novo btn_alterar e btn_Excluir
            PopulaLista();
        }



        private void lbox_Equipes_Click(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                BDItemEquipe obj_BDItemEquipe = new BDItemEquipe();
                ItemEquipe obj_ItemEquipe = new ItemEquipe();

                BDEquipe obj_BDEquipe = new BDEquipe();
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

                obj_Equipe_Atual.Cod_Equipe = Convert.ToInt16(s_Lin.Substring(0, i_Pos));
                obj_Equipe_Atual = obj_BDEquipe.FindByCod(obj_Equipe_Atual);
                obj_ItemEquipe.Cod_Equipe = obj_Equipe_Atual.Cod_Equipe;
                obj_Equipe_Atual.Lst_ItemEquipe = obj_BDItemEquipe.FindAllByCodEquipe(obj_ItemEquipe);
                PopulaForm(obj_Equipe_Atual);
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
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        private Equipe PopulaObjeto()
        {
            //Instancia do objeto
            Equipe obj_Equipe = new Equipe();
            ItemEquipe obj_ItemEquipe = new ItemEquipe();

            if (tbox_Cod_Equipe.Text != "")
            {
                obj_Equipe.Cod_Equipe = Convert.ToInt16(tbox_Cod_Equipe.Text);
            }

            obj_Equipe.Nm_Equipe = tbox_Nm_Equipe.Text;
            obj_Equipe.Desc_Equipe = tbox_Desc_Equipe.Text;

            for (int i = 0; i < lview_ItemEquipe.Items.Count; i++)
            {
                obj_ItemEquipe.Cod_Equipe = obj_Equipe.Cod_Equipe;
                obj_ItemEquipe.Cod_Funcionario = Convert.ToInt16(lview_ItemEquipe.Items[i].SubItems[1].Text);
                obj_ItemEquipe.Carg_ItemEquipe = lview_ItemEquipe.Items[i].SubItems[0].Text;

                obj_Equipe.Lst_ItemEquipe.Add(obj_ItemEquipe);


            }

            return obj_Equipe;

        }

        /********************************************************************
        *  Nome da Classe: PopulaForm
        *       Parametro:
        *       Descrição: Responsavel por popular o Formulario
        *       Cadastrados no Banco de Dados do BD
        *     Dt. Criação: 22/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        private void PopulaForm(Equipe pobj_Equipe)
        {
            EventArgs e = new EventArgs();

            lview_ItemEquipe.Items.Clear();

            tbox_Cod_Equipe.Text = pobj_Equipe.Cod_Equipe.ToString();
            tbox_Nm_Equipe.Text = pobj_Equipe.Nm_Equipe;
            tbox_Desc_Equipe.Text = pobj_Equipe.Desc_Equipe;

            for (int i = 0; i < pobj_Equipe.Lst_ItemEquipe.Count; i++)
            {


                Funcionario obj_Funcionario = new Funcionario();
                BDFuncionario obj_BDFuncionario = new BDFuncionario();

                obj_Funcionario.Cod_Funcionario = pobj_Equipe.Lst_ItemEquipe[i].Cod_Funcionario;
                obj_Funcionario = obj_BDFuncionario.FindByCod(obj_Funcionario);

                PopulaLinha(lview_ItemEquipe,
                            pobj_Equipe.Lst_ItemEquipe[i].Carg_ItemEquipe,
                            pobj_Equipe.Lst_ItemEquipe[i].Cod_Funcionario.ToString(),
                            obj_Funcionario.Nm_Funcionario);

            }

        }

        private void tbox_Cod_Funcionario_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                Funcionario obj_Funcionario = new Funcionario();
                BDFuncionario obj_BDFuncionario = new BDFuncionario();

                if (int.TryParse(((TextBox)sender).Text, out int Cod))
                {
                    obj_Funcionario.Cod_Funcionario = Cod;
                }

                obj_Funcionario = obj_BDFuncionario.FindByCod(obj_Funcionario);

                lb_Nm_Funcionario.Text = obj_Funcionario.Nm_Funcionario;
            }
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            Frm_Funcionario obj_Frm_Funcionario = new Frm_Funcionario();
            obj_Frm_Funcionario.ShowDialog();
            if (obj_Frm_Funcionario.obj_Funcionario_Atual.Cod_Funcionario != -1)
            {
                tbox_Cod_Funcionario.Text = obj_Frm_Funcionario.obj_Funcionario_Atual.Cod_Funcionario.ToString();
                tbox_Cod_Funcionario_Leave(tbox_Cod_Funcionario, e);
            }
        }

        private void btn_IncluirList_Click(object sender, EventArgs e)
        {
            BDFuncionario obj_BDFuncionario = new BDFuncionario();
            Funcionario obj_Funcionario = new Funcionario();

            obj_Funcionario.Cod_Funcionario = Convert.ToInt16(tbox_Cod_Funcionario.Text);
            obj_Funcionario = obj_BDFuncionario.FindByCod(obj_Funcionario);

            PopulaLinha(lview_ItemEquipe, tbox_Carg_ItemEquipe.Text, obj_Funcionario.Cod_Funcionario.ToString(), obj_Funcionario.Nm_Funcionario);

            tbox_Carg_ItemEquipe.Clear();
            tbox_Cod_Funcionario.Clear();
            lb_Nm_Funcionario.Text = "";
        }

        private void PopulaLinha(ListView plview, string pCargItemEquipe, string pCodFuncionario, string pNmFuncionario)
        {
            ListViewItem item = new ListViewItem(new[] { pCargItemEquipe, pCodFuncionario, pNmFuncionario });
            plview.Items.Add(item);
        }

        private void btn_ExcluirList_Click(object sender, EventArgs e)
        {
            if (lview_ItemEquipe.SelectedItems != null)
            {
                var vConfirma = MessageBox.Show("Deseja retirar este item da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vConfirma == DialogResult.Yes)
                {
                    for (int i = 0; i < lview_ItemEquipe.Items.Count; i++)
                    {
                        if (lview_ItemEquipe.Items[i].Selected)
                        {
                            tbox_Carg_ItemEquipe.Text = lview_ItemEquipe.Items[i].SubItems[0].Text;
                            tbox_Cod_Funcionario.Text = lview_ItemEquipe.Items[i].SubItems[1].Text;
                            lb_Nm_Funcionario.Text = lview_ItemEquipe.Items[i].SubItems[2].Text;
                            lview_ItemEquipe.Items[i].Remove();
                            i--;
                        }
                    }
                }

            }
        }

    }

}
