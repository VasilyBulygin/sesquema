using sesquema.protocol.Definitions;

namespace sesquema.ViewModels
{
    public abstract class DefinitionBaseViewModel<T> : BaseViewModel<T> where T : DefinitionBase
    {
        protected DefinitionBaseViewModel(T model) : base(model)
        {
        }
    }
}
