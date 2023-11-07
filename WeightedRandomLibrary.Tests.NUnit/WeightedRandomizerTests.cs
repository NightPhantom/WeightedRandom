namespace WeightedRandomLibrary.Tests.NUnit;

[TestFixture]
public class WeightedRandomizerTests
{
    [Test]
    public void Constructor_OptionsEmpty_ThrowsArgumentException()
    {
        // Arrange
        var options = new Option<int>[0];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new WeightedRandomizer<int>(options));
    }

    [Test]
    public void Next_GivenOptions_ReturnsOption()
    {
        // Arrange
        var options = new[]
        {
            new Option<int>(1, 30),
            new Option<int>(2, 50),
            new Option<int>(3, 20)
        };
        var randomizer = new WeightedRandomizer<int>(options);

        // Act
        var result = randomizer.Next();

        // Assert
        Assert.Contains(result.Value, options.Select(o => o.Value).ToArray()); // Ensure the result is one of the provided options
    }

    [Test]
    public void Next_Randomization_WithinTolerance()
    {
        // Arrange
        var options = new[]
        {
            new Option<int>(1, 30),
            new Option<int>(2, 50),
            new Option<int>(3, 20)
        };
        var randomizer = new WeightedRandomizer<int>(options);

        var totalWeight = 30 + 50 + 20;
        var totalIterations = 100000;

        // Calculate the expected counts based on weights
        var expectedCounts = new Dictionary<Option<int>, int>();
        foreach (var option in options)
        {
            expectedCounts[option] = (int)Math.Round((double)option.Weight / totalWeight * totalIterations);
        }

        // Define the tolerance for randomness
        const double tolerance = 0.02; // 2%

        // Act
        var resultCounts = new Dictionary<Option<int>, int>();

        for (int i = 0; i <totalIterations; i++)
        {
            var result = randomizer.Next();

            if (resultCounts.ContainsKey(result))
            {
                resultCounts[result]++;
            }
            else
            {
                resultCounts[result] = 1;
            }
        }

        // Assert (the observed counts are within the tolerance of expected counts)
        foreach (var option in options)
        {
            int observedCount = resultCounts.ContainsKey(option) ? resultCounts[option] : 0;
            int expectedCount = expectedCounts[option];

            double relativeError = Math.Abs((observedCount - expectedCount) / (double)expectedCount);

            Assert.True(relativeError < tolerance);
        }
    }

    [Test]
    public void Next_GivenSeed_ResultsAlwaysMatch()
    {
        // Arrange
        var options = new[]
        {
            new Option<int>(1, 30),
            new Option<int>(2, 50),
            new Option<int>(3, 20)
        };
        var seed = DateTime.Now.Ticks;
        var randomizer1 = new WeightedRandomizer<int>(options, (int)seed);
        var randomizer2 = new WeightedRandomizer<int>(options, (int)seed);
        var totalIterations = 100;

        // Act & Assert
        for (int i = 0; i < totalIterations; i++)
        {
            Assert.That(randomizer2.Next(), Is.EqualTo(randomizer1.Next()));
        }
    }

    [Test]
    public void Next_WeightsTotalZero_ThrowsException()
    {
        // Arrange
        var badOption = new Option<int>(1, 10);

        // Use reflection to set the Value and Weight properties
        typeof(Option<int>).GetProperty("Weight").SetValue(badOption, 0, null);

        var options = new[]
        {
            badOption
        };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new WeightedRandomizer<int>(options));
    }
}