/********************************************************************
 *  Nome da Classe: Serviço
 *       Descrição: Esta classe de objeto representa o Objeto Serviço
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
    class Servico
    {

        #region Atributos Privados
        private int v_Cod_Servico = -1;
        private int v_Cod_Agendamento = -1;
        private int v_Cod_Equipe = -1;
        private string v_Tip_Servico = "";
        #endregion


        #region Metodos Publicos

        public int Cod_Servico 
        { 
            get => v_Cod_Servico; 
            set => v_Cod_Servico = value; 
        }

        public int Cod_Agendamento 
        { 
            get => v_Cod_Agendamento; 
            set => v_Cod_Agendamento = value; 
        }

        public int Cod_Equipe 
        { 
            get => v_Cod_Equipe; 
            set => v_Cod_Equipe = value; 
        }

        public string Tip_Servico 
        { 
            get => v_Tip_Servico; 
            set => v_Tip_Servico = value; 
        }


        #endregion

    }
}
