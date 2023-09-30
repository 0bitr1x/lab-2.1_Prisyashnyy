Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= (Math.Pow(2, 2))) && ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) >= (Math.Pow(1, 2))));