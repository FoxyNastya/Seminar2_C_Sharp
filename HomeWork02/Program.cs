/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите число от 10 до 9999");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
if (a > 99 && a < 999)
{
   int b = a % 10;
   Console.Write("Третья цифра числа: ");
   Console.Write(b);
}
else if (a > 999 && a < 9999)
{
    int c = a / 10;
    int b = c % 10;
    Console.Write("Третья цифра числа: ");
    Console.Write(b);
}
else
{
    Console.Write("Введено двухзначное число");
}