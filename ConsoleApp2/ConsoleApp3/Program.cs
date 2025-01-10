// See https://aka.ms/new-console-template for more information

// QUESTÃO 2:
//Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
//escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e
// IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;


Console.Write("Digite um numero para calcular a sequencia de fibonacci: ");
if (!int.TryParse(Console.ReadLine(), out var numero))
{
    Console.Write("É obrigatório a digitação de um número, encerrando...");
    return;
}

var isFibonacci = ChecaSeNumeroPertenceAoFibonacci(numero);

if (isFibonacci)
{
    //retorne uma mensagem avisando se o número informado pertence ou não a sequência.
    Console.WriteLine("Esse número é fibonacci!");
    return;
}

Console.WriteLine("Esse número NÃO é fibonacci!");
return;

bool ChecaSeNumeroPertenceAoFibonacci(int numero)
{
    var primeiroNumero = 0;
    var segundoNumero = 1;

    if (numero == primeiroNumero || numero == segundoNumero)
        return true;

    while (segundoNumero < numero)
    {
        var numeroTemporario = segundoNumero;
        segundoNumero = primeiroNumero + segundoNumero;
        primeiroNumero = numeroTemporario;
    }

    return segundoNumero == numero;
}