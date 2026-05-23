void Nota()
{
    Console.WriteLine("Digite sua nota: ");
    double nota = Convert.ToDouble(Console.ReadLine());

    if (nota >= 7.0)
    {
        Console.WriteLine("Você passou!");
    }
    else if (nota > 5.0 || nota < 7.0)
    {
        Console.WriteLine("Você está na recuperação");
    }
    else
    {
        Console.WriteLine("Você reprovou");
    }
}
void Login()
{
    string user_nameLogin = "cailloufco" ;
    string user_passwordLogin = "caio123" ;

    Console.WriteLine("Digite seu nome de usuario: ");
    string user_try_nameLogin = Console.ReadLine();
    
    Console.WriteLine("Digite sua senha: ");
    string user_try_passowordLogin = Console.ReadLine();

    if (user_try_nameLogin == user_nameLogin && user_passwordLogin == user_try_passowordLogin)
    {
        Console.WriteLine("Login efetuado com sucesso!");
    }
    else
    {
        Console.WriteLine("Nome de usuario ou senha incorretos!");
    }
}
Login();