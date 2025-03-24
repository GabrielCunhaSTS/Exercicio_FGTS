double salario, fgts;

Console.Write("Digite seu Salário (R$): ");
while (!double.TryParse(Console.ReadLine()!, out salario) || salario < 0) 
{
    Console.Write("Salário Invalido! Digite um salário (não negativo): ");
}

fgts = salario * 0.08;

Console.WriteLine($"FGTS: R$ {fgts:F2}");