using System;
// Interface representando um ataque
interface IAtacante {
    void Atacar();
}
public abstract class Heroi() {

//Atributos da classe Heroi
    private string nome;
    private double vida;
    private double forca;
    private double agilidade;

    // Construtor da classe Heroi
    public Heroi(string nome, double vida, double forca, double agilidade)
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

    public abstract void Especial();
}

// Classe Guerreiro implementando a interface IAtacante
public class Guerreiro : Heroi, IAtacante {
     public Guerreiro(string nome, double vida, double forca, double agilidade) : base(nome, vida, forca, agilidade) {}
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");    
    }
    public override void Especial()
    {
        Console.WriteLine("Guerreiro atacando com seu golpe matador");
    }
}
// Classe Mago implementando a interface IAtacante
class Mago : Heroi, IAtacante {
     public Mago(string nome, double vida, double forca, double agilidade) : base(nome, vida, forca, agilidade) {}
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
    public override void Especial()
    {
        Console.WriteLine("Mago lança bola de ar");
    }
}
// Classe Arqueiro implementando a interface IAtacante
class Arqueiro : Heroi, IAtacante {
     public Arqueiro(string nome, double vida, double forca, double agilidade) : base(nome, vida, forca, agilidade) {}
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
    public override void Especial()
    {
        Console.WriteLine("Arqueiro dispara flechas com fogo");
    }
}
class Program {
    static void Main(string[] args) {
        // Criando instâncias de diferentes personagens 
        Guerreiro guerreiro = new Guerreiro();
        Mago mago = new Mago();
        Arqueiro arqueiro = new Arqueiro();

        // Chamando o método Atacar de cada personagem
        guerreiro.Atacar();
        guerreiro.Especial();

        mago.Atacar();
        mago.Especial();

        arqueiro.Atacar();
        arqueiro.Especial();
    }
}