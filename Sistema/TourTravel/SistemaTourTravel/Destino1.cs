using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTourTravel
{
    public partial class Destino1 : Form
    {

        public Destino1()
        {
            InitializeComponent();
        }

        private void Destino1_Load(object sender, EventArgs e)
        {

        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de Dashboard
            Destino2 dst2 = new Destino2();//Abre la ventana de Destino2
            dst2.ShowDialog();//Bloque la ventana Dashboard 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de Destino1
            Dashboard dsh = new Dashboard();
            dsh.ShowDialog();//Abre la ventana de Dashboard

        }

        private void btnTirolesa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura fac = new Factura();
            fac.ShowDialog();   
        }
    }
}
