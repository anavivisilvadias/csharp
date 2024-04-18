using System;

public class Personagem
{
    //Atributos da classe Personagem
    private string nome;
    private int nivel;
    private double pontuacao;
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private string[] armasEquipamentos;

// Construtor da classe Personagem
public Personagem(string nome, int nivel, double pontuacao, double vida, double forca,
double agilidade, double inteligencia, string[] armasEquipamentos)
{
    this.nome = nome;
    this.nivel = nivel;
    this.pontuacao = pontuacao;
    this.vida = vida;
    this.forca = forca;
    this.agilidade = agilidade;
    this.inteligencia = inteligencia;
    this.armasEquipamentos = armasEquipamentos;
}

//Getter para o nome
public string GetNome(){
    return nome;
}
//Setter para o nome
public void SetNome(string nome){
    this.nome = nome;
}
//Getter para o nivel
public int GetNivel(){
    return nivel;
}
// Setter para o nivel
public void SetNivel(int nivel){
    this.nivel = nivel;
}
// Getter para o pontuacao
public double GetPontuacao(){
    return pontuacao;
}
// Setter para o pontuacao
public void SetPontuacao(double pontuacao){
    this.pontuacao = pontuacao;
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
// Getter para o inteligencia
public double GetInteligencia(){
    return inteligencia;
}
// Setter para o inteligencia
public void SetInteligencia(double inteligencia){
    this.inteligencia = inteligencia;
} 
// Getter para o armasEquipamentos
public string[] GetArmasEquipamentos(){
    return armasEquipamentos;
}
// Setter para o armasEquipamentos
public void SetArmasEquipamentos(string[] armasEquipamentos){
    this.armasEquipamentos = armasEquipamentos;
}

//Métodos
// Exemplo de método para mover o personagem
public void Mover(string direcao, double distancia){
    Console.WriteLine($"{GetNome()} esta se movendo na direcao {direcao} po {distancia} passos.");
}
// Exemplo de método para atacar outro personagem
public void Atacar(Personagem alvo){
    Console.WriteLine($"{GetNome()} esta atacando {alvo.GetNome()}.");
}
// Método para receber dano
public void ReceberDano(double dano){
    vida -= dano;
    if (vida <= 0){
        Morrer();
    }else{
        Console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
    }
}

// Método para usar uma habilidade
public void UsarHabilidade(string habilidade, Personagem alvo){
    Console.WriteLine($"{GetNome()} esta usando a habilidade {habilidade} em {alvo.GetNome()}.");
}
// Método para subir de nivel
public void SubirDeNivel(){
    nivel++;
    Console.WriteLine($"{GetNome()} subiu para o nivel {GetNivel()}!");
}
// Método para quando o personagem morre
private void Morrer(){
    Console.WriteLine($"{GetNome()} morreu.");
    /* Aqui você pode adicionar lógica adicional, como reiniciar o personagem, exibir uma mensagem de game over, etc. */
    }
}    

class Program{
    static void Main(string[] args){
        //criando um objeto(batman) da classe Personagem
        Personagem batman = new Personagem("Batman", 1, 0, 100, 90, 80, 100, new string[] {
            "Multi-Batarangue", "Lançador de Gel", "Bomba de fumaça", "Ultra Bat-Garra", "Sintetizador de Voz"});
            // Exibindo informações do personagem Batman
            Console.WriteLine("Personagem Heroi");
            Console.WriteLine($"Nome: {batman.GetNome()}");
            Console.WriteLine($"Nivel: {batman.GetNivel()}");
            Console.WriteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
            Console.WriteLine($"Vida: {batman.GetVida()}");
            Console.WriteLine($"Forca: {batman.GetForca()}");
            Console.WriteLine($"Agilidade: {batman.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {batman.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(", ", batman.GetArmasEquipamentos())}");
            Console.WriteLine("");
    

 //criando um objeto(coringa) da classe Personagem
        Personagem coringa = new Personagem("Coringa", 1, 0, 100, 70, 65, 85, new string[] {
            "Gás do Riso", "Flores que Esguicham Ácido", "Baralhas de Carta", "Luva de Choque",});
            // Exibindo informações do personagem Coringa
            Console.WriteLine("Personagem Inimigo");
            Console.WriteLine($"Nome: {coringa.GetNome()}");
            Console.WriteLine($"Nivel: {coringa.GetNivel()}");
            Console.WriteLine($"Pontuacao do Coringa: {coringa.GetPontuacao()}");
            Console.WriteLine($"Vida: {coringa.GetVida()}");
            Console.WriteLine($"Forca: {coringa.GetForca()}");
            Console.WriteLine($"Agilidade: {coringa.GetAgilidade()}");
            Console.WriteLine($"Inteligencia: {coringa.GetInteligencia()}");
            Console.WriteLine($"Armas e Equipamentos: {string.Join(", ", coringa.GetArmasEquipamentos())}");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("");

            // Batman movendo
            batman.Mover("norte", 10);
            // Coringa movendo
            coringa.Mover("sul", 10);
            // Batman batendo no Coringa
            batman.Atacar(coringa);
            // Batman usando uma habilidade
            batman.UsarHabilidade("Multi-Batarangue", coringa);
            // Coringa Recebendo dano
            coringa.ReceberDano(50);
            // Batman ganha pontos
            batman.SetPontuacao(50);
            Console.WriteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
            // Coringa usando uma habilidade
            coringa.UsarHabilidade("Gas do Riso", batman);
            // Coringa ganha pontos
            coringa.SetPontuacao(30);
            Console.WriteLine($"Pontuacao do Coringa: {coringa.GetPontuacao()}");
            // Batman usando uma habilidade
            batman.UsarHabilidade("Ultra Bat-Garra", coringa);
            // Coringa Morrendo
            coringa.ReceberDano(999); // Para simular a morte
            // Batman ganha pontos
            batman.SetPontuacao(100);
            Console.WriteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
            // Subindo de nivel após matar Coringa
            batman.SubirDeNivel();
            Console.ReadLine();
        }
    }        