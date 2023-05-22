namespace Restaurante
{
    partial class MenuRecepcion
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.btnorden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(97, 56);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(99, 23);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Ingresar Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(99, 177);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(97, 23);
            this.btncerrarsesion.TabIndex = 1;
            this.btncerrarsesion.Text = "Cerrar Sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // btnorden
            // 
            this.btnorden.Location = new System.Drawing.Point(99, 102);
            this.btnorden.Name = "btnorden";
            this.btnorden.Size = new System.Drawing.Size(97, 23);
            this.btnorden.TabIndex = 2;
            this.btnorden.Text = "Ingresar Orden";
            this.btnorden.UseVisualStyleBackColor = true;
            this.btnorden.Click += new System.EventHandler(this.btnorden_Click);
            // 
            // MenuRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 297);
            this.Controls.Add(this.btnorden);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btncliente);
            this.Name = "MenuRecepcion";
            this.Text = "MenuRecepcion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Button btnorden;
    }
}