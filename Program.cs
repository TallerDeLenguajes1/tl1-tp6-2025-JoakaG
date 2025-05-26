// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//PUNTO 1

// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("Valor de a: " + a);
// Console.WriteLine("Valor de b: " + b);

// Console.Write("Ingresa un numero a invertir");
// int numero;
// if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
// {
//     Console.WriteLine("anana" + numero);
//     int numeroInvertido = 0;
//     while (numero != 0)
//     {
//         numeroInvertido = numeroInvertido * 10 + (numero % 10);
//         numero = numero / 10;
//     }
//     Console.WriteLine("Numero Invertido" + numeroInvertido);
// }
// else
// {
//     Console.WriteLine("Numero ingresado menor a 0 o NO ingresaste un número");

// }


// PUNTO 2

string cadena = "hola que tal";
LargoDeCadena(cadena);
Console.WriteLine("Ingrese su nombre");
string cadenaIngresada = Console.ReadLine();
ConcatenarCadenas(cadena, cadenaIngresada);
ExtraerCadena(cadenaIngresada);
RecorrerString(cadena);
IndexOf(cadenaIngresada);
MayusculasYMinusculas(cadenaIngresada);
splitt(cadena);
calculadorabasica();
calculadoraSospechosa();

void LargoDeCadena(string cadenaIngresada)
{
    Console.WriteLine($"Largo de la cadena: {cadena.Length}");
}

void ConcatenarCadenas(string cadena1, string cadena2)
{
    Console.WriteLine($"Concatenación cadena 1 y 2: {cadena1} {cadena2}");
}

void ExtraerCadena(string cadena)
{
    Console.WriteLine($"Extración de las primeras 3 letras:{cadena.Substring(0, 3)}");
}

void RecorrerString(string cadena)
{
    Console.WriteLine("Escribir cadena con Foreach");
    foreach (char c in cadena)
    {
        Console.Write(c);
    }
}

void IndexOf(string cadena)
{
    Console.WriteLine("\nIngresar palabra a buscar en la cadena ingresada");
    string ingresado = Console.ReadLine();
    int posicion = cadena.IndexOf(ingresado);
    if (posicion == -1)
    {
        Console.WriteLine($"La palabra '{ingresado}' no se encuentra en la cadena ingresada anteriormente");
    }
    else
    {
        Console.WriteLine($"La palabra '{ingresado}' está en la posición {posicion}'");
    }
}

void MayusculasYMinusculas(string cadena)
{
    Console.WriteLine(cadena.ToUpper());
    Console.WriteLine(cadena.ToLower());
}

void splitt(string cadena)
{
    string[] partes = cadena.Split(' '); //Separa las palabras y agrega cada una en un elemento de un arreglo según el separado ' ' :)
    foreach (string parte in partes) // me permite reccorer el arreglo facil;
    {
        Console.WriteLine(parte);
    }
}

int opcion = -1;

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
        case 5:
            FuncionMin(numero1, numero2);
            break;
        case 6:
            FuncionMax(numero1, numero2);
            break;
        default:
            break;
    }
}

void FuncionSumar(float a, float b)
{
    Console.WriteLine($"\n\nResultado de {a}+{b}: " + (a + b).ToString());
}

void FuncionRestar(float a, float b)
{
    Console.WriteLine($"\n\nResultado de {a}-{b}: " + (a - b).ToString());
}

void FuncionMultiplicar(float a, float b)
{
    Console.WriteLine($"\n\nResultado de {a}*{b}: " + (a * b).ToString());
}

void FuncionDividir(float a, float b)
{
    if (b != 0)
    {
        Console.WriteLine($"\n\nResultado de {a}/{b}: " + (a / b).ToString());
    }
    else
    {
        Console.WriteLine($"\n\nERROR{a}/0 INDEFINIDO\n\n");
    }
}

void FuncionMax(float a, float b)
{
    if (a > b)
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
    if (a > b)
    {
        Console.WriteLine("\n\n Número menor: " + b);
    }
    else
    {
        Console.WriteLine("\n\n Número menor: " + a);
    }
}

void calculadoraSospechosa()
{
    Console.WriteLine("Ingresar operación basica a realizar (+, -, *, /, <, >)");
    string Operacion = Console.ReadLine();
    char[] Operadores = { '+', '-', '*', '/', '<', '>' };
    int posicion = -1;
    int opcion = -1;
    float numero1 = 0;
    float numero2 = 0;
    foreach (char Operador in Operadores)
    {
        posicion = Operacion.IndexOf(Operador);
        if (posicion != -1)
        {
            if (float.TryParse(Operacion.Substring(0, posicion), out numero1) && float.TryParse(Operacion.Substring(posicion + 1), out numero2))
            {
                switch (Operacion[posicion])
                {
                    case '+':
                        FuncionSumar(numero1, numero2);
                        break;
                    case '-':
                        FuncionRestar(numero1, numero2);
                        break;
                    case '*':
                        FuncionMultiplicar(numero1, numero2);
                        break;
                    case '/':
                        FuncionDividir(numero1, numero2);
                        break;
                    case '<':
                        FuncionMin(numero1, numero2);
                        break;
                    case '>':
                        FuncionMax(numero1, numero2);
                        break;
                    default:
                        break;
                }
            }
            break;
        }
    }
    if (posicion == -1)
    {
            Console.WriteLine("Operacion Ingresada NO válida.\n Finalizando Programa....");
    }
}