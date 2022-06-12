/*
    Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:
        BilletesDe10
        BilletesDe20
        BilletesDe50
        BilletesDe100
        BilletesDe200
        BilletesDe500
        BilletesDe1000
    Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total
    en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

    Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que
    devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.

    Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras
    deberan quedar en cero. (Sin billetes)
*/

using Clase_13___Ejercicio.Modelos;

var billetera1 = new Billetera()
{
    BilletesDe10 = 1,
    BilletesDe20 = 1,
    BilletesDe50 = 1,
    BilletesDe100 = 1,
    BilletesDe200 = 1,
    BilletesDe500 = 1,
    BilletesDe1000 = 1,
};
var billetera2 = new Billetera()
{
    BilletesDe10 = 100,
    BilletesDe20 = 50,
    BilletesDe50 = 20,
    BilletesDe100 = 10,
    BilletesDe200 = 5,
    BilletesDe500 = 2,
    BilletesDe1000 = 1,
};
Console.WriteLine(billetera1.Total());
Console.WriteLine(billetera2.Total());
Console.WriteLine(billetera1.Combinar(billetera2).Total());
Console.WriteLine(billetera1.Total());
Console.WriteLine(billetera2.Total());