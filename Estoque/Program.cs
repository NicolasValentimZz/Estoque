List<Produto> produto = [];

bool login = false;

while (!login)
{
    Usuario user = new();
    Console.WriteLine("Tela de Login");
    Console.WriteLine("Digite seu email:");
    user.Email = Console.ReadLine();
    Console.WriteLine("Digite sua senha: ");
    user.Senha = Console.ReadLine();

    if (user.Email == "nvalentim825@gmail.com" && user.Senha == "1234")
    {
        Console.WriteLine("Login bem-sucedido");
        login = true;
    }
}
    bool continuar = true;
    while(continuar)
{
    Console.WriteLine("1. Cadastro de Produto");
    Console.WriteLine("2. Consultar Produto");
    Console.WriteLine("3. Cadastrar Usuario:");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            
            Produto novosProdutos = new();
            Console.WriteLine("Digite o id do produto: ");
            novosProdutos.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do produto: ");
            novosProdutos.Nome = Console.ReadLine();
            produto.Add(novosProdutos);
            Console.WriteLine($"Produto: {novosProdutos.Nome}, {novosProdutos.Id} cadastrado com sucesso!");
            break;
        case 2:
            Console.WriteLine("Digite o id do produto: ");
            int IdConsulta = int.Parse(Console.ReadLine());
            foreach (var item in produto)
            {
                if (item.Id == IdConsulta)
                {
                    Console.WriteLine($"{item.Id}, {item.Nome}");
                }
            }
            break;

        case 3:
            Console.WriteLine("Cadastro de usuario:");
            Console.WriteLine("\nDigite o email de cadastro do usuario:");
            
            break;
    }
}