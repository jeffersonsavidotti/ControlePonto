using System;
namespace ControleDePonto
{
    public class Vendedor:Funcionario
    {
        public double Comissao { get; set; }
        public long NumeroVendas { get; set; }
        public override double CalculaSalario()
        {
            return Comissao*NumeroVendas+SalarioMinimo;
        }
    }
}