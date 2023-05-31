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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGuardarPDF = new System.Windows.Forms.Button();
            this.btnGuardarOpenXml = new System.Windows.Forms.Button();
            this.btnGuardarConInterop = new System.Windows.Forms.Button();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.btnGuardarCSV = new System.Windows.Forms.Button();
            this.txtCaracterSeparador = new System.Windows.Forms.TextBox();
            this.chartGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPDF.Location = new System.Drawing.Point(287, 28);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(101, 67);
            this.btnGuardarPDF.TabIndex = 15;
            this.btnGuardarPDF.Text = "Guardar en PDF";
            this.btnGuardarPDF.UseVisualStyleBackColor = true;
            this.btnGuardarPDF.Click += new System.EventHandler(this.btnGuardarPDF_Click);
            // 
            // btnGuardarOpenXml
            // 
            this.btnGuardarOpenXml.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarOpenXml.Location = new System.Drawing.Point(180, 28);
            this.btnGuardarOpenXml.Name = "btnGuardarOpenXml";
            this.btnGuardarOpenXml.Size = new System.Drawing.Size(101, 67);
            this.btnGuardarOpenXml.TabIndex = 14;
            this.btnGuardarOpenXml.Text = "Guardar con OpenXml";
            this.btnGuardarOpenXml.UseVisualStyleBackColor = true;
            this.btnGuardarOpenXml.Click += new System.EventHandler(this.btnGuardarOpenXml_Click);
            // 
            // btnGuardarConInterop
            // 
            this.btnGuardarConInterop.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConInterop.Location = new System.Drawing.Point(73, 28);
            this.btnGuardarConInterop.Name = "btnGuardarConInterop";
            this.btnGuardarConInterop.Size = new System.Drawing.Size(101, 67);
            this.btnGuardarConInterop.TabIndex = 13;
            this.btnGuardarConInterop.Text = "Guardar con Interop";
            this.btnGuardarConInterop.UseVisualStyleBackColor = true;
            this.btnGuardarConInterop.Click += new System.EventHandler(this.btnGuardarConInterop_Click);
            // 
            // lstvDatos
            // 
            this.lstvDatos.HideSelection = false;
            this.lstvDatos.Location = new System.Drawing.Point(12, 101);
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(776, 367);
            this.lstvDatos.TabIndex = 11;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarWord.Location = new System.Drawing.Point(394, 28);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(101, 67);
            this.btnGuardarWord.TabIndex = 16;
            this.btnGuardarWord.Text = "Guardar en Word";
            this.btnGuardarWord.UseVisualStyleBackColor = true;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click);
            // 
            // btnGuardarCSV
            // 
            this.btnGuardarCSV.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCSV.Location = new System.Drawing.Point(501, 28);
            this.btnGuardarCSV.Name = "btnGuardarCSV";
            this.btnGuardarCSV.Size = new System.Drawing.Size(101, 67);
            this.btnGuardarCSV.TabIndex = 17;
            this.btnGuardarCSV.Text = "Guardar CSV";
            this.btnGuardarCSV.UseVisualStyleBackColor = true;
            this.btnGuardarCSV.Click += new System.EventHandler(this.btnGuardarCSV_Click);
            // 
            // txtCaracterSeparador
            // 
            this.txtCaracterSeparador.Location = new System.Drawing.Point(609, 38);
            this.txtCaracterSeparador.Name = "txtCaracterSeparador";
            this.txtCaracterSeparador.Size = new System.Drawing.Size(100, 22);
            this.txtCaracterSeparador.TabIndex = 18;
            // 
            // chartGrafica
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrafica.Legends.Add(legend1);
            this.chartGrafica.Location = new System.Drawing.Point(806, 101);
            this.chartGrafica.Name = "chartGrafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrafica.Series.Add(series1);
            this.chartGrafica.Size = new System.Drawing.Size(560, 367);
            this.chartGrafica.TabIndex = 19;
            this.chartGrafica.Text = "ChartGrafica";
            this.chartGrafica.Click += new System.EventHandler(this.chartGrafica_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(180, 474);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(587, 277);
            this.treeView1.TabIndex = 22;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(855, 515);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(138, 66);
            this.btnCargar.TabIndex = 23;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmCodigoPostal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 763);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chartGrafica);
            this.Controls.Add(this.txtCaracterSeparador);
            this.Controls.Add(this.btnGuardarCSV);
            this.Controls.Add(this.btnGuardarWord);
            this.Controls.Add(this.btnGuardarPDF);
            this.Controls.Add(this.btnGuardarOpenXml);
            this.Controls.Add(this.btnGuardarConInterop);
            this.Controls.Add(this.lstvDatos);
            this.Name = "FrmCodigoPostal";
            this.Text = "FrmCodigoPostal";
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPDF;
        private System.Windows.Forms.Button btnGuardarOpenXml;
        private System.Windows.Forms.Button btnGuardarConInterop;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.Button btnGuardarWord;
        private System.Windows.Forms.Button btnGuardarCSV;
        private System.Windows.Forms.TextBox txtCaracterSeparador;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafica;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnCargar;
    }
}