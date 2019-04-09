using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterWrappedBueno
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IEnchufeIngles
    {
        // Devuelve un array de enteros con un voltaje de unos 110V
        int[] Flujo110V();

        // Devuelve el numero de bornes del enchufe
        int getNumeroBornes();
    }
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

    public interface IEnchufeEuropeo
    {
        // Devuelve un array de enteros con un voltaje de unos 220V
        int[] Flujo220V();

        // Devuelve el numero de bornes del enchufe
        int getNumeroBornes();
    }
    public class EnchufeEspanol : IEnchufeEuropeo
    {
        #region IEnchufeEuropeo Members

        // Devuelve un array con voltajes en distintos momentos
        public int[] Flujo220V()
        {
            int[] arrayFlujo = new int[100];
            Random r = new Random();
            for (int i = 0; i < arrayFlujo.Length; i++)
            {
                // Calculamos la fluctuacion del voltaje
                int fluctuacion = r.Next(100) > 50 ? 1 : -1;    // Positiva o negativa
                fluctuacion = fluctuacion * (r.Next(10) + 1);    // El valor fluctuara entre -0 y +10

                // Valor total entre 210 y 230V
                arrayFlujo[i] = fluctuacion + 220;
            }

            return arrayFlujo;
        }

        // Devuelve el numero de bornes del enchufe
        public int getNumeroBornes()
        {
            return 2;
        }

        #endregion
    }

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
