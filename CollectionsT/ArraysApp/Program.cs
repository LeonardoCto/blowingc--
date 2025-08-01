 public class Aarrays
    {
        public static void Main(string[] args)
        {

            //Multidimensionals arrays
            int[,] a = new int[2, 3] { { 20, 30, 40 }, { 50, 40, 30 } };
            int[,] b = {
                        { 1, 2 },
                        { 3, 4 },
                        { 5 ,6}
                        };

            //loop through multidimensional array to show elements
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.WriteLine($"{b[i, j]}");
                }
                Console.WriteLine();
            }

            foreach (int x in b)
            {
                Console.WriteLine("foeach multi" + " - " + x);
            }

            //Exercice to show elements of an array multi with for loop
            string[,] alunos =  {
                                { "Maria", "Paulo", "Marta", "Pedro", "Carlos" },
                                { "Silvia", "Amanda", "Manoel", "Paula", "Alicia"}
                                };

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                for (int j = 0; j < alunos.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i}, {j}] = {alunos[i, j]}\t");
                }
            }


            string[] nomes = new string[2] { "Leonardo", "Isabella" };
            string[] nomes1 = { "Leonardo", "Isabella", "Maria" };

            //Simple way to declare
            int[] numeros = { 1, 2, 3, 4, 5, 6 }; //index init on 0

            //instance of array
            int[] numeros1;
            // alocate in memory
            numeros1 = new int[3];
            //assigning  values
            numeros1[0] = 1;
            numeros1[1] = 2;
            numeros1[2] = 3;

            Console.WriteLine(nomes1[2]);//Accessing position 2 of array nomes

            // loop through the elements of array by the indexes
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Elemento de indice {i} : {numeros[i]}");
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Elemento de indice {i} : {nomes[i]}");
            }

            //loop through the elements of array with foreach
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Foreach" + " - " + numero);
            }

            foreach (string nome in nomes1)
            {
                Console.WriteLine($"Foreach Nomes" + " - " + nome);
            }

            //Array inverting
            Array.Reverse(nomes);

            //Array sorting
            Array.Sort(nomes);

            //Finding a index on array
            Array.BinarySearch();

            //Exercice to calculate aritmetric average

            string[] nomes2 = new string[5];
            double[] notas = new double[5];

            for (int i = 0; i < nomes2.Length; i++)
            {
                Console.WriteLine("Informe o nome");
                string nome = Console.ReadLine();
                nomes2[i] = nome;
            }

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Informe a nota");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas[i] = nota;
            }

            foreach (string nome in nomes2)
            {
                Console.WriteLine($"Alunos" + nome);
            }

            var somaNotas = 0.0;
            var totalNotas = notas.Count();
            foreach (double nota in notas)
            {
                somaNotas += nota;
                Console.WriteLine($"Notas" + nota);
            }

            Console.WriteLine($"Média aritmetica : {somaNotas / totalNotas}");
            Console.ReadKey();


        }
        //Exercice 2 using params

        //Params just accept an unimendisonal array and need to be declared just once at the last position of the parameters 
        public static int Somar(params int[] numeros)
        {
            int total = 0;
            foreach (int numero in numeros)
            {
                total += numero;
            }
            return total;
        }

        int[] valores = { 10, 20, 90 };

        //Using params we do not need to declare the array 
        //Can pass directly in the arguments calling the method
        
        int res = Aarrays.Somar(10, 20, 90);
       
    }