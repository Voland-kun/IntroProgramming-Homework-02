int getThirdDigitFromNumber(int number)
{
    int thirdDigit = 0;
    while(Math.Abs(number) > 99)
    {
        thirdDigit = Math.Abs(number % 10);
        number = number / 10;
    }
    return thirdDigit;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

//int number = new Random().Next(-10000, 10000);
if (Math.Abs(number) < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    int thirdDigit = getThirdDigitFromNumber(number);
    Console.WriteLine($"Третья цифра числа {number} это {thirdDigit}");
}