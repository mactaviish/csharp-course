using System;

class Programa
{
    static void Main(string[] args)
    {
        int inteiro = 10;
        int outroInteiro = 0;
        float flutuante = 10.5f;
        double outroFlutuante = 10.5;
        
        outroInteiro = (int)flutuante;

        Console.WriteLine("Hello, World!");
        Console.WriteLine(inteiro);
        Console.WriteLine(outroInteiro);
        Console.WriteLine(flutuante);
        Console.WriteLine(outroFlutuante);
        Console.WriteLine("Tecle Enter para continuar...");
        Console.ReadLine();
    }
}