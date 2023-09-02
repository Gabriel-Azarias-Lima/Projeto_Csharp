/********************************************************************
 *  Nome da Classe: BDItemAgendamento
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodItemAgendamento e 
 *                  FindAllItemAgendamento
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
    class BDItemAgendamento
    {
        //Metodo Destruct
        ~BDItemAgendamento()
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  ItemAgendamento na TB_ITEMAGENDAMENTO.
        *       Parametro: Objeto ItemAgendamento
        *         Retorno: Código do ItemAgendamento (PK)
        *     Dt. Criação: 18/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public int Incluir(ItemAgendamento pobj_ItemAgendamento)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_ITEMAGENDAMENTO " +
                           " ( " +
                           " I_COD_AGENDAMENTO, " +
                           " S_NM_ITEMAGENDAMENTO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_AGENDAMENTO, " +
                           " @S_NM_ITEMAGENDAMENTO " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_ITEMAGENDAMENTO') AS COD";


            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_ItemAgendamento.Cod_Agendamento);
            obj_Com.Parameters.AddWithValue("@S_NM_ITEMAGENDAMENTO", pobj_ItemAgendamento.Nm_ItemAgendamento);


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
                return pobj_ItemAgendamento.Cod_ItemAgendamento;
            }

        }


        /********************************************************************
        *  Nome do Método: ExcluirByAgendamento
        *       Descrição: Responsável por Excluir o Registro (Tupla) do 
        *                  ItemAgendamento na TB_ITEMAGENDAMENTO.
        *       Parametro: Objeto ItemAgendamento
        *         Retorno: Booleano
        *     Dt. Criação: 18/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public bool Excluir(ItemAgendamento pobj_ItemAgendamento)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_ITEMAGENDAMENTO " +
                           " WHERE I_COD_AGENDAMENTO = @I_COD_AGENDAMENTO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_ItemAgendamento.Cod_Agendamento);

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
        *  Nome do Método: FindAllByCodAgendamento
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos ItemAgendamentos na TB_ITEMAGENDAMENTO.
        *       Parametro: -
        *         Retorno: Lista<ItemAgendamento>
        *     Dt. Criação: 18/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public List<ItemAgendamento> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_ITEMAGENDAMENTO " +
                           " WHERE I_COD_AGENDAMENTO = @I_COD_AGENDAMENTO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<ItemAgendamento> Lst_ItemAgendamento = new List<ItemAgendamento>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        ItemAgendamento obj_ItemAgendamento = new ItemAgendamento();

                        obj_ItemAgendamento.Cod_ItemAgendamento = Convert.ToInt16(obj_Dtr["I_COD_ITEMAGENDAMENTO"].ToString());
                        obj_ItemAgendamento.Cod_Agendamento = Convert.ToInt16(obj_Dtr["I_COD_AGENDAMENTO"].ToString());
                        obj_ItemAgendamento.Nm_ItemAgendamento = obj_Dtr["S_NM_ITEMAGENDAMENTO"].ToString();

                        Lst_ItemAgendamento.Add(obj_ItemAgendamento);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_ItemAgendamento;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ItemAgendamento>();
            }
        }
    }
}
