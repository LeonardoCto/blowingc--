

var pedido = new Pedido();

pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;
pedido.CriarPedido("coutinho@gmail.com", "+55 48 98542343");

class PedidoEventArgs : EventArgs
{
    public string Email { get; set; }
    public string Telefone { get; set; }
}
class Pedido
{
    /// EventHandler and EventHandler<TEventArgs>
    
    // public event EventHandler? OnCriarPedido;
    public event EventHandler<PedidoEventArgs> OnCriarPedido;
    public void CriarPedido(string email, string telefone)
    {
        Console.WriteLine("Pedido Criado!");

        if (OnCriarPedido != null)
        {
            // OnCriarPedido(this, EventArgs.Empty);
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone });
        }
    }

}

class Email
{
    // public static void Enviar(object? sender, EventArgs e)
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        {
            Console.WriteLine($"Enviando EMAIL{e.Email}");
        }
    }
}

    class SMS
    {
        //public static void Enviar(object? sender, EventArgs e)
        public static void Enviar(object? sender, PedidoEventArgs e)
        {
            Console.WriteLine($"Enviando SMS{e.Telefone}");
        }
    }
