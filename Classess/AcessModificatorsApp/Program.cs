ClasseDerivada cd = new();
cd.Verifica_Acesso();

//Inheritance : declaration between classes
public class ClasseDerivada : ClasseBase
{
    //In this Derived class we declare the methods that we have access 
    public void Verifica_Acesso()
    {
        Public_Mebro();
        Protected_Mebro();
        Protected_Internal_Mebro();
        Internal_Membro();
        //
        //Private_Mebro();

        int soma = public_var + protected_var + internal_var + PrivateVar; // private_var; // Here we cannot access directy the field private_var 
                                                                           // need to declare a proprierty so them we can access on derived class
                                                                           // this is called Encapsulation	
    }

    //the derived class do not inherance the constructor of the base class but the base class constructor without params will be called once
    // when we instance a obj of derived class

    public ClasseDerivada()
    {

    }
    
    //We can use the key word (base) to use an specific constructor of the base class
    public ClasseDerivada(string param) : base(param)
    {

    }
}

//So in this classe we have some methods with diferetns levels of accesses
public class ClasseBase
{
    public int public_var = 1;
    private int private_var =2;
    protected int protected_var =3;
    internal int internal_var =4;
    
    //public proprierty
    public int PrivateVar
    {
        get { return private_var; }
        set { private_var = value; }
    }

    public ClasseBase()
    {

    }

    public ClasseBase(string param)
    {

    }

    public void Public_Mebro()
    {
        Console.WriteLine("Classe_Base - Public");
    }
    protected void Protected_Mebro()
    {
        Console.WriteLine("Classe_Base - Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("Classe_Base - Internal");
    }
    protected internal void Protected_Internal_Mebro()
    {
        Console.WriteLine("Classe_Base - Protected internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("Classe_Base - Private");
    }
}