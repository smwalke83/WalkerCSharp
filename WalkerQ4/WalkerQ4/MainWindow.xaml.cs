// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: MainWindow.xaml.cs

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WalkerQ4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Creates an array of the base type to contain each fuel
        private EnergyTypeBase[] fuels = new EnergyTypeBase[3];

        // Constructor, initializes the window  and populates the fuel array with three different types of fuel object
        public MainWindow()
        {
            InitializeComponent();
            fuels[0] = new Gasoline();
            fuels[1] = new Ethanol();
            fuels[2] = new Methanol();
        }

        // Handlin clicking the get info button
        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            // Sets the index value based on which radio button is clicked (Gasoline, Ethanol, Methanol)
            int index;
            if (rbGasoline.IsChecked == true)
            {
                index = 0;
            }
            else if (rbEthanol.IsChecked == true)
            {
                index = 1;
            }
            else 
            {
                index = 2;
            }

            // Sets the summary to the summary text block, using polymorphism to call the methods on the object regardless of the child class it belongs to
            txblSummary.Text = fuels[index].GetName() + " is a " + fuels[index].GetEnergyType() + " fuel.\n"
                + "Its specific energy is " + fuels[index].GetSpecificEnergy() + " MJ/kg.\n"
                + "Its energy density is " + fuels[index].GetEnergyDensity() + " MJ/L.";
        }
    }
}