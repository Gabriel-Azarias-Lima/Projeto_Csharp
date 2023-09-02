/********************************************************************
 *  Nome da Classe: Equipe
 *       Descrição: Esta classe de objeto representa o Objeto Equipe
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
    public class Equipe
    {

        ~Equipe() 
        {
        
        }

        #region Atributos Privados
        private int v_Cod_Equipe = -1;
        private string v_Nm_Equipe = "";
        private string v_Desc_Equipe = "";

        private List<ItemEquipe> Lst_ItEquip = new List<ItemEquipe>();
        #endregion


        #region Metodos Publicos
        public int Cod_Equipe
        {
            get => v_Cod_Equipe;
            set => v_Cod_Equipe = value;
        }

        public string Nm_Equipe
        {
            get => v_Nm_Equipe;
            set => v_Nm_Equipe = value;
        }

        public string Desc_Equipe
        {
            get => v_Desc_Equipe;
            set => v_Desc_Equipe = value;
        }
        internal List<ItemEquipe> Lst_ItemEquipe
        { 
            get => Lst_ItEquip; 
            set => Lst_ItEquip = value; 
        }
        #endregion

    }
}
