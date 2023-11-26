using salesControl.br.com.salescontrol.connection;
using salesControl.br.com.salescontrol.dao;
using salesControl.br.com.salescontrol.model;
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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO(new ConnectionFactory().getConnection());
            clientTable.DataSource = customerDAO.getCustomers();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer client = new Customer();

            client.name = txtName.Text;
            client.rg = txtRG.Text;
            client.cpf = txtCPF.Text;
            client.email = txtEmail.Text;
            client.phone = txtPhone.Text;
            client.cellphone = txtCellphone.Text;
            client.address = txtAddress.Text;
            client.addressNumber = txtAddressNumber.Text;
            client.city = txtCity.Text;
            client.neighborhood = txtNeighborhood.Text;
            client.uf = txtUF.Text;
            client.cep = txtCEP.Text;
            client.complement = txtComplement.Text;

            CustomerDAO customerDAO = new CustomerDAO(new ConnectionFactory().getConnection());
            customerDAO.registerCustomer(client);

            clientTable.DataSource = customerDAO.getCustomers();

            txtCode.Text = "";
            txtName.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCellphone.Text = "";
            txtCEP.Text = "";
            txtAddress.Text = "";
            txtAddressNumber.Text = "";
            txtComplement.Text = "";
            txtNeighborhood.Text = "";
            txtCity.Text = "";
            txtUF.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO(new ConnectionFactory().getConnection());
            customerDAO.deleteCustomer(int.Parse(txtCode.Text));

            clientTable.DataSource = customerDAO.getCustomers();

            txtCode.Text = "";
            txtName.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCellphone.Text = "";
            txtCEP.Text = "";
            txtAddress.Text = "";
            txtAddressNumber.Text = "";
            txtComplement.Text = "";
            txtNeighborhood.Text = "";
            txtCity.Text = "";
            txtUF.Text = "";
        }

        private void clientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = clientTable.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = clientTable.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = clientTable.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = clientTable.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = clientTable.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = clientTable.CurrentRow.Cells[5].Value.ToString();
            txtCellphone.Text = clientTable.CurrentRow.Cells[6].Value.ToString();
            txtCEP.Text = clientTable.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = clientTable.CurrentRow.Cells[8].Value.ToString();
            txtAddressNumber.Text = clientTable.CurrentRow.Cells[9].Value.ToString();
            txtComplement.Text = clientTable.CurrentRow.Cells[10].Value.ToString();
            txtNeighborhood.Text = clientTable.CurrentRow.Cells[11].Value.ToString();
            txtCity.Text = clientTable.CurrentRow.Cells[12].Value.ToString();
            txtUF.Text = clientTable.CurrentRow.Cells[13].Value.ToString();

            tabClients.SelectedTab = tabPage1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer client = new Customer();

            client.code = int.Parse(txtCode.Text);
            client.name = txtName.Text;
            client.rg = txtRG.Text;
            client.cpf = txtCPF.Text;
            client.email = txtEmail.Text;
            client.phone = txtPhone.Text;
            client.cellphone = txtCellphone.Text;
            client.address = txtAddress.Text;
            client.addressNumber = txtAddressNumber.Text;
            client.city = txtCity.Text;
            client.neighborhood = txtNeighborhood.Text;
            client.uf = txtUF.Text;
            client.cep = txtCEP.Text;
            client.complement = txtComplement.Text;

            CustomerDAO customerDAO = new CustomerDAO(new ConnectionFactory().getConnection());
            customerDAO.editCustomer(client);

            clientTable.DataSource = customerDAO.getCustomers();

            txtCode.Text = "";
            txtName.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCellphone.Text = "";
            txtCEP.Text = "";
            txtAddress.Text = "";
            txtAddressNumber.Text = "";
            txtComplement.Text = "";
            txtNeighborhood.Text = "";
            txtCity.Text = "";
            txtUF.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
