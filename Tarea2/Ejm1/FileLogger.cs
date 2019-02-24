using System;
using Libs;
namespace Singleton.Ejm1
{
    /// <summary>
    /// Registra un mensaje y lo graba en un archivo de texto
    /// </summary>
    class FileLogger: Logger
    {
        private static FileLogger logger;

        //Constructor privado para evitar que los objetos clientes creen varias instancias
        private FileLogger()
        {

        }

        //Método estático que devuelve una sola instancia de la clase
        public static FileLogger getFileLogger()
        {
            if (logger == null)
            {
                logger = new FileLogger();
            }
            return logger;

        }

        public void Log(String msg)
        {
            FileUtil futil = new FileUtil();


            futil.WriteToFile(msg, "log.txt");
        }
    }
}
