using System;

namespace ControleDePonto 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vendedor MeuVendedor = new Vendedor();
            MeuVendedor.Nome = "Vinicius";
            MeuVendedor.Comissao = 10;
            MeuVendedor.NumeroVendas = 100;

            ControlePonto Ponto = new ControlePonto();
            Ponto.RegistrarEntrada(MeuVendedor);
            Ponto.RegistrarSaida(MeuVendedor);
            
        }
}
}