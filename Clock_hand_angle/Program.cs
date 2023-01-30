
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

double angle = ClockHandAngle(hour, min);

// print out input
Console.WriteLine("The lesser angle between " + hour + " hour hand and " + min + " minute hand is = " + angle + " degrees");

return 0;


// function to calculate the lesser angle between clock hands
static double ClockHandAngle(int hour, int min)
{
    double angle = Math.Abs((hour * 30 + min * 0.5) - (min * 6));

    if (angle < 180)
        return angle;
    return 360 - angle;
}