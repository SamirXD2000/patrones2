using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_WrapperCSHARP_Example
{
    public class EnchufeBritanico : IEnchufeIngles
    {
        #region IEnchufeIngles Members

        // Devuelve un array con voltajes en distintos momentos
        public int[] Flujo110V()
        {
            int[] arrayFlujo = new int[100];
            Random r = new Random();
            for (int i = 0; i < arrayFlujo.Length; i++)
            {
                // Calculamos la fluctuacion del voltaje
                int fluctuacion = r.Next(100) > 50 ? 1 : -1;    // Positiva o negativa
                fluctuacion = fluctuacion * (r.Next(7) + 1);    // El valor fluctuara entre -7 y +7

                // Valor total entre 103 y 117V
                arrayFlujo[i] = fluctuacion + 110;
            }

            return arrayFlujo;
        }

        // Devuelve el numero de bornes del enchufe
        public int getNumeroBornes()
        {
            return 3;
        }



        #endregion
    }
}
