﻿/*
    Ejercicio de cartas españolas orientado a objetos:

    Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos)
    y un palo (espadas, bastos, oros y copas)
    La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

    Las operaciones que podrá realizar la baraja son:

    --Barajar():
      Cambia de posición todas las cartas aleatoriamente.

    --SiguienteCarta():
      Devuelve la siguiente carta que está en la baraja, cuando no haya más
      o se haya llegado al final, se indica al usuario que no hay más cartas.

    --CartasDisponibles():
      Indica el número de cartas que aún puede repartir

    --DarCartas(int cantidad):
      Dado un número de cartas que nos pidan, le devolveremos ese número de
      cartas (piensa que puedes devolver). En caso de que haya menos cartas
      que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.

    --CartasMonton():
      Mostramos aquellas cartas que ya han salido, si no ha salido ninguna
      indicárselo al usuario.

    --MostrarBaraja():
      Muestra todas las cartas hasta el final. Es decir, si se saca una carta
      y luego se llama al método, este no mostrara esa primera carta.


    Escribir un programa que dentro de un bucle vaya mostrando las opciones que
    querramos, por ejemplo

    1 - Barajar
    2 - Mostrar siguiente carta
    3 - Mostrar cartas disponibles
    4 - Dar cartas
    5 - Mostrar cartas del monton
    6 - Mostrar baraja
    7 - Salir
*/

using Clase_14___Ejercicio.Modelos;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Baraja baraja = new();
int opcion = 0;

while (opcion != 7)
{
    Console.Clear();
    Console.Write("\n\t\t\t\tCARTAS ESPAÑOLAS\n\n" +
                      "\t1 - Barajar\n" +
                      "\t2 - Mostrar siguiente carta\n" +
                      "\t3 - Mostrar cartas disponibles\n" +
                      "\t4 - Dar cartas\n" +
                      "\t5 - Mostrar cartas del monton\n" +
                      "\t6 - Mostrar baraja\n" +
                      "\t7 - Salir\n" +
                      "\n¿Qué desea hacer? ");
    opcion = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (opcion)
    {
        case 1:
            baraja.Barajar();
            break;
        case 2:
            baraja.SiguienteCarta();
            break;
        case 3:
            baraja.CartasDisponibles();
            break;
        case 4:
            Console.Write("¿Cuántas cartas quiere extraer? ");
            baraja.DarCartas(int.Parse(Console.ReadLine()));
            Console.Clear();
            break;
        case 5:
            baraja.CartasMonton();
            break;
        case 6:
            baraja.MostrarBaraja();
            break;
    }
    
}






