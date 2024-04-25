using System;

public abstract class Animal
{
    //Atributos da classe Personagem
    private string nome;
    private double vida;
    private double forca;
    private double agilidade;

    // Construtor da classe Personagem
    public Animal(string nome, double vida, double forca, double agilidade)
    {
        this.nome = nome;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
    }

    //Getter para o nome
    public string GetNome(){
        return nome;
    }
    //Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para o vida
    public double GetVida(){
        return vida;
    }
    // Setter para o vida
    public void SetVida(double vida){
        this.vida = vida;
    }
    // Getter para o forca
    public double GetForca(){
        return forca;
    }
    // Setter para o forca
    public void SetForca(double forca){
        this.forca = forca;
    }
    // Getter para o agilidade
    public double GetAgilidade(){
        return agilidade;
    }
    // Setter para o agilidade
    public void SetAgilidade(double agilidade){
        this.agilidade = agilidade;
    }

    //Métodos
    // Exemplo de método para mover o animal
    public void Mover(string direcao, double distancia){
        Console.WriteLine($"{GetNome()} esta se movendo na direcao {direcao} por {distancia} passos.");
    }

    // Método para usar uma habilidade
    public abstract void UsarHabilidade();

    // Exemplo de método para atacar outro Animal
    public abstract void Atacar();

    // Método para receber dano
    public void ReceberDano(double dano){
        vida -= dano;
        if (vida <= 0){
            Morrer();
        }else{
            Console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
        }
    }
    
    // Método para quando o animal morre
    private void Morrer(){
        Console.WriteLine($"{GetNome()} morreu.");
        /* Aqui você pode adicionar lógica adicional, como reiniciar o animal, exibir uma mensagem de game over, etc. */
    }
}   

public class Leao : Animal {
    public Leao(string nome, double vida, double forca, double agilidade) : base(nome, vida, forca, agilidade) {}
    public override void Atacar() {
        Console.WriteLine("ataca com sua boca!");
    }
    public override void UsarHabilidade() {
        Console.WriteLine("Usar habilidade com sua garra!");
    }
}

public class Gorila : Animal {
    public Gorila(string nome, double vida, double forca, double agilidade) : base(nome, vida, forca, agilidade) {}
    public override void UsarHabilidade() {
        Console.WriteLine("Usar habilidade com sua garra!");
    }
    public override void Atacar() {
        Console.WriteLine("Ataca com sua boca!");
    }
}

class Program{
    static void Main(string[] args){
        //criando um objeto(leao) da classe Animal
        Leao leao = new Leao("Leao Alex", 50, 85, 75);
            // Exibindo informações do Leao
            Console.WriteLine("Animal Heroi");
            Console.WriteLine($"Nome: {leao.GetNome()}");
            Console.WriteLine($"Vida: {leao.GetVida()}");
            Console.WriteLine($"Forca: {leao.GetForca()}");
            Console.WriteLine($"Agilidade: {leao.GetAgilidade()}");
            Console.WriteLine("");
    

 //criando um objeto(gorila) da classe Animal
        Gorila gorila = new Gorila("Gorila Marte", 50, 100, 70);
            // Exibindo informações do personagem Coringa
            Console.WriteLine("Animal Inimigo");
            Console.WriteLine($"Nome: {gorila.GetNome()}");
            Console.WriteLine($"Vida: {gorila.GetVida()}");
            Console.WriteLine($"Forca: {gorila.GetForca()}");
            Console.WriteLine($"Agilidade: {gorila.GetAgilidade()}");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("");

            // Leao movendo
            leao.Mover("norte", 10);
            // Gorila movendo
            gorila.Mover("sul", 10);
            // Leao batendo no Gorila
            leao.Atacar();
            // Leao usando uma habilidade
            leao.UsarHabilidade();
            // Gorila Recebendo dano
            gorila.ReceberDano(50);
            // Gorila usando uma habilidade
            gorila.UsarHabilidade();
            // Leao usando uma habilidade
            leao.UsarHabilidade();
            // Gorila Morrendo
            gorila.ReceberDano(999); // Para simular a morte
            Console.ReadLine();
        }
    }        