int getSecondDigitFrom3DigitNumber(int number)
{
    int secondDigit = (number % 100 - number % 10)/10;
    return secondDigit;
}

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

//int number = new Random().Next(100, 1000);

int secondDigit = getSecondDigitFrom3DigitNumber(number);
Console.WriteLine($"Вторая цифра числа {number} это {secondDigit}");
