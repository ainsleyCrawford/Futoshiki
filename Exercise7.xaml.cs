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

namespace Futoshiki
{
    /// <summary>
    /// Interaction logic for Exercise7.xaml
    /// </summary>
    public partial class Exercise7 : Window
    {
        public Exercise7()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            int oneOne = 4, twoOne = 3, threeOne = 2, fourOne = 1;
            int oneTwo = 2, twoTwo = 1, threeTwo = 3, fourTwo = 4;
            int oneThree = 3, twoThree = 4, threeThree = 1, fourThree = 2;
            int oneFour = 1, twoFour = 2, threeFour = 4, fourFour = 3;

            int oneOneInput, twoOneInput, threeOneInput, fourOneInput;
            int oneTwoInput, twoTwoInput, threeTwoInput, fourTwoInput;
            int oneThreeInput, twoThreeInput, threeThreeInput, fourThreeInput;
            int oneFourInput, twoFourInput, threeFourInput, fourFourInput;

            oneOneInput = Convert.ToInt32(OneOne.Text); twoOneInput = Convert.ToInt32(TwoOne.Text); threeOneInput = Convert.ToInt32(ThreeOne.Text); fourOneInput = Convert.ToInt32(FourOne.Text);
            oneTwoInput = Convert.ToInt32(OneTwo.Text); twoTwoInput = Convert.ToInt32(TwoTwo.Text); threeTwoInput = Convert.ToInt32(ThreeTwo.Text); fourTwoInput = Convert.ToInt32(FourTwo.Text);
            oneThreeInput = Convert.ToInt32(OneThree.Text); twoThreeInput = Convert.ToInt32(TwoThree.Text); threeThreeInput = Convert.ToInt32(ThreeThree.Text); fourThreeInput = Convert.ToInt32(FourThree.Text);
            oneFourInput = Convert.ToInt32(OneFour.Text); twoFourInput = Convert.ToInt32(TwoFour.Text); threeFourInput = Convert.ToInt32(ThreeFour.Text); fourFourInput = Convert.ToInt32(FourFour.Text);

            if (oneOneInput == oneOne & twoOneInput == twoOne & threeOneInput == threeOne & fourOneInput == fourOne
                & oneTwoInput == oneTwo & twoTwoInput == twoTwo & threeTwoInput == threeTwo & fourTwoInput == fourTwo
                & oneThreeInput == oneThree & twoThreeInput == twoThree & threeThreeInput == threeThree & fourThreeInput == fourThree
                & oneFourInput == oneFour & twoFourInput == twoFour & threeFourInput == threeFour & fourFourInput == fourFour)
            {
                MessageBox.Show("Superb!");
                Exercise8 exercise8 = new Exercise8();
                exercise8.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong answer. Keep trying!");
            }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You have not filled in all the boxes.");
            }
        }
    }
}
