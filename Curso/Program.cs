using System;
using System.Globalization;

namespace Curso {
    internal class Program {
        public static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL: {0}", aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            aluno.VerificarAprovacao();
        }
    }
}