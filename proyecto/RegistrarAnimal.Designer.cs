namespace proyecto
{
    partial class RegistrarAnimal
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
            this.lblRegistrarAnimal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.bllPeso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrarAnimal
            // 
            this.lblRegistrarAnimal.AutoSize = true;
            this.lblRegistrarAnimal.Location = new System.Drawing.Point(202, 56);
            this.lblRegistrarAnimal.Name = "lblRegistrarAnimal";
            this.lblRegistrarAnimal.Size = new System.Drawing.Size(83, 13);
            this.lblRegistrarAnimal.TabIndex = 0;
            this.lblRegistrarAnimal.Text = "Registrar Animal";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(47, 195);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(47, 246);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 2;
            this.lblRaza.Text = "Raza:";
            // 
            // bllPeso
            // 
            this.bllPeso.AutoSize = true;
            this.bllPeso.Location = new System.Drawing.Point(47, 297);
            this.bllPeso.Name = "bllPeso";
            this.bllPeso.Size = new System.Drawing.Size(34, 13);
            this.bllPeso.TabIndex = 3;
            this.bllPeso.Text = "Peso:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(47, 348);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(47, 399);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(47, 450);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(47, 144);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(60, 13);
            this.lblPropietario.TabIndex = 7;
            this.lblPropietario.Text = "Propietario:";
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(220, 141);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(200, 21);
            this.cmbPropietario.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(220, 192);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Items.AddRange(new object[] {
            "Romo",
            "CCC",
            "BON",
            "Chino",
            "Hartón"});
            this.cmbRaza.Location = new System.Drawing.Point(220, 242);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(200, 21);
            this.cmbRaza.TabIndex = 10;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(220, 293);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(200, 20);
            this.txtPeso.TabIndex = 11;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Preñada",
            "Parida"});
            this.cmbEstado.Location = new System.Drawing.Point(220, 343);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 21);
            this.cmbEstado.TabIndex = 12;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(220, 394);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 13;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Propia",
            "Al Partir"});
            this.cmbTipo.Location = new System.Drawing.Point(220, 444);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 21);
            this.cmbTipo.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(345, 564);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(50, 564);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RegistrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 645);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbPropietario);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.bllPeso);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblRegistrarAnimal);
            this.Name = "RegistrarAnimal";
            this.Text = "RegistrarAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarAnimal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label bllPeso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}