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
    public class SupplierDAO
    {
        private MySqlConnection _connection;
        public SupplierDAO(MySqlConnection connection)
        {
            this._connection = connection;
        }

        #region CadastrarFornecedor
        public void registerSupplier(Supplier supplier)
        {
            try
            {
                string sql = @"INSERT INTO tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                               VALUES (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", supplier.name);
                mysqlCommand.Parameters.AddWithValue("@cnpj", supplier.cnpj);
                mysqlCommand.Parameters.AddWithValue("@email", supplier.email);
                mysqlCommand.Parameters.AddWithValue("@telefone", supplier.phone);
                mysqlCommand.Parameters.AddWithValue("@celular", supplier.cellphone);
                mysqlCommand.Parameters.AddWithValue("@cep", supplier.cep);
                mysqlCommand.Parameters.AddWithValue("@endereco", supplier.address);
                mysqlCommand.Parameters.AddWithValue("@numero", supplier.addressNumber);
                mysqlCommand.Parameters.AddWithValue("@complemento", supplier.complement);
                mysqlCommand.Parameters.AddWithValue("@bairro", supplier.neighborhood);
                mysqlCommand.Parameters.AddWithValue("@cidade", supplier.city);
                mysqlCommand.Parameters.AddWithValue("@estado", supplier.uf);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + error);
            }
            
        }
        #endregion

        #region ListarFornecedores
        public DataTable getSuppliers()
        {
            try
            {
                DataTable supplierTable = new DataTable();

                string sql = "SELECT * FROM tb_fornecedores";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(supplierTable);

                this._connection.Close();
                return supplierTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar fornecedores: " + error);
                return null;
            }
        }
        #endregion

        #region EditarFornecedor
        public void editSupplier(Supplier supplier)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedores set nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, celular=@celular, cep=@cep,
                             endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                             WHERE id=@id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("id", supplier.code);
                mysqlCommand.Parameters.AddWithValue("nome", supplier.name);
                mysqlCommand.Parameters.AddWithValue("cnpj", supplier.cnpj);
                mysqlCommand.Parameters.AddWithValue("email", supplier.email);
                mysqlCommand.Parameters.AddWithValue("telefone", supplier.phone);
                mysqlCommand.Parameters.AddWithValue("celular", supplier.cellphone);
                mysqlCommand.Parameters.AddWithValue("cep", supplier.cep);
                mysqlCommand.Parameters.AddWithValue("endereco", supplier.address);
                mysqlCommand.Parameters.AddWithValue("numero", supplier.addressNumber);
                mysqlCommand.Parameters.AddWithValue("complemento", supplier.complement);
                mysqlCommand.Parameters.AddWithValue("bairro", supplier.neighborhood);
                mysqlCommand.Parameters.AddWithValue("cidade", supplier.city);
                mysqlCommand.Parameters.AddWithValue("estado", supplier.uf);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao editar fornecedor: " + error);
            }
        }
        #endregion

        #region DeletarFornecedor
        public void deleteSupplier(string supplierId)
        {
            try
            {
                string sql = "DELETE FROM tb_fornecedores WHERE id = @id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", supplierId);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao deletar fornecedor: " + error);
            }
        }
        #endregion

        #region BuscarFornecedorPorNome
        public DataTable getSupplierByName(string supplierName)
        {
            try
            {
                DataTable supplierTable = new DataTable();

                string sql = "SELECT * FROM tb_fornecedores WHERE nome = @nome";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", supplierName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(supplierTable);

                this._connection.Close();
                return supplierTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + error);
                return null;
            }
        }
        #endregion

        #region ListarFornecedoresPorNome
        public DataTable getSuppliersByName(string supplierName)
        {
            try
            {
                supplierName = $"%{supplierName}%";
                DataTable supplierTable = new DataTable();

                string sql = "SELECT * FROM tb_fornecedores WHERE nome LIKE @nome";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", supplierName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(supplierTable);

                this._connection.Close();
                return supplierTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar fornecedor: " + error);
                return null;
            }
        }
        #endregion
    }
}
