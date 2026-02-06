using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PeZetSpice.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetProp<T>(ref T field, T value, [CallerMemberName] string propertyName = null) where T : class
        {
            if (field != value)
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
}
