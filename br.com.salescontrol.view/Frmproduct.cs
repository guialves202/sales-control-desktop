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
    public partial class Frmproduct : Form
    {
        public Frmproduct()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void Frmproduct_Load(object sender, EventArgs e)
        {
            SupplierDAO supplierDAO = new SupplierDAO(new ConnectionFactory().getConnection());
            txtSupplier.DataSource = supplierDAO.getSuppliers();
            txtSupplier.DisplayMember = "nome";
            txtSupplier.ValueMember = "id";

            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());
            productTable.DataSource = productDAO.getProducts();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            new Helpers().ClearScreen(this);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = txtName.Text;
            product.price = decimal.Parse(txtPrice.Text);
            product.stockQuantity = int.Parse(txtStock.Text);
            product.supplierId = int.Parse(txtSupplier.SelectedValue.ToString());

            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());
            productDAO.registerProduct(product);

            productTable.DataSource = productDAO.getProducts();

            new Helpers().ClearScreen(this);
            tabProduct.SelectedTab = tabPage2;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int productId = int.Parse(txtCode.Text);

            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());
            productDAO.deleteProduct(productId);

            productTable.DataSource = productDAO.getProducts();

            new Helpers().ClearScreen(this);
            tabProduct.SelectedTab = tabPage2;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.code = int.Parse(txtCode.Text);
            product.name = txtName.Text;
            product.price = decimal.Parse(txtPrice.Text);
            product.stockQuantity = int.Parse(txtStock.Text);
            product.supplierId = int.Parse(txtSupplier.SelectedValue.ToString());

            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());
            productDAO.editProduct(product);

            productTable.DataSource = productDAO.getProducts();

            new Helpers().ClearScreen(this);
            tabProduct.SelectedTab = tabPage2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string productName = txtSearchName.Text;

            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());
            productTable.DataSource = productDAO.getProductByName(productName);
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string productName = txtSearchName.Text;

            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());
            productTable.DataSource = productDAO.getProductsByName(productName);
        }

        private void productTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = productTable.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = productTable.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = productTable.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = productTable.CurrentRow.Cells[3].Value.ToString();
            txtSupplier.Text = productTable.CurrentRow.Cells[4].Value.ToString();

            tabProduct.SelectedTab = tabPage1;
        }
    }
}
