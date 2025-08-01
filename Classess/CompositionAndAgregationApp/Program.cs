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

    public void ListarProfessores()
    {
        Console.WriteLine($"Departamento de { Nome}");

        foreach (var prof in professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
    }
}


public class Professor
{

    public string Nome { get; set; }
    public string Disciplina { get; set; }
    public Professor(string nome, string disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}


    //Using inherance and composition together
    public class Animal {
        public int Idade { get; set; }

        public void Comer()
        {
            Console.WriteLine("Animal está comendo");
        }
        public void Dormir()
        {
            Console.WriteLine("Animal está dormindo");
        }

    }

    public class ComportamentoAndar
    {
    public void Andar()
    {
        Console.WriteLine("Animal está andando");
        }
    }

    public class ComportamentoNadar()
    {
    public void Nadar()
    {
        Console.WriteLine("Animal está nadando");
    }
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

        public Sardinha (ComportamentoNadar comportamentoNadar)
        {
            _comportamentoNadar = comportamentoNadar;
        }
    }
    