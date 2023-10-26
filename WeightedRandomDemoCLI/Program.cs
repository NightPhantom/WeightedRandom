using WeightedRandomLibrary;


// Setup the randomizer
var options = new []
{
    new Option<char>('A', 10),
    new Option<char>('B', 30),
    new Option<char>('C', 10),
    new Option<char>('D', 50)
};

var weightedRandom = new WeightedRandomizer<char>(options);

// Get user input
Console.Write("Enter # of iterations: ");
var userInput = Console.ReadLine();
int totalIterations;
while (!int.TryParse(userInput, out totalIterations))
{
    Console.Write("Value entered is not an integer, try again: ");
    userInput = Console.ReadLine();
}

// Results of rolls (option, count)
var results = new Dictionary<char, int>()
{
    { 'A', 0 },
    { 'B', 0 },
    { 'C', 0 },
    { 'D', 0 },
};

// Roll for items
for (int i = 0; i < totalIterations; i++)
{
    var pick = weightedRandom.Next().Value;

    results[pick]++;
}

// Show the results
Console.WriteLine("Given the options: ");
Console.WriteLine(
    string.Join(
        "\n",
        options.Select(o => $"\t{o.Value} with a weight of {o.Weight}.")
        )
    );
Console.WriteLine($"After rolling {totalIterations} times:");
Console.WriteLine(
    string.Join(
        "\n",
        results.Select(r => $"\t{r.Key} was picked {r.Value} times. ({r.Value * 100 / totalIterations} % of the time)")
        )
    );
