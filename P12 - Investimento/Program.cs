using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Executando o projeto 12 - Investimento a longo prazo");

        double FatorRendimento = 1.005;
        double investimento = 1000;
        //Este é o início do primeiro loop (for) que itera através dos anos,
        //de 1 a 5. Cada iteração representa um ano.
        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {   
                investimento *= FatorRendimento;
            }   //simula um aumento no investimento com base no fator de rendimento.

            FatorRendimento += 0.001;
        }   //Esse trecho incrementa o fator de rendimento em 0.001, simulando um aumento no rendimento para o próximo ano.

        Console.WriteLine("Depois de 5 anos voce tera R$ " + investimento);

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();

    }
}