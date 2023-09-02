/********************************************************************
 *  Nome da Classe: ItemEquipe
 *       Descrição: Esta classe de objeto representa o Objeto ItemEquipe
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
    class ItemEquipe
    {

        ~ItemEquipe() 
        { 
        
        }

        #region Atributos Privados
        private int v_Cod_ItemEquipe = -1;
        private int v_Cod_Equipe = -1;
        private int v_Cod_Funcionario = -1;
        private string v_Carg_ItemEquipe = "";
        #endregion


        #region Metodos Publicos

        public int Cod_ItemEquipe 
        { 
            get => v_Cod_ItemEquipe; 
            set => v_Cod_ItemEquipe = value; 
        }

        public int Cod_Equipe 
        { 
            get => v_Cod_Equipe; 
            set => v_Cod_Equipe = value; 
        }

        public int Cod_Funcionario 
        { 
            get => v_Cod_Funcionario; 
            set => v_Cod_Funcionario = value; 
        }

        public string Carg_ItemEquipe 
        { 
            get => v_Carg_ItemEquipe; 
            set => v_Carg_ItemEquipe = value; 
        }

        #endregion

    }
}
