using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WeightedRandomLibrary;

namespace WeightedRandomDemoWPF
{
    /// <summary>
    /// Interaction logic for IterationsPage.xaml
    /// </summary>
    public partial class IterationsPage : Page
    {
        public IterationsPage()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {
            var options = GetOptions();
            var weightedRandomizer = new WeightedRandomizer<char>(options);
            var totalIterations = (int)Math.Floor(sliderIterations.Value);
            var results = RollForItems(weightedRandomizer, totalIterations);
            ShowTheResults(results, totalIterations);
        }

        private Option<char>[] GetOptions()
        {
            return new[]
            {
                new Option<char>(textBlockA.Text[0], (int)Math.Floor(sliderWeightA.Value)),
                new Option<char>(textBlockB.Text[0], (int)Math.Floor(sliderWeightB.Value)),
                new Option<char>(textBlockC.Text[0], (int)Math.Floor(sliderWeightC.Value)),
                new Option<char>(textBlockD.Text[0], (int)Math.Floor(sliderWeightD.Value))
            };
        }

        private void ShowTheResults(Dictionary<char, int> results, int totalIterations)
        {
            rollCountA.Minimum = 0;
            rollCountB.Minimum = 0;
            rollCountC.Minimum = 0;
            rollCountD.Minimum = 0;

            rollCountA.Maximum = totalIterations;
            rollCountB.Maximum = totalIterations;
            rollCountC.Maximum = totalIterations;
            rollCountD.Maximum = totalIterations;

            rollCountA.Value = results[textBlockA.Text[0]];
            rollCountB.Value = results[textBlockB.Text[0]];
            rollCountC.Value = results[textBlockC.Text[0]];
            rollCountD.Value = results[textBlockD.Text[0]];
        }

        private Dictionary<char, int> RollForItems(WeightedRandomizer<char> weightedRandomizer, int totalIterations)
        {

            // Results of rolls (option, count)
            var results = new Dictionary<char, int>()
            {
                { textBlockA.Text[0], 0 },
                { textBlockB.Text[0], 0 },
                { textBlockC.Text[0], 0 },
                { textBlockD.Text[0], 0 },
            };

            // Roll for items
            for (int i = 0; i < totalIterations; i++)
            {
                var pick = weightedRandomizer.Next().Value;

                results[pick]++;
            }

            return results;
        }
    }
}
