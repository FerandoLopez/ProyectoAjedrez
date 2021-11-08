using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class LoginDatos
    {
        Conexion _conexion;

        public LoginDatos()
        {
            try
            {
                _conexion = new Conexion("localhost", "ajedrez", "ajedrez", "ajedrez");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo la conexion" + ex.Message);
            }
        }

        public int ObtenerLogins(string user,string password)
        {
            string consulta = string.Format("select count(*) from login where Usuario = '{0}' and Contraseña = '{1}';", user, password);
            int Contar = int.Parse(_conexion.ConsultaRetorno(consulta));
            return Contar;
        }
    }
}
