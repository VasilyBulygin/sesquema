using Avalonia.Media;
using sesquema.protocol.Definitions;

namespace sesquema.ViewModels
{
    public class ItemDefinitionViewModel : BaseViewModel<ItemDefinition>
    {
        public ItemDefinitionViewModel(ItemDefinition model) : base(model)
        {
        }

        public int Id => Model.Id;

        public string IconUrl
        {
            get => Model.IconUrl;
            set
            {
                Model.IconUrl = value;
                OnPropertyChanged();
            }
        }

        public string IconUrlLarge
        {
            get => Model.IconUrlLarge;
            set
            {
                Model.IconUrlLarge = value;
                OnPropertyChanged();
            }
        }

        public bool Hidden
        {
            get => Model.Hidden;
            set
            {
                Model.Hidden = value;
                OnPropertyChanged();
            }
        }

        public bool StoreHidden
        {
            get => Model.StoreHidden;
            set
            {
                Model.StoreHidden = value;
                OnPropertyChanged();
            }
        }

        public bool GrantedManually
        {
            get => Model.GrantedManually;
            set
            {
                Model.GrantedManually = value;
                OnPropertyChanged();
            }
        }

        public bool AutoStack
        {
            get => Model.AutoStack;
            set
            {
                Model.AutoStack = value;
                OnPropertyChanged();
            }
        }

        public bool Tradable
        {
            get => Model.Tradable;
            set
            {
                Model.Tradable = value;
                OnPropertyChanged();
            }
        }

        public bool Marketable
        {
            get => Model.Marketable;
            set
            {
                Model.Marketable = value;
                OnPropertyChanged();
            }
        }

        public Color NameColor
        {
            get => Color.Parse(Model.NameColor);
            set
            {
                Model.NameColor = value.ToString();
                OnPropertyChanged();
            }
        }

        public Color BackgroundColor
        {
            get => Color.Parse(Model.BackgroundColor);
            set
            {
                Model.BackgroundColor = value.ToString();
                OnPropertyChanged();
            }
        }
    }
}
