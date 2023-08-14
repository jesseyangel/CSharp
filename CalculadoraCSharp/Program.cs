using System;

class Program
{
    static void Main()
    {
        //Mostra tudo na tela antes de comecar
        Console.WriteLine("Calculadora Básica");
        Console.WriteLine("Escolha uma operação e a perte ENTER:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        //Input para escolher a operacao
        string operacaoEscolhida = Console.ReadLine();
        //Input dos numeros da oprecao e convertendo do tipo string para o tipo double
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());
        //Declarando o resultado como Double
        double resultado = 0.0;
        //Usando Switch Case para escolher qual uma das operacoes
        switch (operacaoEscolhida)
        {
            case "1":
                resultado = numero1 + numero2;
                break;
            case "2":
                resultado = numero1 - numero2;
                break;
            case "3":
                resultado = numero1 * numero2;
                break;
            case "4":
                resultado = numero1 / numero2;
                break;
            default:
                Console.WriteLine("Operação inválida!");
                return; // Sai do programa se a operação for inválida.
        }

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
}
