# WeightedRandom

A concise C# library for effortless random selection of items from a list, each with its own probability. Perfect for scenarios requiring diverse likelihoods in a simple and efficient package.

## Getting Started

### Usage

Various examples have been provided in this repo using [CLI](WeightedRandomDemoCLI), [WPF](WeightedRandomDemoWPF), etc.

In a nutshell:
1. Create an array of `Option<T>`.
    * Each option consists of a `Value` of type `T` and an integer representing its `Weight`.
    * For example: `new Option<char>('A', 10)` creates an Option for the character `A` with a weight of 10.
    * Weights are relative to one another. For example, the set of weights [10, 20, 40] is equivalent to [1, 2, 4] or [30, 40, 120], they all give the first entry a 14% change, the second entry a 28% chance, and the third entry a 57% chance.
1. Give that array to a new instance of `WeightedRandomizer<T>`.
    * You may optionally provide a specific seed value as well. Otherwise the default seed value for `System.Random` is used
1. Call the method `Next()` and consume the returned value however you wish.
```
var options = new []
{
    new Option<char>('A', 10),
    new Option<char>('B', 30),
    new Option<char>('C', 10),
};

var weightedRandom = new WeightedRandomizer<char>(options);

Option<char> selection = weightedRandom.Next();
```

## Version History

* 0.1
    * Initial Release

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
