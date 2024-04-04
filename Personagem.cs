using System;

private class Personagem
{
    // Propriedades
    private string Nome
    private int Nivel 
    private int PontosVida 
    private int PontosAtaque 
    private int PontosDefesa 
      // Construtor
    private Personagem(string nome, int nivel, int pontosVida, int pontosAtaque, int pontosDefesa)
    {
        Nome = nome;
        Nivel = nivel;
        PontosVida = pontosVida;
        PontosAtaque = pontosAtaque;
        PontosDefesa = pontosDefesa;
    }

    // Método para exibir informações do personagem
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Pontos de Vida: {PontosVida}");
        Console.WriteLine($"Pontos de Ataque: {PontosAtaque}");
        Console.WriteLine($"Pontos de Defesa: {PontosDefesa}");
    }

    // Método para o personagem atacar outro personagem
    public void Atacar(Personagem alvo)
    {
        int dano = PontosAtaque - alvo.PontosDefesa;
        if (dano > 0)
        {
            alvo.PontosVida -= dano;
            Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {dano} de dano.");
        }
        else
        {
            Console.WriteLine($"{Nome} atacou {alvo.Nome}, mas não causou dano.");
        }
    }
}
// Classe Guerreiro que herda de Personagem
public class Guerreiro : Personagem
{
    // Construtor
    public Guerreiro(string nome, int nivel, int pontosVida, int pontosAtaque, int pontosDefesa)
        : base(nome, nivel, pontosVida, pontosAtaque, pontosDefesa)
    {
    }

    // Métodos específicos do Guerreiro, se necessário
}
// Classe Mago que herda de Personagem
public class Mago : Personagem
{
    // Construtor
    public Mago(string nome, int nivel, int pontosVida, int pontosAtaque, int pontosDefesa)
        : base(nome, nivel, pontosVida, pontosAtaque, pontosDefesa)
    {
    }

    // Métodos específicos do Mago, se necessário
}
class Program
{
    static void Main(string[] args)
    {
        // Instanciando um Guerreiro e um Mago
        Guerreiro guerreiro = new Guerreiro("Conan", 10, 100, 30, 20);
        Mago mago = new Mago("Gandalf", 10, 80, 25, 15);

        // Exibindo informações dos personagens
        guerreiro.ExibirInformacoes();
        Console.WriteLine();
        mago.ExibirInformacoes();
        Console.WriteLine();
        // Fazendo o Guerreiro atacar o Mago
        guerreiro.Atacar(mago);
        Console.WriteLine();

        // Exibindo informações do Mago após o ataque
        mago.ExibirInformacoes();
    }
}