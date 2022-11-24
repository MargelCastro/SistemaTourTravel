using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTourTravel
{
    public partial class AgregarDestino : Form
    {
        public AgregarDestino()
        {
            InitializeComponent();
        }

        private void AgregarDestino_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de Destino1
            Dashboard dsh = new Dashboard();
            dsh.ShowDialog();//Abre la ventana de Dashboard
        }
    }
}
