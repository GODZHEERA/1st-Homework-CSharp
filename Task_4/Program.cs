Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int min = 2;


/* if (a%2 == 0){
    Console.WriteLine(min);
    min = (min++);
}
else
{
    min = (min++);
} */

if (a > 1) {
   do {
    Console.Write(min + ", ");
    min = min + 2;
    } while (min <= a);
}
else {
    Console.WriteLine("Слишком маленькое число");
}