// using System;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Cannot do that Stack do not support inicialization with values
        // Stack<int> numeros = new Stack<int>() { 1,4,2};

        //Cannot do that
        // var indice = numeros[0]; // This will throw an exception because Stack does not support indexing

        int[] array = new int[] { 1, 4, 2 };
        Stack<int> pilha = new Stack<int>(array);

        var impares = new Stack<int>(3); //Here a new stack is created with a capacity of 3
        impares.Push(1);

        Stack<int> numeros = new Stack<int>();
        numeros.Push(10);
        numeros.Push(20);
        numeros.Push(30);
        numeros.Push(40);//LIFO last int first out so 40 will be on the top of the stack

        Console.WriteLine($"Count: {numeros.Count}");
        Console.WriteLine($"Peek: {numeros.Peek()}"); // Peek returns the top element without removing it
        Console.WriteLine($"Pop: {numeros.Pop()}"); // Pop removes and returns the top element

        if (numeros.Contains(20))
        {
            Console.WriteLine("20 está na pilha.");
        }
        else
        {
            Console.WriteLine("20 não está na pilha.");
        }


        var copia = new Stack<int>(numeros.ToArray()); // Create a copy of the stack

        Console.WriteLine("Pilha original:");
        ExibirPilha(numeros);
        //Here will be an array so the order will be reversed
        Console.WriteLine("Cópia da pilha:");
        ExibirPilha(copia);

    }

    static void ExibirPilha<T>(IEnumerable<T> pilha)
    {
        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}


public class EditorTexto
{
    static void Main(string[] args)
    {
        EditorTexto editor = new EditorTexto();
        Console.WriteLine("Digitando:");
        editor.Digitar('s');
        editor.Digitar('t');
        editor.Digitar('a');
        editor.Digitar('c');
        editor.Digitar('q');

        Console.WriteLine("Desfazendo com undo:");
        editor.Undo();
        editor.Undo();

        Console.WriteLine("Redigitando:");
        editor.Digitar('c');
        editor.Digitar('k');
    }

    private Stack<char> undoStack = new Stack<char>();
    private string texto = "";

    public void Digitar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"Texto atual: {texto}");
    }

    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            char ultimoCaractere = undoStack.Pop();
            texto = texto.Substring(0, texto.Length -1);//here we put -1 to remove the last character of the string
            Console.WriteLine($"Texto atual: {texto}");
        }
    }
}