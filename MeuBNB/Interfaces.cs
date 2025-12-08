using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class Interfaces
    {
        frmCadImoveis frmCadImoveis;
        frmConsImoveis frmConsImoveis;
        frmCadClientes frmCadClientes;
        frmConsClientes frmConsClientes;
        public Interfaces()
        {
            frmCadImoveis = new frmCadImoveis();
            frmConsImoveis = new frmConsImoveis();
            frmCadClientes = new frmCadClientes();
            frmConsClientes = new frmConsClientes();

            frmConsImoveis.setFrmCad(frmCadImoveis);
            frmConsClientes.setFrmCad(frmCadClientes);
            frmCadClientes.setFrmCons(frmConsImoveis);
        }
        public void MostraImoveis(object obj, object ctrl)
        {
            frmConsImoveis.ConhecaObj(obj, ctrl);
            frmConsImoveis.ShowDialog();
        }
        public void MostraClientes(object obj, object ctrl)
        {
            frmConsClientes.ConhecaObj(obj, ctrl);
            frmConsClientes.ShowDialog();
        }
    }
}
