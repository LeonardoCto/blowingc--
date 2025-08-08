




try
{
    Console.WriteLine("Informe o dividendo:");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o divisor:");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = dividendo / divisor;
    Console.WriteLine($"Resultado da divisão: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
    Console.WriteLine($"An error occurred: {ex.Source}");
    Console.WriteLine($"An error occurred: {ex.StackTrace}");
    Console.WriteLine($"An error occurred: {ex.InnerException}");
    Console.WriteLine($"An error occurred: {ex.HelpLink}");

}
finally
{
    Console.WriteLine("Execution completed.");
}


