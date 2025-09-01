
Console.WriteLine("\nUsando o evento onCriarPedido");
var pedido = new Pedido();

//register the subscribers on the events 
pedido.OnCriarPedido += EMAIL.Enviar;
pedido.OnCriarPedido += SMS.Enviar;
//So EMAIL and SMS are the subscribers and Pedido are the Publisher

pedido.CriarPedido();

//Delegate for the event
delegate void PedidoEventHandler();
class Pedido
{
    
    public event PedidoEventHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("Pedido Criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

class EMAIL
{
   public static void Enviar()
    {
        Console.WriteLine("Enviando SMS");
    }
}
class SMS
{
   public static void Enviar()
    {
        Console.WriteLine("Enviando SMS");
    }
}