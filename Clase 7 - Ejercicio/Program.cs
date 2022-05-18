/*
    Escribe un programa que:
    1) Pida 10 números al usuario.
    2) Obtener la suma de todos los números ingresados.
    3) Obtener cual es el mayor de todos los números.
    4) Obtener cual es el menor de todos los números.
    5) Obtener el promedio de todos los números.
    6) Mostrar todos los números ingresados por pantalla.
    7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
 */

int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese un valor para el elemento {i + 1} del vector:");
    numeros[i] = Int16.Parse(Console.ReadLine());
    Console.Clear();
}
Console.WriteLine($"La suma de todos los elementos del vector dan como resultado { numeros.Sum(x => x)}.");
Console.WriteLine($"El elemento mayor del vector es {numeros.Max()}.");
Console.WriteLine($"El elemento menor del vector es {numeros.Min()}.");
Console.WriteLine($"El promedio de todos los elementos es { (numeros.Sum(x => x) / numeros.Length) }.");
Console.WriteLine($"Los elementos del vector son: {String.Join(" - ",numeros)}.");