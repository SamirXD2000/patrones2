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

namespace Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para DPControl.xaml
    /// </summary>
    public partial class DPControl : UserControl
    {
        public DPControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SetTextProperty = DependencyProperty.Register("SetText", typeof(string), typeof(DPControl), new PropertyMetadata(""));

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        }

        private static void OnSetTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DPControl dpcontrol1 = d as DPControl;
            dpcontrol1.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            txtBlock1.Text = e.NewValue.ToString();
        }
    }
}
