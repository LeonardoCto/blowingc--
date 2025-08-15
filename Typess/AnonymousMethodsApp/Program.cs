
using System;
using System.Collections.Generic;

public class AnonymousMethodsApp
{
    public static void Main(string[] args)
    {

        List<string> nomes = new List<string> { "João", "Maria", "José" };

        // string resultado = nomes.Find(VerificaNomeNaLista);

        //using delegate to create an anonymous method
        string? resultado = nomes.Find(delegate (string nome)
        {
            return nome.Equals("Maria");
        });

        //using lambda expression to create an anonymous method
        string? resultado2 = nomes.Find(nome => nome.Equals("Maria"));
                                       //param => expression

        Console.WriteLine($"Resultado da busca: {resultado}");

    }
}





