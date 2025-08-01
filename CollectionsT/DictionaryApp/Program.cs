

            //Dictionary
            
            Dictionary<int, int> dic1 = new Dictionary<int, int>();
            
            var dic2 = new Dictionary<int, int>();
            dic2.Add(1, 100);
            dic2.Add(3, 100);
            dic2.Add(4, 200);

        // Example of a dictionary with reference type custom class
        // This example uses a dictionary to store students with their respective grades.
        Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
        {
            {1, new Aluno("Leonardo", 7)},
            {2, new Aluno("Maria", 3)},
            {3, new Aluno("Isabella", 9)},
            {4, new Aluno("Lucas", 10)},
            {5, new Aluno("Pedro", 6)},
        };

        //SortedDictionary

        SortedDictionary<int, string> brics = new SortedDictionary<int, string>()
        {
            {20, "Brasil"},
            {10, "URSS"},
            {30, "China"},
            {40, "Alemanha"},
            {50, "França"}
        };

        if (brics.ContainsKey(60))
        {
            Console.WriteLine("Brasil está no dicionário");
        }
        else
        {
            brics.Add(60, "EUA");
        }
        //Count return the number of elements in the dictionary
        Console.WriteLine("Numero de elementos no dicionário: " + brics.Count);
        
        //Iterating through the dictionary
        var valor = brics[20];
        Console.WriteLine("Valor associado à chave 20: " + valor);
        //Updating a value in the dictionary
        brics[20] = "Brasil atualizado";
        //Removing an element from the dictionary
        brics.Remove(10);
        //Verifying if a key or value exists in the dictionary
        Console.WriteLine("Verificando se uma chave existe no dicionário:");
        Console.WriteLine("Chave 30 existe? " + brics.ContainsKey(30)); //->return true
                                                                        
        //verifying if a value exists in the dictionary
        Console.WriteLine("Verificando se um valor existe no dicionário:");
        Console.WriteLine("Valor China existe? " + brics.ContainsValue("China")); //->return true

        // Accessing a value using TryGetValue
        Console.WriteLine("Obtendo valor usando TryGetValue:");
        if (brics.TryGetValue(30, out string? valorChave30))
        {
            Console.WriteLine("Valor associado à chave 30: " + valorChave30); //retrurn "China"
        }

        foreach(var pais in brics)
        {
            Console.WriteLine($"Chave: {pais.Key}, Valor: {pais.Value}");
        }

    public class Aluno
{
    public int Nota { get; set; }
    public string Nome { get; set; }


    public Aluno(string nome, int nota)
    {
        Nota = nota;
        Nome = nome;
    }
}
    