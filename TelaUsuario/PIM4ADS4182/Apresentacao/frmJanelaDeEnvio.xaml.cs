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
    /// Lógica interna para frmJanelaDeEnvio.xaml
    /// </summary>
    public partial class frmJanelaDeEnvio : Window
    {
        public frmJanelaDeEnvio()
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

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            List<String> dadosRegistros = new List<string>();
            dadosRegistros.Add("0");
            dadosRegistros.Add(txbNome.Text);
            dadosRegistros.Add(txbRA.Text);
            dadosRegistros.Add(txbCPF.Text);
            dadosRegistros.Add(txbAssunto.Text);
            dadosRegistros.Add(txbEmail.Text);
            dadosRegistros.Add(txbTexto.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EnivarRegistros(dadosRegistros);
            MessageBox.Show(controle.mensagem);
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
