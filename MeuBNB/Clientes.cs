using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    public class Clientes
    {
        int idCliente;
        string nome;
        string cpf;
        int diarias;
        int qtdPessoas;
        string telefone;
        DateTime dataInicioReserva;
        DateTime dataFimReserva;
        double valorPago;
        string formaPagamento;
        Imoveis oImovel;
        public Clientes()
        {
            idCliente = 0;
            nome = "";
            cpf = "";
            diarias = 0;
            qtdPessoas = 0;
            telefone = "";
            dataInicioReserva = DateTime.Now;
            dataFimReserva = DateTime.Now;
            valorPago = 0.0;
            formaPagamento = "";
            oImovel = new Imoveis();
        }
        public Clientes(int idCliente, string nome, string cpf, int diarias, int qtdPessoas, string telefone, DateTime dataInicioReserva, DateTime dataFimReserva, double valorPago, string formaPagamento, Imoveis oImovel)
        {
            this.idCliente = idCliente;
            this.nome = nome;
            this.cpf = cpf;
            this.diarias = diarias;
            this.qtdPessoas = qtdPessoas;
            this.telefone = telefone;
            this.dataInicioReserva = dataInicioReserva;
            this.dataFimReserva = dataFimReserva;
            this.valorPago = valorPago;
            this.formaPagamento = formaPagamento;
            this.oImovel = oImovel;
        }
        public Clientes Clone() { return new Clientes(this.idCliente, this.nome, this.cpf, this.diarias, this.qtdPessoas, this.telefone, this.dataInicioReserva, this.dataFimReserva, this.valorPago, this.formaPagamento, this.oImovel); }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Diarias { get => diarias; set => diarias = value; }
        public int QtdPessoas { get => qtdPessoas; set => qtdPessoas = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataInicioReserva { get => dataInicioReserva; set => dataInicioReserva = value; }
        public DateTime DataFimReserva { get => dataFimReserva; set => dataFimReserva = value; }
        public double ValorPago { get => valorPago; set => valorPago = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public Imoveis OImovel { get => oImovel; set => oImovel = value; }
    }
}
