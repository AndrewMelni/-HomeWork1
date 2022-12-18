/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;

if(index>=a)
    {
        Console.WriteLine("Ошибка! Введите число больше 1!");
    }

while(index<=a)
{
    if(index%2==0)
    {
        Console.Write(index + " ");
        index+=2;
    }
    else
    {
        index++;
    }
}