namespace Solucion_Lab01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCuarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarSoldadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesConMayorCantidadSoldadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioEdadPorEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCuarteToolStripMenuItem,
            this.ingresarSoldadoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // ingresarCuarteToolStripMenuItem
            // 
            this.ingresarCuarteToolStripMenuItem.Name = "ingresarCuarteToolStripMenuItem";
            this.ingresarCuarteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ingresarCuarteToolStripMenuItem.Text = "Ingresar Cuartel";
            this.ingresarCuarteToolStripMenuItem.Click += new System.EventHandler(this.ingresarCuarteToolStripMenuItem_Click);
            // 
            // ingresarSoldadoToolStripMenuItem
            // 
            this.ingresarSoldadoToolStripMenuItem.Name = "ingresarSoldadoToolStripMenuItem";
            this.ingresarSoldadoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ingresarSoldadoToolStripMenuItem.Text = "Ingresar Soldado";
            this.ingresarSoldadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarSoldadoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem,
            this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem,
            this.especialidadesConMayorCantidadSoldadosToolStripMenuItem,
            this.promedioEdadPorEspecialidadToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cuartelesConSoldadosDeMenroEdadToolStripMenuItem
            // 
            this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem.Name = "cuartelesConSoldadosDeMenroEdadToolStripMenuItem";
            this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem.Text = "Cuarteles con soldados de menor edad";
            this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem.Click += new System.EventHandler(this.cuartelesConSoldadosDeMenroEdadToolStripMenuItem_Click);
            // 
            // cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem
            // 
            this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem.Name = "cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem";
            this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem.Text = "Cuarteles menor cantidad soldados una especialidad";
            this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem_Click);
            // 
            // especialidadesConMayorCantidadSoldadosToolStripMenuItem
            // 
            this.especialidadesConMayorCantidadSoldadosToolStripMenuItem.Name = "especialidadesConMayorCantidadSoldadosToolStripMenuItem";
            this.especialidadesConMayorCantidadSoldadosToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.especialidadesConMayorCantidadSoldadosToolStripMenuItem.Text = "Especialidades con mayor cantidad soldados";
            this.especialidadesConMayorCantidadSoldadosToolStripMenuItem.Click += new System.EventHandler(this.especialidadesConMayorCantidadSoldadosToolStripMenuItem_Click);
            // 
            // promedioEdadPorEspecialidadToolStripMenuItem
            // 
            this.promedioEdadPorEspecialidadToolStripMenuItem.Name = "promedioEdadPorEspecialidadToolStripMenuItem";
            this.promedioEdadPorEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.promedioEdadPorEspecialidadToolStripMenuItem.Text = "Promedio edad por especialidad";
            this.promedioEdadPorEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.promedioEdadPorEspecialidadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCuarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarSoldadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuartelesConSoldadosDeMenroEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuartelesMenorCantidadSoldadosUnaEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesConMayorCantidadSoldadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioEdadPorEspecialidadToolStripMenuItem;
    }
}

