namespace Solucion_Lab01
{
    partial class FrmCuartelesMenorCantEspecialidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxespecialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxcuarteles = new System.Windows.Forms.ListBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad";
            // 
            // cboxespecialidad
            // 
            this.cboxespecialidad.FormattingEnabled = true;
            this.cboxespecialidad.Items.AddRange(new object[] {
            "Infantería",
            "Artillería",
            "Caballería"});
            this.cboxespecialidad.Location = new System.Drawing.Point(93, 23);
            this.cboxespecialidad.Name = "cboxespecialidad";
            this.cboxespecialidad.Size = new System.Drawing.Size(152, 21);
            this.cboxespecialidad.TabIndex = 1;
            this.cboxespecialidad.SelectedIndexChanged += new System.EventHandler(this.cboxespecialidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuarteles";
            // 
            // lboxcuarteles
            // 
            this.lboxcuarteles.FormattingEnabled = true;
            this.lboxcuarteles.Location = new System.Drawing.Point(17, 107);
            this.lboxcuarteles.Name = "lboxcuarteles";
            this.lboxcuarteles.Size = new System.Drawing.Size(227, 108);
            this.lboxcuarteles.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(102, 232);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(70, 26);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmCuartelesMenorCantEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 267);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lboxcuarteles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxespecialidad);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuartelesMenorCantEspecialidad";
            this.Text = "FrmCuartelesMenorCantEspecialidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxespecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxcuarteles;
        private System.Windows.Forms.Button btnsalir;
    }
}