using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;


namespace SistemaTourTravel
{
    public partial class frm_InicioSesion : Form
    {

        E_Users objeuser = new E_Users(); 
        N_Users objnuser = new N_Users();
        Dashboard frmPrincipal = new Dashboard();

        public static string Nombre_usuario;
        public static string Cargo;

         void P_logeo()
        {
            DataTable dt = new DataTable();
            objeuser.NombreUsuario = txtUser.Text;
            objeuser.pass = txtPassword.Text;

            dt = objnuser.N_user(objeuser);

            if(dt.Rows.Count > 0)
            {

                //codigo nuevo abajo
                Nombre_usuario = dt.Rows[0][1].ToString();
                Cargo = dt.Rows[0][3].ToString();

                //codigo nuevo arriba
                
                this.Hide();
                frmPrincipal.ShowDialog();

                frm_InicioSesion logeo = new frm_InicioSesion();
                logeo.ShowDialog();

                if (logeo.DialogResult == DialogResult.OK)                
                    Application.Run(new Dashboard());             
                
                txtUser.Clear();
                txtPassword.Clear();

            }
            else
            {
                MessageBox.Show("Verifique que los campos contengan los datos correctamente","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }            
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             P_logeo();//Ejecuta la funcion logeo abriendo Dashboard
             this.Close();//Cierra el formulario de inicio de sesion                    
        }                      
          
       private void frm_InicioSesion_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();

        }
        public frm_InicioSesion()
        {
            InitializeComponent();
        }
        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();               
        }

    }
}
