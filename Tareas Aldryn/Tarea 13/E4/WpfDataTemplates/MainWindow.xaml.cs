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

namespace WpfDataTemplates
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Company comp { set; get; }
        public MainWindow()
        {
            InitializeComponent();
            comp = new Company { CompanyName = "TutorialsPoint", TagLine = "Simply Easy Learning" };
            DataContext = this;
        }
    }
    public class Company
    {
        public string CompanyName { get; set; }
        public string TagLine { get; set; }
    }
}
