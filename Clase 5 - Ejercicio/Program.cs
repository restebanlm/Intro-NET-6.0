Console.Clear();
Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"¡Hola {nombre}!");
Console.WriteLine("¿Desea continuar con la ejecución? [S=SI / N=NO]");
string accion = Console.ReadLine();

while (accion.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");
    Console.WriteLine("¿Desea continuar? [S=SI / N=NO]");
    accion = Console.ReadLine();
}
if (accion.ToUpper() == "N")
    Console.WriteLine("Programa finalizado correctamente");
else
    Console.WriteLine("Opción no válida");