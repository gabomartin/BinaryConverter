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
           
        }

        private void ToDecimalText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ToBinarioButton_Click(object sender, RoutedEventArgs e)
        { 
            BinaryConverterLogic.Logic logic = new Logic();
            long input = Convert.ToInt64(ToBinarioText.Text);
            D2BResult.Text = logic.IntToBinary(input);
        }

        private void ToDecimalButton_Click(object sender, RoutedEventArgs e)
        {
            BinaryConverterLogic.Logic logic = new Logic();
            long input = Convert.ToInt64(ToDecimalText.Text);
            B2DResult.Text = logic.BinaryToInt(input).ToString();
        }
    }
}
