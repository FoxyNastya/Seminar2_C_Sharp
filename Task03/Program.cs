// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
int GetNumber()
{
    Console.WriteLine("Введите число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
}

int FirstNumber = GetNumber();

if (FirstNumber % 7 == 0 && FirstNumber % 23 == 0 )
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}


