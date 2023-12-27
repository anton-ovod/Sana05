using OOP;

MyDate start = new MyDate(2023, 12, 22, 11, 23);
MyDate end = new MyDate(2023, 12, 23, 11, 40);
Airplane airplane = new Airplane("Lublin", "Warszawa", start, end);
Console.WriteLine(airplane);
Console.WriteLine(airplane.GetTotalTime());
Console.WriteLine(airplane.IsArrivingToday());