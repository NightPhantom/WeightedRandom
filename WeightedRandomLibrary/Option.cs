namespace WeightedRandomLibrary;

public class Option<T>
{
    public T Value { get; }

    public int Weight { get; set; }

    public Option(T value, int weight)
    {
        Value = value;
        Weight = weight;
    }

    public Option(Option<T> option)
    {
        Value = option.Value;
        Weight = option.Weight;
    }
}
