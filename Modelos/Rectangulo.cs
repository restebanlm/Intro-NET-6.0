using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16___Ejercicio.Modelos
{
    public sealed class Rectangulo : Cuadrilatero
    {
        public Rectangulo(float XpuntoA, float YpuntoA, float XpuntoB, float YpuntoB, float XpuntoC, float YpuntoC, float XpuntoD, float YpuntoD) : base(XpuntoA, YpuntoA, XpuntoB, YpuntoB, XpuntoC, YpuntoC, XpuntoD, YpuntoD)
        {
            _coordenadasXPuntoA = XpuntoA;
            _coordenadasYPuntoA = YpuntoA;
            _coordenadasXPuntoB = XpuntoB;
            _coordenadasYPuntoB = YpuntoB;
            _coordenadasXPuntoC = XpuntoC;
            _coordenadasYPuntoC = YpuntoC;
            _coordenadasXPuntoD = XpuntoD;
            _coordenadasYPuntoD = YpuntoD;
        }

        public override double CalcularArea()
        {
            return
                CalcularDistanciaDosPuntos(
                    _coordenadasXPuntoA, _coordenadasYPuntoA,
                    _coordenadasXPuntoB, _coordenadasYPuntoB) *
                CalcularDistanciaDosPuntos(
                    _coordenadasXPuntoB, _coordenadasYPuntoB,
                    _coordenadasXPuntoC, _coordenadasYPuntoC);
        }
    }
}
