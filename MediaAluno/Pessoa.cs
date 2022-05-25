using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pessoa
{
    // Atributos
    public string nome;
    public double nota1, nota2, nota3, nota4;


    // Média
    public double media()
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }


    // Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    // Mensagem
    public void mensagem()
    {
        // Obter a média
        double obterMedia = media();

        // Obter a situação
        string obterSituacao = situacao(obterMedia);

        // Mensagem
        Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
    }

}

