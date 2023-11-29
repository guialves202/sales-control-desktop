namespace salesControl.br.com.salescontrol.view
{
    partial class Frmemployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabEmployees = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLevel = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearchCEP = new System.Windows.Forms.Button();
            this.txtUF = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddressNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 100);
            this.panel1.TabIndex = 1;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.tabPage1);
            this.tabEmployees.Controls.Add(this.tabPage2);
            this.tabEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployees.Location = new System.Drawing.Point(8, 108);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.SelectedIndex = 0;
            this.tabEmployees.Size = new System.Drawing.Size(1100, 588);
            this.tabEmployees.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLevel);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtPosition);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btnSearchCEP);
            this.tabPage1.Controls.Add(this.txtUF);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtNeighborhood);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtComplement);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtAddressNumber);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCEP);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtCellphone);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtRG);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLevel
            // 
            this.txtLevel.FormattingEnabled = true;
            this.txtLevel.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.txtLevel.Location = new System.Drawing.Point(110, 502);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(285, 28);
            this.txtLevel.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(55, 506);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "Nível:";
            // 
            // txtPosition
            // 
            this.txtPosition.FormattingEnabled = true;
            this.txtPosition.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Estagiário",
            "Administrativo"});
            this.txtPosition.Location = new System.Drawing.Point(110, 455);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(285, 28);
            this.txtPosition.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(45, 459);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Cargo:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 409);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(285, 26);
            this.txtPassword.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(41, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Senha:";
            // 
            // btnSearchCEP
            // 
            this.btnSearchCEP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCEP.ForeColor = System.Drawing.Color.White;
            this.btnSearchCEP.Location = new System.Drawing.Point(293, 251);
            this.btnSearchCEP.Name = "btnSearchCEP";
            this.btnSearchCEP.Size = new System.Drawing.Size(95, 30);
            this.btnSearchCEP.TabIndex = 6;
            this.btnSearchCEP.Text = "Pesquisar";
            this.btnSearchCEP.UseVisualStyleBackColor = false;
            this.btnSearchCEP.Click += new System.EventHandler(this.btnSearchCEP_Click);
            // 
            // txtUF
            // 
            this.txtUF.FormattingEnabled = true;
            this.txtUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUF.Location = new System.Drawing.Point(849, 349);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(121, 28);
            this.txtUF.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(806, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "UF:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(495, 349);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(285, 26);
            this.txtCity.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(426, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(110, 348);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(285, 26);
            this.txtNeighborhood.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(41, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro:";
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(751, 299);
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(268, 26);
            this.txtComplement.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(630, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Complemento:";
            // 
            // txtAddressNumber
            // 
            this.txtAddressNumber.Location = new System.Drawing.Point(495, 300);
            this.txtAddressNumber.Name = "txtAddressNumber";
            this.txtAddressNumber.Size = new System.Drawing.Size(111, 26);
            this.txtAddressNumber.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(420, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Número:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 300);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 26);
            this.txtAddress.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(14, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(110, 253);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(172, 26);
            this.txtCEP.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(53, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "CEP:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(110, 207);
            this.txtCellphone.Mask = "(00) 0 0000-0000";
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(172, 26);
            this.txtCellphone.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(36, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(110, 161);
            this.txtPhone.Mask = "(00) 0000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(172, 26);
            this.txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(23, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(784, 69);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(172, 26);
            this.txtCPF.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(727, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(533, 68);
            this.txtRG.Mask = "00,000,000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(172, 26);
            this.txtRG.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(485, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(41, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(41, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(110, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(111, 26);
            this.txtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.employeesTable);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearchName);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // employeesTable
            // 
            this.employeesTable.AllowUserToAddRows = false;
            this.employeesTable.AllowUserToDeleteRows = false;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesTable.Location = new System.Drawing.Point(14, 74);
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.ReadOnly = true;
            this.employeesTable.Size = new System.Drawing.Size(1067, 463);
            this.employeesTable.TabIndex = 7;
            this.employeesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesTable_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(489, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 41);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(112, 31);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(356, 26);
            this.txtSearchName.TabIndex = 5;
            this.txtSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchName_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(43, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(789, 710);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 53);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(581, 710);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 53);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(370, 710);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 53);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(155, 710);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 53);
            this.btnNew.TabIndex = 28;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Frmemployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 774);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tabEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNew);
            this.Name = "Frmemployees";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.Frmemployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEmployees.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSearchCEP;
        private System.Windows.Forms.ComboBox txtUF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddressNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCellphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox txtLevel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox txtPosition;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label17;
    }
}