﻿using System;
using Newtonsoft.Json;
namespace Main.models
{
    public class Venda
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}