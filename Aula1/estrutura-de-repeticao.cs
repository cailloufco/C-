void contagemComFor()
{
    for (int i = 0; i != 11; i++)
    {
        Console.WriteLine(i);
    }
}
void contagemComWhile()
{
    int i = 0;

    while (i != 10)
    {
        i++;
        Console.WriteLine(i);
    }
}
void numerosPares()
{
    for (int i = 0; i != 21; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " é par");
        }
    }
}
void pedindoSenhaAteAcertar()
{
    string user_password = "cailloufco123";
    Console.WriteLine("digite a senha até acerta-la : ");

    string user_tryPassword = Console.ReadLine();

    while (user_tryPassword != user_password)
    {
        Console.WriteLine("Senha errada! Tente novamente :");
        user_tryPassword = Console.ReadLine();

    }
    Console.WriteLine("Senha correta!!!");
}

void miniBanco()
{
    double saldo_bancario = 0.0;
    int opcao = 99;
    while (opcao != 0)
    {
        Console.WriteLine("1 - Ver saldo\n2 - Depositar\n0 - Sair");
        opcao = Convert.ToInt32(Console.ReadLine());
        

        if (opcao == 1)
        {
            Console.WriteLine($"\nSEU SALDO BANCARIO\nSALDO : {saldo_bancario} $");
        }
        else if(opcao == 2)
        {
            Console.WriteLine("Digite quantos REAIS deseja depositar: ");
            saldo_bancario += Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Saindo...");
        }
    }
}
miniBanco();