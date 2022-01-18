using Newtonsoft.Json;

namespace sesquema.common.Definitions
{
    /// <summary>
    /// This is a special form of generator that can be granted by the ISteamInventory::TriggerItemDrop call from the application.
    /// </summary>
    public class PlaytimeGeneratorDefinition : DefinitionBase
    {
        /// <summary>
        /// If true, the "drop_limit" will be used to limit the items grant via ISteamInventory::TriggerItemDrop.
        /// </summary>
        [JsonProperty("use_drop_limit")]
        public bool UseDropLimit { get; set; }

        /// <summary>
        /// Limits for a specific user the number of times this item will be dropped via ISteamInventory::TriggerItemDrop. Setting to zero will prevent any future drops of this item.
        /// </summary>
        [JsonProperty("drop_limit")]
        public uint DropLimit { get; set; }

        /// <summary>
        /// Playtime in minutes before the item can be granted to the user.
        /// </summary>
        [JsonProperty("drop_interval")]
        public uint DropInterval { get; set; }

        /// <summary>
        ///  If true, the "drop_window" will be used for this itemdef.
        /// </summary>
        [JsonProperty("use_drop_window")]
        public bool UseDropWindow { get; set; }

        /// <summary>
        /// Elapsed time in minutes of a cool-down window before item will be granted.
        /// </summary>
        [JsonProperty("drop_window")]
        public uint DropWindow { get; set; }

        /// <summary>
        /// Numbers of grants within the window permitted before cooldown applies. Default value is 1.
        /// </summary>
        [JsonProperty("drop_max_per_window")]
        public uint DropMaxPerWindow { get; set; }
    }
}
