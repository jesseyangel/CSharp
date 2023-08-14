using System;
class Programa
{
    static void Main(string[] args)
    {
        //double: Um número de ponto flutuante de precisão dupla é frequentemente representado em 64 bits (8 bytes).
        double salario = 3000.15;
        Console.WriteLine(salario);

        //int: Um inteiro é geralmente representado em 32 bits (4 bytes).
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //long: Um número inteiro longo é frequentemente representado em 64 bits (8 bytes).
        long x = 2000000000;
        Console.WriteLine(x);

        //short: Um inteiro curto é frequentemente representado em 16 bits (2 bytes).
        short y = 15000;
        Console.WriteLine(y);

        //long: Um número inteiro longo é frequentemente representado em 64 bits (8 bytes).
        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}