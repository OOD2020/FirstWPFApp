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

namespace SecondWDFApp
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

        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            RollingDice();
        }
        public async void RollingDice()
        {

            Random random = new Random();

            //roll the dice
            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(1, 7);
                tblkDice.Text = number.ToString();
                await Task.Delay(50);
            }//end of loop
           
        }
    }
}
