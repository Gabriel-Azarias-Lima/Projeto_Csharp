/********************************************************************
 *  Nome da Classe: BDConnection
 *       Descrição: Esta classe faz o Controle de acesso ao Banco de dados
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
    class BDConnection
    {

        ~BDConnection() 
        { 
        
        }


        //Método da classe que retorna o caminho de onde está o BD.
        public static string ConnectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=
            C:\Users\gabri\Desktop\Projeto_Software\PROJETO\SysCtrlServices\SysCtrlServices\BDSysCtrlServices.mdf;
            Integrated Security=True;Connect Timeout=15";
        }


    }
}
