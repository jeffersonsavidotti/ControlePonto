using System;

namespace ControleDePonto
{
	public abstract class Funcionario
	{
		public const double SalarioMinimo = 1302;
		public String Nome { get; set; }
		public String CPF { get; set; }
		public abstract double CalculaSalario();
	}
}