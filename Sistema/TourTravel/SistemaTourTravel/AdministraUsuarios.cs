using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaTourTravel
{
    public partial class AdministraUsuarios : Form
    {
        Dashboard Dash = new Dashboard();

        public AdministraUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de administracion
            Dash.ShowDialog();//Abre la ventana de Dashboard y bloquea la anterior
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REKE-LAPTOP;Initial Catalog=AgenciaTourDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into usuarios values (@NombreUsuario,@pass,@TipoUsuario,@Nombre_Apellido)", con);

            cmd.Parameters.AddWithValue("@NombreUsuario", (txtfullname.Text));
            cmd.Parameters.AddWithValue("@pass",(txtPass.Text));
            cmd.Parameters.AddWithValue("@TipoUsuario", (cbTipoUser.Text));
            cmd.Parameters.AddWithValue("@Nombre_Apellido",(txtUser.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Guardado con Éxito");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REKE-LAPTOP;Initial Catalog=AgenciaTourDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update usuarios set pass=@pass, TipoUsuario=@TipoUsuario,  Nombre_Apellido=@Nombre_Apellido where NombreUsuario=@NombreUsuario", con);

            cmd.Parameters.AddWithValue("@NombreUsuario", (txtfullname.Text));
            cmd.Parameters.AddWithValue("@pass", (txtPass.Text));
            cmd.Parameters.AddWithValue("@TipoUsuario", (cbTipoUser.Text));
            cmd.Parameters.AddWithValue("@Nombre_Apellido", (txtUser.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Actualización Completada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REKE-LAPTOP;Initial Catalog=AgenciaTourDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete usuarios where NombreUsuario=@NombreUsuario", con);

            cmd.Parameters.AddWithValue("@NombreUsuario", (txtUser.Text));
            cmd.ExecuteNonQuery();
            con.Close ();

            MessageBox.Show("Eliminado Exitosamente");
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=REKE-LAPTOP;Initial Catalog=AgenciaTourDB;Integrated Security=True");
            con.Open ();
            SqlCommand cmd = new SqlCommand("Select * from usuarios where NombreUsuario=@NombreUsuario",con);
            cmd.Parameters.AddWithValue("@NombreUsuario", (txtfullname.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void AdministraUsuarios_Load(object sender, EventArgs e)
        {


        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }     
    }
}
