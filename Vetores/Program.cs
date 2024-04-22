int numero;
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    numero = int.Parse(Console.ReadLine());
    numeros[i] = numero;
}

for(int i = 0;i < 5; i++)
{
    Console.WriteLine("o numero eh:" + numeros[i]);
}
