namespace WeightedRandomLibrary;

public class WeightedRandomizer<T>
{
    private readonly Random random;

    private readonly Option<T>[] options;

    private readonly int totalWeight;

    public WeightedRandomizer(Option<T>[] options, int? seed = null)
    {
        random = seed.HasValue ? new Random(seed.Value) : new Random();
        this.options = options.Select(o => new Option<T>(o)).ToArray();
        this.totalWeight = options.Sum(i => i.Weight);
    }

    public Option<T> Next()
    {
        var next = random.Next(this.totalWeight);
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