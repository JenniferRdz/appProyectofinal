using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace AppProyectoFinal
{
    public partial class FrmPrecio_del_dolar : Form
    {
        public FrmPrecio_del_dolar()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Response response = Read();
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

        private static Response Read()
        {
            try
            {
                string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/2023-01-31/2023-01-31";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "application/json";
                request.Headers["Bmx-Token"] = "69260904c3e398685c78e54928e7129fb21c7f79443e3c8b59e5c91f8319ef47";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(string.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Response jsonResponse = (Response)objResponse;

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
