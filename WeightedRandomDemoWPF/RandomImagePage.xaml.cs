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
using WeightedRandomLibrary;

namespace WeightedRandomDemoWPF
{
    /// <summary>
    /// Interaction logic for RandomImagePage.xaml
    /// </summary>
    public partial class RandomImagePage : Page
    {
        public RandomImagePage()
        {
            InitializeComponent();
        }

        private void getRandomImageButton_Click(object sender, RoutedEventArgs e)
        {
            var options =  GetOptions();
            var weightRandomizer = new WeightedRandomizer<ImageSource>(options);
            resultImage.Source = weightRandomizer.Next().Value;
            resultImage.Visibility = Visibility.Visible;
            resultPlaceholderText.Visibility = Visibility.Collapsed;
        }

        private Option<ImageSource>[] GetOptions()
        {
            return new[]
            {
                new Option<ImageSource>(image1.Source, (int)Math.Floor(sliderWeight1.Value)),
                new Option<ImageSource>(image2.Source, (int)Math.Floor(sliderWeight2.Value)),
                new Option<ImageSource>(image3.Source, (int)Math.Floor(sliderWeight3.Value)),
                new Option<ImageSource>(image4.Source, (int)Math.Floor(sliderWeight4.Value))
            };
        }
    }
}
