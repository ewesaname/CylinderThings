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

namespace CylinderThings
{
    /// <summary>
    /// Interaction logic for RectangleRulesWindow.xaml
    /// </summary>
    public partial class RectangleRulesWindow : Window
    {
        public RectangleRulesWindow()
        {
            InitializeComponent();
        }
                
        private void clickHereButton_Click(object sender, RoutedEventArgs e)
        {

            double rectangleLength = Convert.ToDouble(rectangleLengthTextBox.Text);
            double rectangleWidth = Convert.ToDouble(rectangleWidthTextBox.Text);
            string rectangleUnits = rectangleUnitsTextbox.Text;
            decimal squareArea = Convert.ToDecimal(rectangleLength * rectangleWidth);

            squareAreaTextBlock.Text = ("The area of your square is ") + squareArea + (" square ") + rectangleUnitsTextbox.Text; 
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            rectangleLengthTextBox.Text = ("");
            rectangleWidthTextBox.Text = ("");
            rectangleUnitsTextbox.Text = ("");

            squareAreaTextBlock.Text = ("Area:");

            //this.Close();       
        }
    }
}
