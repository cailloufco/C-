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
void DivisaoUsandoDouble()                               
{
    double teste = double.MaxValue;
    double teste2 = double.MinValue;
    Console.WriteLine(teste);
    Console.WriteLine(teste2);
    double tres = 1.0 / 3.0 ;
    Console.WriteLine(tres);
}
void DivisaoComM()
{
    decimal num1 = 1.0m;
    decimal num2 = 3.0m;
    Console.WriteLine(num1 / num2);

    double num3 = 1.0;
    double num4 = 3.0;
    Console.WriteLine(num3 / num4) ;
}


void Desafio()
{
    double ValorPi = Math.PI;
    double RaioDoCirculo = 2.50;

    Console.WriteLine($"A aréa do circulo em CENTIMETROS é = {ValorPi * (RaioDoCirculo * RaioDoCirculo)}");
}
Desafio();