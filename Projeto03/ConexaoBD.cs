using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    class ConexaoBD
    {
        private string BancoDados = "server=localhost;uid=root;database=bdTarefas";

        public MySqlConnection Conectar()
        {
            MySqlConnection Dados = new MySqlConnection(BancoDados);
            Dados.Open();


            return Dados;
        }
    }
}
