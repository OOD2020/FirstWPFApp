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

namespace FirstWPFApp
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

        private void TbxName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxName.Clear();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            // read name entered in the text box 
            string input = tbxName.Text;

            //display message
           // MessageBox.Show("Hi " + input);
            MessageBox.Show("Hi " + input, "Information",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Information);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
