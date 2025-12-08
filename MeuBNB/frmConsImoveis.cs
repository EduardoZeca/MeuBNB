using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeuBNB
{
    public partial class frmConsImoveis : MeuBNB.frmCons
    {
        frmCadImoveis ofrmCad;
        Interfaces inter;
        Imoveis oImovel;
        CtrlImoveis aCtrlImovel;
        public frmConsImoveis()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            ofrmCad.ConhecaObj(oImovel, aCtrlImovel);
            ofrmCad.LimpaTxt();
            ofrmCad.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Alterar()
        {
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            oImovel = (Imoveis)aCtrlImovel.CarregaObj(codSelecionado);
            ofrmCad.ConhecaObj(oImovel, aCtrlImovel);
            ofrmCad.LimpaTxt();
            ofrmCad.CarregaTxt();
            ofrmCad.ShowDialog();
            this.CarregaLV("");
        }
        protected override void Excluir()
        {
            string aux = ofrmCad.btnSalvar.Text;
            int codSelecionado = Convert.ToInt32(listV.SelectedItems[0].SubItems[0].Text);
            oImovel = (Imoveis)aCtrlImovel.CarregaObj(codSelecionado);
            ofrmCad.ConhecaObj(oImovel, aCtrlImovel);
            ofrmCad.LimpaTxt();
            ofrmCad.CarregaTxt();
            ofrmCad.BloqTxt();
            ofrmCad.btnSalvar.Text = "EXCLUIR";
            ofrmCad.ShowDialog();
            ofrmCad.DesbloqTxt();
            ofrmCad.btnSalvar.Text = aux;
            this.CarregaLV("");
        }
        protected override void Pesquisar()
        {
            this.CarregaLV(this.txtPesquisa.Text);
        }
        protected override void CarregaLV(string chave)
        {
            if(chave == "")
            {
                listV.Items.Clear();
                foreach (Imoveis imovel in aCtrlImovel.Listar())
                {
                    ListViewItem item = new ListViewItem(imovel.IdImovel.ToString());
                    item.SubItems.Add(imovel.Rua);
                    item.SubItems.Add(imovel.Bairro);
                    item.SubItems.Add(imovel.Numero.ToString());
                    item.SubItems.Add(imovel.Cidade);
                    item.SubItems.Add(imovel.Disponibilidade);
                    item.SubItems.Add(imovel.ValorDiaria.ToString("F2"));
                    item.SubItems.Add(imovel.Despesas.ToString("F2"));
                    item.SubItems.Add(imovel.TipoImovel);
                    item.Tag = imovel;
                    listV.Items.Add(item);
                }
            }
            else
            {
                listV.Items.Clear();
                foreach (Imoveis imovel in aCtrlImovel.Pesquisar(chave))
                {
                    ListViewItem item = new ListViewItem(imovel.IdImovel.ToString());
                    item.SubItems.Add(imovel.Rua);
                    item.SubItems.Add(imovel.Bairro);
                    item.SubItems.Add(imovel.Numero.ToString());
                    item.SubItems.Add(imovel.Cidade);
                    item.SubItems.Add(imovel.Disponibilidade);
                    item.SubItems.Add(imovel.ValorDiaria.ToString("F2"));
                    item.SubItems.Add(imovel.Despesas.ToString("F2"));
                    item.SubItems.Add(imovel.TipoImovel);
                    listV.Items.Add(item);
                }
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oImovel = (Imoveis)obj;
            if(ctrl != null)
                aCtrlImovel = (CtrlImoveis)ctrl;
            this.CarregaLV("");
        }
        public override void setFrmCad(object obj)
        {
            if(obj != null)
                ofrmCad = (frmCadImoveis)obj;
        }
        private void cONSULTARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inter.MostraClientes(oImovel, aCtrlImovel);
        }
        private void listV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.listV.SelectedItems[0];
                Imoveis imovel = (Imoveis)item.Tag;
                oImovel.IdImovel = imovel.IdImovel;
                oImovel.Rua = imovel.Rua;
                oImovel.Numero = imovel.Numero;
                oImovel.Bairro = imovel.Bairro;
                oImovel.Cidade = imovel.Cidade;
                oImovel.Disponibilidade = imovel.Disponibilidade;
                oImovel.ValorDiaria = imovel.ValorDiaria;
                oImovel.Despesas = imovel.Despesas;
                oImovel.TipoImovel = imovel.TipoImovel;
            }
        }
    }
}
