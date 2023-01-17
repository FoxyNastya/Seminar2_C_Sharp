// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int GetNumber()
{
    int number1 = Convert.ToInt32(Console.ReadLine());
    return number1;
}

int FirstNumber = GetNumber();
int SecondNumber = GetNumber();

if (SecondNumber % FirstNumber == 0)
{
    Console.WriteLine($"Второе число кратно первому");
}
else
{
    Console.WriteLine(SecondNumber % FirstNumber);
}

