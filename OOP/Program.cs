using OOP;

MyDate start = new MyDate(2023, 12, 22);
MyDate end = new MyDate(2023, 12, 23);
Airplane airplane = new Airplane("Lublin", "Warszawa", start, end);
Console.WriteLine(airplane);
Console.WriteLine(airplane.GetTotalTime());
Console.WriteLine(airplane.IsArrivingToday());