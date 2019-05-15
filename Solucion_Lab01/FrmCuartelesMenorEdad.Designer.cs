namespace Solucion_Lab01
{
    partial class FrmCuartelesMenorEdad
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
            this.lblmenor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxcuarteles = new System.Windows.Forms.ListBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menor edad";
            // 
            // lblmenor
            // 
            this.lblmenor.AutoSize = true;
            this.lblmenor.Location = new System.Drawing.Point(122, 29);
            this.lblmenor.Name = "lblmenor";
            this.lblmenor.Size = new System.Drawing.Size(0, 13);
            this.lblmenor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuarteles";
            // 
            // lboxcuarteles
            // 
            this.lboxcuarteles.FormattingEnabled = true;
            this.lboxcuarteles.Location = new System.Drawing.Point(29, 94);
            this.lboxcuarteles.Name = "lboxcuarteles";
            this.lboxcuarteles.Size = new System.Drawing.Size(222, 108);
            this.lboxcuarteles.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(115, 222);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(69, 20);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmCuartelesMenorEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lboxcuarteles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmenor);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuartelesMenorEdad";
            this.Text = "FrmCuartelesMenorEdad";
            this.Load += new System.EventHandler(this.FrmCuartelesMenorEdad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmenor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxcuarteles;
        private System.Windows.Forms.Button btnsalir;
    }
}