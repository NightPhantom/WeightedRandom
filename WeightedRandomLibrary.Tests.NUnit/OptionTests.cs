namespace WeightedRandomLibrary.Tests.NUnit;

[TestFixture]
public class OptionTests
{
    [Test]
    public void Constructor_WithValidWeight_ValuesMatch()
    {
        // Arrange
        var expectedValue = 42;
        var expectedWeight = 50;

        // Act
        var option = new Option<int>(expectedValue, expectedWeight);

        // Assert
        Assert.That(option.Value, Is.EqualTo(expectedValue));
        Assert.That(option.Weight, Is.EqualTo(expectedWeight));
    }

    [Test]
    public void Constructor_WithZeroWeight_ThrowsArgumentException()
    {
        // Arrange
        var expectedValue = 42;
        var expectedWeight = 0;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Option<int>(expectedValue, expectedWeight));
    }

    [Test]
    public void Constructor_WithNegativeWeight_ThrowsArgumentException()
    {
        // Arrange
        var expectedValue = 42;
        var expectedWeight = -50;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Option<int>(expectedValue, expectedWeight));
    }

    [Test]
    public void CopyConstructor_ValuesMatch()
    {
        // Arrange
        var originalOption = new Option<int>(42, 50);

        // Act
        var copiedOption = new Option<int>(originalOption);

        // Assert
        Assert.That(copiedOption.Value, Is.EqualTo(originalOption.Value));
        Assert.That(copiedOption.Weight, Is.EqualTo(originalOption.Weight));
    }
}
