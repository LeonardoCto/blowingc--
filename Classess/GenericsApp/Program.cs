 //Comparing two int numbers 
    Genericss generico = new Genericss();
    int i1 = 10;
    int i2 = 20;
    generico.Comparar(i1, i2);

    //So if we want to compare two floats?

    float f1 = 10;
    float f2 = 20;
    generico.Comparar(f1, f2);//Its not possible because our method Comparar only accept int
    //Will be needed to declare another method with floats in parameter

    //With the Generic we can compare any data Type
    string s1 = "10";
    string s2 = "10";
    // generico.Comparar(s1, s2);


    //Could be public class Genericss<T1,T2>

    // Genericss<int,int> generico1 = new Genericss<int, int> ();
    //so in this case we can only compare int because its declared in the class de T and in the instance the type int
    //Could be Genericss<string,int> , Genericss<double,double>, Genericss<float,float>
    public class Genericss
    {
        //public void Comparar(T1 p1, T2 p2) where T1 : struct where T2: struct

        //HERE we have the generic method
        public void Comparar<T>(T p1, T p2) where T : struct //struct define that T needs to be a valueType
        {
            Console.WriteLine($"Os tipos {p1.GetType()} e {p2.GetType()}\n");
            var resultado = p1.Equals(p2); //Equals compare the data type and the content and == just de ref
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
        }
        public void Comparar(int p1, int p2)
        {
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
        }

        public void Comparar(float p1, float p2)
        {
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
        }
    }
