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

        int idEstudiante=0;
        string entradaValida;
        double numeroValido;

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

            for(int p = 0; p < numParciales; p++){
                Console.Write($"Parcial {p+1}: ")

                while(true){
                entradaValida = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: No se puede ingresar un texto vacío o solo espacios. ");
                    continue;
                }

                if(double.TryParse(entradaValida, out numeroValido) && numeroValido >= 0 && numeroValido <=100){
                    notas[p]
                }
            }

            }
        }

    }

}
