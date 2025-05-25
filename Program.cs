// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


int opcion = -1;
do
{
    Console.WriteLine("\n---Seleccione una opción---");
    Console.WriteLine("1. Valor absoluto de un número");
    Console.WriteLine("2. Cuadrado de un número");
    Console.WriteLine("3. Raíz cuadrada de un número");
    Console.WriteLine("4. Seno de un número");
    Console.WriteLine("5. Coseno de un número");
    Console.WriteLine("6. Parte entera de un número");
    Console.WriteLine("7. Mínimo entre dos números");
    Console.WriteLine("8. Máximo entre dos números");
    Console.WriteLine("0. Salir");
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion != 0 && opcion < 9)
    {
        realizarOperaciones(opcion);
    }
    else
    {
        opcion = 0;
    }
} while (opcion > 0 && opcion <= 8);
Console.WriteLine("Finalizando programa...");

float FuncionIngresarNumero()
{
    Console.WriteLine("Ingresa número (utilizar , como separador decimal en caso de necesitarlo)");
    string ingreso = Console.ReadLine();
    if (float.TryParse(ingreso, out float numero))
    {
        return numero;
    }
    else
    {
        return 1.45730625279f;
    }
}



void realizarOperaciones(int opcion)
{
    float a;
    float b = 0f;
    if (opcion < 7)
    {
        a = FuncionIngresarNumero();
    }
    else
    {
        a = FuncionIngresarNumero();
        b = FuncionIngresarNumero();
    }
    if (a == 1.45730625279 || b == 1.45730625279)
    {
        Console.WriteLine("ERROR no se ingresó un número válido");
        return;
    }
    switch (opcion)
    {
        case 1:
            FuncionAbsoluto(a);
            break;
        case 2:
            FuncionCuadrado(a);
            break;
        case 3:
            FuncionRaizCuadrada(a);
            break;
        case 4:
            FuncionSeno(a);
            break;

        case 5:
            FuncionCoseno(a);
            break;
        case 6:
            FuncionParteEntera(a);
            break;
        case 7:
            
            FuncionMin(a, b);
            break;
        case 8:
            FuncionMax(a, b);
            break;
        default:
            break;
    }
}


void FuncionAbsoluto(float a)
{
    Console.WriteLine("\n\n|"+a+"|= "+ Math.Abs(a));
}

void FuncionCuadrado(float a)
{
    Console.WriteLine("\n\n"+a +"^2"+ "= " + (a * a));
}
void FuncionRaizCuadrada(float a)
{
    Console.WriteLine("\n\n√" + a + "=" + Math.Sqrt(a));
}

void FuncionParteEntera(float a)
{
    Console.WriteLine("\n\n[" + a + "]= " + Math.Floor(a));
}

void FuncionSeno(float a)
{
    Console.WriteLine("\n\nsen " + a + "= " + Math.Sin(a));
}

void FuncionCoseno(float a)
{
    Console.WriteLine("\n\ncos " + a + "= " + Math.Cos(a));
}

void FuncionMax(float a, float b)
{
    if (a >= b)
    {
        Console.WriteLine("\n\n Número mayor: " + a);
    }
    else
    {
        Console.WriteLine("\n\n Número mayor: " + b);
    }
}

void FuncionMin(float a, float b)
{
    if (a < b)
    {
        Console.WriteLine("\n\n Número menor: " + a);
    }
    else
    {
        Console.WriteLine("\n\n Número menor: " + b);
    }
}