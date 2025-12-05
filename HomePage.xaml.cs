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

namespace Prototype
{
    /// <summary>
    /// Interaction logic for EuropeanBurgers.xaml
    /// </summary>
    public partial class EuropeanBurgers : Page
    {
        public EuropeanBurgers()
        {
            InitializeComponent();
        }

        double total = 0.0;

        private void btnSingleOlympian_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Single Olympian Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnDoubleOlympian_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Double Olympian Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnSingleParisian_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Single Parisian Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnDoubleParisian_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Double Parisian Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnSingleRoma_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Single Roma Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnDoubleRoma_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Double Roma Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnSingleMatador_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Single Matador Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnDoubleMatador_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Double Matador Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnSingleKaiser_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Single Kaiser Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnDoubleKaiser_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Double Kaiser Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnNashvilleHot_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Nashville Hot Chicken Burger \n";
            txtPrices.Text += "$10.50\n";
            total += 10.50;
        }

        private void btnKyotoKatsu_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Kyoto Katsu Chicken Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnMarrakesh_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Marrakesh Chicken Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnBaja_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Baja Chicken Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnSeoulFire_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Seoul Fire Chicken Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnBangkokSatay_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Bangkok Satay Chicken Burger \n";
            txtPrices.Text += "$14.50\n";
            total += 14.50;
        }

        private void btnOaxaca_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Oaxaca Veggie Burger \n";
            txtPrices.Text += "$10.50\n";
            total += 10.50;
        }

        private void btnBombay_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Bombay Veggie Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnNordic_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Nordic Salmon Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnHavana_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Havana Fish Burger \n";
            txtPrices.Text += "$12.50\n";
            total += 12.50;
        }

        private void btnSmallFries_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Fries \n";
            txtPrices.Text += "$3.00\n";
            total += 3.00;

        }

        private void btnMediumFries_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Fires \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
        }

        private void btnLargeFries_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Fries \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
        }

        private void btnGarlicBread_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Garlic Bread \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
        }

        private void btnMozzarellaStick_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Mozzarella Sticks \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
        }

        private void btnSpringRoll_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Spring Rolls \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
        }

        private void btnLoadedNachos_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Loaded Nachos \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
        }

        private void btnPoutine_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Poutine \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
        }

        private void btnChocolateBrownie_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Chocolate Brownie \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
        }

        private void btnChurros_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Churros \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
        }

        private void btnTiramisuCup_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Tiramisu Cup \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
        }

        private void btnMochiIceCream_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Mochi Ice Cream \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
        }

        private void btnCremeBrulee_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Creme Brulee \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
        }

        private void btnBaklavaBites_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Baklava Bites \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
        }

        private void btnMatchaGreenTeaShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Matcha Green Tea Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnChurroCinnamonShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Churro Cinnamon Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnMangoLassiShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Mango Lassi Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnDulceDeLecheShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Dulce De Leche Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnDubaiChocolateShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Dubai Chocolate Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnPandanCoconutShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Pandan Coconut Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnTiramisuShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Tiramisu Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
        }

        private void btnSmallCoke_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSmallCokeNS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumCokeNS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeCokeNS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSmallJarritos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeCoke_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumCoke_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumJarritos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeJarritos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSmallIrnBru_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumIrnBru_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeIrnBru_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSmallLnP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumLnP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeLnP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSmallSparletta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumSparletta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeSparletta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSmallTing_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumTing_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLargeTing_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearOrder_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
            txtPrices.Text = "";
            total = 0.0;
        }

        /*
            private void btn{ FunctionName }_Click(object sender, RoutedEventArgs e)
            {
                txtOutput.Text += "{Insert Menu Item Title} \n";
                txtPrices.Text += "$0.00\n";
                total += 0.00;
            }
         */
    }
}
