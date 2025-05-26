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



