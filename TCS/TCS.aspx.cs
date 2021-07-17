using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TCS
{
    public partial class TCS : System.Web.UI.Page
    {
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                idDrownList.DataSource = txtArea.InnerText.Split();
                idDrownList.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnCalcularCantidades_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                String stResultado = string.Empty;
                String stUrlApi = "https://localhost:44331/api/PRUEBA?pvFrase={pvFraseAReemplazar}&pvPalabra={pvPalabraAReemplazar}&pvToken={pvToken}";

                stUrlApi = stUrlApi.Replace("{pvFraseAReemplazar}", txtArea.InnerText);
                stUrlApi = stUrlApi.Replace("{pvPalabraAReemplazar}", idDrownList.SelectedValue.ToString());
                stUrlApi = stUrlApi.Replace("{pvToken}", "America.1927");

                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                wc.Headers.Add(HttpRequestHeader.Accept, "application/json");

                stResultado = wc.UploadString(stUrlApi, "POST");

                MessageBox.Show("La palabra " + idDrownList.SelectedValue.ToString() + " se encuentra " + stResultado + " veces en la frase " + txtArea.InnerText);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}