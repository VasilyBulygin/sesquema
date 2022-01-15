using System;
using System.Collections.Generic;

namespace sesquema.common
{
    public abstract class ItemDef
    {
        //type
        public string type { get; set; }

        //itemdefid
        public int Id { get; set; }

        //name
        public LocalizableProperty Name { get; set; }
        
        //description
        public LocalizableProperty Description { get; set; }

        //display_type
        public LocalizableProperty DisplayType { get; set; }

        //bundle
        public string bundle { get; set; }

        //promo
        public string promo { get; set; }

        //drop_start_time
        public DateTime? DropStartTime { get; set; }

        //exchange
        public ExchangeRecipe Exchange { get; set; }

        //price
        public string Price { get; set; }

        //price_category
        public string PriceCategory { get; set; }

        //background_color
        public string BackgroundColor { get; set; }

        //name_color
        public string NameColor { get; set; }

        //icon_url
        public string IconUrl { get; set; }

        //icon_url_large
        public string IconUrlLarge { get; set; }

        //marketable
        public bool Marketable { get; set; }

        //tradable
        public bool Tradable { get; set; }

        //tags
        public string Tags { get; set; }

        //tag_generators
        public string TagGenerators { get; set; }

        //tag_generator_name
        public string TagGeneratorName { get; set; }

        //tag_generator_values
        public string TagGeneratorValues { get; set; }

        public string store_tags { get; set; }

        public string store_images { get; set; }

        public bool hidden { get; set; }

        public bool store_hidden { get; set; }

        public bool use_drop_limit { get; set; }

        public uint drop_limit { get; set; }

        public uint drop_interval { get; set; }

        public bool use_drop_window { get; set; }

        public uint drop_window { get; set; }

        public uint drop_max_per_window { get; set; }

        public bool granted_manually { get; set; }

        public bool use_bundle_price { get; set; }

        public bool auto_stack { get; set; }

        public List<ExtendedProperty> ExtendedProperties { get; set; }
    }
}
