using System.Runtime.CompilerServices;
List<Login> log = new();
List<Produto> produto = [];
Login login = new Login();

bool loggin = false;
while (!loggin)
{
    Console.WriteLine("1. Fazer Login");
    Console.WriteLine("2. Sair");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite seu email de login");
            login.Email = Console.ReadLine();
            Console.WriteLine("Digite sua senha de login");
            login.Password = Console.ReadLine();


            if (login.Email == "nvalentim@gmail.com" && login.Password == "0809Ni12@")
            {
                Console.WriteLine("login bem sucedido ");
                loggin = true;
            }
            else
            {
                Console.WriteLine("Login invalido!");
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
            if (escolha == "S")
            {
                continuar = false;
                Console.WriteLine("saindo...");
                
            }
            
            break;
    }
}
