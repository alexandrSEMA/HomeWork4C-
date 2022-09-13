//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int a = number % 10;
    number = number / 10;
    sum = sum + a; 
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);