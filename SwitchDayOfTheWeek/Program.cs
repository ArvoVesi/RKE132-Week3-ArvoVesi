
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // 0-6

switch(weekDay) //Väärtus, mida kontrollitakse
{
    case 0: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on pühapäev");
        break;
    case 1: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on esmaspäev");
        break;
    case 2: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on teisipäev");
        break;
    case 3: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on kolmapäev");
        break;
    case 4: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on neljapäev");
        break;
    case 5: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on reede");
        break;
    case 6: // Case 0:  == if(weekDay == 0)
        Console.WriteLine("Praegu on laupäev");
        break;
    default:
        Console.WriteLine("Error");
        break;
}

Console.WriteLine("Normi päeva!");