using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;

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

        public List<ComboPais> LlenarPais(string consulta)
        {
            List<ComboPais> lista = new List<ComboPais>();

            try
            {
                con.Open();
                var command = new MySqlCommand(consulta, con);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboPais cp = new ComboPais();
                        cp._IdPais = int.Parse(reader["idpais"].ToString());
                        cp._Nombre = reader["nombre"].ToString();
                        lista.Add(cp);
                    }
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                con.Close();
                return lista;
            }
        }

        public List<ComboRol> LlenarRol(string consulta)
        {
            List<ComboRol> lista = new List<ComboRol>();

            try
            {
                con.Open();
                var command = new MySqlCommand(consulta, con);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboRol cr = new ComboRol();
                        cr._Rol = reader["rol"].ToString();
                        lista.Add(cr);
                    }
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                con.Close();
                return lista;
            }
        }

        public List<ComboColor> LlenarColor(string consulta)
        {
            List<ComboColor> lista = new List<ComboColor>();

            try
            {
                con.Open();
                var command = new MySqlCommand(consulta, con);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboColor cc = new ComboColor();
                        cc._Color = reader["color"].ToString();
                        lista.Add(cc);
                    }
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                con.Close();
                return lista;
            }
        }




        public List<ComboParticipante> LlenarParticipante(string consulta)
        {
            List<ComboParticipante> lista = new List<ComboParticipante>();

            try
            {
                con.Open();
                var command = new MySqlCommand(consulta, con);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboParticipante cp = new ComboParticipante();
                        cp._IdParticipante = int.Parse(reader["idparticipante"].ToString());
                        cp._Nombre = reader["nombre"].ToString();
                        lista.Add(cp);
                    }
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                con.Close();
                return lista;
            }
        }


        public List<ComboHotel> LlenarHotel(string consulta)
        {
            List<ComboHotel> lista = new List<ComboHotel>();

            try
            {
                con.Open();
                var command = new MySqlCommand(consulta, con);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ComboHotel ch = new ComboHotel();
                        ch._IdHotel = int.Parse(reader["idhotel"].ToString());
                        ch._Nombre = reader["nombre"].ToString();
                        lista.Add(ch);
                    }
                }
                con.Close();
                return lista;
            }
            catch (Exception)
            {
                con.Close();
                return lista;
            }
        }

    }
}
