using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExampleCS
{
    class Program
    {
        static void Main(string[] args)
        {
            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.PuntoMuerto();
            palancaCambios.InsertarVelocidad(3);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
        }
    }
}
