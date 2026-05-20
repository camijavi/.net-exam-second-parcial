// El programa crea dos arreglos del mismo tamaño: uno almacena nombres y el otro la cantidad de letras de cada nombre.
//  Luego valida que los nombres no estén vacíos, no tengan números ni símbolos y tengan más de 2 caracteres. 
//  Finalmente, muestra cada nombre con su longitud y los clasifica en cortos, medios o largos según la cantidad de letras.

using System;
using System.Linq; 

int tamano;
int carac = 0;
Console.WriteLine("Por favor ingresa la cantidad de valores que deseas ingresar");

// Validacion 1: Cantidad de valores
while (!int.TryParse(Console.ReadLine(), out tamano) || tamano <= 0)
{
    Console.WriteLine("Ingresa un numero valido mayor que 0");
}

string[] nombres = new string[tamano];
int[] longitudes = new int[tamano]; // Se pide arreglo para almacenar cantidades

for (int i = 0; i < tamano; i++)
{
    bool valido = false;
    while (!valido)
    {
        Console.WriteLine($"Ingrese el nombre {i + 1} (solo letras, mas de 2 caracteres):");
        string entrada = Console.ReadLine();

        // Validacion 2: Espacio vacio, longitud > 2 y solo letras (sin numeros ni simbolos)
        if (!string.IsNullOrWhiteSpace(entrada) && entrada.Length > 2 && entrada.All(char.IsLetter))
        {
            nombres[i] = entrada;
            longitudes[i] = entrada.Length;
            valido = true;
        }
        else
        {
            Console.WriteLine("Error: El nombre debe tener mas de 2 caracteres y solo letras.");
        }
    }
}

// Clasificación
for (int i = 0; i < tamano; i++)
{
    carac = longitudes[i];
    Console.WriteLine($"\nEl nombre: {nombres[i]} tiene {carac} caracteres.");

    if (carac >= 3 && carac <= 4)
    {
        Console.WriteLine("Clasificacion: Longitud corta");
    }
    else if (carac >= 5 && carac <= 7)
    {
        Console.WriteLine("Clasificacion: Longitud media");
    }
    else
    {
        Console.WriteLine("Clasificacion: Longitud larga");
    }
}