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
    public partial class FrmRegistraCuartel : Form
    {
        CMinisterio objministerio = new CMinisterio();
        public FrmRegistraCuartel()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(txtcodigo.Text!="" && txtnombre.Text!="" && txtdireccion.Text!="" && cboxciudad.SelectedIndex!=-1)
                if(!objministerio.ExisteCuartel(txtcodigo.Text))
                 {
                     CCuartel objeto = new CCuartel();
                     objeto.Codigo = txtcodigo.Text;
                     objeto.NombreCuartel = txtnombre.Text;
                     objeto.Direccion = txtdireccion.Text;
                     objeto.Ciudad = cboxciudad.Text;
                     objministerio.RegistrarCuartel(objeto);
                 }
            txtcodigo.Clear(); 
            txtnombre.Clear();
            txtdireccion.Clear();
            cboxciudad.SelectedIndex = -1;
            txtcodigo.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
