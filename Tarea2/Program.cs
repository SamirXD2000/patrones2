using System;
using Singleton.Ejm1;
using Singleton.Ejm2;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection conn = DBConnection.getDBConnection();
            conn.Connect("empleados");
            conn.Disconnect();

            DBConnection conn2 = DBConnection.getDBConnection();
            conn2.Connect("nomina");
            conn2.Disconnect();


            Console.ReadKey();
        }
    }
}
