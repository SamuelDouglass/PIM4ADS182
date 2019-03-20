using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Lógica interna para frmPCPI.xaml
    /// </summary>
    public partial class frmPCPI : Window
    {
        public frmPCPI()
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

        private void btnPPID_Click(object sender, RoutedEventArgs e)
        {
            List<String> dadosRegistros = new List<string>();
            dadosRegistros.Add(txbID.Text);
            dadosRegistros.Add("");
            dadosRegistros.Add("");
            dadosRegistros.Add("");
            dadosRegistros.Add("");
            dadosRegistros.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Registros registros = controle.PesquisarPorID(dadosRegistros);
            if (controle.mensagem.Equals(""))
            {
                txbNome.Text = registros.nome;
                txbRA.Text = registros.ra;
                txbCPF.Text = registros.cpf;
                txbAssunto.Text = registros.assunto;
                txbEmail.Text = registros.email;
                txbTexto.Text = registros.texto;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnResponder_Click(object sender, RoutedEventArgs e)
        {
            SmtpClient usuario = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //definição de configurações do usuario
            usuario.Host = "smtp.gmail.com";
            usuario.Port = 587;
            usuario.EnableSsl = true;
            usuario.DeliveryMethod = SmtpDeliveryMethod.Network;
            usuario.UseDefaultCredentials = false;

            //definição de credenciais de acesso ao email
            credenciais.UserName = "emailparatestescsharp";
            credenciais.Password = "testeteste10";

            //definição das credenciais do usuario
            usuario.Credentials = credenciais;

            //preparar para enviar a mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("emailparatestescsharp@gmail.com");
            mensagem.Subject = (txbAssunto.Text);
            mensagem.IsBodyHtml = true;
            mensagem.Body = ("Olá aluno " + txbNome.Text + " Segue resposta da sua dúvida : <br><br>" + txbTextoR.Text);
            mensagem.To.Add(txbEmail.Text);

            //Envio do email
            try
            {
                usuario.Send(mensagem);
                MessageBox.Show("Resposta enviada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel enviar a resposta.");
            }

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
