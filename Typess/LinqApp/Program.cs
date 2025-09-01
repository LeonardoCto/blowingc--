List<string> nomes = new List<string>()
{
        "Leonardo","Maria","Amanda","Isabella"
};

//Using LINQ with query sintax
var resultado = from m in nomes where m.Contains('o') select m;

ExibirResultado(resultado);

//So we have a lot of oters method of System.Linq
//nomes.Where 
// nomes.Add
//nomes.AddRange;.....


//Using LINQ with lambda expression Method Sintax
var resultado2 = nomes.Where(m => m.Contains('r'));

ExibirResultado(resultado2);

static void ExibirResultado(IEnumerable<string> resultado)
{
    foreach (var item in resultado)
    {
         Console.WriteLine($"{item}");
    }
}