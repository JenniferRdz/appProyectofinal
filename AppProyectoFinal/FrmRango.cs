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

namespace AppProyectoFinal
{
    public partial class FrmRango : Form
    {
        public FrmRango()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fechaDesde = dtpDesde.Value.ToString("yyyy-MM-dd");
            string fechaHasta = dtpHasta.Value.ToString("yyyy-MM-dd");
            Response response = read(fechaDesde, fechaHasta);
            ConsultarDatos(response);
        }

        private void ConsultarDatos(Response response)
        {
            Serie serie = response.seriesResponse.Series[0];
            lbSerie.Text = "Serie: " + serie.Title;

            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;
                lbFecha.Text = "Fecha: " + dataSerie.Fecha;
                lbPrecio.Text = "Precio: " + dataSerie.Data;
            }

            Console.ReadLine();
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
    }
}
