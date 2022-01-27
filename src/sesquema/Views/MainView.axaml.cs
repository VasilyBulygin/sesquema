using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using sesquema.ViewModels;

namespace sesquema.Views
{
    public partial class MainView : Window
    {
        public MainView(MainViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public MainView() : this(new MainViewModel())
        {

        }

        public MainViewModel ViewModel { get; }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
