namespace PromedioFIA;

Este programa calcula el promedio de 5 estudiantes de la Facultad de Ingeniería y Arquitectura (FIA) de UAM.



class Program
{
    static void Main(string[] args)
    {
        int estudiantes = 5;
        int parciales = 3;
        double [,] notas = new double [estudiantes, parciales];

        string nombreEstudiante;
        int idEstudiante=0;
        string entradaValida;
        double numeroValido;

        Console.Clear();

        for(int e = 0; e <estudiantes; e++){
            Console.WriteLine($"\nPor favor ingrese el nombre del ESTUDIANTE{e+1}: ");

            while(true){
                entradaValida = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: No se puede ingresar un texto vacío o solo espacios. ");
                    continue;
                }
            }

            for(int p = 0; p < parciales; p++){
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
