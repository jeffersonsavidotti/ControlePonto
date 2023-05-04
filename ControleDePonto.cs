using System;

namespace ControleDePonto
{
    public class ControlePonto
    {
        public void RegistrarEntrada(Funcionario funcionario)
        {
            ImprimirComprovante(funcionario, true);
        }
        public void RegistrarSaida(Funcionario funcionario)
        {
            ImprimirComprovante(funcionario, false);
        }
        public void ImprimirComprovante(Funcionario funcionario, bool ehEntrada)
        {
            String tipoEntrada = ehEntrada ? "Entrada" : "Saida";
            Console.WriteLine("{0}:{1}", tipoEntrada, DateTime.Now);
            Console.WriteLine("Funcionario:{0}", funcionario.Nome);
            Console.WriteLine("Cargo:{0}", funcionario.GetType().Name);


        }
    }
}
