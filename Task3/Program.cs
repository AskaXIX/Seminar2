// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.WriteLine("Insert number of day: ");
int day = Convert.ToInt32(System.Console.ReadLine());

if (day > 5 && day < 8)
{
    System.Console.WriteLine("Its day off!");
}
else if (day < 6 && day > 0)
{
    System.Console.WriteLine("Its working day");
}
else 
{
    System.Console.WriteLine("Error!");
}