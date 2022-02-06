using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
