using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class frmCadClientes : MeuBNB.frmCad
    {
        Clientes oCliente;
        frmConsImoveis oFrmConsImoveis;
        CtrlClientes ctrlClientes;
        public frmCadClientes()
        {
            InitializeComponent();
            txtDataFim.CustomFormat = "dd/MM/yyyy";
            txtDataInicio.CustomFormat = "dd/MM/yyyy";
        }
        public void setFrmCons(object obj)
        {
            if(obj!=null)
                oFrmConsImoveis = (frmConsImoveis)obj;
        }
        public override void Salvar()
        {
            oCliente.IdCliente = Convert.ToInt32(txtId.Text);
            oCliente.Nome = txtNome.Text;
            oCliente.Cpf = txtCpf.Text;
            oCliente.DataInicioReserva = Convert.ToDateTime(txtDataInicio.Text);
            oCliente.DataFimReserva = Convert.ToDateTime(txtDataFim.Text);
            oCliente.Diarias = Convert.ToInt32(txtDiarias.Text);
            oCliente.QtdPessoas = Convert.ToInt32(txtQtd.Text);
            oCliente.Telefone = txtTelefone.Text;
            oCliente.ValorPago = Convert.ToDouble(txtValorPago.Text);
            oCliente.FormaPagamento = txtFormaPag.Text;
            if (this.btnSalvar.Text == "SALVAR")
            {
                MessageBox.Show(ctrlClientes.Salvar(oCliente.Clone()));
            }
            else
            {
                var resp = MessageBox.Show("DESEJA EXCLUIR O CLIENTE DE ID: " + oCliente.IdCliente + "?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    MessageBox.Show(ctrlClientes.Excluir(oCliente));
                }
            }
        }
        public override void CarregaTxt()
        {
            this.txtId.Text = oCliente.IdCliente.ToString();
            this.txtNome.Text = oCliente.Nome;
            this.txtCpf.Text = oCliente.Cpf;
            this.txtDataInicio.Text = oCliente.DataInicioReserva.ToString("dd/MM/yyyy");
            this.txtDataFim.Text = oCliente.DataFimReserva.ToString("dd/MM/yyyy");
            this.txtDiarias.Text = oCliente.Diarias.ToString();
            this.txtQtd.Text = oCliente.QtdPessoas.ToString();
            this.txtTelefone.Text = oCliente.Telefone;
            this.txtValorPago.Text = oCliente.ValorPago.ToString("F2");
            this.txtFormaPag.SelectedItem = oCliente.FormaPagamento;
        }
        public override void LimpaTxt()
        {
            this.txtId.Text = "0";
            this.txtNome.Clear();
            this.txtCpf.Clear();
            this.txtDataInicio.Value = DateTime.Now;
            this.txtDataFim.Value = DateTime.Now;
            this.txtDiarias.Clear();
            this.txtQtd.Clear();
            this.txtTelefone.Clear();
            this.txtValorPago.Clear();
            this.txtFormaPag.SelectedItem = null;
        }
        public override void BloqTxt()
        {
            this.txtId.Enabled = false;
            this.txtNome.Enabled = false;
            this.txtCpf.Enabled = false;
            this.txtDataInicio.Enabled = false;
            this.txtDataFim.Enabled = false;
            this.txtDiarias.Enabled = false;
            this.txtQtd.Enabled = false;
            this.txtTelefone.Enabled = false;
            this.txtValorPago.Enabled = false;
            this.txtFormaPag.Enabled = false;
        }
        public override void DesbloqTxt()
        {
            this.txtId.Enabled = true;
            this.txtNome.Enabled = true;
            this.txtCpf.Enabled = true;
            this.txtDataInicio.Enabled = true;
            this.txtDataFim.Enabled = true;
            this.txtDiarias.Enabled = true;
            this.txtQtd.Enabled = true;
            this.txtTelefone.Enabled = true;
            this.txtValorPago.Enabled = true;
            this.txtFormaPag.Enabled = true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oCliente = (Clientes)obj;
            if(ctrl != null)
                ctrlClientes = (CtrlClientes)ctrl;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsImoveis.btnSair.Text;
            oFrmConsImoveis.btnSair.Text = "SELECIONAR";
            oFrmConsImoveis.ConhecaObj(oCliente.OImovel, ctrlClientes.CtrlImoveis);
            oFrmConsImoveis.ShowDialog();
            this.txtIdImovel.Text = oCliente.OImovel.IdImovel.ToString();
            this.txtDisponibilidade.SelectedItem = oCliente.OImovel.Disponibilidade;
            this.txtTipo.SelectedItem = oCliente.OImovel.TipoImovel;
            this.txtValorPago.Text = Convert.ToString(oCliente.OImovel.ValorDiaria * oCliente.Diarias);
            oFrmConsImoveis.btnSair.Text = btnSair;
        }
    }
}
