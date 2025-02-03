namespace Lab_9;
public static class Program
{
    public static void Main()
    {
        try
        {
            CarParking hueta1 = new CarParking(100, 10);
            Console.WriteLine((int)hueta1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}