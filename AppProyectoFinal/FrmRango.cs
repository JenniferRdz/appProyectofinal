using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppProyectoFinal
{
    public partial class FrmRango : Form
    {
        bool maximizado;
        public FrmRango()
        {
            InitializeComponent();
            maximizado = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string fechaDesde = dtpDesde.Value.ToString("yyyy-MM-dd");
            string fechaHasta = dtpHasta.Value.ToString("yyyy-MM-dd");
            Response response = read(fechaDesde, fechaHasta);
            if (response != null)
            {
                ConsultarDatos(response);
                GraficarDatos(response);
            }
        }

        private void ConsultarDatos(Response response)
        {
            Serie serie = response.seriesResponse.Series[0];
            treeView1.Nodes.Clear();

            TreeNode rootNode = new TreeNode(serie.Title);
            treeView1.Nodes.Add(rootNode);

            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;

                TreeNode node = new TreeNode();
                node.Text = "Fecha: " + dataSerie.Fecha + " - Precio: " + dataSerie.Data;
                rootNode.Nodes.Add(node);
            }

            treeView1.ExpandAll();
        }

        private void GraficarDatos(Response response)
        {
            chart1.Series.Clear();
            Serie serie = response.seriesResponse.Series[0];
            Series series = chart1.Series.Add(serie.Title);
            series.ChartType = SeriesChartType.Line;

            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;
                double precio = Convert.ToDouble(dataSerie.Data);
                DateTime fecha = DateTime.Parse(dataSerie.Fecha);
                series.Points.AddXY(fecha, precio);
            }
        }
        private static Response read(string fechaDesde, string fechaHasta)
        {
            try
            {
                string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/" + fechaDesde + "/" + fechaHasta;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "application/json";
                request.Headers["Bmx-Token"] = "69260904c3e398685c78e54928e7129fb21c7f79443e3c8b59e5c91f8319ef47";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(string.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                }
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Response jsonResponse = objResponse as Response;
                return jsonResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            if (maximizado)
            {
                chart1.Location = new System.Drawing.Point(436, 12);
                chart1.Height = 240; chart1.Width = 320;
                treeView1.Visible = true;
                lbInicio.Visible = true;
                lbFinal.Visible = true;
            }
            else
            {
                chart1.Location = new System.Drawing.Point(0, 0);
                chart1.Height = this.Height; chart1.Width = this.Width; 
                treeView1.Visible = false;
                lbInicio.Visible = false;
                lbFinal.Visible = false;
            }
            maximizado = !maximizado;
        }
    }
}
