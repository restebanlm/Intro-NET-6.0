/*

1) Generar un número secreto aleatorio (de 1 a 20) con la siguiente instruccion:
   int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor al número secreto, avisarle que es muy grande y que intente de nuevo y que
   vuelva al paso 2.

4) Si el numero ingresado es menor al número secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número secreto, sacar el siguiente mensaje:

  "Felicitaciones, has adivinado el número secreto que era: [numeroSecreto] Lo has logrado en [n] intentos!!"
  Y finalizar el programa.

Nota:
Obviamente hay que hacer un bucle y crear un contador de intentos.
Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante 
es intentarlo.

*/

int numero, intento = 0;
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(0, 21);
Console.WriteLine(">> Intente adivinar el número generado <<");

do
{
    intento++;
    Console.WriteLine("Pruebe con un número.");
    numero = Int32.Parse(Console.ReadLine());

    if(numero > numeroSecreto)
    {
        Console.WriteLine($"El número {numero} es mayor comparado al número generado.");
    } else if(numero < numeroSecreto)
    {
        Console.WriteLine($"El número {numero} es menor comparado al número generado.");
    }

} while(numero > numeroSecreto || numero < numeroSecreto);
Console.Clear();
Console.WriteLine($"¡¡Felicitaciones!! Has adivinado el número secreto que era {numeroSecreto}. Lo has logrado en {intento} {(intento > 1 ? "intentos":"intento")}.");