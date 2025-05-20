// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


int opcion = -1;
do
{.
    Console.WriteLine("1. Obtener: \n ●El valor absoluto de un número \n● El cuadrado \n ● La raíz cuadrada \n ● El seno \n ● El Coseno \n ● La parte entera \n 0. Salir");
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion != 0 && opcion < 2)
    {
        float a = FuncionIngresarNumeros();
        realizarOperaciones(a);
    }
    else
    {
        opcion = 0;
    }
} while (opcion > 0 && opcion < 2);
Console.WriteLine("Finalizando programa...");

float FuncionIngresarNumeros()
{
    Console.WriteLine("Ingresa el primer número entero");
    string ingreso1 = Console.ReadLine();
    if (float.TryParse(ingreso1, out float numero1))
    {
        return numero1;
    }
    else
    {
        return 1.45730625279;
    }
}


void realizarOperaciones(float a)
{
    FuncionAbsoluto(a);
    FuncionCuadrado(a);
    FuncionRaizCuadrada(a);
    FuncionSeno(a);
    FuncionCoseno(a);
    FuncionParteEntera(a);
}


void FuncionAbsoluto(float a)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.Abs(a));
}

void FuncionCuadrado(float a)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + (a * a));
}
void FuncionRaizCuadrada(float a)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.Sqrt(a));
}

void FuncionParteEntera(float a)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.(a));
}

void FuncionSeno(float a)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.Sin(a));
}

void FuncionCoseno(float a)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.Cos(a));
}

void FuncionMax(float a, float b)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.Abs(a));
}

void FuncionMin(float a, float b)
{
    Console.WriteLine("\n\nResultado de " + a + ": " + Math.Abs(a));
}