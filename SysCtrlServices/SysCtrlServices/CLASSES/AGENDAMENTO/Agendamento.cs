/********************************************************************
 *  Nome da Classe: Agendamento
 *       Descrição: Esta classe de objeto representa o Objeto Agendamento
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
    class Agendamento
    {

        ~Agendamento() 
        { 
        
        }

        #region Atributos Privados
        private int v_Cod_Agendamento = -1;
        private int v_Cod_Cliente = -1;
        private string v_Desc_Agendament = "";
        private DateTime v_Dat_Agendamento = DateTime.MinValue;

        private List<ItemAgendamento> Lst_ItAgend = new List<ItemAgendamento>();
        #endregion


        #region Metodos Publicos
        public int Cod_Agendamento 
        { 
            get => v_Cod_Agendamento; 
            set => v_Cod_Agendamento = value; 
        }

        public int Cod_Cliente 
        { 
            get => v_Cod_Cliente; 
            set => v_Cod_Cliente = value; 
        }

        public string Desc_Agendamento
        { 
            get => v_Desc_Agendament; 
            set => v_Desc_Agendament = value; 
        }

        public DateTime Dat_Agendamento
        { 
            get => v_Dat_Agendamento; 
            set => v_Dat_Agendamento = value; 
        }
        internal List<ItemAgendamento> Lst_ItemAgendamento
        { 
            get => Lst_ItAgend; 
            set => Lst_ItAgend = value; 
        }

        #endregion

    }
}
