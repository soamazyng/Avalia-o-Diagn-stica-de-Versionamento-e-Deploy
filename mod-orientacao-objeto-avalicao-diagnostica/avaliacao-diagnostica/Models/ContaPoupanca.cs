using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao_diagnostica.Models
{
    public class ContaPoupanca : ContaCorrente
    {
        public double SaldoInvestimento { get; set; }

        public DateTime DataUltimoAporte { get; set; }

        public ContaPoupanca(string nomeCompleto, string agencia, string contaDac, double saldo, double saldoInvestimento, DateTime dataUltimoAporte) 
            : base(nomeCompleto, agencia, contaDac, saldo)
        {
            SaldoInvestimento = saldoInvestimento;
            DataUltimoAporte = dataUltimoAporte;
        }

        public void Aporte(double valor)
        {
            SaldoInvestimento += valor;
            DataUltimoAporte = new DateTime();            
        }

        public override double Extrato()
        {
            return SaldoInvestimento;
        }
    }
}
