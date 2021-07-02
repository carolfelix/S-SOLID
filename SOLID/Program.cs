using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();

            Console.WriteLine("Digite uma sigla para o cargo que deseja saber o salário bruto:");

            Console.WriteLine("Dev - Desenvolvedor / Dba - Dba / Tester - Tester");
            var cargo = Console.ReadLine();

            Console.WriteLine("Digite o salário que deseja saber o valor bruto:");
            var valor = Console.ReadLine();

            var funcionario = new Funcionario(null, 0);
            
            switch (cargo)
            {
                case "Dev":
                     funcionario = new Funcionario(new Desenvolvedor(new QuinzeOuVinteECincoPorCento()), Convert.ToDouble(valor));
                    break;
                case "Dba":
                    funcionario = new Funcionario(new Dba(new DezOuVintePorCento()), Convert.ToDouble(valor));
                    break;
                case "Tester":
                    funcionario = new Funcionario(new Tester(new DezOuVintePorCento()), Convert.ToDouble(valor));
                    break;
                default:
                    break;
            }

            double resultado;

            resultado = calculadora.Calcula(funcionario);

            Console.WriteLine("O salário bruto de um " + cargo  +" que ganha " + valor + " é: " + resultado + ".");
            Console.ReadKey();
        }
    }
}
