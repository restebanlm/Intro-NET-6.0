using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14___Ejercicio.Modelos
{
    public class Carta
    {
        public int Valor { get; set; }
        public string Palo { get; set; }

        public Carta()
        {
            Valor = ValorAleatorio();
            Palo = PaloAleatorio();
        }

        private static string PaloAleatorio()
        {
            Random aleatorio = new();
            string[] palo = { "Espada", "Basto", "Oro", "Copa" };
            return palo[aleatorio.Next(palo.Length)];
        }

        private static int ValorAleatorio()
        {
            Random aleatorio = new();
            int valor;
            do
            {
                valor = aleatorio.Next(1, 12);
            } while (valor == 8 || valor == 9);

            return valor;
        }
        override
        public string ToString()
        {
            return $"{ Valor } de { Palo }";
        }


    }
}
