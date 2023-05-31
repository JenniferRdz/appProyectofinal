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
            this.btnclienteRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCodigoPostal
            // 
            this.btnCodigoPostal.Location = new System.Drawing.Point(401, 117);
            this.btnCodigoPostal.Name = "btnCodigoPostal";
            this.btnCodigoPostal.Size = new System.Drawing.Size(239, 145);
            this.btnCodigoPostal.TabIndex = 0;
            this.btnCodigoPostal.Text = "Codigo Postal";
            this.btnCodigoPostal.UseVisualStyleBackColor = true;
            this.btnCodigoPostal.Click += new System.EventHandler(this.btnCodigoPostal_Click);
            // 
            // btnclienteRest
            // 
            this.btnclienteRest.Location = new System.Drawing.Point(105, 117);
            this.btnclienteRest.Name = "btnclienteRest";
            this.btnclienteRest.Size = new System.Drawing.Size(239, 145);
            this.btnclienteRest.TabIndex = 3;
            this.btnclienteRest.Text = "Precio del dolar";
            this.btnclienteRest.UseVisualStyleBackColor = true;
            this.btnclienteRest.Click += new System.EventHandler(this.btnclienteRest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclienteRest);
            this.Controls.Add(this.btnCodigoPostal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCodigoPostal;
        private System.Windows.Forms.Button btnclienteRest;
    }
}

