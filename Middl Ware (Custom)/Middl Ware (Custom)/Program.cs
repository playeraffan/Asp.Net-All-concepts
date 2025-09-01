var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Middle Execute Before Controller
//it execute on all requests 
//it works in middle of request and controller , thats why its is called pipeline.

//use use() when we need to execute more middleware , it has two parameters second for provoking next middleware 
app.Use(async (context , next) =>
{
    await context.Response.WriteAsync("this is Run middle ware\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("this is Run middle ware 2\n");
    await next(context);
});

//run() uses only one parameter and it doesnot provoke subsequent middlewares
app.Run( async (context) => 
{
    await context.Response.WriteAsync("this is Run middle ware");
});

app.Run();







