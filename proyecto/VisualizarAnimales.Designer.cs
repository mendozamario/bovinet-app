namespace proyecto
{
    partial class VisualizarAnimales
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
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.btnAgregarAnimales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Location = new System.Drawing.Point(43, 57);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.Size = new System.Drawing.Size(813, 216);
            this.dgvAnimales.TabIndex = 0;
            this.dgvAnimales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimales_CellClick);
            // 
            // btnAgregarAnimales
            // 
            this.btnAgregarAnimales.Location = new System.Drawing.Point(43, 339);
            this.btnAgregarAnimales.Name = "btnAgregarAnimales";
            this.btnAgregarAnimales.Size = new System.Drawing.Size(172, 23);
            this.btnAgregarAnimales.TabIndex = 1;
            this.btnAgregarAnimales.Text = "Agregar Animales";
            this.btnAgregarAnimales.UseVisualStyleBackColor = true;
            this.btnAgregarAnimales.Click += new System.EventHandler(this.btnAgregarAnimales_Click);
            // 
            // VisualizarAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btnAgregarAnimales);
            this.Controls.Add(this.dgvAnimales);
            this.Name = "VisualizarAnimales";
            this.Text = "VisualizarAnimales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.Button btnAgregarAnimales;
    }
}