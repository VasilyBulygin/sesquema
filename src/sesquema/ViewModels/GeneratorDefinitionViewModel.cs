using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
