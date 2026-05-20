int tamano;
int carac=0;
Console.WriteLine("Por favor ingresa la cantidad de valores que deseas ingresar");

//Validacion 1
while(!int.TryParse(Console.ReadLine(), out tamano) || tamano <= 0)
{
    Console.WriteLine("Ingresa un numero valido mayor que 0");
}

string [] nombres = new string [tamano];
for(int i=0; i<tamano; i++)
{
    Console.WriteLine("Ingrese un nombre");
    nombres[i]= Console.ReadLine(); 
    //validacion 2
    while(nombres[i] == "")
    {
    Console.WriteLine("No dejes el espacio vacio, ingresa un nombre");
    nombres[i]= Console.ReadLine();
    } 
}
for (int i=0; i<tamano; i++)
{
    Console.WriteLine("El nombre: "+nombres[i]+ " tiene "+ nombres[i].Length + " caracteres ");
    carac = nombres[i].Length;
    
    
    if(carac>1 && carac<5)
    {
        Console.WriteLine("El nombre tiene una longitud corta");
    }
    if(carac>4 && carac<8)
    {
        Console.WriteLine("El nombre tiene una longitud media");
    }
    if(carac>7)
    {
        Console.WriteLine("El nombre tiene una longitud larga");
    }

}  

