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
    public partial class Frmpayment : Form
    {
        private Customer customer = new Customer();
        private DataTable cart = new DataTable();
        public Frmpayment(Customer customer, DataTable cart)
        {
            InitializeComponent();
            this.customer = customer;
            this.cart = cart;
        }

        private void btnFinishSale_Click(object sender, EventArgs e)
        {

        }

        public void writeTotal(decimal total)
        {
            txtTotal.Text = total.ToString();
        }

        private void Frmpayment_Load(object sender, EventArgs e)
        {

        }
    }
}
