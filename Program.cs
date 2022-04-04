using System;
using System.Data;
using System.Data.SqlClient;
using  crud;
namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, edad;
            string name,ape,tele,dire;
            

            Console.Write("INGRESE CARNE: ");
            id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("INGRESE NOMBRE: ");
            name = Console.ReadLine();
            Console.Write("INGRESE APELLIDO: ");
            ape = Console.ReadLine();
            
            Console.Write("INGRESE edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("INGRESE TELEFONO: ");
            tele = Console.ReadLine();
            Console.Write("INGRESE DIRECCION: ");
            dire = Console.ReadLine();

            Controller control = new Controller();

            control.Resgistrarar(id,name,ape,edad,tele,dire);

        }
    }
}
