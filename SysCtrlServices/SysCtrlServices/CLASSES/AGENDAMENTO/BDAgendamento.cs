/********************************************************************
 *       Nome da Classe: BDAgendamento
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodAgendamento e 
 *                  FindAllAgendamento
 *      Dt. Criação: 17/05/2023
 *      Dt. Alteração: --/--/---- ( -- )
 *      Criada por: gAzarias_Lima
 ********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysCtrlServices
{
    class BDAgendamento
    {

        ~BDAgendamento() 
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  Agendamento na TB_AGENDAMENTO.
        *       Parametro: Objeto Agendamento
        *         Retorno: Código do Agendamento (PK)
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/

        public int Incluir(Agendamento pobj_Agendamento)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_AGENDAMENTO " +
                           " ( " +
                           " I_COD_CLIENTE, " +
                           " S_DESC_AGENDAMENTO, " +
                           " DT_DAT_AGENDAMENTO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_CLIENTE, " +
                           " @S_DESC_AGENDAMENTO, " +
                           " @DT_DAT_AGENDAMENTO " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_AGENDAMENTO') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Agendamento.Cod_Cliente);
            obj_Com.Parameters.AddWithValue("@S_DESC_AGENDAMENTO", pobj_Agendamento.Desc_Agendamento);
            obj_Com.Parameters.AddWithValue("@DT_DAT_AGENDAMENTO", pobj_Agendamento.Dat_Agendamento);

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
                return pobj_Agendamento.Cod_Agendamento;
            }

        }

        /********************************************************************
       *  Nome do Método: Alterar
       *       Descrição: Responsável por Alterar o Registro (Tupla) do 
       *                  Agendamento na TB_AGENDAMENTO.
       *       Parametro: Objeto Agendamento
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Alterar(Agendamento pobj_Agendamento)
        {
            if (pobj_Agendamento.Cod_Agendamento != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " UPDATE TB_AGENDAMENTO SET " +
                               " I_COD_CLIENTE = @I_COD_CLIENTE, " +
                               " S_DESC_AGENDAMENTO = @S_DESC_AGENDAMENTO, " +
                               " DT_DAT_AGENDAMENTO = @DT_DAT_AGENDAMENTO " +
                               " WHERE I_COD_AGENDAMENTO = @I_COD_AGENDAMENTO ";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_Agendamento.Cod_Agendamento);
                obj_Com.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Agendamento.Cod_Cliente);
                obj_Com.Parameters.AddWithValue("@S_DESC_AGENDAMENTO", pobj_Agendamento.Desc_Agendamento);
                obj_Com.Parameters.AddWithValue("@DT_DAT_AGENDAMENTO", pobj_Agendamento.Dat_Agendamento);

                try
                {
                    obj_Conn.Open();
                    obj_Com.ExecuteNonQuery();
                    obj_Conn.Close();
                    return true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ERRO AO ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        /********************************************************************
       *  Nome do Método: Excluir
       *       Descrição: Responsável por Excluir o Registro (Tupla) do 
       *                  Agendamento na TB_AGENDAMENTO.
       *       Parametro: Objeto Agendamento
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Excluir(Agendamento pobj_Agendamento)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_AGENDAMENTO " +
                           " WHERE I_COD_AGENDAMENTO = @I_COD_AGENDAMENTO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_Agendamento.Cod_Agendamento);

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
        *  Nome do Método: FindByCod
        *       Descrição: Responsável por Encontrar o Registro (Tupla) do 
        *                  Agendamento na TB_AGENDAMENTO.
        *       Parametro: Objeto Agendamento
        *         Retorno: Agendamento
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public Agendamento FindByCod(Agendamento pobj_Agendamento)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_AGENDAMENTO " +
                           " WHERE I_COD_AGENDAMENTO = @I_COD_AGENDAMENTO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_Agendamento.Cod_Agendamento);


            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Agendamento.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"].ToString());
                    pobj_Agendamento.Desc_Agendamento = obj_Dtr["S_DESC_AGENDAMENTO"].ToString();
                    pobj_Agendamento.Dat_Agendamento = Convert.ToDateTime(obj_Dtr["DT_DAT_AGENDAMENTO"].ToString());

                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return pobj_Agendamento;
                }
                else
                {
                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return new Agendamento();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR POR CÓDIGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Agendamento();
            }
        }


        /********************************************************************
        *  Nome do Método: FindAll
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos Agendamentos na TB_AGENDAMENTO.
        *       Parametro: -
        *         Retorno: Lista<Agendamento>
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public List<Agendamento> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_AGENDAMENTO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<Agendamento> Lst_Agendamento = new List<Agendamento>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Agendamento obj_Agendamento = new Agendamento();

                        obj_Agendamento.Cod_Agendamento = Convert.ToInt16(obj_Dtr["I_COD_AGENDAMENTO"].ToString());
                        obj_Agendamento.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"].ToString());
                        obj_Agendamento.Desc_Agendamento = obj_Dtr["S_DESC_AGENDAMENTO"].ToString();
                        obj_Agendamento.Dat_Agendamento = Convert.ToDateTime(obj_Dtr["DT_DAT_AGENDAMENTO"].ToString());

                        Lst_Agendamento.Add(obj_Agendamento);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_Agendamento;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Agendamento>();
            }
        }

    }
}
