namespace sesquema.common
{
    /// <summary>
    /// Bundle item recipe
    /// </summary>
    public class BundleRecipe
    {
        /// <summary>
        /// Id of item definition.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Desired quantity. Zero will be interpreted as one.
        /// </summary>
        public uint Quantity { get; set; }
    }
}
