namespace MeuBNB
{
    partial class frmConsClientes
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
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiarias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQtdPessoas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFormaPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colCPF,
            this.colTelefone,
            this.colDiarias,
            this.colDiaInicio,
            this.colDiaFim,
            this.colQtdPessoas,
            this.colValor,
            this.colFormaPag});
            this.listV.Location = new System.Drawing.Point(12, 100);
            this.listV.SelectedIndexChanged += new System.EventHandler(this.listV_SelectedIndexChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Items.AddRange(new object[] {
            "GERAL",
            "NOME",
            "CPF",
            "TELEFONE",
            "INICIO RESERVA",
            "VALOR PAGO",
            "FORMA DE PAGAMENTO"});
            // 
            // colNome
            // 
            this.colNome.Text = "NOME";
            this.colNome.Width = 170;
            // 
            // colCPF
            // 
            this.colCPF.Text = "CPF";
            this.colCPF.Width = 100;
            // 
            // colTelefone
            // 
            this.colTelefone.Text = "TELEFONE";
            this.colTelefone.Width = 100;
            // 
            // colDiarias
            // 
            this.colDiarias.Text = "DIARIAS";
            this.colDiarias.Width = 80;
            // 
            // colDiaInicio
            // 
            this.colDiaInicio.Text = "INICIO DA DIARIA";
            this.colDiaInicio.Width = 130;
            // 
            // colDiaFim
            // 
            this.colDiaFim.Text = "FIM DA DIARIA";
            this.colDiaFim.Width = 130;
            // 
            // colQtdPessoas
            // 
            this.colQtdPessoas.Text = "QUANTIDADE DE PESSOAS";
            this.colQtdPessoas.Width = 200;
            // 
            // colValor
            // 
            this.colValor.Text = "VALOR PAGO";
            this.colValor.Width = 130;
            // 
            // colFormaPag
            // 
            this.colFormaPag.Text = "FORMA DE PAGAMENTO";
            this.colFormaPag.Width = 180;
            // 
            // frmConsClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1482, 728);
            this.Name = "frmConsClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colCPF;
        private System.Windows.Forms.ColumnHeader colTelefone;
        private System.Windows.Forms.ColumnHeader colDiarias;
        private System.Windows.Forms.ColumnHeader colDiaInicio;
        private System.Windows.Forms.ColumnHeader colDiaFim;
        private System.Windows.Forms.ColumnHeader colQtdPessoas;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colFormaPag;
    }
}
