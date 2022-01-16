namespace sesquema.common.Definitions
{
    /// <summary>
    /// This is a special form of generator that can be granted by the ISteamInventory::TriggerItemDrop call from the application.
    /// </summary>
    public class PlaytimeGeneratorDefinition : DefinitionBase
    {
        //use_drop_limit
        public bool UseDropLimit { get; set; }

        //drop_limit
        public uint DropLimit { get; set; }

        //drop_interval
        public uint DropInterval { get; set; }

        //use_drop_window
        public bool UseDropWindow { get; set; }

        //drop_window
        public uint DropWindow { get; set; }

        //drop_max_per_window
        public uint DropMaxPerWindow { get; set; }
    }
}
