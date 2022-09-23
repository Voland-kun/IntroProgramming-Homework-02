Console.WriteLine("Введите число ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day < 6)
{
    Console.WriteLine("нет");
}
else if (day >= 6 & day < 8)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("В неделе 7 дней");
}
