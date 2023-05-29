namespace AppProyectoFinal
{
    partial class FrmCodigoPostal
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
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.btnGuardarOpenXml = new System.Windows.Forms.Button();
            this.btnGuardarConInterop = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.btnGuardarCSV = new System.Windows.Forms.Button();
            this.txtCaracterSeparador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Location = new System.Drawing.Point(366, 17);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(101, 43);
            this.btnGuardarPDF.TabIndex = 15;
            this.btnGuardarPDF.Text = "Guardar en PDF";
            this.btnGuardarPDF.UseVisualStyleBackColor = true;
            this.btnGuardarPDF.Click += new System.EventHandler(this.btnGuardarPDF_Click);
            // 
            // btnGuardarOpenXml
            // 
            this.btnGuardarOpenXml.Location = new System.Drawing.Point(259, 17);
            this.btnGuardarOpenXml.Name = "btnGuardarOpenXml";
            this.btnGuardarOpenXml.Size = new System.Drawing.Size(101, 43);
            this.btnGuardarOpenXml.TabIndex = 14;
            this.btnGuardarOpenXml.Text = "Guardar con OpenXml";
            this.btnGuardarOpenXml.UseVisualStyleBackColor = true;
            this.btnGuardarOpenXml.Click += new System.EventHandler(this.btnGuardarOpenXml_Click);
            // 
            // btnGuardarConInterop
            // 
            this.btnGuardarConInterop.Location = new System.Drawing.Point(152, 17);
            this.btnGuardarConInterop.Name = "btnGuardarConInterop";
            this.btnGuardarConInterop.Size = new System.Drawing.Size(101, 43);
            this.btnGuardarConInterop.TabIndex = 13;
            this.btnGuardarConInterop.Text = "Guardar con Interop";
            this.btnGuardarConInterop.UseVisualStyleBackColor = true;
            this.btnGuardarConInterop.Click += new System.EventHandler(this.btnGuardarConInterop_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 17);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(101, 43);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lstvDatos
            // 
            this.lstvDatos.HideSelection = false;
            this.lstvDatos.Location = new System.Drawing.Point(12, 66);
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(776, 367);
            this.lstvDatos.TabIndex = 11;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.Location = new System.Drawing.Point(473, 17);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(101, 43);
            this.btnGuardarWord.TabIndex = 16;
            this.btnGuardarWord.Text = "Guardar en Word";
            this.btnGuardarWord.UseVisualStyleBackColor = true;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click);
            // 
            // btnGuardarCSV
            // 
            this.btnGuardarCSV.Location = new System.Drawing.Point(580, 17);
            this.btnGuardarCSV.Name = "btnGuardarCSV";
            this.btnGuardarCSV.Size = new System.Drawing.Size(101, 43);
            this.btnGuardarCSV.TabIndex = 17;
            this.btnGuardarCSV.Text = "Guardar CSV";
            this.btnGuardarCSV.UseVisualStyleBackColor = true;
            this.btnGuardarCSV.Click += new System.EventHandler(this.btnGuardarCSV_Click);
            // 
            // txtCaracterSeparador
            // 
            this.txtCaracterSeparador.Location = new System.Drawing.Point(688, 27);
            this.txtCaracterSeparador.Name = "txtCaracterSeparador";
            this.txtCaracterSeparador.Size = new System.Drawing.Size(100, 22);
            this.txtCaracterSeparador.TabIndex = 18;
            // 
            // FrmCodigoPostal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCaracterSeparador);
            this.Controls.Add(this.btnGuardarCSV);
            this.Controls.Add(this.btnGuardarWord);
            this.Controls.Add(this.btnGuardarPDF);
            this.Controls.Add(this.btnGuardarOpenXml);
            this.Controls.Add(this.btnGuardarConInterop);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lstvDatos);
            this.Name = "FrmCodigoPostal";
            this.Text = "FrmCodigoPostal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPDF;
        private System.Windows.Forms.Button btnGuardarOpenXml;
        private System.Windows.Forms.Button btnGuardarConInterop;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.Button btnGuardarWord;
        private System.Windows.Forms.Button btnGuardarCSV;
        private System.Windows.Forms.TextBox txtCaracterSeparador;
    }
}