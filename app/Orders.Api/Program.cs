var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



var orders = new List<Order>
{
    new (1,"Latop",2, 45000m),
    new (2, "Mouse", 5, 750m),
    new (3, "Klavye", 1, 2200m)
};



app.MapGet("/health", () => Results.Ok(new { status = "healty" }));

app.MapGet("/getOrders", () => Results.Ok(orders));

app.MapGet("/", () => "Hello World!");

app.Run();

// internal class Order
// {
//     int Id;
//     string Product;
//     int Quantity;
//     decimal Price;
// }

record Order(int Id, string Product, int Quantity, decimal Price);