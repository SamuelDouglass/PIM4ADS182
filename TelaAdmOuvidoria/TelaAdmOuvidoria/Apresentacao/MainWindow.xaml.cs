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

namespace TelaAdmOuvidoria
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

        private void mniAEEDF_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmAEEDF frmAEEDF = new Apresentacao.frmAEEDF();
            frmAEEDF.ShowDialog();
        }

        private void mniPCPI_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmPCPI frmPCPI = new Apresentacao.frmPCPI();
            frmPCPI.ShowDialog();
        }

        private void btnEnvio_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmPCPI frmPCPI = new Apresentacao.frmPCPI();
            frmPCPI.ShowDialog();
        }
    }
}