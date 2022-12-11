using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    internal class conexao
    {
        static private string StrCon = "server=127.0.0.1;database= db_floricultura;user id=root;password=";
        static public MySqlConnection getconexao()
        {
            return new MySqlConnection(StrCon);

        }
    }
}
