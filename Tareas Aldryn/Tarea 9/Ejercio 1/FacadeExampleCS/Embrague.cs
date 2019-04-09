using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExampleCS
{
    public class Embrague : IEmbrague
    {
        #region IEmbrague Members

        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague presionado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }

        #endregion
    }
}
