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
    public partial class FrmRegistraSoldado : Form
    {
        CMinisterio objministerio = new CMinisterio();
        public FrmRegistraSoldado()
        {
            InitializeComponent();
        }

        private void FrmRegistraSoldado_Load(object sender, EventArgs e)
        {
            lboxcuarteles.DisplayMember = "NombreCuartel";
            lboxcuarteles.ValueMember = "Codigo";
            lboxcuarteles.DataSource = CMinisterio.ListaCuarteles;
            lboxcuarteles.SelectedIndex = -1;
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text != "" && txtnombre.Text != "" && txtedad.Text != "" && cboxespecialidad.SelectedIndex != -1 && lboxcuarteles.SelectedIndex!=-1)
                if (!objministerio.ExisteSoldado(txtdni.Text))
                 {
                    CSoldado objeto = new CSoldado();
                    objeto.DNI = txtdni.Text;
                    objeto.Nombre = txtnombre.Text;
                    objeto.Edad = Convert.ToInt32(txtedad.Text);
                    objeto.Especialidad = cboxespecialidad.Text;
                    objministerio.RegistrarSoldado(((CCuartel)lboxcuarteles.SelectedItem).Codigo, objeto);
                 }
            txtdni.Clear();
            txtnombre.Clear();
            txtedad.Clear();
            cboxespecialidad.SelectedIndex = -1;
            lboxcuarteles.SelectedIndex = -1;
            txtdni.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))   // Para validar que solo digitos se muestren en el Textbox de DNI
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))   // Para validar que solo digitos se muestren en el Textbox de Edad
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
