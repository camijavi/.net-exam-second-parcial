namespace PromedioFIA;

// Este programa calcula el promedio de 5 numEstudiantes de la 
// Facultad de Ingeniería y Arquitectura (FIA) de UAM.

class Program
{
    static void Main(string[] args)
    {
        int numEstudiantes = 5;
        int numParciales = 3;

        // Arreglos para manejar la información
        string [] nombres = new string [numEstudiantes];
        double [,] notas = new double [numEstudiantes, numParciales];
        double [] promedios = new double [numEstudiantes];

        Console.Clear();

        for(int e = 0; e <numEstudiantes; e++){
            
            idEstudiante = e + 1; //Asignamos un ID a cada estudiante
            Console.WriteLine($"\n--- Registro del Estudiante ID: {idEstudiante} ---");

            while(true){
                Console.Write("Ingrese al nombre del estudiante: ")

                string nombre = Console.ReadLine();


                if (!string.IsNullOrWhiteSpace(nombre))
                {
                   nombres[e] = nombre;
                    continue;
                }
                 Console.WriteLine("Error: No se puede ingresar un texto vacío o solo espacios. ");
            }

            double sumaNotas = 0;
            for(int p = 0; p < numParciales; p++){
                Console.Write($"Parcial {p+1}: ");

                double nota;
                 Console.WriteLine($"Ingrese nota del Parcial {p+1} (0-100): ");
                while(true){
                    string entradaValida = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace(entradaValida)){
                        Console.WriteLine("Error: No se puede ingresar un texto vacío o solo espacios. ");
                    }

                    if(double.TryParse(entradaValida, out nota) && nota >= 0 && nota <= 100){
                        notas[e,p] = nota;
                        sumNotas += nota;

                        break;
                    }

                    Console.WriteLine("Error: Ingrese un número válido entre 0 y 100.");
                }

                promedios[e] = sumaNotas / numParciales;
            }

        }
    }
}


