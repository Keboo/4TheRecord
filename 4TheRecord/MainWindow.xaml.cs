using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _4TheRecord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            var viewModel = (MainWindowViewModel)DataContext;
            viewModel.SelectedClasses = dataGrid.SelectedItems.OfType<ItemClass>().ToList();
        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            var viewModel = (MainWindowViewModel)DataContext;
            viewModel.SelectedRecords = dataGrid.SelectedItems.OfType<ItemRecord>().ToList();
        }
    }
}
