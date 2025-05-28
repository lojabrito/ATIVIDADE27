class Ataque
{
    public string Nome { get; set; }
    public string Tipo { get; set; }

    public Ataque(string nome, string tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }
}

class Pokemon
{
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public List<string> Tipos { get; set; }
    public List<Ataque> Ataques { get; set; }

    public Pokemon(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
        Tipos = new List<string>();
        Ataques = new List<Ataque>();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Olá! Eu sou o {Nome}!");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Altura: {Altura} m");
        Console.WriteLine("Tipos:");
        foreach (string tipo in Tipos)
        {
            Console.WriteLine($"- {tipo}");
        }

        Console.WriteLine("Ataques:");
        foreach (Ataque ataque in Ataques)
        {
            Console.WriteLine($"- {ataque.Nome} ({ataque.Tipo})");
        }
    }
}

class Program
{
    static void Main()
    {
        Pokemon charizard = new Pokemon("Charizard", 110.5, 1.7);
        charizard.Tipos.Add("Fogo");
        charizard.Tipos.Add("Voador");

        charizard.Ataques.Add(new Ataque("Explosão de Fogo", "Fogo"));
        charizard.Ataques.Add(new Ataque("FirePunch", "Meele"));
        charizard.Ataques.Add(new Ataque("Lança chama", "Fogo"));

        charizard.ExibirInformacoes();
    }
}
