namespace MeuBNB
{
    partial class frmConsImoveis
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
            this.colRua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDisponibilidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDespesas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listV
            // 
            this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRua,
            this.colBairro,
            this.colNum,
            this.colCidade,
            this.colDisponibilidade,
            this.colValor,
            this.colDespesas,
            this.colTipo});
            this.listV.SelectedIndexChanged += new System.EventHandler(this.listV_SelectedIndexChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Items.AddRange(new object[] {
            "GERAL",
            "RUA",
            "BAIRRO",
            "CIDADE",
            "DISPONIBILIDADE",
            "TIPO"});
            // 
            // colRua
            // 
            this.colRua.Text = "RUA";
            this.colRua.Width = 170;
            // 
            // colBairro
            // 
            this.colBairro.Text = "BAIRRO";
            this.colBairro.Width = 170;
            // 
            // colNum
            // 
            this.colNum.Text = "NUMERO";
            this.colNum.Width = 100;
            // 
            // colCidade
            // 
            this.colCidade.Text = "CIDADE";
            this.colCidade.Width = 170;
            // 
            // colDisponibilidade
            // 
            this.colDisponibilidade.Text = "DISPONIBILIDADE";
            this.colDisponibilidade.Width = 170;
            // 
            // colValor
            // 
            this.colValor.Text = "VALOR DIARIA";
            this.colValor.Width = 120;
            // 
            // colDespesas
            // 
            this.colDespesas.Text = "DESPESAS";
            this.colDespesas.Width = 120;
            // 
            // colTipo
            // 
            this.colTipo.Text = "TIPO";
            this.colTipo.Width = 150;
            // 
            // frmConsImoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1482, 728);
            this.Name = "frmConsImoveis";
            this.Text = "CONSULTA DE IMOVEIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader colRua;
        private System.Windows.Forms.ColumnHeader colBairro;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colCidade;
        private System.Windows.Forms.ColumnHeader colDisponibilidade;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colDespesas;
        private System.Windows.Forms.ColumnHeader colTipo;
    }
}
