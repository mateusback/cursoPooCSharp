using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso {
    internal class Funcionario {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido;
        
        public Funcionario(String nome, double salarioBruto, double imposto) {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
            SalarioLiquido = salarioBruto - imposto;
        }

        public void AumentoSalario(double porcentagem) {
            SalarioLiquido = SalarioLiquido * porcentagem;
        }

        public override string ToString() {
            return Nome
                + ", $"
                + SalarioLiquido;
        }
    }
}
