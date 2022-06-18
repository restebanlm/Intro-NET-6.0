/*
    Diseñe la siguiente jerarquía para las clases:

    Cuadrilátero.
    Trapecio.
    Rectángulo.
    Cuadrado.

-   Use la clase Cuadrilátero como la clase base de la jerarquía,
    que debe ser abstracta.

-   Los datos privados de la clase base deben ser las coordenadas x-y
    de los cuatro vértices de la figura y debe contener un método
    abstracto para calcular el área.

-   Agregue un constructor a cada clase para inicializar sus datos e
    invoque el constructor de la clase base desde el constructor de
    cada clase derivada.

-   Escriba un programa que instancie objetos de cada una de las
    clases y calcule el área correspondiente. Investigue las fórmulas
    para calcular el área de cada figura.

*/

using Clase_16___Ejercicio.Modelos;

Cuadrado cuadrado = new Cuadrado(0f,0f,4f,0f,4f,4f,0f,4f);
Console.WriteLine($"Área del Cuadrado => { cuadrado.CalcularArea() } cm2");

Rectangulo rectangulo = new Rectangulo(0f, 0f, 8f, 0f, 8f, 4f, 0f, 4f);
Console.WriteLine($"Área del Rectángulo => { rectangulo.CalcularArea() } cm2");

Trapecio trapecio = new Trapecio(0f, 0f, 10f, 0f, 8f, 4f, 1f, 4f, 8f, 0f);
Console.WriteLine($"Área del Trapecio => { trapecio.CalcularArea() } cm2");