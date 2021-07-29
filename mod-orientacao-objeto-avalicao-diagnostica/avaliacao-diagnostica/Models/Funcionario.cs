using System;
using System.Collections.Generic;
using System.Text;

namespace avaliacao_diagnostica.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public double ValorHora { get; set; }

        public Funcionario()
        {
           
        }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }

        public virtual double CalculaSalario()
        {
            return ValorHora * CargaHoraria;
        }
    }
}
