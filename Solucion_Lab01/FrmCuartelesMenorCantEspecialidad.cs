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
    public partial class FrmCuartelesMenorCantEspecialidad : Form
    {
        CMinisterio objministerio = new CMinisterio();
        public FrmCuartelesMenorCantEspecialidad()
        {
            InitializeComponent();
        }

        private void cboxespecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxcuarteles.Items.Clear();
            foreach (CCuartel cuartel in objministerio.CuartelesMenorCantidadDeUnaEspecialidad(cboxespecialidad.Text))
                lboxcuarteles.Items.Add(cuartel.NombreCuartel);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
