namespace Clase_16___Ejercicio.Modelos
{
    public abstract class Cuadrilatero
    {
        protected float _coordenadasXPuntoA;
        protected float _coordenadasYPuntoA;
        protected float _coordenadasXPuntoB;
        protected float _coordenadasYPuntoB;
        protected float _coordenadasXPuntoC;
        protected float _coordenadasYPuntoC;
        protected float _coordenadasXPuntoD;
        protected float _coordenadasYPuntoD;

        public Cuadrilatero(
            float XpuntoA, float YpuntoA,
            float XpuntoB, float YpuntoB,
            float XpuntoC, float YpuntoC,
            float XpuntoD, float YpuntoD)
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

        public float CoordenadasXPuntoA
        { 
            get 
            { 
                return _coordenadasXPuntoA;
            }
            set
            {
                _coordenadasXPuntoA = value;
            }
        }
        public float CoordenadasYPuntoA
        {
            get
            {
                return _coordenadasYPuntoA;
            }
            set
            {
                _coordenadasYPuntoA = value;
            }
        }
        public float CoordenadasXPuntoB
        {
            get
            {
                return _coordenadasXPuntoB;
            }
            set
            {
                _coordenadasXPuntoB = value;
            }
        }
        public float CoordenadasYPuntoB
        {
            get
            {
                return _coordenadasYPuntoB;
            }
            set
            {
                _coordenadasYPuntoB = value;
            }
        }
        public float CoordenadasXPuntoC
        {
            get
            {
                return _coordenadasXPuntoC;
            }
            set
            {
                _coordenadasXPuntoC = value;
            }
        }
        public float CoordenadasYPuntoC
        {
            get
            {
                return _coordenadasYPuntoC;
            }
            set
            {
                _coordenadasYPuntoC = value;
            }
        }
        public float CoordenadasXPuntoD
        {
            get
            {
                return _coordenadasXPuntoD;
            }
            set
            {
                _coordenadasXPuntoD = value;
            }
        }
        public float CoordenadasYPuntoD
        {
            get
            {
                return _coordenadasYPuntoD;
            }
            set
            {
                _coordenadasYPuntoD = value;
            }
        }

        public abstract double CalcularArea();

        protected double CalcularDistanciaDosPuntos(
            float XpuntoA, float YpuntoA,
            float XpuntoB, float YpuntoB)
        {
            double x = Math.Pow((XpuntoB - XpuntoA), 2);
            double y = Math.Pow((YpuntoB - YpuntoA), 2);
            return (Math.Sqrt( x + y ));
        }
    }
}