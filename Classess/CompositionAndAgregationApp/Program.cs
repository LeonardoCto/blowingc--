Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Junior", "Matematica");

Departamento dp1 = new Departamento("Exatas");
dp1.IncluirProfessor(prof1);
dp1.ListarProfessores();


//Agregation wich object have your life cicle
//A professor can exist without a departamento so if we exclude departamento professor will continue existing
public class Departamento
{
        public string Nome { get; set; }
    //ref to professor
    public List<Professor> professores = new List<Professor>();

    public void IncluirProfessor(Professor professor)
    {
        professores?.Add(professor);
    }

    public Departamento(string nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }

    public void ListaProfessores()
    {
        Console.WriteLine($"Departamento de { Nome}");

        foreach (var prof in professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
    }
}
    

    public class Professor {

        public string Nome { get; set;}
        public strinf Disciplina { get; set;}
    }


    //Using inherance and composition together
    public class Animal {
        public int Idade { get; set;}

        public void Comer ();
        public void Dormir();

    }

    public class ComportamentoAndar
    {
        public void Andar();
    }

    public class ComportamentoNadar()
    {
        public void Nadar();
    }


    public class Macaco : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Macaco (ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }
    }

    public class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Homem (ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }
    }

    public class Sardinha : Animal
    {
        private readonly ComportamentoNadar _comportamentoNadar;

        public Macaco (ComportamentoNadar comportamentoNadar)
        {
            _comportamentoNadar = comportamentoNadar;
        }
    }
    