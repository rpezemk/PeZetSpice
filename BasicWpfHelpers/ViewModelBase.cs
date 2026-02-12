using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicWpfHelpers.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValueProp<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!field.Equals(value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }
    }

    public class ViewModelBase<T> : INotifyPropertyChanged
    {
        public ViewModelBase(T model)
        {
            Model = model;
        }
        public T? Model { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValueProp<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!field.Equals(value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
}
