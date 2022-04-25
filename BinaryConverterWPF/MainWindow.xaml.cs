using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using BinaryConverterLogic;

namespace BinaryConverterWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ToBinarioText_TextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = Regex.Replace(ToBinarioText.Text.Trim(), @"[a-z]|[A-Z]", "");
            ToBinarioText.Text = texto;


        }

        private void ToDecimalText_TextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = Regex.Replace(ToDecimalText.Text.Trim(), @"[a-z]|[A-Z]|[2-9]", "");
            ToDecimalText.Text = texto;

        }

        private void ToBinarioButton_Click(object sender, RoutedEventArgs e)
        { 
            BinaryConverterLogic.Logic logic = new Logic();
            var texto = ToBinarioText.Text;
            if (texto.Length < 20)
            {
                long input = Convert.ToInt64(texto);
                D2BResult.Text = logic.IntToBinary(input);
                ResB.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("El numero es muy grande!");
            }
        }

        private void ToDecimalButton_Click(object sender, RoutedEventArgs e)
        {
            BinaryConverterLogic.Logic logic = new Logic();
            var texto = ToDecimalText.Text;
            if (string.IsNullOrEmpty(texto))
            {
                texto = "0";
            }
            if (texto.Length < 20)
            {
                long input = Convert.ToInt64(texto);
                B2DResult.Text = logic.BinaryToInt(input).ToString();
                ResD.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("El numero es muy grande!");
            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ClearB2D_Click(object sender, RoutedEventArgs e)
        {
            ToDecimalText.Text = "";
            B2DResult.Text = "";
            ResD.Visibility = Visibility.Hidden;
        }

        private void ClearD2B_Click(object sender, RoutedEventArgs e)
        {
            ToBinarioText.Text = "";
            D2BResult.Text = "";
            ResB.Visibility = Visibility.Hidden;
        }
    }
}
