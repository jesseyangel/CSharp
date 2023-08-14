using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeRangel = 16;
        int quantidadePessoas = 2;

        // Craindo variavel booleana, se for maior que 1 e True se nao False
        bool acompanhado = quantidadePessoas > 1;

        //Declarando bloco como string
        string textoAdicional;

        //Se acompanhado for True, imprima "Rangel está acompanhado."
        if (acompanhado == true)
        {
            textoAdicional = "Rangel está acompanhado.";
        }//Se acompanhado for False, imprima "Rangel nao está acompanhado."
        else
        {
            textoAdicional = "Rangel não está acompanhado.";
        }
        //Se idade for maior ou igual a 18 ou estiver acompanhado
        if (idadeRangel >= 18 || acompanhado)
        {
            //Imprima "Pode entrar"
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }//Se nao estiver acompanhado e nem tiver 18 anos, imprima "Nao pode entrar"
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}