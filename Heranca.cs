using System;

public class Produto
{
    private string nome
   private decimal preco
   private string descricao
   private string categoria

    public Produto(string nome, decimal preco, string descricao, string categoria)
    {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }


    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preco: {Preco}");
        Console.WriteLine($"Descricao: {Descricao}");
        Console.WriteLine($"Categoria: {Categoria}");
    }

    public string Nome{
        get {return nome;}
        set {nome = value;}
    }

    public decimal Preco{
        get {return preco;}
        set {preco = value;}
    }

    public string Descricao{
        get {return descricao;}
        set {descricao = value;}
    }

    public string Categoria{
        get {return categoria;}
        set {categoria = value;}
    }
}

public class ConsoleGame : Produto {
    private int capacidadeArmazenamento;

     public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadeArmazenamento) : base(nome, preco, descricao, categoria)
    {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
        this.capacidadeArmazenamento = capacidadeArmazenamento;
    }

    public int CapacidadeArmazenamento{
        get {return capacidadeArmazenamento;}
        set {capacidadeArmazenamento = value;}
    }
}


public class Jogo : Produto {
    private string genero;

     public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria)
    {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
        this.genero = genero;
    }

    public string genero{
        get {return genero;}
        set {genero = value;}
    }
}

public class Acessorio : Produto {
    private string tipo;

     public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria)
    {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
        this.tipo = tipo;
    }

    public string tipo{
        get {return tipo;}
        set {tipo = value;}
    }
}

public class Colecionavel : Produto {
    private bool edicaoLimitada;

     public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada) : base(nome, preco, descricao, categoria)
    {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
        this.edicaoLimitada = edicaoLimitada;
    }

    public string edicaoLimitada{
        get {return edicaoLimitada;}
        set {edicaoLimitada = value;}
    }
}

public static void main (string[] args) {

    Produto produto;
    produto = new ConsoleGame("PlayStation 5", 5.900,"Console de Vídeo Game PlayStation 5 Slim com 1 Tera de armazenamento" , "Console", 1024000);

    Jogo jogo = new Jogo("Marvel's Spider-Man 2 PREMIUM", 299.9,"Jogo completo Marvel's Spider-Man 2 para PS5." , "Jogo PS5", "Ação e Aventura");

    Acessorio acessorio = new Acessorio("Suporte para Controle de Vídeo Game", 50, "Suporte para colocar o Controle em cima", "Suporte");

    Colecionavel colecionavel = new Colecionavel("Coleção de Jogos Spider-Man 2", 5.127,63, "Coleção completa Spider-Man 2", "Todos os Jogos");
}

