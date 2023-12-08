using MySql.Data.MySqlClient;
using salesControl.br.com.salescontrol.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.dao
{
    public class SaleDAO
    {
        private MySqlConnection _connection;
        public SaleDAO(MySqlConnection connection)
        {
            this._connection = connection;
        }

        #region RegistrarVenda
        public void registerSale(Sale sale)
        {

        }
        #endregion
    }
}
