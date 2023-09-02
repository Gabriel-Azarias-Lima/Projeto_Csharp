/********************************************************************
 *       Nome da Classe: BDEquipe
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodEquipe e 
 *                  FindAllEquipe
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
    class BDEquipe
    {

        ~BDEquipe()
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  Equipe na TB_EQUIPE.
        *       Parametro: Objeto Equipe
        *         Retorno: Código do Equipe (PK)
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/

        public int Incluir(Equipe pobj_Equipe)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_EQUIPE " +
                           " ( " +
                           " S_NM_EQUIPE, " +
                           " S_DESC_EQUIPE " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_EQUIPE, " +
                           " @S_DESC_EQUIPE " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_EQUIPE') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@S_NM_EQUIPE", pobj_Equipe.Nm_Equipe);
            obj_Com.Parameters.AddWithValue("@S_DESC_EQUIPE", pobj_Equipe.Desc_Equipe);

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
                return pobj_Equipe.Cod_Equipe;
            }

        }

        /********************************************************************
       *  Nome do Método: Alterar
       *       Descrição: Responsável por Alterar o Registro (Tupla) do 
       *                  Equipe na TB_EQUIPE.
       *       Parametro: Objeto Equipe
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Alterar(Equipe pobj_Equipe)
        {
            if (pobj_Equipe.Cod_Equipe != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " UPDATE TB_EQUIPE SET " +
                               " S_NM_EQUIPE = @S_NM_EQUIPE, " +
                               " S_DESC_EQUIPE = @S_DESC_EQUIPE " +
                               " WHERE I_COD_EQUIPE = @I_COD_EQUIPE ";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_Equipe.Cod_Equipe);
                obj_Com.Parameters.AddWithValue("@S_NM_EQUIPE", pobj_Equipe.Nm_Equipe);
                obj_Com.Parameters.AddWithValue("@S_DESC_EQUIPE", pobj_Equipe.Desc_Equipe);

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
       *                  Equipe na TB_EQUIPE.
       *       Parametro: Objeto Equipe
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Excluir(Equipe pobj_Equipe)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_EQUIPE " +
                           " WHERE I_COD_EQUIPE = @I_COD_EQUIPE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_Equipe.Cod_Equipe);

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
        *                  Equipe na TB_EQUIPE.
        *       Parametro: Objeto Equipe
        *         Retorno: Equipe
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public Equipe FindByCod(Equipe pobj_Equipe)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_EQUIPE " +
                           " WHERE I_COD_EQUIPE = @I_COD_EQUIPE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_EQUIPE", pobj_Equipe.Cod_Equipe);


            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Equipe.Nm_Equipe = obj_Dtr["S_NM_EQUIPE"].ToString();
                    pobj_Equipe.Desc_Equipe = obj_Dtr["S_DESC_EQUIPE"].ToString();


                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return pobj_Equipe;
                }
                else
                {
                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return new Equipe();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR POR CÓDIGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Equipe();
            }
        }


        /********************************************************************
        *  Nome do Método: FindAll
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos Equipes na TB_EQUIPE.
        *       Parametro: -
        *         Retorno: Lista<Equipe>
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public List<Equipe> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_EQUIPE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<Equipe> Lst_Equipe = new List<Equipe>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Equipe obj_Equipe = new Equipe();

                        obj_Equipe.Cod_Equipe = Convert.ToInt16(obj_Dtr["I_COD_EQUIPE"].ToString());
                        obj_Equipe.Nm_Equipe = obj_Dtr["S_NM_EQUIPE"].ToString();
                        obj_Equipe.Desc_Equipe = obj_Dtr["S_DESC_EQUIPE"].ToString();

                        Lst_Equipe.Add(obj_Equipe);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_Equipe;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Equipe>();
            }
        }

    }
}
