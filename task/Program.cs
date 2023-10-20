// // Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");
int num =Convert.ToInt32(Console.ReadLine());
int result = num;

if 
(num>100 && num<1000)
{
result=(num%100)/10;

Console.WriteLine(result);
}
else
{
Console.WriteLine("Ошибка ввода");
}


// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число:");
// int num =Convert.ToInt32(Console.ReadLine());
// int result = num;
// if (num<100)
// {
// Console.WriteLine("Третей цифры нет");
// }
// else if (num>100 && num<1000)

// {
// Console.WriteLine(num%10);
// }
// else if (num>1000)

// Console.WriteLine((num%1000)/100);
 
 
// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// // обозначающую день недели, и проверяет, 
// // является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // // 1 -> нет

// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());

// if (num>=6 && num<=7)
// {
//     Console.Write("Да");
// }
// else 
// {
//    Console.Write("Нет");  
// }