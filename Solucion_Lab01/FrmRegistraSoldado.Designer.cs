namespace Solucion_Lab01
{
    partial class FrmRegistraSoldado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.cboxespecialidad = new System.Windows.Forms.ComboBox();
            this.lboxcuarteles = new System.Windows.Forms.ListBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuartel";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(126, 13);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(129, 20);
            this.txtdni.TabIndex = 5;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(126, 46);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(187, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(126, 88);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(127, 20);
            this.txtedad.TabIndex = 7;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // cboxespecialidad
            // 
            this.cboxespecialidad.FormattingEnabled = true;
            this.cboxespecialidad.Items.AddRange(new object[] {
            "Infantería",
            "Artillería",
            "Caballería"});
            this.cboxespecialidad.Location = new System.Drawing.Point(127, 134);
            this.cboxespecialidad.Name = "cboxespecialidad";
            this.cboxespecialidad.Size = new System.Drawing.Size(185, 21);
            this.cboxespecialidad.TabIndex = 8;
            // 
            // lboxcuarteles
            // 
            this.lboxcuarteles.FormattingEnabled = true;
            this.lboxcuarteles.Location = new System.Drawing.Point(336, 43);
            this.lboxcuarteles.Name = "lboxcuarteles";
            this.lboxcuarteles.Size = new System.Drawing.Size(130, 173);
            this.lboxcuarteles.TabIndex = 9;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(28, 188);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(99, 27);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(203, 188);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 26);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmRegistraSoldado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 232);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lboxcuarteles);
            this.Controls.Add(this.cboxespecialidad);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistraSoldado";
            this.Text = "FrmRegistraSoldado";
            this.Load += new System.EventHandler(this.FrmRegistraSoldado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.ComboBox cboxespecialidad;
        private System.Windows.Forms.ListBox lboxcuarteles;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsalir;
    }
}