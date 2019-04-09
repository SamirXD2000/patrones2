using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_WrapperCSHARP_Example
{
    public class Taladro
    {
        // Enchufe del taladro
        private IEnchufeIngles enchufe;

        // Constructor a traves del cual se inyecta el enchufe
        public Taladro(IEnchufeIngles enchufeTaladro)
        {
            this.enchufe = enchufeTaladro;
        }

        public void Encender()
        {
            // Obtenemos la alimentación a través de la interfaz.
            // Recordemos que nuestro enchufe requiere una alimentacion de 110V
            int[] voltaje100ms = enchufe.Flujo110V();

            // Mostramos por pantalla el resultado.
            for (int i = 0; i < voltaje100ms.Length; i++)
                Console.WriteLine("El taladro esta funcionando con voltaje de " + voltaje100ms[i] + " Voltios");
        }
    }
    }
