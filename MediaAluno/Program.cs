using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estanciar Objt das classes presentes
            Pessoa pssa = new Pessoa();
            pssa.nome = "Fabio";
            pssa.nota1 = 6;
            pssa.nota2 = 3;
            pssa.nota3 = 9;
            pssa.nota4 = 7;
            pssa.mensagem();

        }
    }
}
