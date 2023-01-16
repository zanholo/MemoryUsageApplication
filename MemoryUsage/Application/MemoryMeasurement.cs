using System.Diagnostics;

namespace MemoryUsageApplication.Application
{
    public class MemoryMeasurement
    {
        private int time;
        private Thread threadMemory;
        private string message;

        public MemoryMeasurement()
        {
            time = 10;
        }

        /// <summary>
        /// Every x seconds this application will run again, this property is in seconds, if is not setted will run every 10 seconds
        /// </summary>
        public MemoryMeasurement(int refreshTime)
        {
            time = refreshTime;
            threadMemory = new Thread(new ThreadStart(RunMemoryUsage));
            threadMemory.IsBackground = true;
        }

        /// <summary>
        /// Create a Thread than runs assincronely that shows amount of the memory usage
        /// </summary>
        public void MemoryUsageInThread()
        {            
            threadMemory.Start();
        }

        /// <summary>
        /// Get Current Memory, only show the memory usage of this momemnt
        /// </summary>
        public void GetCurrentMemoryUsage()
        {
            this.MemoryUsage();
        }


        private void RunMemoryUsage()
        {
            // Looping infinto 
            while (true)
            {                
               this.MemoryUsage();
                // Await rodando
                System.Threading.Thread.Sleep(time * 1000);
            } 
            //Roda enquanto a aplicação estiver viva
        }               

        private void MemoryUsage()
        {
            using Process processo = Process.GetCurrentProcess();
            // Current usage of memory
            long memoryUsage = (processo.PrivateMemorySize64 / 1024) / 1024; // Convert in MB

            // Imprime o uso de memória
            if (message != null && message.ToString() != string.Empty)
                Console.WriteLine(message + " = {0} MegaBytes", memoryUsage);
            else            
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + " -  Memory usage = {0} MegaBytes", memoryUsage);
        }
        
    }
}
