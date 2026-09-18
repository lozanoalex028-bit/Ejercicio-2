// --------------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA

// Muestra en la consola el nombre o número del ejercicio.
Console.WriteLine("EJERCICIO_2");

// Muestra el título que describe lo que realiza el programa.
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");

// Deja una línea en blanco para separar visualmente el encabezado.
Console.WriteLine();

// --------------------------------------------------------------------
// ENTRADAS DE DATOS

Console.Write("Ingrese la primera calificación: ");

double calificacion1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la segunda calificación: ");

double calificacion2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera calificación: ");

double calificacion3 = Convert.ToDouble(Console.ReadLine());


// --------------------------------------------------------------------
// OPERACIONES

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;

// --------------------------------------------------------------------
// SALIDAS DE DATOS

Console.WriteLine();

Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");

if (promedio >= 70)
{
    Console.WriteLine("Felicidades Alumno Aprobado");
}
else
{
    Console.WriteLine("Alumno Reprobado Sigue Intentandolo");
}