using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercurio",
    "Venus",
    "Terra",
    "Marte"
};
//ReadOnlyCollection will not allow modifications to the collection
var listaPlanetas = new ReadOnlyCollection<string>(planetas);
// var novaLista = planetas.AsReadOnly();

//Using linq to filter planets
listaPlanetas.ToList().ForEach(p => Console.WriteLine(p));
Console.WriteLine(listaPlanetas.Count());
Console.WriteLine(listaPlanetas.Contains("Terra") ? "Terra está na lista" : "Terra não está na lista");

Console.WriteLine("Planeta de indice 2: " + listaPlanetas[2]);
//IndexOf will return the index of the specified item
Console.WriteLine("Indice da terra na lista: " + listaPlanetas.IndexOf("Terra"));

Console.WriteLine("Copiando os planetas da coleção para um array");
var arrayPlanetas = new string[listaPlanetas.Count + 2];// Adding extra space for demonstration
listaPlanetas.CopyTo(arrayPlanetas, 1); // Copying starting from index 2
arrayPlanetas.ToList().ForEach(p => Console.WriteLine(p));


var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

//var exoPlanetas[0] = "NovoNome"; // This line will cause a compile-time error because ReadOnlyCollection does not allow modification

// exoPlanetas[0].Nome = "Novo Nome"; // This is allowed when we used complex types like classes because the collection itself is read-only, but the objects within it can still be modified.
public class ExoPlaneta
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() { Nome = "Proxima Centauri b" },
            new ExoPlaneta() { Nome = "Kepler-186f" },
            new ExoPlaneta() { Nome = "TRAPPIST-1e" }
        };
    }
}

public class GerenciadorExoPlanetas
{
    //So here we are using a private list to hold the exoplanets, and exposing it as a ReadOnlyCollection.
    //This allows us to add new exoplanets while preventing external modification of the collection.
    private List<ExoPlaneta>? exoPlanetas = ExoPlaneta.GetExoPlanetas();
    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get
        {
            return new ReadOnlyCollection<ExoPlaneta>(exoPlanetas);
        }
    }
    // Method to add a new exoplanet to the private list

    public void AdicionarExoPlaneta(ExoPlaneta exoPlaneta)
    {
        if (exoPlanetas != null)
        {
            exoPlanetas.Add(exoPlaneta);
        }
    }
}