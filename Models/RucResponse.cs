using Newtonsoft.Json;

namespace RucConsultaApp.Models
{
    public class RucResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("ruc")]
        public string Ruc { get; set; }

        [JsonProperty("nombre_o_razon_social")]
        public string NombreORazonSocial { get; set; }

        [JsonProperty("estado_del_contribuyente")]
        public string EstadoDelContribuyente { get; set; }

        [JsonProperty("condicion_de_domicilio")]
        public string CondicionDeDomicilio { get; set; }

        [JsonProperty("ubigeo")]
        public string Ubigeo { get; set; }

        [JsonProperty("tipo_de_via")]
        public string TipoDeVia { get; set; }

        [JsonProperty("nombre_de_via")]
        public string NombreDeVia { get; set; }

        [JsonProperty("codigo_de_zona")]
        public string CodigoDeZona { get; set; }

        [JsonProperty("tipo_de_zona")]
        public string TipoDeZona { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("interior")]
        public string Interior { get; set; }

        [JsonProperty("lote")]
        public string Lote { get; set; }

        [JsonProperty("dpto")]
        public string Dpto { get; set; }

        [JsonProperty("manzana")]
        public string Manzana { get; set; }

        [JsonProperty("kilometro")]
        public string Kilometro { get; set; }

        [JsonProperty("departamento")]
        public string Departamento { get; set; }

        [JsonProperty("provincia")]
        public string Provincia { get; set; }

        [JsonProperty("distrito")]
        public string Distrito { get; set; }

        [JsonProperty("direccion")]
        public string Direccion { get; set; }

        [JsonProperty("direccion_completa")]
        public string DireccionCompleta { get; set; }

        [JsonProperty("ultima_actualizacion")]
        public string UltimaActualizacion { get; set; }
    }
}
