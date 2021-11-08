using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class Conexion
    {
        MySqlConnection con;
        string valor = "";

        public Conexion(string server, string user, string password, string database)
        {
            con = new MySqlConnection(string.Format("server={0};" +
            "user={1}; password={2}; database={3};", server, user, password, database));

        }
        public string Comando(string q)
        {
            try
            {
                MySqlCommand c = new MySqlCommand(q, con);
                con.Open();
                c.ExecuteNonQuery();
                con.Close();
                return "Correcto";
            }
            catch (Exception ex)
            {
                con.Close();
                return ex.Message;
            }
        }

        public DataSet Mostrar(string q, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, con);
                con.Open();
                da.Fill(ds, tabla);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                con.Close();
                return ds;
            }
        }

        public string ConsultaRetorno(string consulta)
        {
            con.Open();
            var command = new MySqlCommand(consulta, con);
            command.ExecuteNonQuery();
            valor = Convert.ToString(command.ExecuteScalar());
            con.Close();
            return valor;
        }
    }

}
