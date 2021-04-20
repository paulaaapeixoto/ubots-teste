using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Compras
    {
        [JsonProperty("codigo")]
        public string codigo { get; set; }

        [JsonProperty("data")]
        public string data { get; set; }

        [JsonProperty("cliente")]
        public string cliente { get; set; }

        [JsonProperty("itens")]
        public List<Itens> itens { get; set; }

        [JsonProperty("valorTotal")]
        public double valorTotal { get; set; }
    }
}

