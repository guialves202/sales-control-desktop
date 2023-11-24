using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.connection
{
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(connection);
        }
    }
}
