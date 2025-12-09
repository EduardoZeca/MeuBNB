using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class frmCadImoveis : MeuBNB.frmCad
    {
        Imoveis oImovel;
        CtrlImoveis aCTRL;
        public frmCadImoveis()
        {
            InitializeComponent();
        }
        public override void Salvar()
        {
            //Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtRua.Text) ||
                string.IsNullOrWhiteSpace(txtBairro.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                txtDisponibilidade.SelectedItem == null ||
                txtTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos de texto e selecione as opções.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validação dos campos numéricos
            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("O campo 'Número' deve conter apenas números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return;
            }
            double valorDiaria;
            if (!double.TryParse(txtValor.Text, out valorDiaria))
            {
                MessageBox.Show("O campo 'Valor Diária' inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
                return;
            }
            double despesas;
            if (!double.TryParse(txtDespesas.Text, out despesas))
            {
                MessageBox.Show("O campo 'Despesas' inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDespesas.Focus();
                return;
            }
            //Se chegou aqui, os dados são válidos
            try
            {
                oImovel.IdImovel = (txtID.Text == "" || txtID.Text == "0") ? 0 : Convert.ToInt32(txtID.Text);
                oImovel.Rua = txtRua.Text;
                oImovel.Numero = numero;
                oImovel.Bairro = txtBairro.Text;
                oImovel.Cidade = txtCidade.Text;
                oImovel.Disponibilidade = txtDisponibilidade.Text;
                oImovel.ValorDiaria = valorDiaria;
                oImovel.Despesas = despesas;
                oImovel.TipoImovel = txtTipo.Text;

                if (this.btnSalvar.Text == "SALVAR")
                {
                    MessageBox.Show(aCTRL.Salvar(oImovel.Clone()));
                }
                else
                {
                    var resp = MessageBox.Show("DESEJA EXCLUIR O IMÓVEL DE ID: " + oImovel.IdImovel + "?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        MessageBox.Show(aCTRL.Excluir(oImovel));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar dados: " + ex.Message);
            }
        }
        public override void LimpaTxt()
        {
            this.txtID.Text = "0";
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtBairro.Clear();
            this.txtCidade.Clear();
            this.txtDisponibilidade.SelectedItem = null;
            this.txtValor.Clear();
            this.txtDespesas.Clear();
            this.txtDisponibilidade.SelectedItem = null;
        }
        public override void CarregaTxt()
        {
            this.txtID.Text = oImovel.IdImovel.ToString();
            this.txtRua.Text = oImovel.Rua;
            this.txtNumero.Text = oImovel.Numero.ToString();
            this.txtBairro.Text = oImovel.Bairro;
            this.txtCidade.Text = oImovel.Cidade;
            this.txtDisponibilidade.SelectedItem = oImovel.Disponibilidade;
            this.txtValor.Text = oImovel.ValorDiaria.ToString("F2");
            this.txtDespesas.Text = oImovel.Despesas.ToString("F2");
            this.txtTipo.SelectedItem = oImovel.TipoImovel;
        }
        public override void BloqTxt()
        {
            this.txtID.Enabled = false;
            this.txtRua.Enabled = false;
            this.txtNumero.Enabled = false;
            this.txtBairro.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtDisponibilidade.Enabled = false;
            this.txtValor.Enabled = false;
            this.txtDespesas.Enabled = false;
            this.txtTipo.Enabled = false;
        }
        public override void DesbloqTxt()
        {
            this.txtID.Enabled = true;
            this.txtRua.Enabled = true;
            this.txtNumero.Enabled = true;
            this.txtBairro.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtDisponibilidade.Enabled = true;
            this.txtValor.Enabled = true;
            this.txtDespesas.Enabled = true;
            this.txtTipo.Enabled = true;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oImovel = (Imoveis)obj;
            if(ctrl != null)
                aCTRL = (CtrlImoveis)ctrl;
        }
        // Evento para permitir apenas a entrada de números no campo "Número"
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        // Evento para permitir apenas números e vírgula no campo "Valor da Diária"
        private void txtValorDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        // Evento para permitir apenas números e vírgula no campo "Despesas"
        private void txtDespesas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
