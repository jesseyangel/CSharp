using System;
class Programa
{
    static void Main(string[] args)
    {
        //Mostrar
        Console.WriteLine("Executando projeto 6 - Atribuicoes de variaveis");
        //Declarar idade como numero inteiro
        int idade = 30;
        //Mostrar que a idade da Ana e igual o valor da idade
        int idadeAna = idade;
        //Mostrando que ele imprime ainda a idade que foi declarada primeiro
        Console.WriteLine(idadeAna);

        idade = 25;


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}