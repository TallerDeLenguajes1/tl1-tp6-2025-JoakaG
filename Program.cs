// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


int opcion = -1;
do
{
    Console.WriteLine("\nSeleccione acción a realizar\n 1. Sumar\n 2. Resta\n 3.Multiplicar\n 4.Dividir \n 0. Salir");
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion != 0 && opcion < 5)
    {
        FuncionIngresarNumeros(opcion);
    }
    else
    {
        opcion = 0;
    }
} while (opcion > 0 && opcion < 5);
Console.WriteLine("Finalizando programa...");
void FuncionIngresarNumeros(int opcion)
{
    Console.WriteLine("Ingresa el primer número (en caso de necesitar separador decimal utilizar ,)");
    string ingreso1 = Console.ReadLine();
    Console.WriteLine("Ingresa el segundo número (en caso de necesitar separador decimal utilizar ,)");
    string ingreso2 = Console.ReadLine();
    if (float.TryParse(ingreso1, out float numero1) && float.TryParse(ingreso2, out float numero2))
    {
        realizarOperacion(numero1, numero2, opcion);
    }
    else
    {
        Console.WriteLine("\n\nUno o los dos datos ingresados no son números\n\n");
    }
}

void realizarOperacion(float numero1, float numero2, int opcion)
{
    switch (opcion)
    {
        case 1:
            FuncionSumar(numero1, numero2);
            break;
        case 2:
            FuncionRestar(numero1, numero2);
            break;
        case 3:
            FuncionMultiplicar(numero1, numero2);
            break;
        case 4:
            FuncionDividir(numero1, numero2);
            break;
        default:
            break;
    }
}


void FuncionSumar(float a, float b)
{
    Console.WriteLine("\n\nResultado de " + a + "+" + b + ": " + (a + b));
}

void FuncionRestar(float a, float b)
{
    Console.WriteLine("\n\nResultado de " + a + "-" + b + ": " + (a - b));
}

void FuncionMultiplicar(float a, float b)
{
    Console.WriteLine("\n\nResultado de " + a + "*" + b + ": " + (a * b));
}

void FuncionDividir(float a, float b)
{
    if (b != 0)
    {
        Console.WriteLine("\n\nResultado de " + a + "/" + b + ": " + (a / b));
    }
    else
    {
        Console.WriteLine("\n\nERROR"+a+"/0 INDEFINIDO\n\n");
    }
}