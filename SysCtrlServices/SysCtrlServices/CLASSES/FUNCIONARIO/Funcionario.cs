/********************************************************************
 *  Nome da Classe: Funcionário
 *       Descrição: Esta classe de objeto representa o Objeto Funcionário
 *     Dt. Criação: 17/05/2023
 *   Dt. Alteração: --/--/---- ( -- )
 *      Criada por: gAzarias_Lima
 ********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCtrlServices
{
    public class Funcionario
    {

        ~Funcionario()
        {

        }

        #region Atributos Privados
        private int v_Cod_Funcionario = -1;
        private string v_Nm_Funcionario = "";
        private string v_CPF_Funcionario = "";
        private string v_CNH_Funcionario = "";
        private string v_Cel_Funcionario = "";
        private string v_Per_Funcionario = "";
        private string v_Cid_Funcionario = "";
        private string v_Bai_Funcionario = "";
        private string v_End_Funcionario = "";
        #endregion


        #region Metodos Publicos

        public int Cod_Funcionario
        {
            get => v_Cod_Funcionario;
            set => v_Cod_Funcionario = value;
        }

        public string Nm_Funcionario
        {
            get => v_Nm_Funcionario;
            set => v_Nm_Funcionario = value;
        }

        public string CPF_Funcionario
        {
            get => v_CPF_Funcionario;
            set => v_CPF_Funcionario = value;
        }

        public string CNH_Funcionario
        {
            get => v_CNH_Funcionario;
            set => v_CNH_Funcionario = value;
        }

        public string Cel_Funcionario
        {
            get => v_Cel_Funcionario;
            set => v_Cel_Funcionario = value;
        }

        public string Per_Funcionario
        {
            get => v_Per_Funcionario;
            set => v_Per_Funcionario = value;
        }

        public string Cid_Funcionario
        {
            get => v_Cid_Funcionario;
            set => v_Cid_Funcionario = value;
        }

        public string Bai_Funcionario
        {
            get => v_Bai_Funcionario;
            set => v_Bai_Funcionario = value;
        }

        public string End_Funcionario
        {
            get => v_End_Funcionario;
            set => v_End_Funcionario = value;
        }
        #endregion

    }
}
