/********************************************************************
 *  Nome da Classe: ItemAgendamento
 *       Descrição: Esta classe de objeto representa o Objeto ItemAgendamento
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
    class ItemAgendamento
    {

        ~ItemAgendamento()
        {
        
        }

        #region Atributos Privados
        private int v_Cod_ItemAgendamento = -1;
        private int v_Cod_Agendamento = -1;
        private string v_Nm_ItemAgendamento = "";
        #endregion


        #region Metodos Publicos

        public int Cod_ItemAgendamento 
        { 
            get => v_Cod_ItemAgendamento; 
            set => v_Cod_ItemAgendamento = value; 
        }

        public int Cod_Agendamento 
        {
            get => v_Cod_Agendamento; 
            set => v_Cod_Agendamento = value; 
        }

        public string Nm_ItemAgendamento 
        { 
            get => v_Nm_ItemAgendamento; 
            set => v_Nm_ItemAgendamento = value; 
        }

        #endregion

    }
}
