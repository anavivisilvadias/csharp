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
    public void Atacar() {
        Console.WriteLine("Ataque básico!");
    }
    public class Atacar(string habilidade) {
        Console.WriteLine("Ataque especial: " + habilidade);
    }
}
// Classe Guerreiro que herda de Personagem
public class Guerreiro : Personagem {
    
    // Construtor
    public Guerreiro(string nome, int nivel, int pontosVida, int pontosAtaque, int pontosDefesa)
        : base(nome, nivel, pontosVida, pontosAtaque, pontosDefesa)
    {
    }

    // Métodos específicos do Guerreiro, se necessário
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
}
// Classe Mago que herda de Personagem
public class Mago : Personagem {
    
    // Construtor
    public Mago(string nome, int nivel, int pontosVida, int pontosAtaque, int pontosDefesa)
        : base(nome, nivel, pontosVida, pontosAtaque, pontosDefesa)
    {
    }
      // Métodos específicos do Mago, se necessário
       public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
}    

class Program
{
    static void Main(string[] args)
    {
        // Instanciando um Guerreiro e um Mago
        Guerreiro guerreiro = new Guerreiro("Conan", 10, 100, 30, 20);
        Mago mago = new Mago("Gandalf", 10, 80, 25, 15);

        public class Program {

            public static void Main(string[] args) {
                Personagem guerreiro = new Guerreiro();
                Personagem mago = new Mago();
                Personagem arqueiro = new Arqueiro();
                //Sobrecarga
                guerreiro.Atacar();//Chama o método Atacar() da classe derivada
                guerreiro.Atacar("Investida!");//Chama o método Atacar(string) da classe base
                //Sobrecarga
                mago.Atacar();
                mago.Atacar("Bola de Fogo!");
            }
        }
    }
}