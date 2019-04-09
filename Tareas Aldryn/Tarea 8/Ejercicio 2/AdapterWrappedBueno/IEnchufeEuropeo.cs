using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_WrapperCSHARP_Example
{
    public interface IEnchufeEuropeo
    {
        // Devuelve un array de enteros con un voltaje de unos 220V
        int[] Flujo220V();

        // Devuelve el numero de bornes del enchufe
        int getNumeroBornes();
    }
}
