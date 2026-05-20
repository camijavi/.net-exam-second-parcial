/* La Abarrotera ABSA tiene 4 sucursales en las cuales se realizaron diferentes ventas en los
meses de Julio a diciembre del año 2022, se le ha solicitado a usted realizar un programa en
donde pueda capturar una siguiente tabla de dato
*/

using System;

// Declaración de variables
double[,] ventas = new double[4, 6];
string[] meses = { "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
double ventatotal = 0;
double ventaalta = 0;
double ventabaja = -1; // Inicializamos en -1 para que la primera comparación siempre sea verdadera

for (int i = 0; i < ventas.GetLength(0); i++)
{
    Console.WriteLine($"\n--- Tienda {i + 1} ---");
    Console.WriteLine("Digite las ventas por mes:");
    
    for (int j = 0; j < ventas.GetLength(1); j++)
    {
        Console.Write($"{meses[j]}: ");
        // Validación: solo números positivos
        while (!double.TryParse(Console.ReadLine(), out ventas[i, j]) || ventas[i, j] < 0)
        {
            Console.WriteLine("Error: Por favor, digite un monto válido mayor o igual a 0:");
        }
        ventatotal += ventas[i, j];
    }
}

// Salida de la tabla
Console.WriteLine("\n" + new string('-', 30));
Console.WriteLine("Ventas por tienda y mes:");
for (int i = 0; i < ventas.GetLength(0); i++)
{
    Console.Write($"Tienda {i + 1}: ");
    for (int j = 0; j < ventas.GetLength(1); j++)
    {
        Console.Write($"{ventas[i, j],10:N2} |");
    }
    Console.WriteLine();
}

Console.WriteLine($"\nVenta total general: {ventatotal:N2}\n");

// Análisis por tiendas
int tiendaAlta = 0, tiendaBaja = 0;

for (int i = 0; i < 4; i++)
{
    double sumatienda = 0;
    for (int j = 0; j < 6; j++)
    {
        sumatienda += ventas[i, j];
    }
    
    Console.WriteLine($"Total tienda {i + 1}: {sumatienda:N2}");
    
    if (sumatienda > ventaalta)
    {
        ventaalta = sumatienda;
        tiendaAlta = i + 1;
    }
    
    if (ventabaja == -1 || sumatienda < ventabaja)
    {
        ventabaja = sumatienda;
        tiendaBaja = i + 1;
    }
}

Console.WriteLine($"\nLa tienda con MAYOR venta fue la {tiendaAlta} con: {ventaalta:N2}");
Console.WriteLine($"La tienda con MENOR venta fue la {tiendaBaja} con: {ventabaja:N2}");