using System;

int[] numeros = new int[10];
int[] numerosPrimos = new int[numeros.Length];
int qtdPrimos = 0;


for (int i = 0; i < 10; i++)
{
    Console.Write("\nInforme o número " + (i + 1) + ": ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    int num = numeros[i];
    int qtdDivisores = 0;
    for (int j = 1; j <= num; j++)
    {
        if (num % j == 0)
        {
            qtdDivisores++;
        }
    }
    if (qtdDivisores == 2)
    {
        numerosPrimos[qtdPrimos] = num;
        qtdPrimos++;       
    }
   
}
Console.Write("\nNumeros Primos: \n");
for (int i = 0; i < qtdPrimos; i++)
{
    Console.Write("\n" + numerosPrimos[i] +"\n");
}