namespace WeightedRandomLibrary;

public class WeightedRandomizer<T>
{
    private readonly Random random;

    private readonly Option<T>[] options;

    private readonly int totalWeight;

    public WeightedRandomizer(Option<T>[] options, int? seed = null)
    {
        if (options == null || options.Length == 0) {  throw new ArgumentNullException(nameof(options), $"The {nameof(options)} parameter must not be null or empty."); }

        this.totalWeight = options.Sum(i => i.Weight);
        if (this.totalWeight < 1) { throw new ArgumentOutOfRangeException(nameof(options), $"The sum of the weights provided in the {nameof(options)} parameter should be greater than 0."); }

        this.options = options.Select(o => o).ToArray();

        this.random = seed.HasValue ? new Random(seed.Value) : new Random();
    }

    public Option<T> Next()
    {
        var next = this.random.Next(this.totalWeight);
        var seeker = next;

        foreach (var option in this.options)
        {
            if (next < option.Weight)
            {
                return option;
            }
            next -= option.Weight;
        }

        throw new Exception($"An unexpected error has resulted in no selection being made. ({this.totalWeight}, {next}, {seeker}) {options}");
    }
}