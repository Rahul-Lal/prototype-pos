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

namespace Prototype
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void btnEftpos_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;

            
        }

        private void btnExactAmount_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
        }

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
        }

        private void btnHundredDollars_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
            totalAmount -= 100.0;
            txtTotalPrice.Text = totalAmount.ToString();

        }

        private void btnFiftyDollars_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
            totalAmount -= 50.0;
            txtTotalPrice.Text = totalAmount.ToString();

        }

        private void btnTwentyDollars_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            txtTotalPrice.Text = home.total.ToString();
            double totalAmount = home.total;
            totalAmount -= 20.00;
            txtTotalPrice.Text = totalAmount.ToString();


        }

        private void btnTenDollars_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
            totalAmount -= 10.0;
            txtTotalPrice.Text = totalAmount.ToString();

        }

        private void btnFiveDollars_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
            totalAmount -= 5.0;
            txtTotalPrice.Text = totalAmount.ToString();

        }
    }
}
