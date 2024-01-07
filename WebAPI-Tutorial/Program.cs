var builder = WebApplication.CreateBuilder(args);

// ***** Services *****
//Adding dependency for MapControllers to work
builder.Services.AddControllers();

var app = builder.Build();

// HTTP request pipeline.
app.UseHttpsRedirection();

app.MapControllers();

// ***** Routing *****

// ***** Mapping action methods in Minimal API *****
/*
app.MapGet("/shirts", () => 
{
    return "Reading all the shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Reading shirt with ID: {id}";
});

app.MapPost("/shirts", () =>
{
    return "Creating a shirt";
});

app.MapPut("/shirts/{id}", (int id) =>
{
    return $"Updating shirt with ID:{id}";
});

app.MapDelete("shirts/{id}", (int id) =>
{
    return $"Deleting shirt with ID:{id}";
});
*/


app.Run();