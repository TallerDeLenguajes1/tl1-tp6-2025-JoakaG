// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);

Console.Write("Ingresa un numero a invertir");
int numero;
if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
{
    Console.WriteLine("anana" + numero);
    int numeroInvertido = 0;
    while (numero != 0)
    {
        numeroInvertido = numeroInvertido * 10 + (numero % 10);
        numero = numero / 10;
    }
    Console.WriteLine("Numero Invertido" + numeroInvertido);
}
else
{
    Console.WriteLine("Numero ingresado menor a 0 o NO ingresaste un número");

}



