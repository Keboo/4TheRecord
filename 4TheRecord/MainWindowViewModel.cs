using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace _4TheRecord
{
    public class MainWindowViewModel
    {

        public ObservableCollection<ItemClass> ItemClassess { get; } = new();
        public IList<ItemClass>? SelectedClasses { get; set; }
        public ICommand ToggleClasses { get; }

        public ObservableCollection<ItemRecord> ItemRecords { get; } = new();
        public IList<ItemRecord>? SelectedRecords { get; set; }

        public ICommand ToggleRecords { get; }

        public MainWindowViewModel()
        {
            ItemClassess.Add(new ItemClass("First"));
            ItemClassess.Add(new ItemClass("Second"));
            ItemClassess.Add(new ItemClass("Third"));
            ItemClassess.Add(new ItemClass("Fourth"));
            ToggleClasses = new RelayCommand(OnToggleClasses);

            ItemRecords.Add(new ItemRecord("First"));
            ItemRecords.Add(new ItemRecord("Second"));
            ItemRecords.Add(new ItemRecord("Third"));
            ItemRecords.Add(new ItemRecord("Fourth"));
            ToggleRecords = new RelayCommand(OnToggleRecords);
        }

        private void OnToggleClasses()
        {
            foreach (var item in SelectedClasses ?? Enumerable.Empty<ItemClass>())
            {
                item.IsDone = !item.IsDone;
            }
        }

        private void OnToggleRecords()
        {
            foreach (var item in SelectedRecords ?? Enumerable.Empty<ItemRecord>())
            {
                item.IsDone = !item.IsDone;
            }
        }
    }
}
