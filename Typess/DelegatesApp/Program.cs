public class Calculadora
{
    public static float Somar(float a, float b)
    {
        return a + b;
    }
    public static float Subtrair(float a, float b)
    {
        return a - b;
    }
    public static float Multiplicar(float a, float b)
    {
        return a * b;
    }
    public static float Dividir(float a, float b)
    {
        return a / b;
    }
}

public delegate float DelegateCalculadora(float a, float b);

public class Program
{
    public static void Main(string[] args)
    {

        

        //Here we have 3 different ways to use the delegate
        DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
        var resultado = calc.Invoke(10, 5);
        Console.WriteLine($"Resultado da soma: {resultado}");
    
        DelegateCalculadora calc2 = Calculadora.Subtrair;
        var resultado1 = calc2(10, 5);
        Console.WriteLine($"Resultado da subtração: {resultado1}");

        DelegateCalculadora calc3 = (float a, float b) => Calculadora.Somar(a, b);
        var resultado2 = calc3(10, 5);
        Console.WriteLine($"Resultado da soma (usando lambda): {resultado2}");
    }
}