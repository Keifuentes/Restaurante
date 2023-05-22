namespace Restaurante
{
    partial class MenuBodeguero
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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.btnverstock = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(89, 59);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(120, 23);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Ingresar Producto";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(111, 139);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(75, 23);
            this.btnRecetas.TabIndex = 1;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(99, 180);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(101, 23);
            this.btnProveedor.TabIndex = 2;
            this.btnProveedor.Text = "Pedido Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(85, 36);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(0, 20);
            this.Stock.TabIndex = 3;
            // 
            // btnverstock
            // 
            this.btnverstock.Location = new System.Drawing.Point(111, 98);
            this.btnverstock.Name = "btnverstock";
            this.btnverstock.Size = new System.Drawing.Size(75, 23);
            this.btnverstock.TabIndex = 4;
            this.btnverstock.Text = "Ver Stock";
            this.btnverstock.UseVisualStyleBackColor = true;
            this.btnverstock.Click += new System.EventHandler(this.btnverstock_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(99, 220);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(101, 23);
            this.btncerrarsesion.TabIndex = 5;
            this.btncerrarsesion.Text = "Cerrar Sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // MenuBodeguero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 269);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btnverstock);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnRecetas);
            this.Controls.Add(this.btnStock);
            this.Name = "MenuBodeguero";
            this.Text = "MenuBodeguero";
            this.Load += new System.EventHandler(this.MenuBodeguero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Button btnverstock;
        private System.Windows.Forms.Button btncerrarsesion;
    }
}