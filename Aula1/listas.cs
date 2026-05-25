List<string> nomes = new List<string>();
string nome = "caio";
while (true)
{   
    Console.WriteLine("Escolha uma opção:\n1 - Adicionar nome a lista\n2 - Vizualizar lista\n 0 - Sair");
    int op = Convert.ToInt32(Console.ReadLine());
    
    if (op == 1)
    {
        Console.WriteLine("Qual nome que deseja adicionar a lista?: ");
        nome = Console.ReadLine();
        adicionarNome(nome);
    }
    else if (op == 2)
    {
        foreach (string names in nomes)
        {
            Console.WriteLine(names);
        }
        Console.WriteLine("ESTA SÃO TODAS AS PESSOAS ADICIONADAS A LISTA!!!");
    }
    else if (op == 0)
    {
        break;
    }
}
Console.WriteLine("Saiu...");
void adicionarNome(string pessoa)
{
    nomes.Add(pessoa);
    Console.WriteLine("Nome adicionado a lista...");
}
