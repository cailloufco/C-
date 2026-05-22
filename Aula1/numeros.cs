using System.ComponentModel.DataAnnotations;

void CalcularPreco()
{
    int quantia = 20;
    int preco = 8;
    int ValorTotal = quantia * preco;
    Console.WriteLine($"O valor total foi de {ValorTotal}");
}
void OperadoresMatematicos()
{
    int num1 = 10;
    int num2 = 7;
    int num3 = 2;

    //subtração
    Console.WriteLine($"A subtração: {num1 - num2}");

    //soma
    Console.WriteLine($"A soma : {num1 + num3}");

    //multiplicação
    Console.WriteLine($"A multiplicação : {num1 * num3}");

    //divisão
    Console.WriteLine($"A divisão : {num2 / num3}");
}
void MaisOperadoresDoCSharp()
{
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");
    int what = max + 1;
    Console.WriteLine($"An example of overflow: {what}");
}
void LiberaramOFloat()
{
    double quantia = 5;
    double preco = 2.49;
    double ValorTotal = quantia * preco;
    Console.WriteLine($"{ValorTotal}");
}
void UmaLoucuraAqui()                               
{
    double teste = double.MaxValue;
    Console.WriteLine(teste);
    double tres = 1.0 / 3.0 ;
    Console.WriteLine(tres);
}
UmaLoucuraAqui();