﻿


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace PayWhirl.Models
{

    public class Data
    {

        [JsonProperty("object")]
        public Object Object { get; set; }
    }

}
