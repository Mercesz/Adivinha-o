using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using _1_Introdução.Models;

Random random = new Random();


bool jogarNovamente = true; // Controla o reinicio do jogo

while (jogarNovamente)
{
    int numero = 0, contador = 5;
    int numeroAleatorio = random.Next(1, 101);

    do
    {
        
        Console.WriteLine("Adivinhe um número entre 1 e 100: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if ( numero < numeroAleatorio)
        {
            Console.WriteLine("O número é maior!");
        }
        if (numero > numeroAleatorio)
        {
            Console.WriteLine("o numero é menor");
        }

        contador--;//Decrementando as tentativas do jogador

    } while (contador > 0 && numero != numeroAleatorio);//Continua enquanto houver tentativas e o número não for acertado

    if (numero == numeroAleatorio)
    {
        Console.WriteLine($"Parabéns você acertou em {contador} tentativas");
    }
    else
    {
        Console.WriteLine("Game Over");
    }

    Console.WriteLine("Você quer jogar novamente (s/n)");
    string resposta = Console.ReadLine().ToLower();
    if (resposta != "s")//Reposta diferente de "s" jogo encerra
    {
        jogarNovamente = false;
        Console.WriteLine("Obrigado por jogar!");
    }
}
