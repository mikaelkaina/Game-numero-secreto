using System.Reflection.Metadata.Ecma335;

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 15);

do
{

    Console.Write("Digite um número entre 1 e 15: ");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número secreto :)");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior :(");
    }
    else
    {
        Console.WriteLine("O número é menor :(");
    }

} while (true);

