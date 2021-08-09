using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _4TheRecord
{
    public class ItemClass : INotifyPropertyChanged, IEquatable<ItemClass>
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

        public override bool Equals(object? obj)
        {
            return Equals(obj as ItemClass);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_isDone, Name);
        }

        public bool Equals(ItemClass? other)
        {
            if (other is { } item)
            {
                return item._isDone = _isDone &&
                    item.Name == Name;
            }
            return false;
        }

        public static bool operator !=(ItemClass? left, ItemClass? right)
        {
            return !(left == right);
        }

        public static bool operator ==(ItemClass? left, ItemClass? right)
        {
            return left == right || (left != null && left.Equals(right));
        }
    }
}
