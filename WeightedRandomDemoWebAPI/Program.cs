using WeightedRandomLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/weightedrandomizer", (Option<string>[] options) =>
{
    return new WeightedRandomizer<string>(options).Next().Value;
})
.WithName("PickWeightedRandom")
.WithOpenApi();

app.MapPost("/multipleweightedrandomizer", (Option<string>[] options, int count) =>
{
    var retVal = new List<string>();

    for (int i = 0; i < count; i++)
    {
        retVal.Add(new WeightedRandomizer<string>(options).Next().Value);
    }
    return retVal;
})
.WithName("PickMultipleWeightedRandoms")
.WithOpenApi();

app.MapGet("/optionsexample", () =>
{
    var exampleOptions = new[]
    {
        new Option<string>("Option 1", 20),
        new Option<string>("Option 2", 50),
        new Option<string>("Option 3", 10),
        new Option<string>("Option 4", 50),
        new Option<string>("Option 5", 70)
    };
    return exampleOptions;
})
.WithName("GetOptionsExample")
.WithOpenApi();

app.Run();
