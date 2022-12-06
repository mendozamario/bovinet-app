namespace proyecto
{
    partial class RegistrarProduccion
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblCostoDia = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCostoDia = new System.Windows.Forms.TextBox();
            this.lblRegistrarProduccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(47, 146);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(47, 88);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 2;
            this.lblAnimal.Text = "Animal:";
            // 
            // lblCostoDia
            // 
            this.lblCostoDia.AutoSize = true;
            this.lblCostoDia.Location = new System.Drawing.Point(47, 204);
            this.lblCostoDia.Name = "lblCostoDia";
            this.lblCostoDia.Size = new System.Drawing.Size(78, 13);
            this.lblCostoDia.TabIndex = 3;
            this.lblCostoDia.Text = "Precio del Día:";
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(193, 85);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(174, 20);
            this.txtAnimal.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(193, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(174, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtCostoDia
            // 
            this.txtCostoDia.Location = new System.Drawing.Point(193, 201);
            this.txtCostoDia.Name = "txtCostoDia";
            this.txtCostoDia.Size = new System.Drawing.Size(174, 20);
            this.txtCostoDia.TabIndex = 6;
            // 
            // lblRegistrarProduccion
            // 
            this.lblRegistrarProduccion.AutoSize = true;
            this.lblRegistrarProduccion.Location = new System.Drawing.Point(148, 32);
            this.lblRegistrarProduccion.Name = "lblRegistrarProduccion";
            this.lblRegistrarProduccion.Size = new System.Drawing.Size(106, 13);
            this.lblRegistrarProduccion.TabIndex = 7;
            this.lblRegistrarProduccion.Text = "Registrar Producción";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(50, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(292, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // RegistrarProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblRegistrarProduccion);
            this.Controls.Add(this.txtCostoDia);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lblCostoDia);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblCantidad);
            this.Name = "RegistrarProduccion";
            this.Text = "RegistrarProduccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblCostoDia;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCostoDia;
        private System.Windows.Forms.Label lblRegistrarProduccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}