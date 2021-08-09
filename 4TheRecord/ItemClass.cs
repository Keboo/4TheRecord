using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _4TheRecord
{
    public class ItemClass : INotifyPropertyChanged
    {
        public ItemClass(string name)
        {
            Name = name;
        }

        public string Name { get; }

        private bool _isDone;
        public bool IsDone
        {
            get => _isDone;
            set => SetProperty(ref _isDone, value);
        }

        private bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
