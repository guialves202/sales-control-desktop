using MySqlX.XDevAPI;
using salesControl.br.com.salescontrol.connection;
using salesControl.br.com.salescontrol.dao;
using salesControl.br.com.salescontrol.model;
using salesControl.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesControl.br.com.salescontrol.view
{
    public partial class Frmemployees : Form
    {
        public Frmemployees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.name = txtName.Text;
            employee.rg = txtRG.Text;
            employee.cpf = txtCPF.Text;
            employee.email = txtEmail.Text;
            employee.phone = txtPhone.Text;
            employee.cellphone = txtCellphone.Text;
            employee.address = txtAddress.Text;
            employee.addressNumber = txtAddressNumber.Text;
            employee.city = txtCity.Text;
            employee.neighborhood = txtNeighborhood.Text;
            employee.uf = txtUF.SelectedItem.ToString();
            employee.cep = txtCEP.Text;
            employee.complement = txtComplement.Text;
            employee.password = txtPassword.Text;
            employee.position = txtPosition.SelectedItem.ToString();
            employee.accessLevel = (EmployeeAccessLevel)Enum.Parse(typeof(EmployeeAccessLevel), txtLevel.SelectedItem.ToString());

            EmployeeDAO employeeDAO = new EmployeeDAO(new ConnectionFactory().getConnection());
            employeeDAO.RegisterEmployee(employee);

            new Helpers().ClearScreen(this);

            employeesTable.DataSource = employeeDAO.getEmployees();
            tabEmployees.SelectedTab = tabPage2;
        }

        private void employeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = employeesTable.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = employeesTable.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = employeesTable.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = employeesTable.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = employeesTable.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = employeesTable.CurrentRow.Cells[5].Value.ToString();
            txtPosition.Text = employeesTable.CurrentRow.Cells[6].Value.ToString();
            txtLevel.Text = Enum.GetName(typeof(EmployeeAccessLevel), employeesTable.CurrentRow.Cells[7].Value).ToString();
            txtPhone.Text = employeesTable.CurrentRow.Cells[8].Value.ToString();
            txtCellphone.Text = employeesTable.CurrentRow.Cells[9].Value.ToString();
            txtCEP.Text = employeesTable.CurrentRow.Cells[10].Value.ToString();
            txtAddress.Text = employeesTable.CurrentRow.Cells[11].Value.ToString();
            txtAddressNumber.Text = employeesTable.CurrentRow.Cells[12].Value.ToString();
            txtComplement.Text = employeesTable.CurrentRow.Cells[13].Value.ToString();
            txtNeighborhood.Text = employeesTable.CurrentRow.Cells[14].Value.ToString();
            txtCity.Text = employeesTable.CurrentRow.Cells[15].Value.ToString();
            txtUF.Text = employeesTable.CurrentRow.Cells[16].Value.ToString();

            tabEmployees.SelectedTab = tabPage1;
        }

        private void Frmemployees_Load(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO(new ConnectionFactory().getConnection());
            employeesTable.DataSource = employeeDAO.getEmployees();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Helpers().ClearScreen(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(txtCode.Text);

            EmployeeDAO employeeDAO = new EmployeeDAO(new ConnectionFactory().getConnection());
            employeeDAO.DeleteEmployee(employeeId);

            new Helpers().ClearScreen(this);

            employeesTable.DataSource = employeeDAO.getEmployees();
            tabEmployees.SelectedTab = tabPage2;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.code = int.Parse(txtCode.Text);
            employee.name = txtName.Text;
            employee.rg = txtRG.Text;
            employee.cpf = txtCPF.Text;
            employee.email = txtEmail.Text;
            employee.phone = txtPhone.Text;
            employee.cellphone = txtCellphone.Text;
            employee.address = txtAddress.Text;
            employee.addressNumber = txtAddressNumber.Text;
            employee.city = txtCity.Text;
            employee.neighborhood = txtNeighborhood.Text;
            employee.uf = txtUF.SelectedItem.ToString();
            employee.cep = txtCEP.Text;
            employee.complement = txtComplement.Text;
            employee.password = txtPassword.Text;
            employee.position = txtPosition.SelectedItem.ToString();
            employee.accessLevel = (EmployeeAccessLevel)Enum.Parse(typeof(EmployeeAccessLevel), txtLevel.SelectedItem.ToString());

            EmployeeDAO employeeDAO = new EmployeeDAO(new ConnectionFactory().getConnection());
            employeeDAO.EditEmployee(employee);

            new Helpers().ClearScreen(this);

            employeesTable.DataSource = employeeDAO.getEmployees();
            tabEmployees.SelectedTab = tabPage2;
        }

        private void btnSearchCEP_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCEP.Text;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";

                DataSet cepData = new DataSet();
                cepData.ReadXml(xml);

                txtAddress.Text = cepData.Tables[0].Rows[0]["logradouro"].ToString();
                txtComplement.Text = cepData.Tables[0].Rows[0]["complemento"].ToString();
                txtNeighborhood.Text = cepData.Tables[0].Rows[0]["bairro"].ToString();
                txtCity.Text = cepData.Tables[0].Rows[0]["localidade"].ToString();
                txtUF.Text = cepData.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string employeeName = txtSearchName.Text;

            EmployeeDAO employeeDAO = new EmployeeDAO(new ConnectionFactory().getConnection());
            employeesTable.DataSource = employeeDAO.getEmployeeByName(employeeName);
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string employeeName = txtSearchName.Text;

            EmployeeDAO employeeDAO = new EmployeeDAO(new ConnectionFactory().getConnection());
            employeesTable.DataSource = employeeDAO.getEmployeesByName(employeeName);
        }
    }
}
