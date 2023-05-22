namespace Restaurante.Bodeguero
{
    partial class SolicitarInsumos
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
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcuerpo = new System.Windows.Forms.RichTextBox();
            this.btnatras = new System.Windows.Forms.Button();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(51, 73);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(116, 20);
            this.txtcorreo.TabIndex = 0;
            // 
            // txtcuerpo
            // 
            this.txtcuerpo.Location = new System.Drawing.Point(51, 128);
            this.txtcuerpo.Name = "txtcuerpo";
            this.txtcuerpo.Size = new System.Drawing.Size(512, 173);
            this.txtcuerpo.TabIndex = 1;
            this.txtcuerpo.Text = "";
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(12, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 23);
            this.btnatras.TabIndex = 2;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(512, 322);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Correo a Enviar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Redactar Solicitud";
            // 
            // SolicitarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.txtcuerpo);
            this.Controls.Add(this.txtcorreo);
            this.Name = "SolicitarInsumos";
            this.Text = "SolicitarInsumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.RichTextBox txtcuerpo;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}