
Console.WriteLine("This program calculates the lesser angle between analog clock hands");
int hour, min;

// get input
try
{
    Console.Write("Please input the hour: ");
    string input = Console.ReadLine();
    hour = int.Parse(input);

    Console.Write("Please input the minutes: ");
    input = Console.ReadLine();
    min = int.Parse(input);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    return -1;
}

// validate input
if (hour < 0 || hour > 12)
{
    Console.WriteLine("Bad hour input");
    return -1;
}

if (min < 0 || min >= 60)
{
    Console.WriteLine("Bad minute input");
    return -1;
}

// print out input
Console.WriteLine("hour: " + hour + " min: " + min);

return 0;