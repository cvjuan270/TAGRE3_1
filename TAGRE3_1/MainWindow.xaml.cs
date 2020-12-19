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

namespace AppBase
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DemoItemsListBox_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MenuToggleButton.IsChecked = false;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridContenedor.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    GridContenedor.Children.Add(usc);
                    break;
                case "ItemUsuario":
                    usc = new UserControlUsuario();
                    GridContenedor.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }
    }
}
