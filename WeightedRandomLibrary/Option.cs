using System.Text.Json.Serialization;

namespace WeightedRandomLibrary;

public class Option<T>
{
    public T Value { get; }

    public int Weight { get; private set; }

    [JsonConstructor]
    public Option(T value, int weight)
    {
        if (weight < 1) { throw new ArgumentOutOfRangeException(nameof(weight), $"The value {weight} is not valid {nameof(weight)}. The value of the parameter {nameof(weight)} must be greater than 0."); }

        Value = value;
        Weight = weight;
    }

    public Option(Option<T> option)
    {
        Value = option.Value;
        Weight = option.Weight;
    }
}
