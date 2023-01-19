Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}

Console.WriteLine("A в степени B = " + step);
