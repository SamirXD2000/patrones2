using System.Collections.Generic;
using Libs;
namespace Singleton.Ejm1
{
    /// <summary>
    /// Fabrica de objetos
    /// </summary>
    class LoggerFactory
    {
        /// <summary>
        /// Determina si el parámetro de configuración FileLogging=ON
        /// </summary>
        /// <returns>True si está en ON, false si esta en OFF</returns>
        public bool IsFileLogginEnabled()
        {
            Dictionary<string, string> properties = Properties.GetProperties(@"d:\logger.properties");
            if (properties["FileLogging"].Equals("ON"))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Fabrica de objetos
        /// </summary>
        /// <returns>Un objeto FileLogger ó un objeto ConsoleLogger, segun el criterio</returns>
        public Logger getLogger()
        {
            if (IsFileLogginEnabled())
                return FileLogger.getFileLogger();//Observar este cambio
            else
                return new ConsoleLogger();
        }
    }
}
