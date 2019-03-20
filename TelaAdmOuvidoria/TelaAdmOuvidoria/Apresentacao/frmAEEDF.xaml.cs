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

namespace TelaAdmOuvidoria.Apresentacao
{
    /// <summary>
    /// Lógica interna para frmAEEDF.xaml
    /// </summary>
    public partial class frmAEEDF : Window
    {
        public frmAEEDF()
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

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        { 
            /*
            List<String> dadosRegistros = new List<string>();
            dadosRegistros.Add("0");
            dadosRegistros.Add(txbPer.Text);
            dadosRegistros.Add(txbRes.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.AtualizarDuvidas(dadosRegistros);
            MessageBox.Show(controle.mensagem);
            */
        }

        private void txbRes_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
