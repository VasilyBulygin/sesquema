using System.IO;
using NUnit.Framework;

namespace sesquema.protocol.tests
{
    public class SchemaSerializationTests
    {
        [Test]
        [TestCase("{\"appid\":123456,\"items\":[]}")]
        public void Should_serialize_with_no_items(string expectedJson)
        {
            //Arrange
            var schema = new Schema {AppId = 123456};
            using var writer = new StringWriter();

            //Act
            SchemaSerializer.Serialize(schema, writer);
            var json = writer.ToString();

            //Assert
            Assert.AreEqual(json, expectedJson);
        }
    }
}
