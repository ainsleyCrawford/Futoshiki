using System;
using System.Windows;

namespace Futoshiki
{
    public partial class Exercise1 : Window
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int oneOne = 2, twoOne = 4, threeOne = 1, fourOne = 3;
                int oneTwo = 1, twoTwo = 3, threeTwo = 4, fourTwo = 2;
                int oneThree = 4, twoThree = 2, threeThree = 3, fourThree = 1;
                int oneFour = 3, twoFour = 1, threeFour = 2, fourFour = 4;

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
                    MessageBox.Show("Success! \nLet's try another");
                    Exercise2 exercise2 = new Exercise2();
                    exercise2.Show();
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
