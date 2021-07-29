using System;
using System.Collections.Generic;
using System.Text;

namespace avaliacao_diagnostica.Models
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public string EmpresaOrigem { get; set; }

        public double TaxaServico { get; set; }

        public FuncionarioTerceirizado()           
        {
                        
        }

        public FuncionarioTerceirizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico)
           : base(nome, cargaHoraria, valorHora)
        {
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }

        public override double CalculaSalario()
        {
            var salarioBase = ValorHora * CargaHoraria;
            var taxaExtra = salarioBase * (TaxaServico / 100);
            return salarioBase + taxaExtra;
        }
    }
}
