// See https://aka.ms/new-console-template for more information
using Refit;
using RefitDemo;


var coffeeApi = RestService.For<ICoffeeApi>("https://api.sampleapis.com");
var response = await coffeeApi.GetCoffeeDetailsAsync();

Console.WriteLine($"Coffees");
foreach (var item in response)
{
    Console.WriteLine($"{item.title}");
}

public class Coffee
{
    public string title { get; set; }
}