using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTourTravel
{
    public partial class Dashboard : Form
    {
        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            //objeuser.NombreUsuario = lblUsuario.Text;
            //objeuser.Cargo = lblCargo.Text;
        }

        private void btnAdmUsers_Click(object sender, EventArgs e)
        {       

            this.Hide();//Oculta la ventana de Dashboard
            AdministraUsuarios admUsers = new AdministraUsuarios();//Abre la ventana de AdministradorUsuarios
            admUsers.ShowDialog();//Bloque la ventana Dashboard 
        }

        private void btnPaqViajes_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de Dashboard
            Destino1 dst1 = new Destino1();//Abre la ventana de Destino1
            dst1.ShowDialog();//Bloque la ventana Dashboard 
        }     
        private void btnCrearViajes_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de Dashboard
            AgregarDestino agrDes = new AgregarDestino();
            agrDes.ShowDialog();//Abre la ventana AgregarDestino
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }                                   
}
           