using System.Security;

// public class Calculadora
// {
//     public static float Somar(float a, float b)
//     {
//         return a + b;
//     }
//     public static float Subtrair(float a, float b)
//     {
//         return a - b;
//     }
//     public static float Multiplicar(float a, float b)
//     {
//         return a * b;
//     }
//     public static float Dividir(float a, float b)
//     {
//         return a / b;
//     }

// }

// public delegate float DelegateCalculadora(float a, float b);

// public delegate void MeuDelegate(string mensagem);

// public class Program
// {
//     public static void Main(string[] args)
//     {

//         //Here we have 3 different ways to use the delegate
//         DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
//         var resultado = calc.Invoke(10, 5);
//         Console.WriteLine($"Resultado da soma: {resultado}");

//         DelegateCalculadora calc2 = Calculadora.Subtrair;
//         var resultado1 = calc2(10, 5);
//         Console.WriteLine($"Resultado da subtração: {resultado1}");

//         DelegateCalculadora calc3 = (float a, float b) => Calculadora.Somar(a, b);
//         var resultado2 = calc3(10, 5);
//         Console.WriteLine($"Resultado da soma (usando lambda): {resultado2}");



//         //Using multicast delegate

//         static void MeuMetodo1(string mensagem)
//         {
//             Console.WriteLine("Meu metodo 1: " + mensagem);
//         }

//         static void MeuMetodo2(string mensagem)
//         {
//             Console.WriteLine("Meu metodo 2: " + mensagem);
//         }

//         MeuDelegate delegateMultiCast = new MeuDelegate(MeuMetodo1);

//         delegateMultiCast += MeuMetodo2;
//         //We can add and remove methods from the multicast delegate
//         delegateMultiCast -= MeuMetodo2;

//         Console.WriteLine("Chamando o delegate multicast:");
//         delegateMultiCast("Olá, mundo!");




//         //Using anonymous methods with pre defined delegates

//         //here we  use an predefined delegate Predicate<T> with an lambda expression to simplify the code
//         // Predicate<T> is a delegate that represents a method that takes an input of type T and returns a boolean value
//         Console.WriteLine("INforme um número:");
//         int numero = Convert.ToInt32(Console.ReadLine());

//         Predicate<int> delegateParLambda = x => x % 2 == 0;

//         // Predicate<int> delegatePar = delegate (int x)
//         // {
//         //         return x % 2 == 0;
//         // };

//         if (delegateParLambda(numero))
//         {
//             Console.WriteLine("O número é par.");
//         }
//         else
//         {
//             Console.WriteLine("O número é ímpar.");
//         }

//         // static bool VerificaPar(int numero)
//         // {
//         //     return numero % 2 == 0;
//         // }


//         //ACTION<T> is a delegate that represents a method that takes an input of type T and does not return a value
//         Console.WriteLine("INforme um número:");
//         int numero1 = Convert.ToInt32(Console.ReadLine());

//         Action<int> dobra = x => Console.WriteLine(x * 2);
//         dobra(numero1);

//         // Duplicar(numero1);
//         // static void Duplicar(int x)
//         // {
//         //     int resultado = x * 2;
//         //     Console.WriteLine("Resultado da duplicação: " + resultado);
//         // }



//         //Func<T, TResult> is a delegate that represents a method that takes an input of type T and returns a value of type TResult

//         Console.WriteLine("INforme um número:");
//         double numero2 = Convert.ToDouble(Console.ReadLine());

//         //Using Func<T, TResult> to create an anonymous method for calculating the square root
//         //So after that we can use with a lambda to simplify the code
//         // Func<double, double> raizQuadrada = delegate (double x)
//         // {
//         //     return Math.Sqrt(x);
//         // };

//         //Func with lambda expression
//         Func<double, double> raizQuadrada = x => Math.Sqrt(x);

//         double resultadoFunc = raizQuadrada(numero2);

//         Console.WriteLine($"Resultado da raiz quadrada: {resultadoFunc}");

//         //
//         // var resultadoFunc2 = RaizQuadrada(numero2);
//         // static double RaizQuadrada(double x)
//         // {
//         //     return Math.Sqrt(x);
//         // }

//     }
// }

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    public static List<Pessoa> GetPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa("João", 10),
            new Pessoa("Maria", 30),
            new Pessoa("José", 20)
        };
       return pessoas;
    }

    static void Main(string[] args)
    {
        //Using Action<T> to loop through a list of Pessoa objects and display their properties
        var listaPessoas = Pessoa.GetPessoas();
        Console.WriteLine("Lista de Pessoas:");
        Action<Pessoa> exibirLista = pessoa => Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");

        listaPessoas.ForEach(exibirLista);

        //Using Predicate<T> to filter the list of Pessoa objects based on a condition (Idade > 18)
        Predicate<Pessoa> filtrarIdade = pessoa => pessoa.Idade > 18;
        var pessoasFiltradas = listaPessoas.FindAll(filtrarIdade);
        Console.WriteLine("\nPessoas com idade maior que 18:");
        pessoasFiltradas.ForEach(exibirLista);

        //Using Func<T, TResult> to get the maximum age from the list of Pessoa objects
        Func<Pessoa, int> obterIdade = pessoa => pessoa.Idade;
        var idadeMaxima = listaPessoas.Max(obterIdade);
        Console.WriteLine($"\nIdade máxima: {idadeMaxima}");
        Console.WriteLine($"Nome da pessoa mais velha: " + listaPessoas.FirstOrDefault(p => p.Idade == idadeMaxima)?.Nome);

    }
}
