 public class Event
    {

        //Proprierties, something that works like lombok in JAVA have get and set included in the declaration of the 
        public string Name { get; private set; } //We can put private on set to encapsule the rule inside the class
        public string Local { get; private set; }
        public DateTime Date { get; private set; }
        public ETypeEvent Type { get; private set; }
        public static string Reviews; //Static field, this one belong to the class like the static method (Event.Review = "";)

        //Constructor of the object, every time that you instance an object will pass through the constructor being requires the fields  of the parameter
        public Event(string name, string local, DateTime date, ETypeEvent type)
        {
            this.Name = name;
            this.Local = local;
            this.Date = date;
            this.Type = type;

        }
        //Static constructor, a class can only have one of these and that's executed automatically before that any instance of the class
        static Event()
        {
            Reviews = "Otimo";
        }

        //Set of name field, its only possible to change the name of the object by calling this method, in this way we can encapsule and create rules
        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetFins(ETypeEvent type)
        {
            this.Type = type;
        }

        //Method with return to concat field of some instance
        public string showEvent()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                return string.Concat(Name, " - ", Type.ToString(), " - ", Date, " - ", Local);

            }
            return "Nome inválido";
        }

        //Example of static method, this one only can be acessed by the class and not for an instance
        //In this example we use too method overload
        //Event.showEvent(string Name, ETypeEvent Type, DateTime Date, string Local);
        public static string showEvent(string Name, ETypeEvent Type, DateTime Date, string Local)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                return string.Concat(Name, " - ", Type.ToString(), " - ", Date, " - ", Local);

            }
            return "Nome inválido";
        }
    }