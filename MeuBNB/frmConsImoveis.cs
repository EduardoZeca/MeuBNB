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
        Imoveis oImovel;
        Imoveis imovelSelecionado;
        CtrlImoveis aCtrlImovel;
        public frmConsImoveis()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0; //"GERAL" por padrão
        }
        public Imoveis ImovelSelecionado { get; private set; }
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
            listV.Items.Clear();
            List<Imoveis> listaResultados;
            
            if (string.IsNullOrEmpty(chave))
                listaResultados = aCtrlImovel.Listar();
            else
            {
                string filtro = cbFiltro.Text;
                listaResultados = aCtrlImovel.Pesquisar(chave, filtro);
            }
            foreach (Imoveis imovel in listaResultados)
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
        //Ao ser acessado pelo frmCadClientes para selecionar um imóvel
        public void ConfigurarModoSelecao(bool ativo)
        {
            // Esconde/Mostra botões de CRUD
            btnIncluir.Visible = !ativo;
            btnAlterar.Visible = !ativo;
            btnExcluir.Visible = !ativo;

            // Muda o texto do botão de sair
            btnSair.Text = ativo ? "SELECIONAR" : "SAIR";

            // Limpa seleção anterior
            if (ativo) ImovelSelecionado = null;
        }
        private void listV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listV.SelectedItems.Count > 0)
            {
                // Recupera o objeto completo da Tag do item (preenchido no CarregaLV)
                Imoveis imovelDaLista = (Imoveis)this.listV.SelectedItems[0].Tag;
                this.ImovelSelecionado = imovelDaLista;
                if (oImovel != null)
                {
                    oImovel.IdImovel = imovelDaLista.IdImovel;
                    oImovel.Rua = imovelDaLista.Rua;
                    oImovel.Numero = imovelDaLista.Numero;
                    oImovel.Bairro = imovelDaLista.Bairro;
                    oImovel.Cidade = imovelDaLista.Cidade;
                    oImovel.Disponibilidade = imovelDaLista.Disponibilidade;
                    oImovel.ValorDiaria = imovelDaLista.ValorDiaria;
                    oImovel.Despesas = imovelDaLista.Despesas;
                    oImovel.TipoImovel = imovelDaLista.TipoImovel;
                }
            }
        }
    }
}
