using System.Collections.Generic;
using Newtonsoft.Json;
using sesquema.common.Definitions;

namespace sesquema.common
{
    /// <summary>
    /// Inventory schema.
    /// </summary>
    public class Schema
    {
        /// <summary>
        /// Application identifier.
        /// </summary>
        [JsonProperty("appid")]
        public uint AppId { get; set; }

        /// <summary>
        /// List of all item definitions.
        /// </summary>
        [JsonProperty("items")]
        public List<DefinitionBase> Definitions { get; set; }
    }
}
