using OOPSconcepts.Abstraction;
using OOPSconcepts.Encapsulation;
using OOPSconcepts.Inheritance;
using OOPSconcepts.polymorphism;
using OOPSconcepts.Relations;
using OOPSconcepts.SolidPrinciples._1_SRP;
using OOPSconcepts.SolidPrinciples._2_OCP;
using OOPSconcepts.SolidPrinciples._3_LSP;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    string currentDirectoryPath = Directory.GetCurrentDirectory();
    string fileContent = Path.Combine(currentDirectoryPath, "Views", "index.html");

    string html = await File.ReadAllTextAsync(fileContent);

    await context.Response.WriteAsync(html);
});

app.MapGet("/abstraction", async context =>
{
    Abstraction obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/encapsulation", async context =>
{
    Encapsulation obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/inheritance", async context =>
{
    Inheritance obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/polymorphism", async context =>
{
    Polymorphism obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/classrelations", async context =>
{
    Association obj1 = new();
    Composition obj2 = new();
    await context.Response.WriteAsync($"{obj1.Main()}\n\n{obj2.Main()}");
});

app.MapGet("/srp", async context =>
{
    SRP obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/ocp", async context =>
{
    OCP obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/lsp", async context =>
{
    LSP obj = new();
    await context.Response.WriteAsync($"{obj.Main()}");
});

app.MapGet("/isp", async context =>
{
});

app.Run();