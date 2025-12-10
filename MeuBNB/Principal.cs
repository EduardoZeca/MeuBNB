using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class Principal : Form
    {
        Interfaces inter = new Interfaces();
        Imoveis imovel = new Imoveis();
        Clientes cliente = new Clientes();
        CtrlImoveis ctrlImoveis = new CtrlImoveis();
        CtrlClientes ctrlClientes = new CtrlClientes();
        public Principal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            inter.MostraImoveis(imovel, ctrlImoveis);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            inter.MostraClientes(cliente, ctrlClientes);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
