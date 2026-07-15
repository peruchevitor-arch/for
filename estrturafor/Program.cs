//while enquanto true =2 etc executa ...
// int i = 1;

// while (i <= 10)
// {
//     int tabuada = i * 5;

//     Console.WriteLine("5 x " + i + " = " + tabuada);

//     i++;
// }

//validador de entrada de dados enquanto usuario n digitar numero entre 1 e 10 pede pra ele digitar novamente
int numero = 0;

while (numero < 1 || numero > 10)
{
    Console.WriteLine("Digite um número entre 1 e 10: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 1 || numero > 10)
    {
        Console.WriteLine("Número inválido. Tente novamente.");
    }
    else
    {
        Console.WriteLine("Número válido: " + numero);
    }
}meu cu
