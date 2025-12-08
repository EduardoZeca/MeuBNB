namespace MeuBNB
{
    partial class frmCadClientes
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtDiarias = new System.Windows.Forms.TextBox();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFim = new System.Windows.Forms.DateTimePicker();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFormaPag = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDisponibilidade = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.txtIdImovel = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(14, 71);
            this.txtId.MaxLength = 5;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(163, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(294, 71);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(374, 22);
            this.txtNome.TabIndex = 6;
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Location = new System.Drawing.Point(674, 71);
            this.txtCpf.MaxLength = 14;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(226, 22);
            this.txtCpf.TabIndex = 7;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(906, 71);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(226, 22);
            this.txtTelefone.TabIndex = 8;
            // 
            // txtQtd
            // 
            this.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtd.Location = new System.Drawing.Point(1138, 71);
            this.txtQtd.MaxLength = 3;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 22);
            this.txtQtd.TabIndex = 9;
            // 
            // txtDiarias
            // 
            this.txtDiarias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiarias.Location = new System.Drawing.Point(295, 139);
            this.txtDiarias.MaxLength = 2;
            this.txtDiarias.Name = "txtDiarias";
            this.txtDiarias.Size = new System.Drawing.Size(100, 22);
            this.txtDiarias.TabIndex = 10;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataInicio.Location = new System.Drawing.Point(401, 139);
            this.txtDataInicio.MaxDate = new System.DateTime(2030, 12, 30, 0, 0, 0, 0);
            this.txtDataInicio.MinDate = new System.DateTime(2025, 12, 1, 0, 0, 0, 0);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(254, 22);
            this.txtDataInicio.TabIndex = 11;
            this.txtDataInicio.Value = new System.DateTime(2025, 12, 5, 12, 20, 23, 0);
            // 
            // txtDataFim
            // 
            this.txtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataFim.Location = new System.Drawing.Point(661, 139);
            this.txtDataFim.MaxDate = new System.DateTime(2030, 12, 30, 0, 0, 0, 0);
            this.txtDataFim.MinDate = new System.DateTime(2025, 12, 1, 0, 0, 0, 0);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(254, 22);
            this.txtDataFim.TabIndex = 12;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(921, 139);
            this.txtValorPago.MaxLength = 6;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 22);
            this.txtValorPago.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1136, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "QUANTIDADE DE PESSOAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "DIARIAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "DATA DE INICIO DA DIARIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "DATA DE TERMINO DA DIARIA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(920, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "VALOR PAGO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1026, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "FORMA DE PAGAMENTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "TELEFONE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "CPF";
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFormaPag.FormattingEnabled = true;
            this.txtFormaPag.Items.AddRange(new object[] {
            "DINHEIRO",
            "DÉBITO",
            "CRÉDITO",
            "PIX"});
            this.txtFormaPag.Location = new System.Drawing.Point(1027, 137);
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Size = new System.Drawing.Size(211, 24);
            this.txtFormaPag.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "ID IMOVEL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "DISPONIBILIDADE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "TIPO IMOVEL";
            // 
            // txtDisponibilidade
            // 
            this.txtDisponibilidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDisponibilidade.FormattingEnabled = true;
            this.txtDisponibilidade.Items.AddRange(new object[] {
            "RESERVADO",
            "DISPONIVEL"});
            this.txtDisponibilidade.Location = new System.Drawing.Point(294, 228);
            this.txtDisponibilidade.Name = "txtDisponibilidade";
            this.txtDisponibilidade.Size = new System.Drawing.Size(185, 24);
            this.txtDisponibilidade.TabIndex = 28;
            // 
            // txtTipo
            // 
            this.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "CASA",
            "KITNET",
            "APARTAMENTO"});
            this.txtTipo.Location = new System.Drawing.Point(485, 228);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(170, 24);
            this.txtTipo.TabIndex = 29;
            // 
            // txtIdImovel
            // 
            this.txtIdImovel.Location = new System.Drawing.Point(14, 230);
            this.txtIdImovel.MaxLength = 5;
            this.txtIdImovel.Name = "txtIdImovel";
            this.txtIdImovel.Size = new System.Drawing.Size(163, 22);
            this.txtIdImovel.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(663, 227);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 25);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1482, 733);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdImovel);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDisponibilidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtDiarias);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Name = "frmCadClientes";
            this.Text = "CADASTRO DE CLIENTES";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtCpf, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.txtQtd, 0);
            this.Controls.SetChildIndex(this.txtDiarias, 0);
            this.Controls.SetChildIndex(this.txtDataInicio, 0);
            this.Controls.SetChildIndex(this.txtDataFim, 0);
            this.Controls.SetChildIndex(this.txtValorPago, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtDisponibilidade, 0);
            this.Controls.SetChildIndex(this.txtTipo, 0);
            this.Controls.SetChildIndex(this.txtIdImovel, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtDiarias;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.DateTimePicker txtDataFim;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtFormaPag;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtDisponibilidade;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.TextBox txtIdImovel;
        private System.Windows.Forms.Button btnBuscar;
    }
}
