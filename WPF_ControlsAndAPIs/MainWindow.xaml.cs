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

namespace WPF_ControlsAndAPIs
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

        private void RadioButtonClicked(object sender, RoutedEventArgs e)
        {
            switch ((sender as RadioButton)?.Content.ToString())
            {
                case "Ink Mode":
                    inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Erase Mode":
                    inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case "Select Mode":
                    inkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
            }

        }

        private void ColorChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }
    }
}
