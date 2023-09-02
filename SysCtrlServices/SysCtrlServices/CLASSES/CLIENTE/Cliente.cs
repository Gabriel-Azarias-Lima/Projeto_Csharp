/********************************************************************
 *  Nome da Classe: Cliente
 *       Descrição: Esta classe de objeto representa a Objeto Cliete 
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
    public class Cliente
    {

       ~Cliente() 
        {
        
        
        }

        #region Atributos Privados
        private int v_Cod_Cliente = -1;
        private string v_Nm_Cliente = "";
        private string v_Cel_Cliente = "";
        private string v_Cid_Cliente = "";
        private string v_Bai_Cliente = "";
        private string v_End_Cliente = "";
        #endregion


        #region Metodos Publicos

        public int Cod_Cliente 
        {
            get => v_Cod_Cliente; 
            set => v_Cod_Cliente = value; 
        }

        public string Nm_Cliente 
        { 
            get => v_Nm_Cliente; 
            set => v_Nm_Cliente = value; 
        }

        public string Cel_Cliente 
        { 
            get => v_Cel_Cliente; 
            set => v_Cel_Cliente = value; 
        }

        public string Cid_Cliente 
        { 
            get => v_Cid_Cliente; 
            set => v_Cid_Cliente = value; 
        }

        public string Bai_Cliente 
        {
            get => v_Bai_Cliente; 
            set => v_Bai_Cliente = value;
        }

        public string End_Cliente
        { 
            get => v_End_Cliente; 
            set => v_End_Cliente = value; 
        }

        #endregion

    }
}
