//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число");
int numberA =int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень возведения");
int numberB =int.Parse(Console.ReadLine());
int sum = numberA;
for (int i = 1; i < numberB; i++)
{
    sum = sum * numberA;
}
System.Console.Write("Ответ = " );
System.Console.Write(sum);