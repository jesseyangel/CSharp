using System;
class Programa
{
    static void Main(string[] args)
    {   //Mostrando na tela
        Console.WriteLine("Projeto 2 - Criando Variáveis");
        //declarando idade como tipo int
        int idade;
        //definindo valor da idade
        idade = 24;
        //Concatenando texto com a variavel idade
        Console.WriteLine("Minha idade e " + idade);
        //criando uma condicao
        idade = 24 - 5;
        //mostrando na tela o resultado da idade agora
        Console.WriteLine(idade);
        //Criando nova soma para teste sobre o a ordem dos precedentes 
        idade = 5 * 2 - 6;
        //Pedindo para printar a idade 
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}