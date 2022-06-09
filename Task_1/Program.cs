Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число б: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Число а - большее");
}

else if (a==b)
{
    Console.WriteLine("Числа равны");
}

else
    {
        Console.WriteLine("Число б - большее");
    }