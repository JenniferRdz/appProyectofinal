namespace AppProyectoFinal
{
    partial class FrmPrecio_del_dolar
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbSerie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(143, 47);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(43, 76);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(44, 16);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "label1";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(43, 106);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(44, 16);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "label2";
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.Location = new System.Drawing.Point(43, 137);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(44, 16);
            this.lbSerie.TabIndex = 3;
            this.lbSerie.Text = "label2";
            // 
            // FrmPrecio_del_dolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 176);
            this.Controls.Add(this.lbSerie);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.btnAbrir);
            this.Name = "FrmPrecio_del_dolar";
            this.Text = "FrmPrecio_del_dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbSerie;
    }
}