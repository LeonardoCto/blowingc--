 public class ListandIE
    {
         public static void Main(string[] args)
        {
            //Here we created an instance of class ListAndIENumerable
            var limiteCredito = new List<ListAndIENumerable>();
            //and here we put 15 values into the list
            for (int i = 0; i < 16; i++)
            {
                limiteCredito.Add(new ListAndIENumerable() { Numero = i });
            }

            //here the obj limiteComRestrição reiceves a list 
            var limiteComRestricao = limiteCredito.Where(x => x.AnalisaLimite()).ToList();

            //So if we do not use ToList the obj limiteComRestriçao will be a IENumerable and when we fell in this ifs the exec will need
            // to load the list twice because IENumerable is not alocated in memory and this turns into a unecessary thing
            //IENumerable fell in lazy evaluation that means load item by item and the list load evereting at the begining
            if (limiteComRestricao.Count() > 3)
            {
                Console.WriteLine("Temos mais de 3 limites com restrição");
            }

            if (limiteComRestricao.Count() > 5)
            {
                Console.WriteLine("Temos mais de 5 limites com restrição");
            }

            //In that situation will return the first element of the lis(15) where isRestrição is true
            //but if we use a IENumerable will load element by element and return wich is the first with isRestrição is true(so do not load all 15 elements)
            var primeiroLimiteComRestrica = limiteComRestricao.FirstOrDefault();
            Console.WriteLine($"Primeiro com restrição{limiteComRestricao}");
    }

internal class ListAndIENumerable
{
        public int Numero { get; set; }
        private bool IsRestricao;
        public ListAndIENumerable()
        {
            //here we generate a Guid and GetHashCode convert into a int
            var semente = Guid.NewGuid().GetHashCode();
            var numeroAleatorio = new Random(semente).Next(1, 4);
            IsRestricao = numeroAleatorio == 1;
        }

        public bool AnalisaLimite()
        {
            Console.WriteLine($"Analise de limite de credito para o limite{Numero}");
            return IsRestricao;
        }
    }
}