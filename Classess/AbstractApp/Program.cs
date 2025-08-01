public abstract class Forma
    {

        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        //A abstract method is implicitly virtual
        //The implementation of this method is write in the derived class here just exist an signature
        public abstract void CaclcularArea();
        public abstract void CaclcularPerimetro();


    }

    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override void CaclcularArea(){
            //Here in the derived class its required to exists the implementation of the method 
            this.Area = Lado * Lado;
        }

        public override void CaclcularPerimetro(){
            
            this.Perimetro = 4 * Lado;
        }
    }