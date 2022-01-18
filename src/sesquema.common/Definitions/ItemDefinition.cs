using Newtonsoft.Json;

namespace sesquema.common.Definitions
{
    /// <summary>
    /// An item type that can be found in a player inventory.
    /// </summary>
    public class ItemDefinition : DefinitionBase
    {
        /// <summary>
        /// Id to the linked workshop item
        /// </summary>
        [JsonProperty("workshopid")]
        public int WorkshopId { get; set; }
    }
}
