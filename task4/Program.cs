//Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
for (int number1 = 1; number1 <= number; number1++)
    if (number1 % 2 == 0)
        Console.WriteLine(number1);