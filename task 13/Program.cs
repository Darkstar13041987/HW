//  Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
int num =Convert.ToInt32(Console.ReadLine());
int result = num;
if (num<100)
{
Console.WriteLine("Третей цифры нет");
}
else if (num>100 && num<1000)

{
Console.WriteLine(num%10);
}
else if (num>1000)

Console.WriteLine((num%1000)/100);
 