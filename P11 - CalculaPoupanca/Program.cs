using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Executando o projeto 11 - Calcula Poupanca");

        double investimento = 500000;

        //     Variavel | Condicao | Contador || Funcina parecido com o While
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mes " + mes + " voce tem R$ " + investimento);
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();

    }
}