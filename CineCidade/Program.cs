Console.Write("Digite o nome do cliente: ");
string nome = Console.ReadLine()!;

Console.Write("Digite a quantidade de ingressos: ");
int quantidadeIngressos = int.Parse(Console.ReadLine()!);

Console.Write("Digite o cupom de desconto: ");
string cupom = Console.ReadLine()!;

Console.Write("Digite a idade do cliente: ");
int idade = int.Parse(Console.ReadLine()!);

decimal custoBruto = 5 + (quantidadeIngressos * 25);

decimal desconto = 0;

if (cupom.Equals("CINEMA10", StringComparison.OrdinalIgnoreCase))
{
    desconto = custoBruto * 0.10m;
}

decimal valorFinal = custoBruto - desconto;

string nomeFormatado = nome.ToUpper();

bool elegivelSessaoNoturna = quantidadeIngressos > 1 && idade >= 18;

Console.WriteLine();
Console.WriteLine("===== CINECIDADE =====");
Console.WriteLine($"Cliente: {nomeFormatado}");
Console.WriteLine($"Valor bruto: R${custoBruto:F2}");
Console.WriteLine($"Valor final: R${valorFinal:F2}");
Console.WriteLine($"Elegível para Sessão Noturna: {elegivelSessaoNoturna}");