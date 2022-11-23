using System;

class Programa
{
    static void Main(string[] args)
    {
    }
}

/*      --> codigo das aulas <--

        int inteiro = 10;
        int outroInteiro = 0;
        float flutuante = 10.5f;
        double outroFlutuante = 10.5;
        string mensagem = "Tecle Enter para continuar...";
        bool ehJaguara = false;
        string hello = ehJaguara ? "Hello, Jaguara!" : "Hello, World!";

        outroInteiro = (int)flutuante;

        switch (inteiro)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("Um");
                break;
            default:
                Console.WriteLine($"Desconhecido: {inteiro}");
                break;
        }

        Console.WriteLine(hello);
        Console.WriteLine(inteiro);
        Console.WriteLine(outroInteiro);
        Console.WriteLine(flutuante);
        Console.WriteLine(outroFlutuante);
        if (ehJaguara)
            Console.WriteLine("Muito Jaguara!");
        else
            Console.WriteLine("Não é Jaguara!");
        Console.WriteLine(mensagem);
        Console.ReadLine(); 
*/

/*      --> numeros primos <--
        int max = 100;
        int i, j, qtd = 0;

        Console.WriteLine($"Números primos de 0 a {max}");
        for (i = 2; i <= max; i++)
        {
            bool ehPrimo = true;
            for (j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
            if (ehPrimo)
            {
                Console.WriteLine(i);
                qtd++;
            }
        }
        Console.WriteLine($"\nTotal: {qtd}");
*/

/*      --> fibonacci <--
        int max = 1000;
        int i = 0, j = 0, k = 0;

        Console.WriteLine($"Fibonacci 0 a {max}");
        while (j <= max)
        {
            Console.WriteLine(j);

            k = i;
            i = j;
            j = (j == 0) ? 1 : (k + i);
        }
*/