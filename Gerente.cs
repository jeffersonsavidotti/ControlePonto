using System;

namespace ControleDePonto
{
    public class Gerente : Funcionario
    {
        public double Bonificacao { get; set; }
        public override double CalculaSalario()
        {
            return Bonificacao + SalarioMinimo * 6;
        }
    }
}