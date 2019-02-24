using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton.Ejm1
{
    /// <summary>
    /// Interface que será implementada por FileLogger y ConsoleLogger
    /// </summary>
    interface Logger
    {
        /// <summary>
        /// Registra un mensaje
        /// </summary>
        /// <param name="msg">Mensaje a registrar</param>
        void Log(string msg);
    }
}
