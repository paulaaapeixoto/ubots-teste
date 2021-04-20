using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Itens
    {
        [JsonProperty("produto")]
        public string produto { get; set; }

        [JsonProperty("variedade")]
        public string variedade { get; set; }

        [JsonProperty("pais")]
        public string pais { get; set; }

        [JsonProperty("categoria")]
        public string categoria { get; set; }

        [JsonProperty("safra")]
        public string safra { get; set; }

        [JsonProperty("preco")]
        public double preco { get; set; }

    }
}
