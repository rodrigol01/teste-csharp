// See https://aka.ms/new-console-template for more information

//QUESTÃO 4:

// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//     • SP – R$67.836,43
//     • RJ – R$36.678,66
//     • MG – R$29.229,88
//     • ES – R$27.165,48
//     • Outros – R$19.849,55
// Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

var estadosFaturamentos = new Dictionary<string, decimal>
{
    { "SP", 67836.43m },
    { "RJ", 36678.66m },
    { "MG", 29229.88m },
    { "ES", 27165.48m },
    { "Outros", 19849.53m }
};

var total = estadosFaturamentos.Values.Aggregate(0, (current, valor) => (int)(current + valor));

foreach (var estado in estadosFaturamentos)
{
    var percentual = (estado.Value / total) * 100;
    Console.WriteLine($"{estado.Key}: {percentual:F2}%");
}