namespace salesControl.br.com.salescontrol.view
{
    partial class Frmsale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCPF = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpProduct = new System.Windows.Forms.GroupBox();
            this.btnSearchProductCode = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpCustomer.SuspendLayout();
            this.gpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDAS";
            // 
            // gpCustomer
            // 
            this.gpCustomer.Controls.Add(this.btnSearchCPF);
            this.gpCustomer.Controls.Add(this.txtDate);
            this.gpCustomer.Controls.Add(this.label9);
            this.gpCustomer.Controls.Add(this.txtCustomerName);
            this.gpCustomer.Controls.Add(this.label3);
            this.gpCustomer.Controls.Add(this.txtCPF);
            this.gpCustomer.Controls.Add(this.label6);
            this.gpCustomer.Location = new System.Drawing.Point(6, 118);
            this.gpCustomer.Name = "gpCustomer";
            this.gpCustomer.Size = new System.Drawing.Size(506, 216);
            this.gpCustomer.TabIndex = 3;
            this.gpCustomer.TabStop = false;
            this.gpCustomer.Text = "Cliente";
            // 
            // btnSearchCPF
            // 
            this.btnSearchCPF.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCPF.ForeColor = System.Drawing.Color.White;
            this.btnSearchCPF.Location = new System.Drawing.Point(235, 83);
            this.btnSearchCPF.Name = "btnSearchCPF";
            this.btnSearchCPF.Size = new System.Drawing.Size(95, 30);
            this.btnSearchCPF.TabIndex = 15;
            this.btnSearchCPF.Text = "Pesquisar";
            this.btnSearchCPF.UseVisualStyleBackColor = false;
            this.btnSearchCPF.Click += new System.EventHandler(this.btnSearchCEP_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDate.Location = new System.Drawing.Point(84, 38);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(142, 26);
            this.txtDate.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(22, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(84, 128);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(389, 26);
            this.txtCustomerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCPF.Location = new System.Drawing.Point(84, 85);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(142, 26);
            this.txtCPF.TabIndex = 11;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(26, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            // 
            // gpProduct
            // 
            this.gpProduct.Controls.Add(this.btnSearchProductCode);
            this.gpProduct.Controls.Add(this.btnRemove);
            this.gpProduct.Controls.Add(this.btnAdd);
            this.gpProduct.Controls.Add(this.txtPrice);
            this.gpProduct.Controls.Add(this.label7);
            this.gpProduct.Controls.Add(this.txtQuantity);
            this.gpProduct.Controls.Add(this.label5);
            this.gpProduct.Controls.Add(this.txtProductName);
            this.gpProduct.Controls.Add(this.label2);
            this.gpProduct.Controls.Add(this.txtCode);
            this.gpProduct.Controls.Add(this.label4);
            this.gpProduct.Location = new System.Drawing.Point(6, 354);
            this.gpProduct.Name = "gpProduct";
            this.gpProduct.Size = new System.Drawing.Size(506, 259);
            this.gpProduct.TabIndex = 4;
            this.gpProduct.TabStop = false;
            this.gpProduct.Text = "Produto";
            // 
            // btnSearchProductCode
            // 
            this.btnSearchProductCode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchProductCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProductCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProductCode.ForeColor = System.Drawing.Color.White;
            this.btnSearchProductCode.Location = new System.Drawing.Point(235, 26);
            this.btnSearchProductCode.Name = "btnSearchProductCode";
            this.btnSearchProductCode.Size = new System.Drawing.Size(95, 30);
            this.btnSearchProductCode.TabIndex = 16;
            this.btnSearchProductCode.Text = "Pesquisar";
            this.btnSearchProductCode.UseVisualStyleBackColor = false;
            this.btnSearchProductCode.Click += new System.EventHandler(this.btnSearchProductCode_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(269, 187);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(176, 44);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remover Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(50, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adicionar Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(318, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(155, 26);
            this.txtPrice.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(213, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preço (R$):";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(84, 125);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(111, 26);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(27, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Qtd.:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProductName.Location = new System.Drawing.Point(84, 74);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(389, 26);
            this.txtProductName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCode.Location = new System.Drawing.Point(84, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(142, 26);
            this.txtCode.TabIndex = 9;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código:";
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Location = new System.Drawing.Point(529, 124);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.Size = new System.Drawing.Size(573, 409);
            this.productTable.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(529, 539);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 74);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotal.Location = new System.Drawing.Point(247, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(187, 26);
            this.txtTotal.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(155, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total (R$):";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(529, 619);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(265, 53);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Pagamento";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(834, 619);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(268, 53);
            this.btnCancelSale.TabIndex = 18;
            this.btnCancelSale.Text = "Cancelar";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            // 
            // Frmsale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 684);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.gpProduct);
            this.Controls.Add(this.gpCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "Frmsale";
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.Frmsale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpCustomer.ResumeLayout(false);
            this.gpCustomer.PerformLayout();
            this.gpProduct.ResumeLayout(false);
            this.gpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpCustomer;
        private System.Windows.Forms.GroupBox gpProduct;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchCPF;
        private System.Windows.Forms.Button btnSearchProductCode;
    }
}