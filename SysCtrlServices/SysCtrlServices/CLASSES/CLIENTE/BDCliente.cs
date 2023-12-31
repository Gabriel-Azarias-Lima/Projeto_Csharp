﻿/********************************************************************
 *       Nome da Classe: BDCliente
 *       Descrição: Esta classe de Controle de objeto negocia com o 
 *                  Banco de dados os métodos publicos: Incluir, 
 *                  Excluir, Alterar, FindByCodCliente e 
 *                  FindAllCliente
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
    class BDCliente
    {

        ~BDCliente()
        {

        }

        /********************************************************************
        *  Nome do Método: Incluir
        *       Descrição: Responsável por incluir o Registro (Tupla) do 
        *                  Cliente na TB_CLIENTE.
        *       Parametro: Objeto Cliente
        *         Retorno: Código do Cliente (PK)
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/

        public int Incluir(Cliente pobj_Cliente)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " INSERT INTO TB_CLIENTE " +
                           " ( " +          
                           " S_NM_CLIENTE, " +
                           " S_CEL_CLIENTE, " +
                           " S_CID_CLIENTE, " +
                           " S_BAI_CLIENTE, " +
                           " S_END_CLIENTE " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_CLIENTE, " +
                           " @S_CEL_CLIENTE, " +
                           " @S_CID_CLIENTE, " +
                           " @S_BAI_CLIENTE, " +
                           " @S_END_CLIENTE " +
                           " ); " +
                           " SELECT IDENT_CURRENT('TB_CLIENTE') AS COD";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@S_NM_CLIENTE", pobj_Cliente.Nm_Cliente);
            obj_Com.Parameters.AddWithValue("@S_CEL_CLIENTE", pobj_Cliente.Cel_Cliente);
            obj_Com.Parameters.AddWithValue("@S_CID_CLIENTE", pobj_Cliente.Cid_Cliente);
            obj_Com.Parameters.AddWithValue("@S_BAI_CLIENTE", pobj_Cliente.Bai_Cliente);
            obj_Com.Parameters.AddWithValue("@S_END_CLIENTE", pobj_Cliente.End_Cliente);

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
                return pobj_Cliente.Cod_Cliente;
            }

        }

        /********************************************************************
       *  Nome do Método: Alterar
       *       Descrição: Responsável por Alterar o Registro (Tupla) do 
       *                  Cliente na TB_CLIENTE.
       *       Parametro: Objeto Cliente
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Alterar(Cliente pobj_Cliente)
        {
            if (pobj_Cliente.Cod_Cliente != -1)
            {
                //Conexão com o BD
                SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

                string s_Sql = " UPDATE TB_CLIENTE SET " +
                               " S_NM_CLIENTE = @S_NM_CLIENTE, " +
                               " S_CEL_CLIENTE = @S_CEL_CLIENTE, " +
                               " S_CID_CLIENTE = @S_CID_CLIENTE, " +
                               " S_BAI_CLIENTE = @S_BAI_CLIENTE, " +
                               " S_END_CLIENTE = @S_END_CLIENTE " +
                               " WHERE I_COD_CLIENTE = @I_COD_CLIENTE ";

                SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
                obj_Com.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);
                obj_Com.Parameters.AddWithValue("@S_NM_CLIENTE", pobj_Cliente.Nm_Cliente);
                obj_Com.Parameters.AddWithValue("@S_CEL_CLIENTE", pobj_Cliente.Cel_Cliente);
                obj_Com.Parameters.AddWithValue("@S_CID_CLIENTE", pobj_Cliente.Cid_Cliente);
                obj_Com.Parameters.AddWithValue("@S_BAI_CLIENTE", pobj_Cliente.Bai_Cliente);
                obj_Com.Parameters.AddWithValue("@S_END_CLIENTE", pobj_Cliente.End_Cliente);

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
       *                  Cliente na TB_CLIENTE.
       *       Parametro: Objeto Cliente
       *         Retorno: Booleano
       *     Dt. Criação: 17/05/2023
       *   Dt. Alteração: --/--/---- ( -- )
       *      Criada por: gAzarias_Lima
       ********************************************************************/
        public bool Excluir(Cliente pobj_Cliente)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " DELETE FROM TB_CLIENTE " +
                           " WHERE I_COD_CLIENTE = @I_COD_CLIENTE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);

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
        *                  Cliente na TB_CLIENTE.
        *       Parametro: Objeto Cliente
        *         Retorno: Cliente
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public Cliente FindByCod(Cliente pobj_Cliente)
        {

            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_CLIENTE " +
                           " WHERE I_COD_CLIENTE = @I_COD_CLIENTE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);
            obj_Com.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);


            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Cliente.Nm_Cliente = obj_Dtr["S_NM_CLIENTE"].ToString();
                    pobj_Cliente.Cel_Cliente = obj_Dtr["S_CEL_CLIENTE"].ToString();
                    pobj_Cliente.Cid_Cliente = obj_Dtr["S_CID_CLIENTE"].ToString();
                    pobj_Cliente.Bai_Cliente = obj_Dtr["S_BAI_CLIENTE"].ToString();
                    pobj_Cliente.End_Cliente = obj_Dtr["S_END_CLIENTE"].ToString();


                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return pobj_Cliente;
                }
                else
                {
                    obj_Conn.Close();
                    obj_Dtr.Close();
                    return new Cliente();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR POR CÓDIGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Cliente();
            }
        }


        /********************************************************************
        *  Nome do Método: FindAll
        *       Descrição: Responsável por Encontrar Todos os Registros (Tuplas) 
        *                  dos Clientes na TB_CLIENTE.
        *       Parametro: -
        *         Retorno: Lista<Cliente>
        *     Dt. Criação: 17/05/2023
        *   Dt. Alteração: --/--/---- ( -- )
        *      Criada por: gAzarias_Lima
        ********************************************************************/
        public List<Cliente> FindAll()
        {
            //Conexão com o BD
            SqlConnection obj_Conn = new SqlConnection(BDConnection.ConnectionPath());

            string s_Sql = " SELECT * FROM TB_CLIENTE ";

            SqlCommand obj_Com = new SqlCommand(s_Sql, obj_Conn);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Com.ExecuteReader();

                List<Cliente> Lst_Cliente = new List<Cliente>();

                if (obj_Dtr.HasRows)
                {
                    while (obj_Dtr.Read())
                    {
                        Cliente obj_Cliente = new Cliente();

                        obj_Cliente.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"].ToString());
                        obj_Cliente.Nm_Cliente = obj_Dtr["S_NM_CLIENTE"].ToString();
                        obj_Cliente.Cel_Cliente = obj_Dtr["S_CEL_CLIENTE"].ToString();
                        obj_Cliente.Cid_Cliente = obj_Dtr["S_CID_CLIENTE"].ToString();
                        obj_Cliente.Bai_Cliente = obj_Dtr["S_BAI_CLIENTE"].ToString();
                        obj_Cliente.End_Cliente = obj_Dtr["S_END_CLIENTE"].ToString();

                        Lst_Cliente.Add(obj_Cliente);

                    }
                }
                obj_Conn.Close();
                obj_Dtr.Close();
                return Lst_Cliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO AO ENCONTRAR TODOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Cliente>();
            }
        }

    }
}
