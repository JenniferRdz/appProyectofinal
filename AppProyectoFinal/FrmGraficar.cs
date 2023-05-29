﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProyectoFinal
{
    public partial class FrmGraficar : Form
    {
        public FrmGraficar()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            { return; }

            StreamReader sr = new StreamReader(dialogo.FileName, Encoding.GetEncoding(1252));

            string renglon;
            string x = "";
            int y = 0;


            while ((renglon = sr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');
                if (x != datos[0] && x != "")
                {
                    chart1.Series[0].Points.AddXY(x, y);
                    y = 0;
                    //x = datos[0];
                    //continue;

                }
                x = datos[0];
                y++;
            }
            chart1.Series[0].Points.AddXY(x, y);
        }
    }
}
