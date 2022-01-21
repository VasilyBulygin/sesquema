using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace sesquema.protocol.Definitions
{
    /// <summary>
    /// Base item definition class
    /// </summary>
    [JsonConverter(typeof(DefinitionConverter))]
    public abstract class DefinitionBase
    {
        /// <summary>
        /// Internal value. ('item' | 'bundle' | 'generator' | 'playtimegenerator' | 'tag_generator')
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        //itemdefid
        /// <summary>
        /// The ID of this itemdef
        /// </summary>
        [JsonProperty("itemdefid")]
        public int Id { get; set; }

        //name
        /// <summary>
        /// Localizable name of the item. Default language is english.
        /// </summary>
        [JsonProperty("name")]
        [JsonConverter(typeof(LocalizablePropertyConverter))]
        public LocalizableProperty Name { get; set; }

        //description
        /// <summary>
        /// Localizable description of the item. Default language is english.
        /// </summary>
        [JsonProperty("description")]
        [JsonConverter(typeof(LocalizablePropertyConverter))]
        public LocalizableProperty Description { get; set; }

        //display_type
        /// <summary>
        /// Localizable description of item's "type". Default language is english.
        /// </summary>
        [JsonProperty("display_type")]
        [JsonConverter(typeof(LocalizablePropertyConverter))]
        public LocalizableProperty DisplayType { get; set; }

        //promo
        [JsonProperty("promo")]
        public string Promo { get; set; }
        
        /// <summary>
        /// UTC timestamp - prevent promo grants before this time, only applicable when promo = manual.
        /// </summary>
        [JsonProperty("drop_start_time")]
        public DateTime? DropStartTime { get; set; }
        
        [JsonProperty("exchange")]
        public ExchangeRecipe Exchange { get; set; }
        
        [JsonProperty("price")]
        public string Price { get; set; }
        
        /// <summary>
        /// A preset price which is handled by Valve itself.
        /// </summary>
        [JsonProperty("price_category")]
        public PriceCategory PriceCategory { get; set; }

        /// <summary>
        /// The color to display in the inventory background as 6 hex digits.
        /// </summary>
        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }
        
        /// <summary>
        /// The color to display the name in the inventory as 6 hex digits.
        /// </summary>
        [JsonProperty("name_color")]
        public string NameColor { get; set; }
        
        /// <summary>
        /// The URL to the item's small icon. The URL should be publicly accessible because the Steam servers will download and cache. Recommended size is 200x200.
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
        
        /// <summary>
        /// The URL to the item's large image. The URL should be publicly accessible because the Steam servers will download and cache. Recommended size is 2048x2048.
        /// </summary>
        [JsonProperty("icon_url_large")]
        public string IconUrlLarge { get; set; }
        
        /// <summary>
        /// Whether this item can be sold to other users in the Steam Community Market.
        /// </summary>
        [JsonProperty("marketable")]
        public bool Marketable { get; set; }
        
        /// <summary>
        /// Whether this item can be traded to other users using Steam Trading.
        /// </summary>
        [JsonProperty("tradable")]
        public bool Tradable { get; set; }

        //tags
        [JsonProperty("tags")]
        public string Tags { get; set; }
        
        /// <summary>
        /// List of tag_generator item definition ids to apply
        /// </summary>
        [JsonProperty("tag_generators")]
        public string TagGenerators { get; set; }
        
        /// <summary>
        /// Name of the tag category token
        /// </summary>
        [JsonProperty("tag_generator_name")]
        public string TagGeneratorName { get; set; }
        
        /// <summary>
        /// List of tag values and the chance that they will be picked
        /// </summary>
        [JsonProperty("tag_generator_values")]
        public string TagGeneratorValues { get; set; }
        
        /// <summary>
        /// String with "tags" delimited by ";" character. These tags will be used to categorize/filter items in the Steam item store for your app.
        /// </summary>
        [JsonProperty("store_tags")]
        public string StoreTags { get; set; }
        
        /// <summary>
        /// Image URLs delimited by ";" character. These images will be proxied and used on the detail page of the Steam item store for your app.
        /// </summary>
        [JsonProperty("store_images")]
        public string StoreImages { get; set; }
        
        /// <summary>
        /// If true, the item definition will not be shown to clients. Use this to hide unused, or under-development, item definitions.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
        
        /// <summary>
        /// If true, this item will be hidden in the Steam Item Store for your app. By default, any items with a price will be shown in the store.
        /// </summary>
        [JsonProperty("store_hidden")]
        public bool StoreHidden { get; set; }
        
        /// <summary>
        /// If true, will only be granted when AddPromoItem() or AddPromoItems() are called with the explicit item definition id. Otherwise, it may be granted via the GrantPromoItems() call. Defaults to false.
        /// </summary>
        [JsonProperty("granted_manually")]
        public bool GrantedManually { get; set; }

        //use_bundle_price
        [JsonProperty("use_bundle_price")]
        public bool UseBundlePrice { get; set; }
        
        /// <summary>
        /// If true, item grants will automatically be added to a single stack of the given type. Grants will be visible in inventory callbacks as quantity changes. Defaults to false.
        /// </summary>
        [JsonProperty("auto_stack")]
        public bool AutoStack { get; set; }

        /// <summary>
        /// Additional properties beyond standard schema
        /// </summary>
        public List<ExtendedProperty> ExtendedProperties { get; set; }
    }

    /// <summary>
    /// 'item' | 'bundle' | 'generator' | 'playtimegenerator' | 'tag_generator
    /// </summary>
    public static class DefinitionTypes
    {
        public const string Item = "item";
        public const string Bundle = "bundle";
        public const string Generator = "generator";
        public const string PlaytimeGenerator = "playtimegenerator";
        public const string TagGenerator = "tag_generator";
    }
}
