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
using System.Data;
using System.Data.SqlClient;

namespace Tarea3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String cs = @"Data Source=DESKTOP-KSNKPUR\SQLEXPRESS;Initial Catalog=tarea3;Integrated Security=True";
            String sql = @"SELECT * FROM USUARIO";
            DataTable tabla = new DataTable();
            SqlConnection c = new SqlConnection(cs);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, c);
            adapter.Fill(tabla);
            DataGrid1.DataContext = tabla;
            c.Close();

        }
    }
}
