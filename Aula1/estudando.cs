using System.Reflection.Metadata;

void NomeIdadeAltura()
{
    string nome = "Caio";
    int idade = 18;
    double altura = 1.65;
    Console.WriteLine($"Meu nome é {nome} tenho {idade} , e meço {altura} de altura. E atualmente estou estuando a linguagem C# !");
}
void ComandoDeEntrada()
{
    Console.WriteLine("Qual seu nome?");
    string nome = Console.ReadLine();
    Console.WriteLine($"Seu nome é {nome}");
}
void Exercicio1()
{
    Console.WriteLine("Digite seu nome:");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Seu nome é {nome} e tem {idade} anos !");
}
void MiniCadastro()
{
    Console.WriteLine("Qual é o seu nome?");
    string user_name = Console.ReadLine();
    
    Console.WriteLine("Quantos anos você tem?");
    int user_age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o nome da cidade em que mora ?");
    string user_city = Console.ReadLine();

    Console.WriteLine("Que profissão você exerce no momento ?");
    string user_profession = Console.ReadLine();

    Console.WriteLine($"===== CADASTRO =====\nNome: {user_name}\nIdade: {user_age}\nCidade: {user_city}\nProfissão: {user_profession}");
}
MiniCadastro();