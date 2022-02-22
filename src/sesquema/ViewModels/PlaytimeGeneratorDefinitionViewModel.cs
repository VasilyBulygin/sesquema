using sesquema.protocol.Definitions;

namespace sesquema.ViewModels
{
    public class PlaytimeGeneratorDefinitionViewModel : DefinitionBaseViewModel<PlaytimeGeneratorDefinition>
    {
        public PlaytimeGeneratorDefinitionViewModel(PlaytimeGeneratorDefinition model) : base(model)
        {
        }

        public bool UseDropLimit
        {
            get => Model.UseDropLimit;
            set
            {
                Model.UseDropLimit = value;
                OnPropertyChanged();
            }
        }

        public bool UseDropWindow
        {
            get => Model.UseDropWindow;
            set
            {
                Model.UseDropWindow = value;
                OnPropertyChanged();
            }
        }

        public uint DropInterval
        {
            get => Model.DropInterval;
            set
            {
                Model.DropInterval = value;
                OnPropertyChanged();
            }
        }
    }
}
