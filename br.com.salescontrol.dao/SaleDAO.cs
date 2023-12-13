using MySql.Data.MySqlClient;
using salesControl.br.com.salescontrol.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesControl.br.com.salescontrol.dao
{
    public class SaleDAO
    {
        private MySqlConnection _connection;
        public SaleDAO(MySqlConnection connection)
        {
            this._connection = connection;
        }

        #region CadastrarVenda
        public void registerSale(Sale sale)
        {
            try
            {
                string sql = @"INSERT INTO tb_vendas (cliente_id, data_venda, total_venda, observacoes) VALUES (@clienteId, @dataVenda, @total, @obs)";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@clienteId", sale.customerId);
                mysqlCommand.Parameters.AddWithValue("@dataVenda", sale.saleDate);
                mysqlCommand.Parameters.AddWithValue("@total", sale.finalPrice);
                mysqlCommand.Parameters.AddWithValue("@obs", sale.observations);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Venda cadastrada com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar venda: " + error);
            }
        }
        #endregion

        #region GetLastSaleID
        public int getLastSaleId()
        {
            try
            {
                int saleId = 0;

                string sql = "SELECT MAX(id) id FROM tb_vendas";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                this._connection.Open();
                MySqlDataReader dataReader = mysqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    saleId = dataReader.GetInt32("id");
                }

                this._connection.Close();
                return saleId;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar ID da última venda: " + error);
                this._connection.Close();
                return 0;
            }
        }
        #endregion
    }
}
