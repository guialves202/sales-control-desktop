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
    public partial class Frmsale : Form
    {
        public Frmsale()
        {
            InitializeComponent();
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) { return; }

            Customer customer = new Customer();
            CustomerDAO customerDAO = new CustomerDAO(new ConnectionFactory().getConnection());

            customer = customerDAO.getCustomerByCPF(txtCPF.Text);
            if (customer == null) { return; }

            txtCustomerName.Text = customer.name;
        }

        private void btnSearchCEP_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            CustomerDAO customerDAO = new CustomerDAO(new ConnectionFactory().getConnection());

            customer = customerDAO.getCustomerByCPF(txtCPF.Text);
            if (customer == null) { return; }

            txtCustomerName.Text = customer.name;
        }

        private void btnSearchProductCode_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());

            product = productDAO.getProductById(int.Parse(txtCode.Text));
            if (product == null) { return; }

            txtProductName.Text = product.name;
            txtPrice.Text = product.price.ToString();
            txtQuantity.Text = "1";
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) { return; }

            Product product = new Product();
            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());

            product = productDAO.getProductById(int.Parse(txtCode.Text));
            if (product == null) { return; }

            txtProductName.Text = product.name;
            txtPrice.Text = product.price.ToString();
            txtQuantity.Text = "1";
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            string code = txtCode.Text;
            string price = txtPrice.Text;
            string quantityText = txtQuantity.Text;

            if (price == "" || quantityText == "" || code == "") { return; }
            int quantity = int.Parse(quantityText);

            Product product = new Product();
            ProductDAO productDAO = new ProductDAO(new ConnectionFactory().getConnection());

            product = productDAO.getProductById(int.Parse(code));
            if (product == null) { return; }

            txtPrice.Text = (product.price * quantity).ToString();
        }
    }
}
