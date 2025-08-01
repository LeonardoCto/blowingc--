
// HERE WE CAN SE THAT

List<Animal> list = new List<Animal>()
{
    new Cachorro(),
    new Gato(),
};


//Wich one a in animal will have your own method
foreach (var a in list)
{
    a.FazerBarulho();
}


//There we have two classes and them have an inherance between so we use virtual in base class to indicate that the member will be 
//rewritten in the derived class
//That is POLIMORFIMS 
public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void FazerBarulho()
    {

    }
}

public class Cachorro : Animal
{
    public string Nome { get; set; }
    public string Raca { get; set; }

    public override void FazerBarulho()
    {
        Console.WriteLine("AuAu");
    }

    public class Gato : Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
    }

    public override void FazerBarulho()
    {
        Console.WriteLine("Miaaaaaaaaaaaaaaaaaaaaaaaaau");
    }

    //Sealed blocks the class to be inherance for other class
    sealed class ClasseSelada
    {
        //We can use SEALED in high level members
      sealed public string Nome { get; set;}

    }

}

