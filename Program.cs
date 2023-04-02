// gerador de números aleatórios
Random random = new Random();

// cria a lista de produtos
IList<Produto> produtos = new List<Produto>
{
    // cria os produtos na lista
    new Produto(random.Next(1, 5000), 250.00M, "Produto " + 1),
    new Produto(random.Next(1, 5000), 326.99M, "Produto " + 2),
    new Produto(random.Next(1, 5000), 99.90M, "Produto " + 3),
    new Produto(random.Next(1, 5000), 45.00M, "Produto " + 4),
    new Produto(random.Next(1, 5000), 180.00M, "Produto " + 5)
};

// cria o cliente
Cliente cliente = new Cliente(1, "Cliente 1", "(99) 99999-9999");

// cria a venda, passando o Id, o Cliente e a Lista de produtos
Venda venda = new Venda(1, cliente, produtos);

// imprime as informações da venda
Console.WriteLine($"\nId: {venda.Id}, Venda realizado por: {venda.Cliente.Nome}, em: {venda.Data.ToString("dd/MM/yyyy")}");

foreach (var item in venda.Produtos)
{
    Console.WriteLine("Descrição: " + item.Descricao + " Valor: " + item.Valor);
}

public class Produto
{
    public Produto(int id, decimal valor, string descricao)
    {
        Id = id;
        Valor = valor;
        Descricao = descricao;
    }

    public int Id { get; set; }
    public decimal Valor { get; set; }
    public string Descricao { get; set; }
}

public class Cliente
{
    public Cliente(int id, string nome, string telefone)
    {
        Id = id;
        Nome = nome;
        Telefone = telefone;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
}

public class Venda
{
    public Venda(int id, Cliente cliente, IList<Produto> produtos)
    {
        Data = DateTime.UtcNow;
        Cliente = cliente;
        Produtos = produtos;
        Id = id;
    }

    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Cliente Cliente { get; set; }
    public IList<Produto> Produtos { get; set; }
}