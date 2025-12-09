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
            //Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtQtd.Text) ||
                string.IsNullOrWhiteSpace(txtDiarias.Text) ||
                string.IsNullOrWhiteSpace(txtValorPago.Text) ||
                txtFormaPag.SelectedItem == null
                )
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validação dos campos numéricos
            int diarias;
            if (!int.TryParse(txtDiarias.Text, out diarias))
            {
                MessageBox.Show("Informe um número válido de diárias.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiarias.Focus();
                return;
            }
            int qtdPessoas;
            if (!int.TryParse(txtQtd.Text, out qtdPessoas))
            {
                MessageBox.Show("Informe a quantidade de pessoas válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtd.Focus();
                return;
            }
            double valorPago;
            if (!double.TryParse(txtValorPago.Text, System.Globalization.NumberStyles.Currency, null, out valorPago))
            {
                MessageBox.Show("Valor pago inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validação dos campos de datas
            if (txtDataFim.Value < txtDataInicio.Value)
            {
                MessageBox.Show("A Data de Fim não pode ser menor que a Data de Início.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Se chegou aqui, os dados são válidos
            try
            {
                oCliente.IdCliente = (txtId.Text == "" || txtId.Text == "0") ? 0 : Convert.ToInt32(txtId.Text);
                oCliente.Nome = txtNome.Text;
                oCliente.Cpf = txtCpf.Text;
                oCliente.DataInicioReserva = txtDataInicio.Value;
                oCliente.DataFimReserva = txtDataFim.Value;
                oCliente.Diarias = diarias;
                oCliente.QtdPessoas = qtdPessoas;
                oCliente.Telefone = txtTelefone.Text;
                oCliente.ValorPago = valorPago;
                oCliente.FormaPagamento = txtFormaPag.Text;

                // Verifica se um imóvel foi selecionado (importante para evitar erro de chave estrangeira)
                if (oCliente.OImovel == null || oCliente.OImovel.IdImovel == 0)
                {
                    // Tenta pegar do textbox caso o objeto não tenha sido preenchido, mas o ideal é garantir via objeto
                    int idImovelTemp;
                    if (int.TryParse(txtIdImovel.Text, out idImovelTemp) && idImovelTemp > 0)
                    {
                        oCliente.OImovel.IdImovel = idImovelTemp;
                    }
                    else
                    {
                        MessageBox.Show("Selecione um Imóvel antes de salvar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

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
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }
        public override void CarregaTxt()
        {
            this.txtId.Text = oCliente.IdCliente.ToString();
            this.txtNome.Text = oCliente.Nome;
            this.txtCpf.Text = oCliente.Cpf;
            this.txtDataInicio.Value = oCliente.DataInicioReserva;
            this.txtDataFim.Value = oCliente.DataFimReserva;
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
            try
            {
                oFrmConsImoveis.ConfigurarModoSelecao(true);
                oFrmConsImoveis.ConhecaObj(null, ctrlClientes.CtrlImoveis);
                oFrmConsImoveis.ShowDialog();
                //Verifica se algo foi selecionado ao voltar
                if (oFrmConsImoveis.ImovelSelecionado != null)
                {
                    // Clona o objeto para garantir segurança da referência
                    oCliente.OImovel = oFrmConsImoveis.ImovelSelecionado.Clone();
                    
                    this.txtIdImovel.Text = oCliente.OImovel.IdImovel.ToString();
                    this.txtDisponibilidade.SelectedItem = oCliente.OImovel.Disponibilidade;
                    this.txtTipo.SelectedItem = oCliente.OImovel.TipoImovel;

                    int numeroDiarias = 0;
                    int.TryParse(txtDiarias.Text, out numeroDiarias);

                    double total = oCliente.OImovel.ValorDiaria * numeroDiarias;
                    this.txtValorPago.Text = total.ToString("C2");
                }
            }
            finally
            {
                oFrmConsImoveis.ConfigurarModoSelecao(false);
            }
        }
        // Remove a formatação para facilitar a edição (R$ 1.000,00 -> 1000,00)
        private void TextBoxMoeda_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                string valorLimpo = txt.Text.Replace("R$", "").Trim();
                txt.Text = valorLimpo;
            }
        }
        // Aplica a formatação de moeda (1000,00 -> R$ 1.000,00)
        private void TextBoxMoeda_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (double.TryParse(txt.Text.Replace("R$", "").Trim(), out double valor))
                txt.Text = valor.ToString("C2");
            else
                txt.Text = "R$ 0,00";
        }
        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txtDiarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
