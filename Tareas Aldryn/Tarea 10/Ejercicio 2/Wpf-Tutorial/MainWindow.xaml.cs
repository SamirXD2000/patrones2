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
using Wpf_Tutorial.Models;

namespace Wpf_Tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Name = "Hola mundo";
        public MainWindow()
        {
            InitializeComponent();
            MyModelObject boton1DataContext = new MyModelObject() { Name = "Soy un boton" };
            MyModelObject boton2DataContext = new MyModelObject() { BadName = "Soy el boton 2" };

            boton1.DataContext = boton1DataContext;
            boton2.DataContext = boton2DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainGridPanel.Background = Brushes.Purple;

        }
    }
}
