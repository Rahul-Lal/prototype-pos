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
        private readonly HomePage _home;

        public PaymentWindow(HomePage home, double total)
        {
            InitializeComponent();
            _home = home;
            amountOwed = total;
            txtTotalPrice.Text = amountOwed.ToString("0.00");
        }

        private void btnEftpos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EFTPOS Accepted!");
            amountOwed -= amountOwed;
            totalPaid();
            clearOutput();
        }

        private void btnExactAmount_Click(object sender, RoutedEventArgs e)
        {
            amountOwed -= amountOwed;
            totalPaid();
            clearOutput();
        }

        private void ApplyPayment(double amount)
        {
            // amountOwed -= amount;


            txtTotalPrice.Text = amountOwed.ToString("0.00");
            double change = amount - amountOwed;
            amountOwed = 0;
            txtTotalPrice.Text = "0.00";

            MessageBox.Show($"Change: ${change:0.00}");
            clearOutput();
            this.Close();
        }

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            double cashInput = double.Parse(txtCash.Text);

            if (cashInput < amountOwed)
            {
                MessageBox.Show($"Insufficient cash. Need ${amountOwed:0.00}");
                return;
            }
            else if (cashInput < amountOwed)
            {
                MessageBox.Show("Insufficient cash provided. Please provide at least $" + amountOwed);
            }
            else
            {
                MessageBox.Show("Payment Complete. Thank you for your purchase!");
                this.Close();
            }

            double change = cashInput - amountOwed;
            amountOwed = 0;
            txtTotalPrice.Text = "0.00";

            MessageBox.Show($"Change: ${change:0.00}");
            clearOutput();
            this.Close();
        }

        private void btnHundredDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(100);
            totalPaid();
        }

        private void btnFiftyDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(50);
            totalPaid();
        }

        private void btnTwentyDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(20);
            totalPaid();
        }

        private void btnTenDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(10);
            totalPaid();
        }

        private void btnFiveDollars_Click(object sender, RoutedEventArgs e)
        {
            ApplyPayment(5);
            totalPaid();
        }

        private void totalPaid()
        {
            if (amountOwed == 0.00)
            {
                MessageBox.Show("Payment Complete. Thank you for your purchase!");
                this.Close();
            }
        }

        private void clearOutput()
        {
            _home.txtOutput.Text = "";
            _home.txtPrices.Text = "";
            _home.total = 0.0;
            _home.txtTotal.Text = _home.total.ToString("C");
        }

    }
}
