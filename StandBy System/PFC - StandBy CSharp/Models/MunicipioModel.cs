using System;
using System.Collections.Generic;

using System.Globalization;
using Bunifu.Json;

namespace PFC___StandBy_CSharp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class MunicipioModel
    {
        public class Temperatures
        {
            public long Id { get; set; }
            public string Nome { get; set; }
            public Municipio Municipio { get; set; }
        }

        public class Municipio
        {
            public long Id { get; set; }
            public string Nome { get; set; }
            public Microrregiao Microrregiao { get; set; }
            public RegiaoImediata RegiaoImediata { get; set; }
        }

        public class Microrregiao
        {
            public long Id { get; set; }
            public string Nome { get; set; }
            public Mesorregiao Mesorregiao { get; set; }
        }

        public class Mesorregiao
        {
            public long Id { get; set; }
            public string Nome { get; set; }
            public Uf Uf { get; set; }
        }

        public class Uf
        {
            public long Id { get; set; }
            public string Sigla { get; set; }
            public string Nome { get; set; }
            public Uf Regiao { get; set; }
        }

        public class RegiaoImediata
        {
            public long Id { get; set; }
            public string Nome { get; set; }
            public Mesorregiao RegiaoIntermediaria { get; set; }
        }
    }
}