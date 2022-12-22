// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter the number of the day of the week: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
  Console.WriteLine("No (it's not a holiday)");
}
else if (a == 2)
{
  Console.WriteLine("No (it's not a holiday)");
}
else if (a == 3)
{
  Console.WriteLine("No (it's not a holiday)");
}
else if (a == 4)
{
  Console.WriteLine("No (it's not a holiday)");
}
else if (a == 5)
{
  Console.WriteLine("No (it's not a holiday)");
}
else if (a == 6)
{
  Console.WriteLine("Yes (it's a holiday)");
}
else if (a == 7)
{
  Console.WriteLine("Yes (it's a holiday)");
}
else
{
  Console.WriteLine("it's not a day of the week");
}
