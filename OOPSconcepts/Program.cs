using OOPSconcepts.Abstraction;
using OOPSconcepts.Encapsulation;
using OOPSconcepts.Inheritance;
using OOPSconcepts.polymorphism;
using OOPSconcepts.SolidPrinciples._1_SRP;
using OOPSconcepts.SolidPrinciples._2_OCP;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// polymorphism route
app.MapGet("/polymorphism", async context =>
{
    Polymorphism demo = new();
    var example1 = demo.Print("Livhuwani", "Masindi");
    var example2 = demo.Print("Livhuwani", "Khathutshelo", "Masindi");
    var example3 = demo.Print();
    await context.Response.WriteAsync($"{example1} \n\n{example2} \n\n{example3}");
});

// inheritance route
app.MapGet("/inheritance", async context =>
{
    Inheritance demo = new();

    string employee = demo.EmployeeDetails();

    await context.Response.WriteAsync(employee);
});

// abstraction route
app.MapGet("/abstraction", async context =>
{
    Triangle triangle = new(12, 6);
    Circle circle = new(13);
    Square square = new(10);

    await context.Response.WriteAsync(
        $"Abstraction Demo\n" +
        $"================================\n" +
        $"Triangle class output: {triangle.Area()}\n\n" +
        $"Circle class output: {Math.Round(circle.Area(), 2)}\n\n" +
        $"Square class output: {square.Area()}");
});

// encapsulation route
app.MapGet("/encapsulation", async context =>
{
    AccessUser accessUser = new();
    await context.Response.WriteAsync(
        $"Encapsulation Demo\n" +
        $"================================\n" +
        $"Full Name: {accessUser.Details()}");

    string[] user = accessUser.Details().Split(" ");

    await context.Response.WriteAsync(
        $"\n\nFull Name Split\n" +
        $"=================================\n" +
        $"First Name: {user[0]}\n" +
        $"Middle Nmae: {user[1]}\n" +
        $"Last Name: {user[2]}");
});

// solid principles
app.MapGet("/srp", async context =>
{
    SRP srp = new();
    await context.Response.WriteAsync(srp.Main());
});

app.MapGet("/ocp", async context =>
{
    OCP ocp = new();
    await context.Response.WriteAsync(ocp.Main());
});

app.MapGet("/isp", async context =>
{

});

app.Run();