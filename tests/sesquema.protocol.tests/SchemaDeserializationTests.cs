using System.IO;
using NUnit.Framework;

namespace sesquema.protocol.tests
{
    public class SchemaDeserializationTests
    {
        [Test]
        [TestCase("{\"appid\": 123456,\"items\": []}")]
        [TestCase("{\"appid\": 123456}")]
        public void SchemaSerializer_should_deserialize_with_no_items(string json)
        {
            //Arrange
            using var reader = new StringReader(json);

            //Act
            var schema = SchemaSerializer.Deserialize(reader);

            //Assert
            Assert.NotNull(schema, "schema is null");
            Assert.AreEqual(schema.AppId, 123456);
            Assert.NotNull(schema.Definitions, "schema.Definitions is null");
        }

        [Test]
        public void SchemaSerializer_should_deserialize_with_items()
        {
            //Arrange
            const string json = "{\r\n\"appid\": 123456,\r\n\"items\": [\r\n{\n\"itemdefid\": 100,\n\"type\":\"item\",\n\"name\":\"Test\",\n\"name_color\":\"3498db\",\n\"item_slot\":\"slot\",\n\"icon_url\": \"https://picsum.photos/200/200.jpg\",\n\"icon_url_large\":\"https://picsum.photos/500/500.jpg\",\n\"tradable\":false,\n\"marketable\":false,\n\"hidden\":true,\n\"commodity\":true,\n\"tags\":\"type:test_tag\"\n}\r\n]\r\n}";
            using var reader = new StringReader(json);

            //Act
            var schema = SchemaSerializer.Deserialize(reader);

            //Assert
            Assert.NotNull(schema);
            Assert.AreEqual(schema.AppId, 123456);
            Assert.NotNull(schema.Definitions);
            Assert.AreEqual(schema.Definitions.Count, 1);
        }
    }
}