using System;

// Se desea realizar un programa en donde se capture el nombre y tres calificaciones para
// 5 estudiantes de la facultad de Ingeniería, y después se pueda procesar dándonos el
// promedio final de cada uno de los alumnos, el resultado se mostrará en pantalla.


namespace PromedioFIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEstudiantes = 5;
            int numParciales = 3;

            string[] nombres = new string[numEstudiantes];
            double[,] notas = new double[numEstudiantes, numParciales];
            double[] promedios = new double[numEstudiantes];

            Console.Clear();

            for (int e = 0; e < numEstudiantes; e++)
            {
                int idEstudiante = e + 1;
                Console.WriteLine($"\n--- Registro del Estudiante ID: {idEstudiante} ---");
 
                // Entrada de nombre con validación para evitar solo números
                while (true)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    string nombreInput = Console.ReadLine();

                    // Validamos que no esté vacío, que no sea solo espacios y que no sea un número
                    if (!string.IsNullOrWhiteSpace(nombreInput) && !double.TryParse(nombreInput, out _))
                    {
                        nombres[e] = nombreInput;
                        break; 
                    }
                    else if (string.IsNullOrWhiteSpace(nombreInput))
                    {
                        Console.WriteLine("Error: El nombre no puede estar vacío.");
                    }
                    else
                    {
                        Console.WriteLine("Error: El nombre no puede ser un número.");
                    }
                }

                double sumaNotas = 0; // Reiniciamos suma para cada estudiante
                for (int p = 0; p < numParciales; p++)
                {
                    double nota;
                    while (true)
                    {
                        Console.Write($"Ingrese nota del Parcial {p + 1} (0-100): ");
                        string entradaValida = Console.ReadLine();

                        if (double.TryParse(entradaValida, out nota) && nota >= 0 && nota <= 100)
                        {
                            notas[e, p] = nota;
                            sumaNotas += nota;
                            break;
                        }
                    Console.WriteLine("\nError: Ingrese un número válido entre 0 y 100.");
                    }
                }
                // El promedio se calcula al terminar los 3 parciales
                promedios[e] = sumaNotas / numParciales;
            }


            // Mostrar resultados 
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("    UNIVERSIDAD AMERICANA (UAM)");
            Console.WriteLine("    FACULTAD DE INGENIERÍA Y ARQUITECTURA");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(string.Format("{0,-5} | {1,-20} | {2,-10}", "ID", "NOMBRE", "PROMEDIO"));
            Console.WriteLine(new string('-', 50));

            // Mostrar resultados de cada estudiante
            for (int i = 0; i < numEstudiantes; i++)
            {
                // El formato {0,-20} alinea el texto a la izquierda ocupando 20 espacios
                Console.WriteLine(string.Format("{0,-5} | {1,-20} | {2,-10:F2}", i + 1, nombres[i], promedios[i]));
            }
            
            Console.WriteLine(new string('=', 50) + "\n");
        }
    }
}