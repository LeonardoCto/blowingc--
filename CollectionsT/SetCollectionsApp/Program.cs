
class HashSetc
{
    static void Main(string[] args)
    {

        var numeros = new HashSet<int> { 1, 2, 3, 4, 5 };
        var frutas = new HashSet<string> { "Uva", "Maça", "Pera" };

        HashSet<int> pares = new HashSet<int>();
        for (int i = 0; i < 6; i++)
        {
            pares.Add(i * 2);
        }


        // //Using IEnumerable
        var impares = new int[] { 1, 3, 5, 7, 9 };
        HashSet<int> conjunto = new HashSet<int>(impares);

        var lista = new List<int>() { 1, 2, 3, 4, 5, 6 };
        HashSet<int> conjuntoLista = new HashSet<int>(lista);



        HashSet<string> timesSP = new HashSet<string> { "Santos", "Palmeiras", "SãoPaulo" };

        HashSet<string> timesRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense" };

        HashSet<string> timesBA = new HashSet<string> { "Bahia", "Vtória", "Juazeiro" };

        var timesMundiais = new HashSet<string> { "Santos", "Palmeiras", "SãoPaulo", "Flamengo" };


        if (!timesSP.Contains("Corinthians"))
        {
            timesSP.Add("Corinthians");
            timesSP.Add("Santos");

        }

        var resultado = timesBA.Remove("Juazeiro");

        //SubSetOf return a bool true or false if the current HashSet<T> is a subset of the collection passed as parameter
        if (timesSP.IsSubsetOf(timesMundiais))
        {
            Console.WriteLine("Times SP é um subconjunto de times mundiais");
        }

        //SupersetOf return a bool true or false if the current HashSet<T> is a superset of the collection passed as parameter
        if (timesMundiais.IsSupersetOf(timesSP))
        {
            Console.WriteLine("TimesMundiais é um superconjunto de times sp");
        }

        //Overlaps return a bool true or false if the current HashSet<T> has any elements in common with the collection passed as parameter
        if (timesRJ.Overlaps(timesMundiais))
        {
            Console.WriteLine("Ao menos um time do RJ tem mundial");
        }

        //SetEquals return a bool true or false if the current HashSet<T> has the same elements as the collection passed as parameter
        if (!timesSP.SetEquals(timesRJ))
        {
            Console.WriteLine("Times SP e times RJ não contem os mesmos elementos");
        }

        //UnionWith will add all elements of the collection passed as parameter into the current HashSet removing duplicates
        Console.WriteLine("Juntando os HashSet<T>: SP, RJ E BA");
        timesSP.UnionWith(timesRJ);
        timesSP.UnionWith(timesBA);
        //We can also use a sorted set to order the elements
        var todosTimes = new SortedSet<string>(timesSP);
        ExibirColecao(todosTimes);

        //IntersertWith will return all the commom elements between the current HashSet<T> and the collection passed as parameter
        Console.WriteLine("Interseção de dois HashSet<T>: timesSP e times mundiais");
        timesSP.IntersectWith(timesMundiais);
        ExibirColecao(timesSP);

        //ExceptWith will remove all elements of the collection passed as parameter from the current HashSet<T>
        Console.WriteLine("Diferença de dois HashSet<T>: times mundiais e timesSp");
        timesMundiais.ExceptWith(timesSP);
        ExibirColecao(timesMundiais);

        //SymmetricExceptWith will compare both HashSet<T> and return the elements that are not in both collections
        Console.WriteLine("Diferença de dois HashSet<T>: times mundiais e timesSp com SymmectricExceptWith");
        timesMundiais.SymmetricExceptWith(timesSP);
        ExibirColecao(timesMundiais);


        Console.WriteLine("Remover todos os elementos");
        timesMundiais.Clear();


        //Here we created a generic method that receive a IEnumerable<T> in params
        //That works because HashSet is into the Syste.Collections.Generic and implements IEnumerable<T>
        static void ExibirColecao<T>(IEnumerable<T> colecao)
        {
            foreach (var item in colecao)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}



