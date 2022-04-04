using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud;


namespace crud
{
      
     class Controller
    {
        prueba.obj.Estudiante estudiante;
        public void Resgistrarar(int carne,String nombre,String apellido,int edad, String telefono,String direccion)
        {
           
            if (carne != 0 || nombre != ""  || apellido != ""  || edad != 0  || telefono != ""  || direccion != ""  )
            {
                estudiante = new prueba.obj.Estudiante(carne,nombre,apellido,edad,telefono,direccion);
                if (estudiante.Insertar())
                {
                    Console.Write("ERROR... ");
                }
                else
                {
                    Console.Write("EXITO..co.");
                }
            }
            
           
        }
    }
}
