using Org.BouncyCastle.Ocsp;
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
    }
}
