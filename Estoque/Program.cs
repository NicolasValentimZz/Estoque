using System.Runtime.CompilerServices;

List<Produto> produto = [];
List<Login> login = new List<Login>();

bool loggin = false;

while (!loggin)
{
    Login log = new Login();
    Console.Clear();
    Console.WriteLine("1. Cadastrar Usuario");
    Console.WriteLine("2. Fazer login");
    Console.WriteLine("3. Sair");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o email do usuario:");
            log.Email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario: ");
            log.Senha = Console.ReadLine();
            login.Add(log);
            break;
        case 2:
            Console.WriteLine("Digite email de usuario: ");
            log.Email = Console.ReadLine();
            Console.WriteLine("Digite a senha de Usuario: ");
            log.Senha = Console.ReadLine();
            foreach (var Log   in login)
            {
                Console.WriteLine("Login bem sucecido!");
                loggin = true;
            }

            

            break;
        case 3:
            Console.WriteLine("Voce desjesa sair: S/N");
            string escolha1 = Console.ReadLine().ToLower();
            if (escolha1 == "S")
            {
                Console.WriteLine("Saindo...");
                loggin = false;
            }
            break;
    }

    
}
    bool continuar = true;
while (continuar)
{
    Console.WriteLine("1. Cadastro de Produto");
    Console.WriteLine("2. Consultar Produto");
    Console.WriteLine("3. Sair");
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
            Console.WriteLine("Voce deseja sair: S/N");
            string escolha = Console.ReadLine().ToLower();
            if (escolha == "S")
            {
                Console.WriteLine("saindo...");
                Environment.Exit(0);
            }
            
            break;
    }
}
