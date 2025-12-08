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

        public double total = 0.00;


        private void btnSingleOlympian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Olympian", 12.50);
        }

        private void btnDoubleOlympian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Olympian", 14.50);
        }

        private void btnSingleParisian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Parisian", 12.50);
        }

        private void btnDoubleParisian_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Parisian", 14.50);
        }

        private void btnSingleRoma_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Roma", 12.50);
        }

        private void btnDoubleRoma_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Roma", 14.50);
        }

        private void btnSingleMatador_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Matador", 12.50);
        }

        private void btnDoubleMatador_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Matador", 14.50);
        }

        private void btnSingleKaiser_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Single Kaiser", 12.50);
        }

        private void btnDoubleKaiser_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Double Kaiser", 14.50);
        }

        private void btnNashvilleHot_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Nashville Hot", 10.50);
        }

        private void btnKyotoKatsu_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Kyoto Katsu", 12.50);
        }

        private void btnMarrakesh_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Marrakesh Chicken", 14.50);
        }

        private void btnBaja_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Baja Chicken", 14.50);
        }

        private void btnSeoulFire_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Seoul Fire", 14.50);
        }

        private void btnBangkokSatay_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Bangkok Satay Chicken", 12.50);
        }

        private void btnOaxaca_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Oaxaca Veggie", 10.50);
        }

        private void btnBombay_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Bombay Veggie", 12.50);
        }

        private void btnNordic_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Nordic Salmon", 12.50);
        }

        private void btnHavana_Click(object sender, RoutedEventArgs e)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            comboOption("Havana Fish", 12.50);
        }

        private void btnSmallFries_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Fries \n";
            txtPrices.Text += "$3.00\n";
            total += 3.00;
            totalAmount(total);

        }

        private void btnMediumFries_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Fires \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnLargeFries_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Fries \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
            totalAmount(total);
        }

        private void btnGarlicBread_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Garlic Bread \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnMozzarellaStick_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Mozzarella Sticks \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
            totalAmount(total);
        }

        private void btnSpringRoll_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Spring Rolls \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
            totalAmount(total);
        }

        private void btnLoadedNachos_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Loaded Nachos \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
            totalAmount(total);
        }

        private void btnPoutine_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Poutine \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
            totalAmount(total);
        }

        private void btnChocolateBrownie_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Chocolate Brownie \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnChurros_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Churros \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnTiramisuCup_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Tiramisu Cup \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
            totalAmount(total);
        }

        private void btnMochiIceCream_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Mochi Ice Cream \n";
            txtPrices.Text += "$5.00\n";
            total += 5.00;
            totalAmount(total);
        }

        private void btnCremeBrulee_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Creme Brulee \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
            totalAmount(total);
        }

        private void btnBaklavaBites_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Baklava Bites \n";
            txtPrices.Text += "$6.50\n";
            total += 6.50;
            totalAmount(total);
        }

        private void btnMatchaGreenTeaShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Matcha Green Tea Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnChurroCinnamonShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Churro Cinnamon Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnMangoLassiShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Mango Lassi Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnDulceDeLecheShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Dulce De Leche Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnDubaiChocolateShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Dubai Chocolate Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnPandanCoconutShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Pandan Coconut Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnTiramisuShake_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Tiramisu Shake \n";
            txtPrices.Text += "$6.00\n";
            total += 6.00;
            totalAmount(total);
        }

        private void btnSmallCoke_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Coke \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnSmallCokeNS_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Coke No Sugar \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnMediumCokeNS_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Coke No Sugar \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnLargeCokeNS_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Coke No Sugar \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnSmallJarritos_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Jarritos \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnLargeCoke_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Coke \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnMediumCoke_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Coke \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnMediumJarritos_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Jarritos \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnLargeJarritos_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Jarritos \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnSmallIrnBru_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Irn Bru \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnMediumIrnBru_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Irn Bru \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnLargeIrnBru_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Irn Bru \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnSmallLnP_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small L&P \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnMediumLnP_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium L&P \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnLargeLnP_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large L&P \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnSmallSparletta_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Sparletta \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnMediumSparletta_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Sparletta \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnLargeSparletta_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Sparletta \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnSmallTing_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Small Ting \n";
            txtPrices.Text += "$2.50\n";
            total += 2.50;
            totalAmount(total);
        }

        private void btnMediumTing_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Medium Ting \n";
            txtPrices.Text += "$3.50\n";
            total += 3.50;
            totalAmount(total);
        }

        private void btnLargeTing_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text += "Large Ting \n";
            txtPrices.Text += "$4.50\n";
            total += 4.50;
            totalAmount(total);
        }

        private void btnClearOrder_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
            txtPrices.Text = "";
            total = 0.0;
            totalAmount(total);
        }

        private void totalAmount(double amount)
        {
            txtTotal.Text = total.ToString("C");
        }


        /*
            private void btn{ FunctionName }_Click(object sender, RoutedEventArgs e)
            {
                txtOutput.Text += "{Insert Menu Item Title} \n";
                txtPrices.Text += "$0.00\n";
                total += 0.00;
            }
         */

        private void comboOption(string burger, double price)
        {
            MakeComboWindow makeCombo = new MakeComboWindow();
            makeCombo.ShowDialog();

                if (makeCombo.makeLarge == true)
                {
                    txtOutput.Text += burger.ToUpper() + " LARGE COMBO\n" +
                        burger + " Burger \n" +
                        "Large Fries \n" +
                        "Large Drink \n";

                    txtPrices.Text +=  (price + 7.5).ToString() + ".00\n\n\n\n";
                    total += price + 7.5;
                    totalAmount(total);

                    makeCombo.makeLarge = false;
                    makeCombo.Close();
                }
                else if (makeCombo.makeMedium == true)
                {
                    txtOutput.Text += burger.ToUpper() + " MEDIUM COMBO\n" +
                        burger + " Burger \n" +
                        "Medium Fries \n" +
                        "Medium Drink \n";

                    txtPrices.Text += (price + 5).ToString() + "0\n\n\n\n";
                    total += price + 5;
                    totalAmount(total);

                    makeCombo.makeMedium = false;
                    makeCombo.Close();
                }
                else if (makeCombo.makeJustBurger == true)
                {
                    txtOutput.Text += burger + " Burger \n";
                    txtPrices.Text += price + "0\n";
                    total += price;
                    totalAmount(total);

                    makeCombo.makeJustBurger = false;
                    makeCombo.Close();
                }
                else
                {
                    makeCombo.Close();
                }
        }
    }
}
