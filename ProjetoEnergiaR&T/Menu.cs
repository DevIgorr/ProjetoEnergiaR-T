
class Menu()
{
    public static void exibirMenu()
    {
        Console.WriteLine("Bem vindo(a) ao programa Energia R&T\n");
        Console.WriteLine("Escolha uma das opções a seguir:");
        Console.WriteLine("Aperte 1 para ver qual plano encaixa no seu bolso.");
        Console.WriteLine("Aperte 2 para cadastrar cliente.");
        Console.WriteLine("Aperte 3 para simular sua energia solar.");
        Console.WriteLine("Aperte 4 para para sair.");

        Console.WriteLine("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch(opcaoEscolhidaNumerica)
        {
            case 1: Planos();
                  break;
            case 2: Registrar();
                break;
            case 3: Simular();
                break;
            case 4:
                Console.WriteLine("Encerrando o programa");
                break;
            default:
                Console.WriteLine("Opçao invalida tente novamente com outra opçao");
                break;
            


        }

        Console.Clear();

    }

     static void Planos()
    {
        Console.Clear();
        Console.WriteLine("Veja a baixo os planos disponiveis");
        Console.WriteLine("Escolha uma das opçoes abaixo\n");
        Console.WriteLine("1. Sistema Fotovoltaica Residencial");
        Console.WriteLine("2. Sistema Fotovoltaica Comercial");
        Console.WriteLine("3. Sistema Fotovoltaica Insdustrial");
        Console.WriteLine("4. Sistema Fotovoltaica Rural");
        Console.WriteLine("5. Voltar ao menu anterior");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                Console.WriteLine("Plano Residencial: Ideal para casas, com capacidade de geração de 3 a 5 kW.");
                Console.WriteLine("Preço médio: R$ 15.000,00");
                break;
            case 2:
                Console.WriteLine("Plano Comercial: Projetado para pequenas e médias empresas, com capacidade de geração de 10 a 20 kW.");
                Console.WriteLine("Preço médio: R$ 50.000,00");
                break;
            case 3:
                Console.WriteLine("Plano Industrial: Para grandes indústrias, com capacidade de geração acima de 50 kW.");
                Console.WriteLine("Preço médio: R$ 200.000,00");
                break;
            case 4:
                Console.WriteLine("Plano Rural: Voltado para propriedades rurais, ideal para bombas d'água e outros usos.");
                Console.WriteLine("Preço médio: R$ 30.000,00");
                break;
            case 5:
                Console.Clear();
                exibirMenu();
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                break;

        }
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
        Planos();
    }

    static void Registrar()
    {
        throw new NotImplementedException();
    }

     static void Simular()
    {
        throw new NotImplementedException();
    }
}