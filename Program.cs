// Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введи число: ");
int newNumber = Convert.ToInt32(Console.ReadLine());

if (newNumber % 7 == 0)
    if (newNumber % 23 == 0)
        { 
            Console.WriteLine ("Число делится на 7 и на 23!");
        }
    else
        {
            Console.WriteLine ("Число не делится на 23!");
        }
else if (newNumber % 23 == 0)
    if (newNumber % 7 == 0)
        { 
            Console.WriteLine ("Число делится на 7 и на 23!");
        }
    else
        {
            Console.WriteLine ("Число не делится на 7!");
        }
else
{
    Console.WriteLine ("Числа не кратны 7 и 23!");
}