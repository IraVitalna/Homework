// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine ("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max;

if (number_1 > number_2)
{
     max = number_1;
}
else 
{
     max = number_2;
}
if (number_2 > number_3)
{
     max = number_2;
}
else 
{
     max = number_3;
}
if (number_1 > number_3)
{
     max = number_1;
}
else 
{
     max = number_3;
}
Console.WriteLine("max");
