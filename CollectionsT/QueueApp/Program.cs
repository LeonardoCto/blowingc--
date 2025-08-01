// class Queue
// {
//     static void Main(string[] args)
//     {
//         //Queue | | | | | -> works with FIFO (First In First Out)
//         Queue<string> dias = new Queue<string>();
//         queue.Enqueue("Segunda");
//         queue.Enqueue("Terça");

//         int[] array = new int[] { 1, 2, 3, 4, 5 };
//         Queue<int> numeros = new Queue<int>(array);

//         var impares = new Queue<int>(3);//-> initializes a queue with a capacity of 3
//         impares.Enqueue(1); //-> adds an element to the queue
//         impares.Count();// returns the number of elements in the queue
//         impares.Dequeue();// removes the first element
//         impares.Peek();// returns the first element without removing it
//         impares.Contains(1);// checks if the queue contains the element
//                             //impares.Clear(); //clear the queue

//         ExibirFila(impares);
//     }

//     static void ExibirFila<T>(IENumerable<T> fila)
//         {
//             foreach (var item in fila)
//             {
//                 Console.WriteLine(item);
//             }
//         }
// }

public class Pedido
{

    static void Main(string[] args)
    {
        Queue<Pedido> filapedidos = new Queue<Pedido>();
        filapedidos.Enqueue(new Pedido(1, 100.50));
        filapedidos.Enqueue(new Pedido(2, 200.75));
        filapedidos.Enqueue(new Pedido(3, 150.00));
        filapedidos.Enqueue(new Pedido(501, 300.25));

        Console.WriteLine("Numero de pedidos na fila: " + filapedidos.Count);
        while (filapedidos.Count > 0)
        {
            Pedido proximoPedido = filapedidos.Dequeue();
            Console.WriteLine($"Processando Pedido Numero: {proximoPedido.Numero}, Valor: {proximoPedido.Valor}");
        }

        int numeroPedido = 501;
        Pedido? pedidoEncontrado = filapedidos.FirstOrDefault(p => p.Numero == numeroPedido); //-> Here we use LINQ to find the first order where Numero is equal to numeroPedido
        if(pedidoEncontrado != null)
        {
            Console.WriteLine($"Pedido encontrado: Numero {pedidoEncontrado.Numero}, Valor {pedidoEncontrado.Valor}");
        }
    }



    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public int Numero { get; set; }
    public double Valor { get; set; }
}