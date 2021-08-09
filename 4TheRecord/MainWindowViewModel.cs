using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace _4TheRecord
{
    public record MainWindowViewModel
    {
        public ObservableCollection<ItemClass> Items { get; } = new();

        public IList<ItemClass>? SelectedItems { get; set; }

        public ICommand Toggle { get; }

        public MainWindowViewModel()
        {
            Items.Add(new ItemClass("First"));
            Items.Add(new ItemClass("Second"));
            Items.Add(new ItemClass("Third"));
            Items.Add(new ItemClass("Fourth"));

            Toggle = new RelayCommand(OnToggle);
        }

        private void OnToggle()
        {
            foreach(var item in SelectedItems ?? Enumerable.Empty<ItemClass>())
            {
                item.IsDone = !item.IsDone;
            }
        }
    }
}
