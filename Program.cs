/*
    EJERCICIO
    Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:
    Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla.
    1) Cartón de 3 filas por 9 columnas.
    2) El cartón debe tener 15 números y 12 espacios en blanco.
    3) Cada fila debe tener 5 números.
    4) Cada columna debe tener 1 o 2 números.
    5) Ningún número puede repetirse.
    6) La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la
       tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene
       del 80 al 90.
    7) Mostrar el carton por pantalla.

*/
int[,] carton = new int[3, 9];
Random numeroAleatorio = new Random();
int maxNumeroColumnaBandera = 0;
int numeroGenerado;
int[] limitePorColumna = new int[9];
int totalNumeroPorCarton = 0;

// GENERO CANTIDAD DE NUMEROS POR COLUMNA LIMITANDO A 15 POR CARTÓN.
while (totalNumeroPorCarton == 0 || totalNumeroPorCarton != 15)
{
    totalNumeroPorCarton = 0;
    for (int i = 0; i < 9; i++)
    {
        limitePorColumna[i] = numeroAleatorio.Next(1, 3);
        totalNumeroPorCarton = totalNumeroPorCarton + limitePorColumna[i];
    }
}

// GENERO NUMEROS A CADA ELEMENTO SIN ELEMENTOS REPETIDOS Y RESPETANDO LA CANTIDAD DE NUMEROS POR COLUMNA.
for (int columna = 0; columna < 9; columna++)
{
    for (int fila = 0; fila < 3; fila++)
    {
        if ((limitePorColumna[columna]-1) >= maxNumeroColumnaBandera)
        {
            numeroGenerado = numeroAleatorio.Next(columna * 10, (columna + 1) * 10);
            while (numeroGenerado == carton[0, columna] ||
                   numeroGenerado == carton[1, columna] ||
                   numeroGenerado == carton[2, columna])
            {
                numeroGenerado = numeroAleatorio.Next(columna * 10, (columna + 1) * 10);
            }
            carton[fila, columna] = numeroGenerado;

        }
        maxNumeroColumnaBandera++;
    }
    maxNumeroColumnaBandera = 0;
}

//


// MUESTRO EL CARTÓN DE BINGO GENERADO.
Console.WriteLine("\t\t\t\t>CARTÓN DE BINGO<\n");
Console.Write(" ------------------------------------------------------------------------------");

for (int i = 0; i < 3; i++)
{
    Console.Write("\n|\t");
    for (int j = 0; j < 9; j++)
    {
        if (carton[i, j] != 0)
        {
            Console.Write($"{carton[i, j]} \t");
        }
        else
        {
            Console.Write("\t");
        }
        
    }
    Console.Write("|\n");
}
Console.Write("\n ------------------------------------------------------------------------------");