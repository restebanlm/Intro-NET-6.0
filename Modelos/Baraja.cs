using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14___Ejercicio.Modelos
{
    public class Baraja
    {
        public List<Carta> ConjuntoCartas { get; set; }
        public List<Carta> ConjuntoCartasUsadas { get; set; }

        public Baraja()
        {
            ConjuntoCartasUsadas = new List<Carta>();
            ConjuntoCartas = new List<Carta>();

            for (int i = 0; i < 40; i++)
            {
                ConjuntoCartas.Add(new Carta());
            }
        }

        public void Barajar()
        {
            List<Carta> ConjuntoBandera = new();
            Random aleatorio = new();
            int bandera = 0;

            while (ConjuntoCartas.Count > 0)
            {
                int val = aleatorio.Next(0, ConjuntoCartas.Count - 1);
                ConjuntoBandera.Add(ConjuntoCartas[val]);
                ConjuntoCartas.RemoveAt(val);
                bandera = 1;
            }
            ConjuntoCartas = ConjuntoBandera;
            if(bandera == 1)
            {
                Console.WriteLine("Baraja mezclada.\n");
            }
            else
            {
                Console.WriteLine("Baraja vacía.\n");
            }
            
            Espera();
        }

        public void SiguienteCarta()
        {
            if(ConjuntoCartas.Count > 0)
            {
                Carta carta = ConjuntoCartas.First();
                ConjuntoCartasUsadas.Add(carta);
                ConjuntoCartas.Remove(carta);

                Console.WriteLine($"Carta => {carta}");
            }
            else
            {
                Console.WriteLine("Baraja vacía.\n");
            }
            
            Espera();
        }

        public void CartasDisponibles()
        {
            if(ConjuntoCartas.Count > 1)
            {
                Console.WriteLine($"Hay {ConjuntoCartas.Count} cartas disponibles en la baraja.");
            }
            else if (ConjuntoCartas.Count == 1)
            {
                Console.WriteLine($"Hay 1 carta disponible en la baraja.");
            }
            else
            {
                Console.WriteLine("No hay cartas disponibles en la baraja.");
            }
            Espera();
        }

        public void DarCartas(int cantidad)
        {           
            if (cantidad <= ConjuntoCartas.Count)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Carta => { ConjuntoCartas.First() }");
                    ConjuntoCartasUsadas.Add(ConjuntoCartas.First());
                    ConjuntoCartas.Remove(ConjuntoCartas.First());
                }
            }
            else if (ConjuntoCartas.Count == 0)
            {
                Console.WriteLine("No hay más cartas en la baraja.");
            }
            else if (ConjuntoCartas.Count != 0 && cantidad >= ConjuntoCartas.Count)
            {
                Console.WriteLine("La cantidad solicitada supera a la cantidad en baraja.");
            }
            Espera();
        }

        public void CartasMonton()
        {
            int i = 0;
            if(ConjuntoCartasUsadas.Count > 0)
            foreach(Carta carta in ConjuntoCartasUsadas)
            {
                i++;
                Console.WriteLine($"Carta {i} => { carta }");
                }
            else
            {
                Console.WriteLine("No ha sacado carta de la baraja.");
            }
            Espera();
        }

        public void MostrarBaraja()
        {
            int i = 0;
            if(ConjuntoCartas.Count > 0)
            {
                foreach (Carta carta in ConjuntoCartas)
                {
                    i++;
                    Console.WriteLine($"Carta {i} => { carta }");
                }
            }
            else
            {
                Console.WriteLine("No hay más cartas en la baraja.");
            }
            Espera();
        }

        private static void Espera()
        {
            Console.WriteLine("\n\n > Presione cualquier tecla <");
            Console.ReadKey();
            Console.Beep();
        }

    }
}
