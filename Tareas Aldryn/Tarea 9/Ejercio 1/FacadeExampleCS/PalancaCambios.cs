using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExampleCS
{
    public class PalancaCambios : IPalancaCambios
    {
        private int _velocidadActual;

        #region IPalancaCambios Members

        public void InsertarVelocidad(int velocidad)
        {
            Console.WriteLine("Introduciendo marcha " + velocidad);
            this._velocidadActual = velocidad;
        }

        public void PuntoMuerto()
        {
            Console.WriteLine("Sacando velocidad " + this._velocidadActual);
            this._velocidadActual = 0;
        }

        public int GetVelocidadActual()
        {
            return _velocidadActual;
        }
        #endregion
    }
}
