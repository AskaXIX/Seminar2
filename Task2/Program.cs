// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

System.Console.WriteLine("Insert number: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 99 && number < 1000)
{
    int num = number % 10;
    System.Console.Write(num);
}
else if (number < -99 && number > -1000)
{
    int num = number % -10;
    System.Console.Write(num);
}
else if (number > 999 && number < 10000)
{
    int num = (number /= 10) % 10;
    System.Console.WriteLine(num);
}
else if (number > 9999 && number < 100000)
{
    int num = (number /= 100) % 10;
    System.Console.WriteLine(num);
}
else
{
    System.Console.WriteLine("Error!");
}
