// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = ReadInt("Введите число"); // Программа работает с любой длинной числа, определяет если введена 1 цифра, работает с отрицательными числами.
if (Validate(number))
{
    if (number == Revers(number))
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}

int ReadInt(string message)
{
    Console.WriteLine ($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Revers(int digit)
{
    int result = 0;
    if (number > 0)
    {
        while (number > 0) 
        {
            result *= 10;
            result += number % 10;
            number /= 10;
        }
        return result;
        }
    else
    {
        while (number < 0) 
        {
            result *= 10;
            result += number % 10;
            number /= 10;
        }
        return result;
    }
}

bool Validate(int number)
{
    if (number < 10 && number > -10)
    {
        Console.WriteLine("Одной цифры мало");
        return false;
    }
    return true;
}
