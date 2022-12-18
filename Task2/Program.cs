/* Задача 2: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
*/
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if(b>a) 
{
    max=b;
    min=a;
}
Console.WriteLine(max + " больше " + min);