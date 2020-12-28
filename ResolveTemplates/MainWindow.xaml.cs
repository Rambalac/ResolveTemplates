using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ResolveTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel model;

        public MainWindow()
        {
            InitializeComponent();
            model = DataContext as MainViewModel;
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            var files=e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files is null)
            {
                return;
            }

            model.AddFiles(files);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var settingsWindow = new SettingsWindow(model);
            settingsWindow.ShowDialog();
        }
    }
}
