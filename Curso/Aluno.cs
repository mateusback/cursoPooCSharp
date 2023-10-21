using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso {
    internal class Aluno {
        public String Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal() {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public void VerificarAprovacao() {
        if(NotaFinal() >= 60.0) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
