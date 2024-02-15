
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("Praegu on pühapäev");
}
else if (weekDay == 1)
{
    Console.WriteLine("Praegu on esmaspäev");
}
else if (weekDay == 2)
{
    Console.WriteLine("Praegu on teisipäev");
}
else if (weekDay == 3)
{
    Console.WriteLine("Praegu on kolmapäev");
}
else if (weekDay == 4)
{
    Console.WriteLine("Praegu on neljapäev");
}
else if (weekDay == 5)
{
    Console.WriteLine("Praegu on reede");
}
else if (weekDay == 6)
{
    Console.WriteLine("Praegu on laupäev");
}