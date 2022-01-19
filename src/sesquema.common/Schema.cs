using System.Collections.Generic;
using Newtonsoft.Json;
using sesquema.common.Definitions;

namespace sesquema.common
{
    public class Schema
    {
        [JsonProperty("appid")]
        public uint AppId { get; set; }

        [JsonProperty("items")]
        public List<DefinitionBase> Definitions { get; set; }
    }
}
