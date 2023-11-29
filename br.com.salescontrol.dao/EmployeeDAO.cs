using MySql.Data.MySqlClient;
using salesControl.br.com.salescontrol.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesControl.br.com.salescontrol.dao
{
    public class EmployeeDAO
    {
        private MySqlConnection _connection;
        public EmployeeDAO(MySqlConnection connection)
        {
            this._connection = connection;
        }

        #region CadastrarFuncionario
        public void RegisterEmployee(Employee employee)
        {
            try
            {
                string sql = @"INSERT INTO tb_funcionarios (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado,
                               senha, cargo, nivel_acesso) VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro,
                               @cidade, @estado, @senha, @cargo, @nivel_acesso)";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                mysqlCommand.Parameters.AddWithValue("@nome", employee.name);
                mysqlCommand.Parameters.AddWithValue("@rg", employee.rg);
                mysqlCommand.Parameters.AddWithValue("@cpf", employee.cpf);
                mysqlCommand.Parameters.AddWithValue("@email", employee.email);
                mysqlCommand.Parameters.AddWithValue("@telefone", employee.phone);
                mysqlCommand.Parameters.AddWithValue("@celular", employee.cellphone);
                mysqlCommand.Parameters.AddWithValue("@cep", employee.cep);
                mysqlCommand.Parameters.AddWithValue("@endereco", employee.address);
                mysqlCommand.Parameters.AddWithValue("@numero", employee.addressNumber);
                mysqlCommand.Parameters.AddWithValue("@complemento", employee.complement);
                mysqlCommand.Parameters.AddWithValue("@bairro", employee.neighborhood);
                mysqlCommand.Parameters.AddWithValue("@cidade", employee.city);
                mysqlCommand.Parameters.AddWithValue("@estado", employee.uf);
                mysqlCommand.Parameters.AddWithValue("@senha", employee.password);
                mysqlCommand.Parameters.AddWithValue("@cargo", employee.position);
                mysqlCommand.Parameters.AddWithValue("@nivel_acesso", employee.accessLevel);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + error);
            }
        }
        #endregion

        #region ListarFuncionarios
        public DataTable getEmployees()
        {
            try
            {
                DataTable employeesTable = new DataTable();

                string sql = "SELECT * FROM tb_funcionarios";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(employeesTable);

                this._connection.Close();

                return employeesTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar os funcionários: " + error);
                return null;
            }
        }
        #endregion

        #region ExcluirFuncionario
        public void DeleteEmployee(int employeeId)
        {
            try
            {
                string sql = "DELETE FROM tb_funcionarios WHERE id=@id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);

                mysqlCommand.Parameters.AddWithValue("@id", employeeId);
                this._connection.Open();

                mysqlCommand.ExecuteNonQuery();
                MessageBox.Show("Funcionário excluído com sucesso!");

                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao excluir o funcionário: " + error);
            }
        }
        #endregion

        #region EditarFuncionario
        public void EditEmployee(Employee employee)
        {
            try
            {
                string sql = @"UPDATE tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, senha=@senha,
                             endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado, cargo=@cargo, nivel_acesso=@nivel
                             WHERE id=@id";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@id", employee.code);
                mysqlCommand.Parameters.AddWithValue("@nome", employee.name);
                mysqlCommand.Parameters.AddWithValue("@rg", employee.rg);
                mysqlCommand.Parameters.AddWithValue("@cpf", employee.cpf);
                mysqlCommand.Parameters.AddWithValue("@email", employee.email);
                mysqlCommand.Parameters.AddWithValue("@telefone", employee.phone);
                mysqlCommand.Parameters.AddWithValue("@celular", employee.cellphone);
                mysqlCommand.Parameters.AddWithValue("@cep", employee.cep);
                mysqlCommand.Parameters.AddWithValue("@endereco", employee.address);
                mysqlCommand.Parameters.AddWithValue("@numero", employee.addressNumber);
                mysqlCommand.Parameters.AddWithValue("@complemento", employee.complement);
                mysqlCommand.Parameters.AddWithValue("@bairro", employee.neighborhood);
                mysqlCommand.Parameters.AddWithValue("@cidade", employee.city);
                mysqlCommand.Parameters.AddWithValue("@estado", employee.uf);
                mysqlCommand.Parameters.AddWithValue("@senha", employee.password);
                mysqlCommand.Parameters.AddWithValue("@cargo", employee.position);
                mysqlCommand.Parameters.AddWithValue("@nivel", employee.accessLevel);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso!");
                this._connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao editar o funcionário: " + error);
            }
        }
        #endregion

        #region BuscarFuncionarioPorNome
        public DataTable getEmployeeByName(string employeeName)
        {
            try
            {
                DataTable employeesTable = new DataTable();

                string sql = "SELECT * FROM tb_funcionarios WHERE nome = @nome";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", employeeName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(employeesTable);

                this._connection.Close();

                return employeesTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar os funcionários: " + error);
                return null;
            }
        }
        #endregion

        #region ListarFuncionariosPorNome
        public DataTable getEmployeesByName(string employeeName)
        {
            try
            {
                employeeName = $"%{employeeName}%";

                DataTable employeesTable = new DataTable();

                string sql = "SELECT * FROM tb_funcionarios WHERE nome LIKE @nome";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, this._connection);
                mysqlCommand.Parameters.AddWithValue("@nome", employeeName);

                this._connection.Open();
                mysqlCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mysqlCommand);
                dataAdapter.Fill(employeesTable);

                this._connection.Close();

                return employeesTable;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao buscar os funcionários: " + error);
                return null;
            }
        }
        #endregion
    }
}
