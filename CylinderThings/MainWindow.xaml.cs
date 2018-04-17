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
using System.Windows.Threading;

namespace CylinderThings
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

        private void clickHereButton_Click(object sender, RoutedEventArgs e)
        {
            double userHeight = Convert.ToInt32(cylinderHeightTextBox.Text); // Had to convert to Int32 to get the volume and area variables to calculate.
            double userRadius = Convert.ToInt32(cylinderRadiusTextBox.Text);
            double pi = 3.1415926;
            string units = unitsTextBox.Text;
            decimal volume = Convert.ToDecimal(pi * userRadius * userRadius * userHeight);
            decimal area = Convert.ToDecimal(2 * pi * userRadius * (userRadius + userHeight));
            volume = Math.Round(volume, 2); // Restricts answer to two decimal places.
            area = Math.Round(area, 2);

            clickHereTextBlock.Text = "Hang on just a sec...";

            // This next bit creates a 'pause for tension...'

            clickHereTextBlock.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate ()
            {
                clickHereTextBlock.UpdateLayout();
            }));
            clickHereTextBlock.Text = "Here y' go...";
            clickHereTextBlock.FontSize = 34;
            System.Threading.Thread.Sleep(2000);


            // and then we carry on working out the answers

            cylinderHeightLabel.Visibility = Visibility.Hidden; // Just to declutter the UI and make room for the 'Boom' image.
            cylinderRadiusLabel.Visibility = Visibility.Hidden;
            enterYourUnitsLabel.Visibility = Visibility.Hidden;            
            boomImage.Visibility = Visibility.Visible;
            cylinderVolumeTextBlock.Text = "The volume of your cylinder is " + volume + " cubic " + units +".";
            cylinderAreaTextBlock.Text = "The surface area of your cylinder is " + area + " square " + units + ".";            
            resetButton.Visibility = Visibility.Visible;
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            cylinderHeightTextBox.Text = "10";
            cylinderRadiusTextBox.Text = "4";
            unitsTextBox.Text = "cm";
            clickHereTextBlock.Text = "Click Here To Work The Magic";
            clickHereTextBlock.FontSize = 24;
            cylinderVolumeTextBlock.Text = "Volume";
            cylinderAreaTextBlock.Text = "Area";            
            resetButton.Visibility = Visibility.Hidden;
            boomImage.Visibility = Visibility.Hidden;
            cylinderHeightLabel.Visibility = Visibility.Visible;
            cylinderRadiusLabel.Visibility = Visibility.Visible;
            enterYourUnitsLabel.Visibility = Visibility.Visible;
        }

        private void squareStuffButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void squareStuffButton_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
