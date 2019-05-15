using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_Lab01
{
    public partial class FrmCuartelesMenorEdad : Form
    {
        CMinisterio objministerio = new CMinisterio();
        public FrmCuartelesMenorEdad()
        {
            InitializeComponent();
        }

        private void FrmCuartelesMenorEdad_Load(object sender, EventArgs e)
        {
            lblmenor.Text = objministerio.MenorEdad().ToString();
            foreach (CCuartel cuartel in objministerio.CuartelesSoldadosMenorEdad())
                lboxcuarteles.Items.Add(cuartel.NombreCuartel);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
