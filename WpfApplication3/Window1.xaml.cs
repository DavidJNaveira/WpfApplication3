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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Agencia_TextChanged(object sender, TextChangedEventArgs e)
        {
            int Agencia;

        }

        private void Conta_TextChanged(object sender, TextChangedEventArgs e)
        {
            int Conta;
        }

        private void NomeCompleto_TextChanged(object sender, TextChangedEventArgs e)
        {
            String Cliente;
        }

        private void DataNasc_TextChanged(object sender, TextChangedEventArgs e)
        {
            DateTime DataNasc;
        }

        private void CPF_TextChanged(object sender, TextChangedEventArgs e)
        {
            int CPF;
        }

        private void Valor_TextChanged(object sender, TextChangedEventArgs e)
        {
#pragma warning disable 0168
            Decimal Valor;
#pragma warning restore 0168
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            mwin.Show();
            this.Close();
        }

        private void Cliente_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Deposito_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
