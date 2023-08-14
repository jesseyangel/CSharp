using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando um projeto 5 - Caracteres e Textos");

        // O tipo char é usado para representar caracteres individuais,
        // como letras em uma palavra, dígitos numéricos, sinais de pontuação, entre outros.
        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);
        // Mostrando que string serve para declarar que e algo do tipo texto
        string primeiraFrase = "Ranjas - Cursos de Tecnologia ";
        // Concatenando string com numero
        Console.WriteLine(primeiraFrase + 2023);
        // Mostrando que nao imprimi nada quando ta vazia, so quando e com '' simples
        string vazia = " ";
        Console.WriteLine(vazia);

        letra = ' ';
        // Mostrando como pulas linha para deixa visualmente mais bonito
        string cursos = @"Cursos disponiveis: 
- C 
- C# 
- Python 
- JavaScript ";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}