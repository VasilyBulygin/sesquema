using System.Collections.Generic;
using Newtonsoft.Json;

namespace sesquema.common.Definitions
{
    /// <summary>
    /// Represents a collection of ItemDefs, with an associated quantity of each type. When this item is granted, it automatically expands into the set of items configured in the bundle property.
    /// </summary>
    public class BundleDefinition : DefinitionBase
    {
        /// <summary>
        /// Type and quantity of the contained bundle items
        /// </summary>
        [JsonProperty("bundle")]
        public List<BundleRecipe> BundleRecipes { get; set; }
    }
}
