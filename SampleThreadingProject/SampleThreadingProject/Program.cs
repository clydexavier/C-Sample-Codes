internal class Program
{
    public static string message = "";
    public static bool processed = false;

    private static void Main(string[] args)
    {
        Program p = new Program();
        Thread t = new Thread(new ThreadStart(p.sample_func));
        t.Start();
        while(true)
        {
            message = Console.ReadLine();
            processed = false;
        }
    }

    private void sample_func()
    {
        while(true)
        {
            if (!processed && message.StartsWith("converse "))
            {
                Console.WriteLine("I will feedback.");
                processed = true;
            }
                
        }
    }
}