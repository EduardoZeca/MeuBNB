using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    public class Imoveis
    {
        int idImovel;
        string rua;
        int numero;
        string bairro;
        string cidade;
        string disponibilidade;
        double valorDiaria;
        double despesas;
        string tipoImovel;
        public Imoveis()
        {
            idImovel = 0;
            rua = "";
            numero = 0;
            bairro = "";
            cidade = "";
            disponibilidade = "";
            valorDiaria = 0.0;
            despesas = 0.0;
            tipoImovel = "";
        }
        public Imoveis(int idImovel, string rua, int numero, string bairro, string cidade, string disponibilidade, double valorDiaria, double despesas, string tipoImovel)
        {
            this.idImovel = idImovel;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.disponibilidade = disponibilidade;
            this.valorDiaria = valorDiaria;
            this.despesas = despesas;
            this.tipoImovel = tipoImovel;
        }
        public Imoveis Clone() { return new Imoveis(this.idImovel, this.rua, this.numero, this.bairro, this.cidade, this.disponibilidade, this.valorDiaria, this.despesas, this.tipoImovel); }
        public int IdImovel { get => idImovel; set => idImovel = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Disponibilidade { get => disponibilidade; set => disponibilidade = value; }
        public double ValorDiaria { get => valorDiaria; set => valorDiaria = value; }
        public double Despesas { get => despesas; set => despesas = value; }
        public string TipoImovel { get => tipoImovel; set => tipoImovel = value; }
    }
}
