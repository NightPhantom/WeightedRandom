namespace WeightedRandomLibrary;

public class Option<T>
{
    public T Value { get; }

    public int Weight { get; set; }

    public Option(T value, int weight)
    {
        if (weight < 1) { throw new ArgumentOutOfRangeException($"The value {weight} is not valid. Weight must be greater than 0."); }

        Value = value;
        Weight = weight;
    }

    public Option(Option<T> option)
    {
        Value = option.Value;
        Weight = option.Weight;
    }
}
