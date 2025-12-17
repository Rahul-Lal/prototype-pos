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
            private double amountOwed;
        public PaymentWindow(double total)
        {
            InitializeComponent();
            amountOwed = total;
            txtTotalPrice.Text = amountOwed.ToString("0.00");
        }

        private void btnEftpos_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();

            
        }

        private void btnExactAmount_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            double totalAmount = home.total;
        }

        private void ApplyPayment(double amount)
        {
            amountOwed -= amount;
            txtTotalPrice.Text = amountOwed.ToString("0.00");
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
            ApplyPayment(50);

        }

        private void btnTwentyDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(20);
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
