using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace prueba.obj
{
    class Estudiante
    {
      Conexion conexion = new Conexion();

      private int _carne;
      private String _nombre;
      private String _apellido;
      private int _edad;
      private String _telefono;
      private String _direccion;

        public int Carne { get => _carne; set => _carne = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public Estudiante(int _carne, string _nombre, String _apellido, int _edad, String _telefono, String _direccion)
        {
          this.Carne = _carne;
          this.Nombre = _nombre;
          this.Apellido = _apellido;
          this.Edad = _edad;
          this.Telefono = _telefono;
          this.Direccion = _direccion;
        }

        public bool Insertar()
        {
          String sql = @"INSERT INTO Estudiantes values('"+this.Carne+"','"+this.Nombre+"','"+this.Apellido+"','"+this.Edad+"','"+this.Telefono+"','"+this.Direccion+"');";

          if (conexion.Guardar(sql))
          
            return true;
          
          else
          {
            return false;
          }
        }
    }
}