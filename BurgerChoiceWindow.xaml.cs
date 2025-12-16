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
    /// Interaction logic for BurgerChoiceWindow.xaml
    /// </summary>
    public partial class BurgerChoiceWindow : Window
    {
        public BurgerChoiceWindow()
        {
            InitializeComponent();
        }

        public bool isOptionOne = false;
        public bool isOptionTwo = false;

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOptionOne_Click(object sender, RoutedEventArgs e)
        {
            isOptionOne = true;
            this.Close();
        }

        private void btnOptionTwo_Click(object sender, RoutedEventArgs e)
        {
            isOptionTwo = true;
            this.Close();
        }
    }
}
