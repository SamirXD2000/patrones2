using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_WrapperCSHARP_Example
{
    public interface IEnchufeIngles
    {
        // Devuelve un array de enteros con un voltaje de unos 110V
        int[] Flujo110V();

        // Devuelve el numero de bornes del enchufe
        int getNumeroBornes();
    }
}
