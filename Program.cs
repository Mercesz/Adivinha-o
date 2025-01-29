using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using _1_Introdução.Models;
// using INTRODUÇÃO.Models;
Calculadora calc = new Calculadora();

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





// string opcao ;
// bool exibirMenu = true;

// while (exibirMenu){
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1-Cadastrar cliente");
//     Console.WriteLine("2-Buscar cliente");
//     Console.WriteLine("3-Apagar cliente");
//     Console.WriteLine("4-Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao){
//         case "1":
//         Console.WriteLine("Cadastro de cliente");
//         break;

//         case "2":
//         Console.WriteLine("Busca cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         // Encerrar o programa por completo = Environment.Exit(0);    
//         break;

//         default:
//         Console.WriteLine("Opção Inválida");
//         break;
//     }    
// }
// Console.WriteLine("Zeze Bonitão");




// int soma = 0,numero = 0;


// do{
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;


// }while(numero != 0 );

// Console.WriteLine($"Total da soma dos números é: {soma}");




// int x = 5;
// int contador = 1;

// while (contador <= 10){
//     Console.WriteLine($"{x} * {contador} = {x * contador}");
//     contador++;

//     if (contador == 6){
//         break;
//     }
// }



// for (int x = 1; x <= 10;x++){
// for (int contador = 1;contador <= 10;contador++){
//     Console.WriteLine($"{x} * {contador} = {x*contador}");
//     if (contador == 10){
//     Console.WriteLine("--------------------");
// }
//   }
// }


// calc.raizQuadrada(9);



// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("incrementando o 10");

// numero ++;

// Console.WriteLine(numero);

// Console.WriteLine (numero);
// Console.WriteLine("Decrementando o 11");
// numero --;
// Console.WriteLine(numero);

// calc.Somar(10 , 30);
// calc.Subtrair(10 , 50);
// calc.Multiplicar(15 , 45);
// calc.Dividir(2 , 2);

// calc.Potencia(3 , 3);



// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");
// }else{
//     Console.WriteLine("Vou pedalar outro dia");
// }



// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado!");
// }else{
//     Console.WriteLine("Reprovado");


// bool ehMaiorDeidade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeidade ||possuiAutorizacaoDoResponsavel ){
//     Console.WriteLine("Entrada permitida");
// }
// else{
//     Console.WriteLine("Entrada nãoliberada!");
// }


// Console.WriteLine("Digite uma letra: ");
// string  letra = Console.ReadLine();

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine ("É vogal");
//         break;
//     default:
//         Console.WriteLine ("Não é vogal");
//         break;
// }






// if (letra == "a" ||
//  letra == "e" || 
//  letra == "i"||
//  letra == "o"||
//  letra == "u"){
//     Console.WriteLine ("É vogal");
//  }
//  else{
//     Console.WriteLine ("Não é vogal");
//  }



// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra>0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0){
//     Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda){
//     Console.WriteLine("Venda realizada.");
// }
// else{
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
// }