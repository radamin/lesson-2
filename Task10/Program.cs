// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру 
// этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstnumber = number / 10;
int secondnumber = number / 100;

int result = firstnumber - secondnumber*10;
Console.WriteLine($"Result from {number} -> {result}");
