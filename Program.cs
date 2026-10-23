Console.Write("Valor do empréstimo: ");
double valor = double.Parse(Console.ReadLine()!);

Console.Write("Quantidade de parcelas: ");
if (!int.TryParse(Console.ReadLine(), out int parcelas))
{
    Console.WriteLine("Digite apenas números.");
    return;
}

Console.Write("Renda mensal: ");
double renda = double.Parse(Console.ReadLine()!);

double parcela = valor / parcelas;

if (parcela <= renda * 0.30)
    Console.WriteLine("Empréstimo autorizado");
else
    Console.WriteLine("Empréstimo negado");