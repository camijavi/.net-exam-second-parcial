// El programa registra las edades de 20 pacientes y las clasifica en niños, jóvenes, adultos y mayores. 
// Luego muestra cuántas personas hay en cada grupo, detecta si existen más de 5 adultos mayores como alerta de riesgo y
//  calcula el promedio de edad general y el promedio de cada grupo.


using System;

int[] paciente = new int[20];
int edad = 0;

int ninos = 0, jovenes = 0, adultos = 0, mayores = 0;
double sumaGeneral = 0;
double sumaNinos = 0, sumaJovenes = 0, sumaAdultos = 0, sumaMayores = 0;

for (int i = 0; i < 20; i++)
{
    bool valido = false;
    while (!valido)
    {
        Console.Write($"Ingresa la edad del paciente {i + 1}: ");
        // Validación: debe ser un número entre 1 y 120 (rango humano lógico)
        if (int.TryParse(Console.ReadLine(), out edad) && edad > 0 && edad <= 120)
        {
            paciente[i] = edad;
            valido = true;
        }
        else
        {
            Console.WriteLine("Error: Por favor, ingresa una edad válida (1-120).");
        }
    }

    sumaGeneral += edad;

    // Clasificación
    if (edad <= 12)
    {
        ninos++;
        sumaNinos += edad;
    }
    else if (edad <= 25)
    {
        jovenes++;
        sumaJovenes += edad;
    }
    else if (edad <= 60)
    {
        adultos++;
        sumaAdultos += edad;
    }
    else
    {
        mayores++;
        sumaMayores += edad;
    }
}

// Resultados
Console.WriteLine("\n--- Resumen de Pacientes ---");
Console.WriteLine($"Niños: {ninos} | Jóvenes: {jovenes} | Adultos: {adultos} | Mayores: {mayores}");

// Alerta de riesgo
if (mayores > 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("¡ALERTA DE RIESGO: Hay más de 5 adultos mayores!");
    Console.ResetColor();
}

// Promedios
Console.WriteLine($"\nPromedio de edad general: {sumaGeneral / 20:F2}");

Console.WriteLine("\n--- Promedios por grupo ---");
if (ninos > 0) Console.WriteLine($"Niños: {sumaNinos / ninos:F2}");
if (jovenes > 0) Console.WriteLine($"Jóvenes: {sumaJovenes / jovenes:F2}");
if (adultos > 0) Console.WriteLine($"Adultos: {sumaAdultos / adultos:F2}");
if (mayores > 0) Console.WriteLine($"Mayores: {sumaMayores / mayores:F2}");