internal class Program
{
    private static void Main(string[] args)
    {
        float result;

        int x, y;

        x = 5; y = 2;
        result = Convert.ToSingle(x) / y;
        Console.WriteLine(result);
        Console.ReadLine();

        int timeINminute = 130;
        int hour;
        int minute;

        hour = timeINminute / 60;
        minute = timeINminute % 60;
        Console.WriteLine("hour: " + hour);
        Console.WriteLine("minute: " + minute);

        int age = 18;
        age = age + 1;
        age++;
        age += 1;
        age += 1; age += 1;

        int result2 = 5 + (12 - 5) * 3 - 1 + 5 * 2;
        Console.WriteLine(result2);


    }
}