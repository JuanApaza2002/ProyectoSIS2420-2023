namespace Restaurante
{
    partial class Frm_Ingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ingreso));
            this.lbl_ingreso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_gerente = new System.Windows.Forms.Button();
            this.btn_cajero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ingreso
            // 
            this.lbl_ingreso.AutoSize = true;
            this.lbl_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingreso.Location = new System.Drawing.Point(167, 38);
            this.lbl_ingreso.Name = "lbl_ingreso";
            this.lbl_ingreso.Size = new System.Drawing.Size(143, 32);
            this.lbl_ingreso.TabIndex = 0;
            this.lbl_ingreso.Text = "INGRESO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_gerente
            // 
            this.btn_gerente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gerente.Location = new System.Drawing.Point(133, 356);
            this.btn_gerente.Name = "btn_gerente";
            this.btn_gerente.Size = new System.Drawing.Size(105, 39);
            this.btn_gerente.TabIndex = 2;
            this.btn_gerente.Text = "GERENTE";
            this.btn_gerente.UseVisualStyleBackColor = false;
            this.btn_gerente.Click += new System.EventHandler(this.btn_gerente_Click);
            // 
            // btn_cajero
            // 
            this.btn_cajero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cajero.Location = new System.Drawing.Point(244, 356);
            this.btn_cajero.Name = "btn_cajero";
            this.btn_cajero.Size = new System.Drawing.Size(102, 39);
            this.btn_cajero.TabIndex = 3;
            this.btn_cajero.Text = "CAJERO";
            this.btn_cajero.UseVisualStyleBackColor = false;
            // 
            // Frm_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 488);
            this.Controls.Add(this.btn_cajero);
            this.Controls.Add(this.btn_gerente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ingreso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Ingreso";
            this.Text = "INGRESO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ingreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_gerente;
        private System.Windows.Forms.Button btn_cajero;
    }
}

