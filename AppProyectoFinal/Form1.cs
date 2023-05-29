﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCodigoPostal_Click(object sender, EventArgs e)
        {
            FrmCodigoPostal frm = new FrmCodigoPostal();
            frm.ShowDialog();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            FrmGraficar frm = new FrmGraficar();
            frm.ShowDialog();
        }

        private void btnclienteRest_Click(object sender, EventArgs e)
        {
            FrmPrecio_del_dolar frm = new FrmPrecio_del_dolar();
            frm.ShowDialog();
        }

        private void btnRango_Click(object sender, EventArgs e)
        {
            FrmRango frm = new FrmRango();
            frm.ShowDialog();
        }
    }
}
