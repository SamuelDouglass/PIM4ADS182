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

namespace PIM4ADS4182
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Modelo.Controle Controle
        {
            get => default(Modelo.Controle);
            set
            {
            }
        }

        private void btnDuvidasFrequentes_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmDuvidasFrequentes frmD = new Apresentacao.frmDuvidasFrequentes();
            frmD.ShowDialog();
        }

        private void btnJanelaDeEnvio_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmJanelaDeEnvio frmJDE = new Apresentacao.frmJanelaDeEnvio();
            frmJDE.ShowDialog();
        }
    }
}
