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


        }
    }
}
