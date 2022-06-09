Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число б: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число с: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c) {
        Console.WriteLine("Число а - максимальное");
    }
    else if(a < c){
        Console.WriteLine("Число с - максимальное");
    }
    else if(a==c) {
        Console.WriteLine("Числа а и с - максимальны и равны");
    }
}
if (a < b)
{
    if (b > c) {
        Console.WriteLine("Число б - максимальное");
    }
    else if(b < c) {
        Console.WriteLine("Число с - максимальное");
    }
    else if(b==c) {
        Console.WriteLine("Числа б и с - максимальны и равны");
    }

}
if (a==b)
{
    if(b==c){
        Console.WriteLine("Все числа максимальны и равны");
    }
    

}