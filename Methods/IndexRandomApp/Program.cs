 public class IndexRandom
    {
        static void Main(string[] args)
        {
            IndexRandom indexators = new IndexRandom();

            string valor1 = indexators[1];//GET
            indexators[1] = "Santos";//SET
        }
    
        string[] valor = new string[10];

        //indexators are useful to have a sintax to acesses and set objs of a class by the index

        //indexators with methods get and set 
        public string this[int i]
        {
            get
            {

                if (i >= 0 && i < valor.Length)

                {
                    return valor[i];
                }
                return "Erro";
            }

            set
            {
                if (i >= 0 && i < valor.Length)
                {
                    valor[i] = value;
                }
            }


        }

        //Class Random its used to generate pseudo numbers "randoms" 
        public static void Random()
        {

            Random random = new Random();

            random.Next(1, 10);
            random.NextDouble();
            //Generate five random numbers
            for (int i = 0; i < 5; i++)
            {
                random.Next();
            }

            //Generating random number using gui to be a seed
            var seed = Guid.NewGuid().GetHashCode();
            var randomNumber = new Random(seed);

            for (int i = 0; i < 10; i++)
            {
                randomNumber.Next();
            }
        }
    }


