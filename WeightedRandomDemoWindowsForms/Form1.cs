using System.Drawing;
using WeightedRandomLibrary;

namespace WeightedRandomDemoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarIterations_ValueChanged(object sender, EventArgs e)
        {
            textBoxIterationCount.Text = trackBarIterations.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxIterationCount.Text = trackBarIterations.Value.ToString();
        }

        #region Itetation demo

        private void buttonRunIterations_Click(object sender, EventArgs e)
        {
            var options = GetIterationOptions();
            var weightedRandomizer = new WeightedRandomizer<char>(options);
            var totalIterations = trackBarIterations.Value;
            var results = RollForItems(weightedRandomizer, totalIterations);
            ShowTheResults(results, totalIterations);
        }

        private Option<char>[] GetIterationOptions()
        {
            return new[]
            {
                new Option<char>(optionA.Text[0], weightA.Value),
                new Option<char>(optionB.Text[0], weightB.Value),
                new Option<char>(optionC.Text[0], weightC.Value),
                new Option<char>(optionD.Text[0], weightD.Value)
            };
        }

        private Dictionary<char, int> RollForItems(WeightedRandomizer<char> weightedRandomizer, int totalIterations)
        {
            // Results of rolls (option, count)
            var results = new Dictionary<char, int>()
            {
                { optionA.Text[0], 0 },
                { optionB.Text[0], 0 },
                { optionC.Text[0], 0 },
                { optionD.Text[0], 0 },
            };

            // Roll for items
            for (int i = 0; i < totalIterations; i++)
            {
                var pick = weightedRandomizer.Next().Value;

                results[pick]++;
            }

            return results;
        }

        private void ShowTheResults(Dictionary<char, int> results, int totalIterations)
        {
            rollCountA.Maximum = totalIterations;
            rollCountB.Maximum = totalIterations;
            rollCountC.Maximum = totalIterations;
            rollCountD.Maximum = totalIterations;

            rollCountA.Value = results[optionA.Text[0]];
            rollCountB.Value = results[optionB.Text[0]];
            rollCountC.Value = results[optionC.Text[0]];
            rollCountD.Value = results[optionD.Text[0]];
        }

        #endregion Iteration Demo

        #region Image demo

        private void buttonGetImage_Click(object sender, EventArgs e)
        {
            var options = GetImageOptions();
            var weightedRandomizer = new WeightedRandomizer<Image>(options);
            resultImage.Image = weightedRandomizer.Next().Value;
        }

        private Option<Image>[] GetImageOptions()
        {
            return new[]
            {
                new Option<Image>(picture1.Image, imageWeight1.Value),
                new Option<Image>(picture2.Image, imageWeight2.Value),
                new Option<Image>(picture3.Image, imageWeight3.Value),
                new Option<Image>(picture4.Image, imageWeight4.Value)
            };
        }

        #endregion Image demo

        #region Word demo

        private void buttonGetWord_Click(object sender, EventArgs e)
        {
            var options = GetWordOptions();
            var weightedRandomizer = new WeightedRandomizer<string>(options);
            resultText.Text = weightedRandomizer.Next().Value;

        }

        private Option<string>[] GetWordOptions()
        {
            return new[]
            {
                new Option<string>(word1.Text, wordWeight1.Value),
                new Option<string>(word2.Text, wordWeight2.Value),
                new Option<string>(word3.Text, wordWeight3.Value),
                new Option<string>(word4.Text, wordWeight4.Value),
                new Option<string>(word5.Text, wordWeight5.Value),
            };
        }

        #endregion Word demo
    }
}