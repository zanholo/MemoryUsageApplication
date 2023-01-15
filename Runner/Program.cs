using MemoryUsageApplication.Application;

class Program
{

    private static void Main(string[] args)
    {
        List<int> listInt = new List<int>();
        MemoryMeasurement memoryUsageDLL = new MemoryMeasurement(10);
        //memoryUsageDLL.RunMemoryUsage();
        /*
        for (int i = 0; i < 10000; i++)
        {
            Random rnd = new Random();
            int num = rnd.Next();
            listInt.Add(num);
            Console.WriteLine(num);
            memoryUsageDLL.GetCurrentMemoryUsage();
            Thread.Sleep(1000);
        }
        */

        ///teste 2
        // Create a random number generator
        Random rand = new Random();

        // Create an array of random size
        byte[] bytes = new byte[rand.Next(0, 1024 * 16000)];

        
        memoryUsageDLL.MemoryUsageInThread();
        // Fill the array with random values
        for (int i = 0; i < bytes.Length; i++)
        {
            //memoryUsageDLL.GetCurrentMemoryUsage();
            var value = (byte)rand.Next(0, rand.Next(88888));
            bytes[i] = value;
            //memoryUsageDLL.GetCurrentMemoryUsage();
            //Console.WriteLine("Total: " + i + " -> value " + value);
        }

        Console.ReadKey();

    }
}