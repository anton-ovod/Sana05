using OOP;

MyDate startDate = new MyDate(2022, 12, 31);
MyDate finishDate = new MyDate(2023, 1, 1);

Airplane airplane = new Airplane("Lublin", "Warsaw", startDate, finishDate);

int totalTime = airplane.GetTotalTime();
bool isArrivingToday = airplane.IsArrivingToday();

Console.WriteLine($"Total travel time: {totalTime} minutes.");
Console.WriteLine($"Same depart/arrival date: {isArrivingToday}.\n");

Currency currency = new Currency("PLN", 9.60M);
Product product = new Product("Frozen Vegetables", 6.00M, currency, 2, "Hertex", 500);

decimal priceUAH = product.GetPriceInUAH();
decimal totalPriceUAH = product.GetTotalPriceInUAH();
double totalWeight = product.GetTotalWeight();

Console.WriteLine($"Price in UAH: {Math.Round(priceUAH, 2)}.");
Console.WriteLine($"Total price in UAH: {Math.Round(totalPriceUAH, 2)}.");
Console.WriteLine($"Total weight: {Math.Round(totalWeight, 2)} g.");