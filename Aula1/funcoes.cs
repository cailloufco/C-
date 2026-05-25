void funcaoNome(string nome)
{
    //crie uma funçao que deve mostrar seu nome.
    Console.WriteLine($"Legal tambem me chamo {nome}");
}
// Console.WriteLine("Digite seu nome: "); funcaoNome(Console.ReadLine());

int funcaoSoma(int num1 , int num2)
{
    return num1 + num2;
}
// Console.WriteLine("digite um numero: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("digite um outro numero: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// int resultado = funcaoSoma(n1 , n2);
// Console.WriteLine(resultado);

//------------------------
//Crie um mini sistema bancário com funções.

// Funções obrigatórias:

// MostrarSaldo()
// Depositar()
// Sacar()

// O saldo deve mudar conforme operações.
//------------------------

double saldo_bancario = 0.0;

void MostrarSaldo()
{
    Console.WriteLine($"SEU SALDO ATUAL: {saldo_bancario}");
}

double Deposito(double valorDepositado)
{
    return saldo_bancario += valorDepositado;
}

double Saque(double valorSacado)
{
    return saldo_bancario -= valorSacado;
}
int op = 99; 
while (op != 0)
{
    Console.WriteLine("1 - Mostrar saldo\n2 - Depositar\n3 - Sacar\n0 - Sair");
    op = Convert.ToInt32(Console.ReadLine());
    if (op == 1)
    {
        MostrarSaldo();
    }
    else if(op == 2)
    {
        Console.WriteLine("Quanto deseja depositar?: ");
        double valorDeposito = Convert.ToDouble(Console.ReadLine());
        Deposito(valorDeposito);
    }
    else if(op == 3)
    {
        Console.WriteLine("Quanto deseja sacar?: ");
        double valorSaque = Convert.ToDouble(Console.ReadLine());
        Saque(valorSaque);
    }
}