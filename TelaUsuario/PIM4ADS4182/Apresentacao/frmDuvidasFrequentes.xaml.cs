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

namespace PIM4ADS4182.Apresentacao
{
    /// <summary>
    /// Lógica interna para frmDuvidasFrequentes.xaml
    /// </summary>
    public partial class frmDuvidasFrequentes : Window
    {
        public frmDuvidasFrequentes()
        {
            InitializeComponent();

        }

        public MainWindow MainWindow
        {
            get => default(MainWindow);
            set
            {
            }
        }

        private void btnVoltarDF_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
