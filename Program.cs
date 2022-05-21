/*
    EJERCICIO

    Crear un programa que cumpla con los siguientes pasos:
    1) Crear una matriz de dos dimensiones de tipo int llamada numeros.
    2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla.
    3) Declarar un vector de tipo double llamado promedios.
    4) Recorrer la matriz para su carga con elementos de tipo int.
    5) Recorrer la matriz para mostrar cada valor de la matriz.
    6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios.
    7) Mostrar los promedios recorriendo el vector promedios.
*/
int filas = 0, columnas = 0;
Console.WriteLine("INGRESAR EL VALOR PARA LA CANTIDAD DE FILAS");
filas = Int16.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("INGRESAR EL VALOR PARA LA CANTIDAD DE COLUMNAS");
columnas = Int16.Parse(Console.ReadLine());
Console.Clear();
int[,] numeros = new int[filas, columnas];
double[] promedios = new double[columnas];

for (int fila = 0; fila < numeros.GetLength(0); fila++)
{
    for (int columna = 0; columna < numeros.GetLength(1); columna++)
    {
        Console.WriteLine($"INGRESAR EL VALOR PARA EL ELEMENTO [{fila},{columna}]");
        numeros[fila,columna] = Int16.Parse(Console.ReadLine());
        Console.Clear();
    }
}
Console.WriteLine("VALORES DE LA MATRIZ");
for (int fila = 0; fila < numeros.GetLength(0); fila++)
{
    Console.Write($"Fila { fila } => ");
    for (int columna = 0; columna < numeros.GetLength(1); columna++)
    {
        Console.Write(numeros[fila, columna]);
        if(columna != numeros.GetLength(1)-1)
            Console.Write(" - ");
    }
    Console.Write("\n");
}


for(int columna = 0; columna < numeros.GetLength(1); columna++)
{
    for(int fila = 0; fila < numeros.GetLength(0); fila++)
    {
        promedios[columna] = promedios[columna] + numeros[fila,columna];
    }
    promedios[columna] = promedios[columna] / columnas;
}
Console.WriteLine("PROMEDIO DE CADA COLUMNA DE LA MATRIZ");
Console.Write("Fila P => ");
for (int columna = 0; columna < promedios.GetLength(0); columna++)
{
    Console.Write(promedios[columna]);
    if (columna != promedios.GetLength(0) - 1)
        Console.Write(" - ");
}