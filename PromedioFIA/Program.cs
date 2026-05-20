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

                // Entrada de nombre corregida
                while (true)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    string nombreInput = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nombreInput))
                    {
                        nombres[e] = nombreInput;
                        break; // Salimos del while cuando el nombre es válido
                    }
                    Console.WriteLine("\n Error: No se puede ingresar un texto vacío.");
                }

                double sumaNotas = 0; // Reiniciamos suma para cada estudiante
                for (int p = 0; p < numParciales; p++)
                {
                    double nota;
                    while (true)
                    {
                        Console.Write($"\nIngrese nota del Parcial {p + 1} (0-100): ");
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
            Console.WriteLine("\n" + new string('=', 40));
            Console.WriteLine("RESULTADOS FINALES");

            for (int i = 0; i < numEstudiantes; i++)
            {
                Console.WriteLine($"ID {i + 1} | Nombre: {nombres[i]} | Promedio Final: {promedios[i]:F2}");
            }
        }
    }
}