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
using System.Windows.Shapes;

namespace ResolveTemplates
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        private MainViewModel model;

        public SettingsWindow(MainViewModel model)
        {
            InitializeComponent();
            DataContext = model;
            this.model = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.Templates.Add(new Template
            {
                Name = "Template"
            });
        }
    }
}
