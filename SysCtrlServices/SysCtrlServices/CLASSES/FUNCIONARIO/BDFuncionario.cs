/********************************************************************
 *  Nome da Classe: BDFuncionario
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodFuncionario e 
 *                  FindAllFuncionario
 *     Dt. Criação: 08/05/2023
 *   Dt. Alteração: --/--/---- ( -- )
 *      Criada por: mFacine (Monstro)
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
    class BDFuncionario

    {
        //Metodo Destruct
        ~BDFuncionario()
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  Funcionario na TB_FUNCIONARIO.
        *       Parametro: Objeto Funcionario
        *         Retorno: Código do Funcionario (PK)
        *     Dt. Criação: 08/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: mFacine (Monstro)
        ********************************************************************/
        public int Incluir(Funcionario pobj_Funcionario)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_FUNCIONARIO " +
                           " ( " +
                           " S_NM_FUNCIONARIO, " +
                           " S_CPF_FUNCIONARIO, " +
                           " S_CNH_FUNCIONARIO, " +
                           " S_CEL_FUNCIONARIO, " +
                           " S_PER_FUNCIONARIO, " +
                           " S_CID_FUNCIONARIO, " +
                           " S_BAI_FUNCIONARIO, " +
                           " S_END_FUNCIONARIO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_FUNCIONARIO, " +
                           " @S_CPF_FUNCIONARIO, " +
                           " @S_CNH_FUNCIONARIO, " +
                           " @S_CEL_FUNCIONARIO, " +
                           " @S_PER_FUNCIONARIO, " +
                           " @S_CID_FUNCIONARIO, " +
                           " @S_BAI_FUNCIONARIO, " +
                           " @S_END_FUNCIONARIO " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_FUNCIONARIO') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@S_NM_FUNCIONARIO", pobj_Funcionario.Nm_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_CPF_FUNCIONARIO", pobj_Funcionario.CPF_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_CNH_FUNCIONARIO", pobj_Funcionario.CNH_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_CEL_FUNCIONARIO", pobj_Funcionario.Cel_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_PER_FUNCIONARIO", pobj_Funcionario.Per_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_CID_FUNCIONARIO", pobj_Funcionario.Cid_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_BAI_FUNCIONARIO", pobj_Funcionario.Bai_Funcionario);
            obj_Com.Parameters.AddWithValue("@S_END_FUNCIONARIO", pobj_Funcionario.End_Funcionario);

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
                return pobj_Funcionario.Cod_Funcionario;
            }

        }

        /********************************************************************
        *  Nome do Método: Alterar
        *       Descrição: Responsável por Alterar o Registro (Tupla) do 
        *                  Funcionario na TB_FUNCIONARIO.
        *       Parametro: Objeto Funcionario
        *         Retorno: Booleano
        *     Dt. Criação: 09/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: mFacine (Monstro)
        ********************************************************************/
        public bool Alterar(Funcionario pobj_Funcionario)
        {
            if (pobj_Funcionario.Cod_Funcionario != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " UPDATE TB_FUNCIONARIO SET " +
                               " S_NM_FUNCIONARIO  = @S_NM_FUNCIONARIO,  " +
                               " S_CPF_FUNCIONARIO = @S_CPF_FUNCIONARIO, " +
                               " S_CNH_FUNCIONARIO = @S_CNH_FUNCIONARIO, " +
                               " S_CEL_FUNCIONARIO = @S_CEL_FUNCIONARIO, " +
                               " S_PER_FUNCIONARIO = @S_PER_FUNCIONARIO, " +
                               " S_CID_FUNCIONARIO = @S_CID_FUNCIONARIO, " +
                               " S_BAI_FUNCIONARIO = @S_BAI_FUNCIONARIO, " +
                               " S_END_FUNCIONARIO = @S_END_FUNCIONARIO " +
                               " WHERE I_COD_FUNCIONARIO = @I_COD_FUNCIONARIO ";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_Funcionario.Cod_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_NM_FUNCIONARIO", pobj_Funcionario.Nm_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_CPF_FUNCIONARIO", pobj_Funcionario.CPF_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_CNH_FUNCIONARIO", pobj_Funcionario.CNH_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_CEL_FUNCIONARIO", pobj_Funcionario.Cel_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_PER_FUNCIONARIO", pobj_Funcionario.Per_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_CID_FUNCIONARIO", pobj_Funcionario.Cid_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_BAI_FUNCIONARIO", pobj_Funcionario.Bai_Funcionario);
                obj_Com.Parameters.AddWithValue("@S_END_FUNCIONARIO", pobj_Funcionario.End_Funcionario);

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
        *                  Funcionario na TB_FUNCIONARIO.
        *       Parametro: Objeto Funcionario
        *         Retorno: Booleano
        *     Dt. Criação: 09/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: mFacine (Monstro)
        ********************************************************************/
        public bool Excluir(Funcionario pobj_Funcionario)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_FUNCIONARIO " +
                           " WHERE I_COD_FUNCIONARIO = @I_COD_FUNCIONARIO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_Funcionario.Cod_Funcionario);

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
        *                  Funcionario na TB_FUNCIONARIO.
        *       Parametro: Objeto Funcionario
        *         Retorno: Funcionario
        *     Dt. Criação: 09/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: mFacine (Monstro)
        ********************************************************************/
        public Funcionario FindByCod(Funcionario pobj_Funcionario)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_FUNCIONARIO " +
                           " WHERE I_COD_FUNCIONARIO = @I_COD_FUNCIONARIO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_Funcionario.Cod_Funcionario);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Funcionario.Nm_Funcionario = obj_Dtr["S_NM_FUNCIONARIO"].ToString();
                    pobj_Funcionario.CPF_Funcionario = obj_Dtr["S_CPF_FUNCIONARIO"].ToString();
                    pobj_Funcionario.CNH_Funcionario = obj_Dtr["S_CNH_FUNCIONARIO"].ToString();
                    pobj_Funcionario.Cel_Funcionario = obj_Dtr["S_CEL_FUNCIONARIO"].ToString();
                    pobj_Funcionario.Per_Funcionario = obj_Dtr["S_PER_FUNCIONARIO"].ToString();
                    pobj_Funcionario.Cid_Funcionario = obj_Dtr["S_CID_FUNCIONARIO"].ToString();
                    pobj_Funcionario.Bai_Funcionario = obj_Dtr["S_BAI_FUNCIONARIO"].ToString();
                    pobj_Funcionario.End_Funcionario = obj_Dtr["S_END_FUNCIONARIO"].ToString();

                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return pobj_Funcionario;
                }
                else
                {
                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return new Funcionario();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR POR CÓDIGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Funcionario();
            }
        }

        /********************************************************************
        *  Nome do Método: FindAll
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos Funcionarios na TB_FUNCIONARIO.
        *       Parametro: -
        *         Retorno: Lista<Funcionario>
        *     Dt. Criação: 09/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: mFacine (Monstro)
        ********************************************************************/
        public List<Funcionario> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_FUNCIONARIO ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<Funcionario> Lst_Funcionario = new List<Funcionario>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Funcionario obj_Funcionario = new Funcionario();

                        obj_Funcionario.Cod_Funcionario = Convert.ToInt16(obj_Dtr["I_COD_FUNCIONARIO"].ToString());
                        obj_Funcionario.Nm_Funcionario = obj_Dtr["S_NM_FUNCIONARIO"].ToString();
                        obj_Funcionario.CPF_Funcionario = obj_Dtr["S_CPF_FUNCIONARIO"].ToString();
                        obj_Funcionario.CNH_Funcionario = obj_Dtr["S_CNH_FUNCIONARIO"].ToString();
                        obj_Funcionario.Cel_Funcionario = obj_Dtr["S_CEL_FUNCIONARIO"].ToString();
                        obj_Funcionario.Per_Funcionario = obj_Dtr["S_PER_FUNCIONARIO"].ToString();
                        obj_Funcionario.Cid_Funcionario = obj_Dtr["S_CID_FUNCIONARIO"].ToString();
                        obj_Funcionario.Bai_Funcionario = obj_Dtr["S_BAI_FUNCIONARIO"].ToString();
                        obj_Funcionario.End_Funcionario = obj_Dtr["S_END_FUNCIONARIO"].ToString();

                        Lst_Funcionario.Add(obj_Funcionario);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_Funcionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Funcionario>();
            }
        }
    }
}
