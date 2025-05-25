// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

int opcion1 = -1;
int opcion = -1;
do
{
    opcion1 = -1;
    Console.WriteLine("Seleccione calculadora a Utilizar:");
    Console.WriteLine("1. Calculadora Común (4 operaciones básicas)");
    Console.WriteLine("2. Calculadora Compleja");
    Console.WriteLine("0. Salir");

    if (int.TryParse(Console.ReadLine(), out opcion1) && opcion1 != 0 && opcion1 < 3)
    {
        if (opcion1 == 1)
        {
            calculadorabasica();
        }
        else
        {
            calculadoraCompleja();
        }

    }
    else
    {
        opcion1 = 0;
    }

} while (opcion1 > 0 && opcion1 <= 2);
Console.WriteLine("Finalizando programa...");

void calculadorabasica()
{
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
}

void calculadoraCompleja()
{
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
}

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
        return float.NaN;
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
    if (float.IsNaN(a) || float.IsNaN(b))
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
        Console.WriteLine("\n\nERROR" + a + "/0 INDEFINIDO\n\n");
    }
}
void FuncionAbsoluto(float a)
{
    Console.WriteLine("\n\n|" + a + "|= " + Math.Abs(a));
}

void FuncionCuadrado(float a)
{
    Console.WriteLine("\n\n" + a + "^2" + "= " + (a * a));
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