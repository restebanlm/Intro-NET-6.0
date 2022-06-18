using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16___Ejercicio.Modelos
{
    public sealed class Trapecio : Cuadrilatero
    {
        private float _coordenadasXPuntoH;
        private float _coordenadasYPuntoH;
        public Trapecio (float XpuntoA, float YpuntoA, float XpuntoB, float YpuntoB, float XpuntoC, float YpuntoC, float XpuntoD, float YpuntoD, float XpuntoH, float YpuntoH) : base(XpuntoA, YpuntoA, XpuntoB, YpuntoB, XpuntoC, YpuntoC, XpuntoD, YpuntoD)
        {
            _coordenadasXPuntoA = XpuntoA;
            _coordenadasYPuntoA = YpuntoA;
            _coordenadasXPuntoB = XpuntoB;
            _coordenadasYPuntoB = YpuntoB;
            _coordenadasXPuntoC = XpuntoC;
            _coordenadasYPuntoC = YpuntoC;
            _coordenadasXPuntoD = XpuntoD;
            _coordenadasYPuntoD = YpuntoD;
            _coordenadasXPuntoH = XpuntoH;
            _coordenadasYPuntoH = YpuntoH;
        }
        public float CoordenadasXPuntoH
        {
            get
            {
                return _coordenadasXPuntoH;
            }
            set
            {
                _coordenadasXPuntoH = value;
            }
        }
        public float CoordenadasYPuntoH
        {
            get
            {
                return _coordenadasYPuntoH;
            }
            set
            {
                _coordenadasYPuntoH = value;
            }
        }
        public override double CalcularArea()
        {
            return
                ((
                CalcularDistanciaDosPuntos(
                    _coordenadasXPuntoA, _coordenadasYPuntoA,
                    _coordenadasXPuntoB, _coordenadasYPuntoB) +
                CalcularDistanciaDosPuntos(
                    _coordenadasXPuntoC, _coordenadasYPuntoC,
                    _coordenadasXPuntoD, _coordenadasYPuntoD)
                ) *
                CalcularDistanciaDosPuntos(
                    _coordenadasXPuntoC, _coordenadasYPuntoC,
                    _coordenadasXPuntoH, _coordenadasYPuntoH)
                ) / 2;
        }
    }
}
