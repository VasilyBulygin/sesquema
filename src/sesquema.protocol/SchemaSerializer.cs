using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sesquema.protocol.Definitions;

namespace sesquema.protocol
{
    public static class SchemaSerializer
    {
        public static Schema Deserialize(TextReader textReader)
        {
            using var reader = new JsonTextReader(textReader);

            var serializer = new JsonSerializer();
            return serializer.Deserialize<Schema>(reader);
        }

        public static void Serialize(Schema schema, TextWriter textWriter)
        {
            using var writer = new JsonTextWriter(textWriter);
            var serializer = new JsonSerializer();
            serializer.Serialize(writer, schema);
        }
    }

    internal abstract class JsonCreationConverter<T> : JsonConverter
    {
        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType,
            object existingValue, JsonSerializer serializer)
        {
            try
            {
                var jObject = JObject.Load(reader);
                var target = Create(objectType, jObject);
                serializer.Populate(jObject.CreateReader(), target);
                return target;
            }
            catch (JsonReaderException)
            {
                return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value,
            JsonSerializer serializer)
        {
            var item = (DefinitionBase) value;
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteValue(item.Type);
            writer.WritePropertyName("id");
            writer.WriteValue(item.Id);
            writer.WriteEndObject();
        }
    }

    internal class DefinitionConverter : JsonCreationConverter<DefinitionBase>
    {
        protected override DefinitionBase Create(Type objectType, JObject jObject)
        {
            var type = jObject["type"].Value<string>();
            switch (type)
            {
                case DefinitionTypes.Item:
                    return new ItemDefinition();
                case DefinitionTypes.Bundle:
                    return new BundleDefinition();
                case DefinitionTypes.Generator:
                    return new GeneratorDefinition();
                case DefinitionTypes.PlaytimeGenerator:
                    return new PlaytimeGeneratorDefinition();
                case DefinitionTypes.TagGenerator:
                    return new TagGeneratorDefinition();
                default:
                    return default;
            }
        }
    }
}
