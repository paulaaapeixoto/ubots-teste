using Newtonsoft.Json;

namespace Ubots.Modelo
{
    public class Cliente
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("cpf")]
        public string cpf { get; set; }
    }
}