using MySql.Data.MySqlClient;
using salesControl.br.com.salescontrol.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesControl.br.com.salescontrol.dao
{
    public class ProductDAO
    {
        private MySqlConnection _connection;
        public ProductDAO(MySqlConnection connection)
        {
            this._connection = connection;
        }

        #region CadastrarProduto
        public void registerProduct(Product product)
        {
            try
            {
                string sql = "INSERT INTO (nome, preco, qtd_estoque, for_id) VALUES (@nome, @preco, @qtd_estoque, @for_id)";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", product.name);
                mysqlCommand.Parameters.AddWithValue("@preco", product.price);
                mysqlCommand.Parameters.AddWithValue("@qtd_estoque", product.stockQuantity);
                mysqlCommand.Parameters.AddWithValue("@for_id", product.supplierId);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao registrar produto: " + error);
            }
        }
        #endregion

        #region ListarProdutos
        public DataTable getProducts()
        {
            try
            {
                DataTable productsTable = new DataTable();

                string sql = @"SELECT tb_produtos.id as 'Código', tb_produtos.nome as 'Nome', tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Qtd estoque',
                tb_fornecedores.nome as 'Fornecedor' FROM tb_produtos INNER JOIN tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(productsTable);

                this._connection.Close();
                return productsTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao listar produtos: " + error);
                return null;
            }
        }
        #endregion

        #region EditarProduto
        public void editProduct(Product product)
        {
            try
            {
                string sql = "UPDATE tb_produtos SET nome=@nome, preco=@preco, qtd_estoque=@qtd_estoque, for_id=@for_id WHERE id=@id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", product.code);
                mysqlCommand.Parameters.AddWithValue("@nome", product.name);
                mysqlCommand.Parameters.AddWithValue("@preco", product.price);
                mysqlCommand.Parameters.AddWithValue("@qtd_estoque", product.stockQuantity);
                mysqlCommand.Parameters.AddWithValue("@for_id", product.supplierId);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao alterar produto: " + error);
            }
        }
        #endregion

        #region DeletarProduto
        public void deleteProduct(int productId)
        {
            try
            {
                string sql = "DELETE FROM tb_produtos WHERE id=@id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", productId);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Produto deletado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao deletar produto: " + error);
            }
        }
        #endregion

        #region BuscarProdutoPorNome
        public DataTable getProductByName(string productName)
        {
            try
            {
                DataTable productTable = new DataTable();

                string sql = @"SELECT tb_produtos.id as 'Código', tb_produtos.nome as 'Nome', tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Qtd estoque',
                tb_fornecedores.nome as 'Fornecedor' FROM tb_produtos INNER JOIN tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id
                WHERE tb_produtos.nome = @nome";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", productName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(productTable);

                this._connection.Close();
                return productTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar produto: " + error);
                return null;
            }
        }
        #endregion

        #region ListarProdutosPorNome
        public DataTable getProductsByName(string productName)
        {
            try
            {
                productName = $"%{productName}%";
                DataTable productTable = new DataTable();

                string sql = @"SELECT tb_produtos.id as 'Código', tb_produtos.nome as 'Nome', tb_produtos.preco as 'Preço', tb_produtos.qtd_estoque as 'Qtd estoque',
                tb_fornecedores.nome as 'Fornecedor' FROM tb_produtos INNER JOIN tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id
                WHERE tb_produtos.nome LIKE @nome";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", productName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(productTable);

                this._connection.Close();
                return productTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar produto: " + error);
                return null;
            }
        }
        #endregion

        #region BuscarProdutoPorId
        public Product getProductById(int productId)
        {
            try
            {
                string sql = "SELECT * FROM tb_produtos WHERE id = @id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", productId);

                this._connection.Open();
                MySqlDataReader dataReader = mysqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    Product product = new Product();

                    product.code = dataReader.GetInt32("id");
                    product.name = dataReader.GetString("nome");
                    product.price = dataReader.GetDecimal("preco");
                    product.stockQuantity = dataReader.GetInt32("qtd_estoque");
                    
                    return product;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    return null;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar produto: " + error);
                return null;
            }
        }
        #endregion
    }
}
