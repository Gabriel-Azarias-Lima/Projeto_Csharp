/********************************************************************
 *       Nome da Classe: BDServico
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodServico e 
 *                  FindAllServico
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
    class BDServico
    {

        ~BDServico()
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  Servico na TB_SERVICO.
        *       Parametro: Objeto Servico
        *         Retorno: Código do Servico (PK)
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/

        public int Incluir(Servico pobj_Servico)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_SERVICO " +
                           " ( " +
                           " I_COD_AGENDAMENTO, " +
                           " I_COD_EQUIPE, " +
                           " S_TIP_SERVICO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_AGENDAMENTO, " +
                           " @I_COD_EQUIPE, " +
                           " @S_TIP_SERVICO " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_SERVICO') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_Servico.Cod_Agendamento);
            obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_Servico.Cod_Equipe);
            obj_Com.Parameters.AddWithValue("@S_TIP_SERVICO", pobj_Servico.Tip_Servico);

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
                return pobj_Servico.Cod_Servico;
            }

        }

        /********************************************************************
       *  Nome do Método: Alterar
       *       Descrição: Responsável por Alterar o Registro (Tupla) do 
       *                  Servico na TB_SERVICO.
       *       Parametro: Objeto Servico
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Alterar(Servico pobj_Servico)
        {
            if (pobj_Servico.Cod_Servico != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " UPDATE TB_SERVICO SET " +
                               " I_COD_AGENDAMENTO = @I_COD_AGENDAMENTO, " +
                               " I_COD_EQUIPE = @I_COD_EQUIPE, " +
                               " S_TIP_SERVICO = @S_TIP_SERVICO " +
                               " WHERE I_COD_SERVICO = @I_COD_SERVICO ";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_SERVICO", pobj_Servico.Cod_Servico);
                obj_Com.Parameters.AddWithValue("@I_COD_AGENDAMENTO", pobj_Servico.Cod_Agendamento);
                obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_Servico.Cod_Equipe);
                obj_Com.Parameters.AddWithValue("@S_TIP_SERVICO", pobj_Servico.Tip_Servico);

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
       *                  Servico na TB_SERVICO.
       *       Parametro: Objeto Servico
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Excluir(Servico pobj_Servico)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_SERVICO " +
                           " WHERE I_COD_SERVICO = @I_COD_SERVICO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_SERVICO", pobj_Servico.Cod_Servico);

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
        *                  Servico na TB_SERVICO.
        *       Parametro: Objeto Servico
        *         Retorno: Servico
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public Servico FindByCod(Servico pobj_Servico)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_SERVICO " +
                           " WHERE I_COD_SERVICO = @I_COD_SERVICO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_SERVICO", pobj_Servico.Cod_Servico);


            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Servico.Cod_Agendamento = Convert.ToInt16(obj_Dtr["I_COD_AGENDAMENTO"].ToString());
                    pobj_Servico.Cod_Equipe = Convert.ToInt16(obj_Dtr["I_COD_EQUIPE"].ToString());
                    pobj_Servico.Tip_Servico = obj_Dtr["S_TIP_SERVICO"].ToString();


                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return pobj_Servico;
                }
                else
                {
                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return new Servico();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR POR CÓDIGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Servico();
            }
        }


        /********************************************************************
        *  Nome do Método: FindAll
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos Servicos na TB_SERVICO.
        *       Parametro: -
        *         Retorno: Lista<Servico>
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public List<Servico> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_SERVICO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<Servico> Lst_Servico = new List<Servico>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Servico obj_Servico = new Servico();

                        obj_Servico.Cod_Servico = Convert.ToInt16(obj_Dtr["I_COD_SERVICO"].ToString());
                        obj_Servico.Cod_Agendamento = Convert.ToInt16(obj_Dtr["I_COD_AGENDAMENTO"].ToString());
                        obj_Servico.Cod_Equipe = Convert.ToInt16(obj_Dtr["I_COD_EQUIPE"].ToString());
                        obj_Servico.Tip_Servico = obj_Dtr["S_TIP_SERVICO"].ToString();

                        Lst_Servico.Add(obj_Servico);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_Servico;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Servico>();
            }
        }

    }
}
