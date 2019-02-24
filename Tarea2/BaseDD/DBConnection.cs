using System;
namespace Singleton.Ejm2
{
    public class DBConnection
    {
        private static DBConnection conn;

        private DBConnection() { }

        public static DBConnection getDBConnection()
        {
            if (conn == null)
            {
                conn = new DBConnection();
                return conn;
            }
            else
                return conn;
        }

        public void Connect(string db)
        {
            Console.WriteLine("Se ha conectado a la bd: " + db);

        }
        public void Disconnect()
        {
            Console.WriteLine("Se ha desconectado de la bd");

        }
    }

}
