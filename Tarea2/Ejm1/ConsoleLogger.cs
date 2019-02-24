using System;
namespace Singleton.Ejm1
{
    /// <summary>
    /// Registra un mensaje por consola
    /// </summary>
    class ConsoleLogger:Logger
    {
        public void Log(String msg)
        {
            Console.WriteLine(msg + " registrado por consola");
        }
    }
}
