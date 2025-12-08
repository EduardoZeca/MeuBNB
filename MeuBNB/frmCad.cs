using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class frmCad : MeuBNB.FRM
    {
        public frmCad()
        {
            InitializeComponent();
        }
        public virtual void Salvar() { }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }
        public virtual void CarregaTxt() { }
        public virtual void LimpaTxt() { }
        public virtual void BloqTxt() { }
        public virtual void DesbloqTxt() { }
    }
}