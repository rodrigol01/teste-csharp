// See https://aka.ms/new-console-template for more information

//QUESTÃO 3:
// Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//     • O menor valor de faturamento ocorrido em um dia do mês;
//     • O maior valor de faturamento ocorrido em um dia do mês;
//     • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

int[] faturamentoPorDia = [1000, 1200, 1300, 1500, 990];

MenorValorDiario(faturamentoPorDia);

MaiorValorDiario(faturamentoPorDia);

QuantidadeDeDiasAbaixoDaMediaDeFaturamento(faturamentoPorDia);


return;

void QuantidadeDeDiasAbaixoDaMediaDeFaturamento(int[] faturamentoPorDia)
{
    var media = faturamentoPorDia.Average();

    var diasAbaixoDaMedia = faturamentoPorDia.Count(faturamento => faturamento < media);

    Console.WriteLine("Dias abaixo da média foi: {0}", diasAbaixoDaMedia);
}


void MaiorValorDiario(int[] faturamentoPorDia)
{
    var maiorFaturamento = faturamentoPorDia.Max();

    Console.WriteLine("O maior faturamento do mês foi de: {0}", maiorFaturamento);
}

void MenorValorDiario(int[] faturamentoPorDia)
{
    var menorFaturamento = faturamentoPorDia.Min();

    Console.WriteLine("O menor faturamento do mês foi de: {0}", menorFaturamento);
}