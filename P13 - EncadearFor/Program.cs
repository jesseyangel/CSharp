using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Executando o projeto 13 -Encadeando For");


        //*
        //**
        //***
        //****
        //******

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinhas)     //Após imprimir um asterisco, este trecho verifica
                    break;                                //se a coluna atual é maior ou igual à linha atual.
                                                          //Se for, o loop de coluna é interrompido usando o comando
                                                          //break. Isso faz com que os asteriscos sejam impressos apenas
                                                          //até a coluna correspondente à linha atual, formando a forma de triângulo.


            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();

    }
}