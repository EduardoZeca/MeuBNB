using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class FRM : Form
    {
        public FRM()
        {
            InitializeComponent();
        }
        public virtual void ConhecaObj(object obj, object ctrl)
        { }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
