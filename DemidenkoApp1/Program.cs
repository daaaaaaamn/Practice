Console.Write("Введите значение переменной х: ");
string s = Console .ReadLine();
double x = Convert.ToDouble(s);
//4Sin(x) * 5Cos(x)
double F = 4 * Math.Sin(x) * 4 * Math.Cos(x);
Console.WriteLine($"Значение F = 4Sin({x}) * 4Cos({x}) = {F}.");
Console.ReadKey();