using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao_diagnostica.Models
{
    public class ContaCorrente
    {
        public string NomeCompleto { get; set; }
        public string Agencia { get; set; }
        public string ContaDac { get; set; }

        public double Saldo { get; set; }

        public ContaCorrente(string nomeCompleto, string agencia, string contaDac, double saldo)
        {
            NomeCompleto = nomeCompleto;
            Agencia = agencia;
            ContaDac = contaDac;
            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public virtual double Extrato()
        {
            return Saldo;
        }
    }
}
