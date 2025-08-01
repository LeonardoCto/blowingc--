

//The big problem of use ArrayList is the box and unboxing process that cause a big lost of performance

//ArrayList this ungeneric class can be changed dynamically
using System.Collections;

ArrayList lista = new ArrayList() { "Leonardo", true, "Isabella", 9 };

        ArrayList lista1 = new();
        lista1.Add(1); //Add an element at the final index positon of the arrayList
        lista1.Add("Jão");

        lista1.Insert(0, "Olá"); //Add an element at the index that you set 

        //It's possible add a elements collection into an arrayList using methods
        lista1.AddRange(lista);//Add an elements colletion at the final index of the array list
        lista1.InsertRange(0, lista); // //Add an elements colletion at the  index that you set

        //It's possible remove elements of the array list using methods
        lista1.Remove("Leonardo");//that will remove the first element called Leonardo
        lista1.RemoveAt(4);//that will remove the element at the index seted
        lista1.RemoveRange(5, 4); //that will remove 4 elements as from index 5

        var existsIsabella = lista1.Contains("Isabella");// this method return true or false if exists this element at the arraylist

        ArrayList lista2 = new ArrayList() { "Leonardo", "João", "Isabella", "Mario" };

        lista2.Sort();//this method return a ascendent sequence of the elements(a,b,c,d,e,f,g) JUST DATA OF THE SAME TYPE
        lista2.Clear();//Remove all the elements of the list but keep the capacity


        //List T its a generic list
        List<int> listaT = new();
        //The same methods off arrayList are avaible for ListT

        listaT.Add(1);
        listaT.Add(10);
        listaT.Sort();
        listaT.Clear();
        listaT.AddRange();
        listaT.Insert(0, 2);
        listaT.InsertRange(0, listaT);
        listaT.Remove(2);
        listaT.RemoveAt(3);
        listaT.RemoveRange(4, 2);

        List<string> frutas = new() { "Uva", "Pera", "Maça", "Banana" };

        //The method find need to receive a predicate in the argument so in this way we needed to write the method Procura that return a bool
        var fruta1 = frutas.Find(Procura);

        static bool Procura(string item)
        {
            return item.Contains("n");
        }
        //Using Lambda expression , so instead create the predicate method like above we can use a lambda 
        var frutasLambda = frutas.Find(f => f.Contains("n"));//Find returns the first element that correspond to the expression
        var fruta3 = frutas.FindLast(f => f.Contains("n"));//FindLast returns the last element that correspond to the expression
        var fruta4 = frutas.FindIndex(f => f.Contains("n"));//FindIndex returns the first index of the element that correspond to the expression
        var fruta5 = frutas.FindLastIndex(f => f.Contains("n"));//FindLastIndex returns the last index of the element that correspond to the expression
        var fruta6 = frutas.FindAll(f => f.Contains("n"));//FindAll returns all the elements that corresponds to the expression

        
    
