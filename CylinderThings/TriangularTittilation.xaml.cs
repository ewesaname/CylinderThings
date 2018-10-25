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
    /// Interaction logic for TriangularTittilation.xaml
    /// </summary>
    public partial class TriangularTittilation : Window
    {
        public TriangularTittilation()
        {
            InitializeComponent();
        }

        private void clickHereButton_Click(object sender, RoutedEventArgs e)
        {
            double triangleBaseLength = Convert.ToDouble(triangleBaseLengthTextbox.Text);
            double triangleHeight = Convert.ToDouble(triangleHeightTextbox .Text);
            string rectangleUnits = triangleUnitsTextbox.Text;
            decimal squareArea = Convert.ToDecimal(triangleBaseLength/2  * triangleHeight);

            triangleAreaTextBlock.Text = ("The area of your triangle is ") + squareArea + " square " + triangleUnitsTextbox.Text;
        }
    }
}
