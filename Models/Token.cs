﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PayWhirl.Models
{

    public class TokenInfo
    {

        [JsonProperty("token")]
        public string Token { get; set; }
    }

}
