// See https://aka.ms/new-console-template for more information

//QUESTÃO 5:

// 5) Escreva um programa que inverta os caracteres de um string.
//     IMPORTANTE:
// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
// b) Evite usar funções prontas, como, por exemplo, reverse;

Console.Write("Digite uma frase para inverter: ");
var inputString = Console.ReadLine();

if (inputString is null or "")
    Console.WriteLine("O valor não pode ser vazio, encerrando...");

var invertida = InverteStringArray(inputString!.ToCharArray());
Console.WriteLine(invertida);

return;

string InverteStringArray(char[] chars)
{
    var esquerda = 0;
    var direita = chars.Length - 1;

    while (esquerda < direita)
    {
        (chars[esquerda], chars[direita]) = (chars[direita], chars[esquerda]);

        esquerda++;
        direita--;
    }

    return new string(chars);
}