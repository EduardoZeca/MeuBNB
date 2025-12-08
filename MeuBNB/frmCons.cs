using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class frmCons : MeuBNB.FRM
    {
        public frmCons()
        {
            InitializeComponent();
        }
        protected virtual void Incluir() { }
        protected virtual void Excluir() { }
        protected virtual void Alterar() { }
        protected virtual void Pesquisar() { }
        protected virtual void CarregaLV(string chave) { }
        public virtual void setFrmCad(object obj) { }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void vERCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        private void cADASTRARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {}
    }
}
