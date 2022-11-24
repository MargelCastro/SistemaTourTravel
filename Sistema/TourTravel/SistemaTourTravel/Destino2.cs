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
    public partial class Destino2 : Form
    {
        public Destino2()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta la ventana de Destino2
            Destino1 dst1 = new Destino1();
            dst1.ShowDialog();//Abre la ventana de Destino1
        }
    }
}
