using System;
using System.Collections.Generic;

namespace sesquema.common.Definitions
{
    public abstract class DefinitionBase
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
        public string Bundle { get; set; }

        //promo
        public string Promo { get; set; }

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

        //store_tags
        public string StoreTags { get; set; }

        //store_images
        public string StoreImages { get; set; }

        //hidden
        public bool Hidden { get; set; }

        //store_hidden
        public bool StoreHidden { get; set; }

        //granted_manually
        public bool GrantedManually { get; set; }

        //use_bundle_price
        public bool UseBundlePrice { get; set; }

        //auto_stack
        public bool AutoStack { get; set; }

        public List<ExtendedProperty> ExtendedProperties { get; set; }
    }
}
