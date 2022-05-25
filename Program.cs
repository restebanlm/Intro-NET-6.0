/*
    EJERCICIO
    Con los conocimientos vistos hasta ahora en clase realizar un programa que 
    haga lo siguiente:

    1) Pedir al usuario la longitud de un vector
    2) Crear el vector del tamaño ingresado.
    3) Llenar el mismo con datos aleatorios.
    4) Mostrar el vector por pantalla.
    5) Invertir el vector, de manera que el primer elemento quede al último y
       el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el
       segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones
       y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe
       quedar así: 50, 40, 30, 20, 10.
       Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C#
       para estas cuestiones.
    6) Mostrar el vector nuevamente.
*/
Console.WriteLine("INGRESAR LA LONGITUD DEL VECTOR");
int longitudVector = int.Parse(Console.ReadLine());
Console.Clear();

int[] vector, vectorAux;
vector = new int[longitudVector];
vectorAux = new int[longitudVector];
Random random = new Random();

Console.WriteLine(">VECTOR GENERADO<");
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next();
    Console.WriteLine($"{i} -> {vector[i]}");
}
int j = 0;
for (int i = vector.Length-1; i >= 0; i--)
{
    vectorAux[j] = vector[i];
    j++;
}
vector = vectorAux;
j = 0;
Console.WriteLine("\n>VECTOR INVERTIDO<");
foreach (int i in vector)
{
    Console.WriteLine($"{j} -> {i}");
    j++;
}