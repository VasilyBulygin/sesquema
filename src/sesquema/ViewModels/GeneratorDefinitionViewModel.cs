using JetBrains.Annotations;
using sesquema.protocol.Definitions;

namespace sesquema.ViewModels
{
    public class GeneratorDefinitionViewModel : DefinitionBaseViewModel<GeneratorDefinition>
    {
        public GeneratorDefinitionViewModel([NotNull] GeneratorDefinition model) : base(model)
        {
        }
    }
}
