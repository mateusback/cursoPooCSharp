using System;
using System.Globalization;

namespace Curso {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine("Funcionario: " + funcionario.ToString());


            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentoSalario(porcentagem);

            Console.WriteLine("Dados Ataulizados: " + funcionario.ToString());
        }
    }
}