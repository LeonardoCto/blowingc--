public class HashCodeEquals
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public HashCodeEquals(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        /// Equals with value type
        string a = "José";
        string b = "José";

        int x = 100;
        int y = 100;

        // Console.WriteLine(a.Equals(b)); -> return true
        // Console.WriteLine(x.Equals(y)); -> return true

        //Equals with reference type
        HashCodeEquals pessoa1 = new HashCodeEquals(1, "Leonardo");
        HashCodeEquals pessoa2 = new HashCodeEquals(1, "Leonardo");

        // Console.WriteLine(pessoa1.Equals(pessoa2)); -> return FALSE because in this type will compare the ref 


        //GetHashCode
        //Generate hashCode based in the obj value 
        // Console.WriteLine(a.GetHashCode()); //here a and b will have the same hashCode
        // Console.WriteLine(b.GetHashCode());//because they have the same value

        // Console.WriteLine(x.GetHashCode());// x and y too
        // Console.WriteLine(y.GetHashCode());

        //Console.WriteLine(pessoa1.GetHashCode());//pessoa 1 and pessoa 2 will have diffents hashCode because they are ref types
        //Console.WriteLine(pessoa2.GetHashCode());//


    }

    public class Pessoa
    {
        public int CPF { get; set; }
        public string Nome { get; set; }

        public Pessoa(int cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        //HERE we override equals method to be possible compare two obj with the same CPF
        public override bool Equals(object? obj)
        {
            if (obj == null) //So if the obj is null return false
                return false;

            if ((obj is not Pessoa)) // If is not of type Pessoa return null
                return false;

            var other = (Pessoa)obj; //And here we do a cast to convert obj to pessoa

            return CPF.Equals(other.CPF); //Finally we compare the obj CPF with the actual CPF instance of pessoa
        }
        
        //Modern way to override Equals (pattern matching)
        // public override bool Equals(object? obj)
        // {
        //     return obj is Pessoa other && CPF.Equals(other.CPF);
        //  }


        public override int GetHashCode()
        {
            return CPF.GetHashCode(); //Will generate the hashcode based in cpf
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(00660919, "Leonardo");
            Pessoa pessoa3 = new Pessoa(0066001919, "Leonardo");
            Pessoa pessoa4 = new Pessoa(0545154811, "Leonardo");

            Console.WriteLine(pessoa.GetHashCode());
            Console.WriteLine(pessoa3.GetHashCode());
            Console.WriteLine(pessoa4.GetHashCode());

            Console.WriteLine(pessoa.Equals(pessoa3));// -> return False
            Console.WriteLine(pessoa3.Equals(pessoa4));// - return False
        }
    }