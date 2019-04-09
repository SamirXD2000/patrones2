using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExampleCS
{
    public class Acelerador : IAcelerador
    {
        #region IAcelerador Members

        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerador presionado");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Acelerador levantado");
        }

        #endregion
    }
}
