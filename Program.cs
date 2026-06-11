// Escreva a mensagem "Informe um numero:"
Console.Write("Informe um numero: ");
// Cria a variável variavelQueSalvaUmNumero,
// Leia o que o usuario digitar
// e transforma o valor lido de texto para inteiro (int.parse)
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine());

// verifica se o valor de variavelQueSalvaUmNumero é par
if (variavelQueSalvaUmNumero % 2 == 0) {
 Console.WriteLine($"Numero {variavelQueSalvaUmNumero} é par");
} else {
    Console.WriteLine($"Numero {variavelQueSalvaUmNumero} é impar");
}