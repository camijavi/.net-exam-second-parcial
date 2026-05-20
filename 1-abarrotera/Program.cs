/* La Abarrotera ABSA tiene 4 sucursales en las cuales se realizaron diferentes ventas en los
meses de Julio a diciembre del año 2022, se le ha solicitado a usted realizar un programa en
donde pueda capturar una siguiente tabla de dato
*/

//Declaracion de variables
double[,] ventas = new double[4,6];
int numtienda = 1;
double ventatotal = 0;
double sumatienda;
double ventaalta = 0, ventabaja = 0;

for (int i = 0; i < ventas.GetLength(0); i++)
{
    Console.WriteLine($"Digite la tienda numero {numtienda}");
    Console.WriteLine($"Digite las ventas de julio hasta diciembre.");
    // Entrada de datos y validación de entrada
    for (int j = 0; j < ventas.GetLength(1); j++)
    {
        while(!double.TryParse(Console.ReadLine(), out ventas[i, j]) || ventas[i,j] <=0)
        {
            Console.WriteLine("Digite un valor valido.");
        }
        ventatotal += ventas[i, j];
    }
    numtienda++;
}

//Salida de la venta total
Console.WriteLine("Ventas por tienda y mes");
for (int i = 0; i < ventas.GetLength(0); i++)
{
    Console.Write($"Tienda {i + 1}: ");
    for (int j = 0; j < ventas.GetLength(1); j++)
    {
        Console.Write($"{ventas[i, j]:N2} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Venta total de todas las tiendas: {ventatotal:N2}");
Console.WriteLine();
// Salida de la venta por tiendas, la tienda con mayor venta y la tienda con menor venta
for (int i = 0; i < 4; i++)
{
    sumatienda = 0;
    for (int j = 0; j < 6; j++)
    {
        sumatienda += ventas[i, j];
    }
    Console.WriteLine($"Total de la tienda {i + 1}: {sumatienda:N2}");
    
        if (sumatienda > ventaalta)
        {
            ventaalta = sumatienda;
        }

        if (sumatienda < ventabaja || ventabaja == 0)
        {
            ventabaja = sumatienda;
        }
}
Console.WriteLine();
Console.WriteLine($"Tienda con mayor venta: {ventaalta:N2}");
Console.WriteLine();
Console.WriteLine($"Tienda con menor venta: {ventabaja:N2}");
Console.WriteLine();