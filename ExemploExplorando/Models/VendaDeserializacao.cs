using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class VendaDeserializacao
    {
        public int Id { get; set; }

        //Conversão de atributos Json
        //[JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}