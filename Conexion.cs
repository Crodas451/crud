using System;
using System.Data;
using System.Data.SqlClient;

namespace prueba
{
    public class Conexion
    {
        private string Conexion = @"Data Source = DESKTOP-LMSRAVI Catalog = Colegio1; Integrate Security = true";
        private SqlConnection cone;
        private SqlCommand cmd;
        private SqlDataAdapter leer;

        private void Conectar()
        {
            cone = new SqlConnection(Conexion);
        }        

        public Conexion()
        {
            Conectar();
        }

        public bool Guardar(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql,cone);
                cone.Open();
                int i = cmd.ExcuteNonQuery();

                if(i > 0)
                return true;
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }
            finally
            {
                cone.Close();
            }
        }
    }
}