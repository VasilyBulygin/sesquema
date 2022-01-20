using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using sesquema.protocol.Definitions;

namespace sesquema.protocol
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

    public class DefinitionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
