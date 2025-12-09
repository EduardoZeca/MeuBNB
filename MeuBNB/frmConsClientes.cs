using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class frmConsClientes : MeuBNB.frmCons
    {
        frmCadClientes oFrmCadClientes;
        Clientes cliente;
        CtrlClientes ctrlClientes;
        public frmConsClientes()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0; //"GERAL" por padrão
        }
        protected override void Incluir()
        {
            oFrmCadClientes.ConhecaObj(cliente, ctrlClientes);
            oFrmCadClientes.LimpaTxt();
            oFrmCadClientes.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Alterar()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            cliente = (Clientes)ctrlClientes.CarregaObj(codSelecionado);
            oFrmCadClientes.ConhecaObj(cliente, ctrlClientes);
            oFrmCadClientes.LimpaTxt();
            oFrmCadClientes.CarregaTxt();
            oFrmCadClientes.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Excluir()
        {
            string aux = oFrmCadClientes.btnSalvar.Text;
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            cliente = (Clientes)ctrlClientes.CarregaObj(codSelecionado);
            oFrmCadClientes.ConhecaObj(cliente, ctrlClientes);
            oFrmCadClientes.LimpaTxt();
            oFrmCadClientes.CarregaTxt();
            oFrmCadClientes.BloqTxt();
            oFrmCadClientes.btnSalvar.Text = "EXCLUIR";
            oFrmCadClientes.ShowDialog();
            oFrmCadClientes.DesbloqTxt();
            oFrmCadClientes.btnSalvar.Text = aux;
            this.CarregaLV("");
        }
        protected override void Pesquisar()
        {
            this.CarregaLV(this.txtPesquisa.Text);
        }
        public override void setFrmCad(object obj)
        {
            if(obj != null)
                oFrmCadClientes = (frmCadClientes)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                cliente = (Clientes)obj;
            if(ctrl != null)
                ctrlClientes = (CtrlClientes)ctrl;
            this.CarregaLV("");
        }
        protected override void CarregaLV(string chave)
        {
            listV.Items.Clear();
            List<Clientes> listaClientes;
            if (string.IsNullOrEmpty(chave))
                listaClientes = ctrlClientes.Listar();
            else
            {
                string filtro = cbFiltro.SelectedItem.ToString();
                listaClientes = ctrlClientes.Pesquisar(chave, filtro);
            }

            foreach (Clientes ocliente in listaClientes)
            {
                ListViewItem item = new ListViewItem(ocliente.IdCliente.ToString());
                item.SubItems.Add(ocliente.Nome);
                item.SubItems.Add(ocliente.Cpf);
                item.SubItems.Add(ocliente.Telefone);
                item.SubItems.Add(ocliente.Diarias.ToString());
                item.SubItems.Add(ocliente.DataInicioReserva.ToString());
                item.SubItems.Add(ocliente.DataFimReserva.ToString());
                item.SubItems.Add(ocliente.QtdPessoas.ToString());
                item.SubItems.Add(ocliente.ValorPago.ToString("F2"));
                item.SubItems.Add(ocliente.FormaPagamento);
                item.Tag = ocliente;
                listV.Items.Add(item);
            }
        }
        private void listV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.listV.SelectedItems[0];
                Clientes clienteSelecionado = (Clientes)item.Tag;
                cliente.IdCliente = clienteSelecionado.IdCliente;
                cliente.Nome = clienteSelecionado.Nome;
                cliente.Cpf = clienteSelecionado.Cpf;
                cliente.Telefone = clienteSelecionado.Telefone;
                cliente.Diarias = clienteSelecionado.Diarias;
                cliente.DataInicioReserva = clienteSelecionado.DataInicioReserva;
                cliente.DataFimReserva = clienteSelecionado.DataFimReserva;
                cliente.QtdPessoas = clienteSelecionado.QtdPessoas;
                cliente.ValorPago = clienteSelecionado.ValorPago;
                cliente.FormaPagamento = clienteSelecionado.FormaPagamento;
            }
        }
    }
}
