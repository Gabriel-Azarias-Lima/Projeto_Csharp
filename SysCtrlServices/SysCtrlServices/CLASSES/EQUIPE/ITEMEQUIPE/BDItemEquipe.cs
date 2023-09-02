/********************************************************************
 *  Nome da Classe: BDItemEquipe
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodItemEquipe e 
 *                  FindAllItemEquipe
 *     Dt. Criação: 18/05/2023
 *   Dt. Alteração: --/--/---- ( -- )
 *      Criada por: gAzarias_Lima
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SysCtrlServices;

namespace SysCtrlExercise
{
    class BDItemEquipe
    {
        //Metodo Destruct
        ~BDItemEquipe()
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  ItemEquipe na TB_ITEMEQUIPE.
        *       Parametro: Objeto ItemEquipe
        *         Retorno: Código do ItemEquipe (PK)
        *     Dt. Criação: 18/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public int Incluir(ItemEquipe pobj_ItemEquipe)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_ITEMEQUIPE " +
                           " ( " +
                           " I_COD_EQUIPE, " +
                           " I_COD_FUNCIONARIO, " +
                           " S_CARG_ITEMEQUIPE " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_EQUIPE, " +
                           " @I_COD_FUNCIONARIO, " +
                           " @S_CARG_ITEMEQUIPE " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_ITEMEQUIPE') AS COD";


            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_ItemEquipe.Cod_Equipe);
            obj_Com.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_ItemEquipe.Cod_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_CARG_ITEMEQUIPE", pobj_ItemEquipe.Carg_ItemEquipe);


            try
            {
                obj_Conn.Open();
                int i_Cod = Convert.ToInt16(obj_Com.ExecuteScalar());
                obj_Conn.Close();
                return i_Cod;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO INCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return pobj_ItemEquipe.Cod_ItemEquipe;
            }

        }


        /********************************************************************
        *  Nome do Método: ExcluirByEquipe
        *       Descrição: Responsável por Excluir o Registro (Tupla) do 
        *                  ItemEquipe na TB_ITEMEQUIPE.
        *       Parametro: Objeto ItemEquipe
        *         Retorno: Booleano
        *     Dt. Criação: 18/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public bool ExcluirByEquipe(ItemEquipe pobj_ItemEquipe)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_ITEMEQUIPE " +
                           " WHERE I_COD_EQUIPE = @I_COD_EQUIPE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_ItemEquipe.Cod_Equipe);

            try
            {
                obj_Conn.Open();
                obj_Com.ExecuteNonQuery();
                obj_Conn.Close();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        /********************************************************************
        *  Nome do Método: FindAllByCodEquipe
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos ItemEquipes na TB_ITEMEQUIPE.
        *       Parametro: -
        *         Retorno: Lista<ItemEquipe>
        *     Dt. Criação: 18/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public List<ItemEquipe> FindAllByCodEquipe(ItemEquipe pobj_ItemEquipe)
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_ITEMEQUIPE " +
                           " WHERE I_COD_EQUIPE = @I_COD_EQUIPE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_ItemEquipe.Cod_Equipe);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<ItemEquipe> Lst_ItemEquipe = new List<ItemEquipe>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        ItemEquipe obj_ItemEquipe = new ItemEquipe();

                        obj_ItemEquipe.Cod_ItemEquipe = Convert.ToInt16(obj_Dtr["I_COD_ITEMEQUIPE"].ToString());
                        obj_ItemEquipe.Cod_Equipe = Convert.ToInt16(obj_Dtr["I_COD_EQUIPE"].ToString());
                        obj_ItemEquipe.Cod_Funcionario = Convert.ToInt16(obj_Dtr["I_COD_FUNCIONARIO"].ToString());
                        obj_ItemEquipe.Carg_ItemEquipe = obj_Dtr["S_CARG_ITEMEQUIPE"].ToString();

                        Lst_ItemEquipe.Add(obj_ItemEquipe);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_ItemEquipe;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ItemEquipe>();
            }
        }
    }
}
