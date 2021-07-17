using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PRUEBAController : ApiController
    {
        [HttpPost]
        public int CantidadDeVecesPalabraFrase(string pvFrase, string pvPalabra, string pvToken)
        {
            int Cantidad = 0;
            String[] palabras;
            try
            {
                if (ConfigurationManager.AppSettings["TOKEN"].ToString() == pvToken)
                {
                    pvFrase = pvFrase.Replace(",", "");
                    pvFrase = pvFrase.Replace(".", "");
                    palabras = pvFrase.Split();
                    Cantidad = palabras.Where(x => x == pvPalabra).Count();
                    return Cantidad;
                }
                else
                {
                    Cantidad = 401;
                    return Cantidad;
                }
            }
            catch (Exception)
            {
                Cantidad = 0;
                throw;
            }

        }

    }
}
