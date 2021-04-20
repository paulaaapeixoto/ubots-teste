using Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Ubots.Modelo;

namespace Ubots.Repositorio
{
    public class ComprasRep
    {
        private static string URLCompras = "http://www.mocky.io/v2/598b16861100004905515ec7";


        public static List<Compras> Listar()
        {
            string result = GetRequest();

            var compras = JsonConvert.DeserializeObject<List<Compras>>(result);

            return compras;
        }


        public static List<Itens> ListarItens()
        {

            string result = GetRequest();

            List<Compras> compras = JsonConvert.DeserializeObject<List<Compras>>(result);

            List<Itens> listaItens = new List<Itens>();


            foreach (Compras cp in compras)
            {
                foreach (var item in cp.itens)
                {
                    listaItens.Add(item);
                }
            }

            return listaItens;
        }


        private static string GetRequest()
        {
            string URL = URLCompras;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            var result = "";
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
