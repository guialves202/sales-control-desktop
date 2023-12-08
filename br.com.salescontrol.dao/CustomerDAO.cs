using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using salesControl.br.com.salescontrol.connection;
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
    public class CustomerDAO
    {
        private MySqlConnection _connection;
        public CustomerDAO(MySqlConnection connection)
        {
            this._connection = connection;
        }

        #region CadastrarCliente
        public void registerCustomer(Customer customer)
        {
            try
            {
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                               VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", customer.name);
                mysqlCommand.Parameters.AddWithValue("@rg", customer.rg);
                mysqlCommand.Parameters.AddWithValue("@cpf", customer.cpf);
                mysqlCommand.Parameters.AddWithValue("@email", customer.email);
                mysqlCommand.Parameters.AddWithValue("@telefone", customer.phone);
                mysqlCommand.Parameters.AddWithValue("@celular", customer.cellphone);
                mysqlCommand.Parameters.AddWithValue("@cep", customer.cep);
                mysqlCommand.Parameters.AddWithValue("@endereco", customer.address);
                mysqlCommand.Parameters.AddWithValue("@numero", customer.addressNumber);
                mysqlCommand.Parameters.AddWithValue("@complemento", customer.complement);
                mysqlCommand.Parameters.AddWithValue("@bairro", customer.neighborhood);
                mysqlCommand.Parameters.AddWithValue("@cidade", customer.city);
                mysqlCommand.Parameters.AddWithValue("@estado", customer.uf);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao registrar o cliente: " + error);
            }
        }
        #endregion

        #region ListarClientes
        public DataTable getCustomers()
        {
            try
            {
                DataTable clientTable = new DataTable();

                string sql = "SELECT * FROM tb_clientes";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(clientTable);

                this._connection.Close();

                return clientTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar os clientes: " + error);
                return null;
            }
        }
        #endregion

        #region editarCliente
        public void editCustomer(Customer customer)
        {
            try
            {
                string sql = @"UPDATE tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep,
                             endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                             WHERE id=@id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", customer.code);
                mysqlCommand.Parameters.AddWithValue("@nome", customer.name);
                mysqlCommand.Parameters.AddWithValue("@rg", customer.rg);
                mysqlCommand.Parameters.AddWithValue("@cpf", customer.cpf);
                mysqlCommand.Parameters.AddWithValue("@email", customer.email);
                mysqlCommand.Parameters.AddWithValue("@telefone", customer.phone);
                mysqlCommand.Parameters.AddWithValue("@celular", customer.cellphone);
                mysqlCommand.Parameters.AddWithValue("@cep", customer.cep);
                mysqlCommand.Parameters.AddWithValue("@endereco", customer.address);
                mysqlCommand.Parameters.AddWithValue("@numero", customer.addressNumber);
                mysqlCommand.Parameters.AddWithValue("@complemento", customer.complement);
                mysqlCommand.Parameters.AddWithValue("@bairro", customer.neighborhood);
                mysqlCommand.Parameters.AddWithValue("@cidade", customer.city);
                mysqlCommand.Parameters.AddWithValue("@estado", customer.uf);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao editar o cliente: " + error);
            }
        }
        #endregion

        #region deletarCliente
        public void deleteCustomer(int customerId)
        {
            try
            {
                string sql = "DELETE FROM tb_clientes WHERE id = @id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", customerId);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Cliente excluído com sucesso!");
                this._connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao excluir o cliente: " + error);
            }
        }
        #endregion

        #region BuscarClientePorNome
        public DataTable getCustomerByName(string customerName)
        {
            try
            {
                DataTable clientTable = new DataTable();
                string sql = "SELECT * FROM tb_clientes WHERE nome=@nome";

                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", customerName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(clientTable);

                this._connection.Close();

                return clientTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar o cliente: " + error);
                return null;
            }
        }
        #endregion

        #region ListarClientesPorNome
        public DataTable getCustomersByName(string customerName)
        {
            try
            {
                customerName = $"%{customerName}%";

                DataTable clientTable = new DataTable();
                string sql = "SELECT * FROM tb_clientes WHERE nome LIKE @nome";

                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", customerName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(clientTable);

                this._connection.Close();

                return clientTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar os clientes: " + error);
                return null;
            }
        }
        #endregion

        #region BuscarClientePorCPF
        public Customer getCustomerByCPF(string cpf)
        {
            try
            {
                Customer customer = new Customer();

                string sql = "SELECT * FROM tb_clientes WHERE cpf = @cpf";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@cpf", cpf);

                this._connection.Open();
                MySqlDataReader dataReader = mysqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    customer.code = dataReader.GetInt32("id");
                    customer.name = dataReader.GetString("nome");
                    customer.rg = dataReader.GetString("rg");
                    customer.cpf = dataReader.GetString("cpf");
                    customer.email = dataReader.GetString("email");
                    customer.phone = dataReader.GetString("telefone");
                    customer.cellphone = dataReader.GetString("celular");
                    customer.cep = dataReader.GetString("cep");
                    customer.address = dataReader.GetString("endereco");
                    customer.addressNumber = dataReader.GetString("numero");
                    customer.complement = dataReader.GetString("complemento");
                    customer.city = dataReader.GetString("bairro");
                    customer.neighborhood = dataReader.GetString("cidade");
                    customer.uf = dataReader.GetString("estado");

                    return customer;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar cliente: " + error);
                return null;
            }
        }
        #endregion
    }
}
