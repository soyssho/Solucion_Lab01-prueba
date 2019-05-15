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
    public partial class Form1 : Form
    {
        CMinisterio objministerio = new CMinisterio();
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarCuarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistraCuartel frm = new FrmRegistraCuartel();
            frm.ShowDialog();
        }

        private void ingresarSoldadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistraSoldado frm = new FrmRegistraSoldado();
            frm.ShowDialog();
        }
        private void cuartelesConSoldadosDeMenroEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuartelesMenorEdad frm = new FrmCuartelesMenorEdad();
            frm.ShowDialog();
        }

        private void cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuartelesMenorCantEspecialidad frm = new FrmCuartelesMenorCantEspecialidad();
            frm.ShowDialog();
        }

        private void especialidadesConMayorCantidadSoldadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cadena = "Especialidad con mas soldados";
            int continf = objministerio.CantidadTotalSoldadosDeEspecialidad("Infantería");
            int contart = objministerio.CantidadTotalSoldadosDeEspecialidad("Artillería");
            int contcab = objministerio.CantidadTotalSoldadosDeEspecialidad("Caballería");
            int mayor = continf;
            if (contart > mayor) mayor = contart;
            if (contcab > mayor) mayor = contcab;
            if (mayor == continf) cadena = cadena + "\nInfantería";
            if (mayor == contart) cadena = cadena + "\nArtillería";
            if (mayor == contcab) cadena = cadena + "\nCaballería";
            MessageBox.Show(cadena);
        }

        private void promedioEdadPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double prominf = objministerio.PromedioEdadEspecialidad("Infantería");
            double promart = objministerio.PromedioEdadEspecialidad("Artillería");
            double promcab = objministerio.PromedioEdadEspecialidad("Caballería");
            MessageBox.Show("Promedio edad por especialidad\nInfantería:"+prominf.ToString()+"\nArtillería:"+ promart.ToString()+"\nCaballería:"+ promcab.ToString());
        }
    }
}
