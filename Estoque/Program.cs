using System.Runtime.CompilerServices;
List<Login> log = new();
List<Produto> produto = [];


bool loggin = false;
while (!loggin)
{
    Login login = new Login();

    Console.WriteLine("1. Cadastro de login");
    Console.WriteLine("2. Fazer Login");
    Console.WriteLine("3. Sair");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {

        
        case 1:
            Console.WriteLine("Digite o email de login a ser cadastrado: ");
            login.Email = Console.ReadLine();
            log.Add(login);
            break;
        case 2:

            try
            {
                Console.WriteLine("Digite seu email:\n ");
                login.Email = Console.ReadLine();
                for (int i = 0; i >= 0; i--)
                {
                    if (log[i].Email == login.Email)
                    {
                        Console.WriteLine("\nlogin realizado com sucesso!\n");
                        loggin = true;
                    }
                }
            }
            catch
            {
                Console.WriteLine("\nDigite um email valido!\n");
              
               ;
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
                    Console.WriteLine($"{item.Nome}, {item.Id}");
                }
            }
            break;

        case 3:
            Console.WriteLine("Voce deseja sair: S/N");
            string escolha = Console.ReadLine().ToLower();
            for (int i = 0; i < escolha.Length; i++)
            {
                if (escolha[i] == 's')
                {
                    Console.WriteLine("Saindo...");
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Continuando...");
                }
            }

            break;
            
    }
}
