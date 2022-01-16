using System;
using System.Collections.Generic;

namespace sesquema.common.Definitions
{
    public abstract class DefinitionBase
    {
        //type
        /// <summary>
        /// Internal value. ('item' | 'bundle' | 'generator' | 'playtimegenerator' | 'tag_generator')
        /// </summary>
        public string type { get; set; }

        //itemdefid
        /// <summary>
        /// The ID of this itemdef
        /// </summary>
        public int Id { get; set; }

        //name
        /// <summary>
        /// Localizable name of the item. Default language is english.
        /// </summary>
        public LocalizableProperty Name { get; set; }

        //description
        /// <summary>
        /// Localizable description of the item. Default language is english.
        /// </summary>
        public LocalizableProperty Description { get; set; }

        //display_type
        /// <summary>
        /// Localizable description of item's "type". Default language is english.
        /// </summary>
        public LocalizableProperty DisplayType { get; set; }

        //bundle
        public string Bundle { get; set; }

        //promo
        public string Promo { get; set; }

        //drop_start_time
        /// <summary>
        /// UTC timestamp - prevent promo grants before this time, only applicable when promo = manual.
        /// </summary>
        public DateTime? DropStartTime { get; set; }

        //exchange
        public ExchangeRecipe Exchange { get; set; }

        //price
        public string Price { get; set; }

        //price_category
        /// <summary>
        /// A preset price which is handled by Valve itself.
        /// </summary>
        public string PriceCategory { get; set; }

        //background_color
        /// <summary>
        /// The color to display in the inventory background as 6 hex digits.
        /// </summary>
        public string BackgroundColor { get; set; }

        //name_color
        /// <summary>
        /// The color to display the name in the inventory as 6 hex digits.
        /// </summary>
        public string NameColor { get; set; }

        //icon_url
        /// <summary>
        /// The URL to the item's small icon. The URL should be publicly accessible because the Steam servers will download and cache. Recommended size is 200x200.
        /// </summary>
        public string IconUrl { get; set; }

        //icon_url_large
        /// <summary>
        /// The URL to the item's large image. The URL should be publicly accessible because the Steam servers will download and cache. Recommended size is 2048x2048.
        /// </summary>
        public string IconUrlLarge { get; set; }

        //marketable
        /// <summary>
        /// Whether this item can be sold to other users in the Steam Community Market.
        /// </summary>
        public bool Marketable { get; set; }

        //tradable
        /// <summary>
        /// Whether this item can be traded to other users using Steam Trading.
        /// </summary>
        public bool Tradable { get; set; }

        //tags
        public string Tags { get; set; }

        //tag_generators
        /// <summary>
        /// List of tag_generator item definition ids to apply
        /// </summary>
        public string TagGenerators { get; set; }

        //tag_generator_name
        /// <summary>
        /// Name of the tag category token
        /// </summary>
        public string TagGeneratorName { get; set; }

        //tag_generator_values
        /// <summary>
        /// List of tag values and the chance that they will be picked
        /// </summary>
        public string TagGeneratorValues { get; set; }

        //store_tags
        /// <summary>
        /// String with "tags" delimited by ";" character. These tags will be used to categorize/filter items in the Steam item store for your app.
        /// </summary>
        public string StoreTags { get; set; }

        //store_images
        /// <summary>
        /// Image URLs delimited by ";" character. These images will be proxied and used on the detail page of the Steam item store for your app.
        /// </summary>
        public string StoreImages { get; set; }

        //hidden
        /// <summary>
        /// If true, the item definition will not be shown to clients. Use this to hide unused, or under-development, item definitions.
        /// </summary>
        public bool Hidden { get; set; }

        //store_hidden
        /// <summary>
        /// If true, this item will be hidden in the Steam Item Store for your app. By default, any items with a price will be shown in the store.
        /// </summary>
        public bool StoreHidden { get; set; }

        //granted_manually
        /// <summary>
        /// If true, will only be granted when AddPromoItem() or AddPromoItems() are called with the explicit item definition id. Otherwise, it may be granted via the GrantPromoItems() call. Defaults to false.
        /// </summary>
        public bool GrantedManually { get; set; }

        //use_bundle_price
        public bool UseBundlePrice { get; set; }

        //auto_stack
        /// <summary>
        /// If true, item grants will automatically be added to a single stack of the given type. Grants will be visible in inventory callbacks as quantity changes. Defaults to false.
        /// </summary>
        public bool AutoStack { get; set; }

        public List<ExtendedProperty> ExtendedProperties { get; set; }
    }
}
