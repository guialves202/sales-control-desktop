using MySqlX.XDevAPI;
using Org.BouncyCastle.Ocsp;
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
    public partial class Frmsupplier : Form
    {
        public Frmsupplier()
        {
            InitializeComponent();
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

        private void clientTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new Helpers().ClearScreen(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            supplier.name = txtName.Text;
            supplier.cnpj = txtCNPJ.Text;
            supplier.email = txtEmail.Text;
            supplier.phone = txtPhone.Text;
            supplier.cellphone = txtCellphone.Text;
            supplier.address = txtAddress.Text;
            supplier.addressNumber = txtAddressNumber.Text;
            supplier.city = txtCity.Text;
            supplier.neighborhood = txtNeighborhood.Text;
            supplier.uf = txtUF.SelectedItem.ToString();
            supplier.cep = txtCEP.Text;
            supplier.complement = txtComplement.Text;

            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            supplierDAO.registerSupplier(supplier);

            supplierTable.DataSource = supplierDAO.getSuppliers();

            new Helpers().ClearScreen(this);
            tabSupplier.SelectedTab = tabPage2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string supplierId = txtCode.Text;

            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            supplierDAO.deleteSupplier(supplierId);

            supplierTable.DataSource = supplierDAO.getSuppliers();

            new Helpers().ClearScreen(this);
            tabSupplier.SelectedTab = tabPage2;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            supplier.code = int.Parse(txtCode.Text);
            supplier.name = txtName.Text;
            supplier.cnpj = txtCNPJ.Text;
            supplier.email = txtEmail.Text;
            supplier.phone = txtPhone.Text;
            supplier.cellphone = txtCellphone.Text;
            supplier.address = txtAddress.Text;
            supplier.addressNumber = txtAddressNumber.Text;
            supplier.city = txtCity.Text;
            supplier.neighborhood = txtNeighborhood.Text;
            supplier.uf = txtUF.SelectedItem.ToString();
            supplier.cep = txtCEP.Text;
            supplier.complement = txtComplement.Text;

            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            supplierDAO.editSupplier(supplier);

            supplierTable.DataSource = supplierDAO.getSuppliers();

            new Helpers().ClearScreen(this);
            tabSupplier.SelectedTab = tabPage2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string supplierName = txtSearchName.Text;

            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            supplierTable.DataSource = supplierDAO.getSupplierByName(supplierName);
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string supplierName = txtSearchName.Text;

            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            supplierTable.DataSource = supplierDAO.getSuppliersByName(supplierName);
        }

        private void supplierTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = supplierTable.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = supplierTable.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = supplierTable.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = supplierTable.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = supplierTable.CurrentRow.Cells[4].Value.ToString();
            txtCellphone.Text = supplierTable.CurrentRow.Cells[5].Value.ToString();
            txtCEP.Text = supplierTable.CurrentRow.Cells[6].Value.ToString();
            txtAddress.Text = supplierTable.CurrentRow.Cells[7].Value.ToString();
            txtAddressNumber.Text = supplierTable.CurrentRow.Cells[8].Value.ToString();
            txtComplement.Text = supplierTable.CurrentRow.Cells[9].Value.ToString();
            txtNeighborhood.Text = supplierTable.CurrentRow.Cells[10].Value.ToString();
            txtCity.Text = supplierTable.CurrentRow.Cells[11].Value.ToString();
            txtUF.Text = supplierTable.CurrentRow.Cells[12].Value.ToString();

            tabSupplier.SelectedTab = tabPage1;
        }

        private void Frmsupplier_Load(object sender, EventArgs e)
        {
            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            supplierTable.DataSource = supplierDAO.getSuppliers();
        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
