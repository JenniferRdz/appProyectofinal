namespace AppProyectoFinal
{
    partial class Form1
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
            this.btnCodigoPostal = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclienteRest = new System.Windows.Forms.Button();
            this.btnRango = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCodigoPostal
            // 
            this.btnCodigoPostal.Location = new System.Drawing.Point(443, 112);
            this.btnCodigoPostal.Name = "btnCodigoPostal";
            this.btnCodigoPostal.Size = new System.Drawing.Size(133, 40);
            this.btnCodigoPostal.TabIndex = 0;
            this.btnCodigoPostal.Text = "Codigo Postal";
            this.btnCodigoPostal.UseVisualStyleBackColor = true;
            this.btnCodigoPostal.Click += new System.EventHandler(this.btnCodigoPostal_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(443, 178);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(133, 40);
            this.btnGraficar.TabIndex = 1;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "s";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnclienteRest
            // 
            this.btnclienteRest.Location = new System.Drawing.Point(147, 112);
            this.btnclienteRest.Name = "btnclienteRest";
            this.btnclienteRest.Size = new System.Drawing.Size(133, 40);
            this.btnclienteRest.TabIndex = 3;
            this.btnclienteRest.Text = "Precio del dolar";
            this.btnclienteRest.UseVisualStyleBackColor = true;
            this.btnclienteRest.Click += new System.EventHandler(this.btnclienteRest_Click);
            // 
            // btnRango
            // 
            this.btnRango.Location = new System.Drawing.Point(147, 245);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(133, 40);
            this.btnRango.TabIndex = 4;
            this.btnRango.Text = "Rango";
            this.btnRango.UseVisualStyleBackColor = true;
            this.btnRango.Click += new System.EventHandler(this.btnRango_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclienteRest);
            this.Controls.Add(this.btnRango);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnCodigoPostal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCodigoPostal;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclienteRest;
        private System.Windows.Forms.Button btnRango;
    }
}

