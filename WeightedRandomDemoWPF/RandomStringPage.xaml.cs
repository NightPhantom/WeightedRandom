using System;
using System.Windows;
using System.Windows.Controls;
using WeightedRandomLibrary;

namespace WeightedRandomDemoWPF
{
    /// <summary>
    /// Interaction logic for RandomStringPage.xaml
    /// </summary>
    public partial class RandomStringPage : Page
    {
        public RandomStringPage()
        {
            InitializeComponent();
        }

        private void getRandomStringButton_Click(object sender, RoutedEventArgs e)
        {
            var options = GetOptions();
            var weightedRandomizer = new WeightedRandomizer<string>(options);
            rollResultTextblock.Text = weightedRandomizer.Next().Value;
        }

        private Option<string>[] GetOptions()
        {
            return new []
            {
                new Option<string>(optionText1.Text, (int)Math.Floor(sliderWeight1.Value)),
                new Option<string>(optionText2.Text, (int)Math.Floor(sliderWeight2.Value)),
                new Option<string>(optionText3.Text, (int)Math.Floor(sliderWeight3.Value)),
                new Option<string>(optionText4.Text, (int)Math.Floor(sliderWeight4.Value)),
                new Option<string>(optionText5.Text, (int)Math.Floor(sliderWeight5.Value))
            };
        }
    }
}
