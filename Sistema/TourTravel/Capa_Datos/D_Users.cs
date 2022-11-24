using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class D_Users
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_user(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("login_usuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreUsuario",obje.NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", obje.pass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /*public DataTable D_user(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("Presentacion", cn);
            cmd.Parameters.AddWithValue("@NombreUsuario", obje.NombreUsuario);
            cmd.Parameters.AddWithValue("@TipoUsuario", obje.TipoUsuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable pd = new DataTable();
            da.Fill(pd);
            return pd;
        }*/
    }
}
