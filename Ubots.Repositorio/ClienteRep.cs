using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Ubots.Modelo;

namespace Ubots.Repositorio
{
    public class ClienteRep
    {
        private static string URLClientes = "http://www.mocky.io/v2/598b16291100004705515ec5";

        public static List<Cliente> Listar()
        {
            string URL = URLClientes;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            var result = "";
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                result = reader.ReadToEnd();
            }

            var clientes = JsonConvert.DeserializeObject<List<Cliente>>(result);

            return clientes;
        }
    }
}
