using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace sesquema.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public abstract class BaseViewModel<TModel> : BaseViewModel
    {
        private TModel _model;

        protected BaseViewModel(TModel model)
        {
            _model = model;
        }

        public TModel Model
        {
            get => _model;
            protected set
            {
                _model = value;
                OnPropertyChanged();
            }
        }
    }
}
