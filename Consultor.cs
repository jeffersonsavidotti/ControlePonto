using System;

namespace ControleDePonto
{
    public class Consultor : Funcionario
    {
        public double ValorHora { get; set; }
        public long HorasTrabalhadas { get; set; }
        public override double CalculaSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }
    }
}