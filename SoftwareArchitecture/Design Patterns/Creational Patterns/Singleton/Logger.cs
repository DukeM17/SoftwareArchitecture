namespace SoftwareArchitecture.Singleton
{
    public class Logger
    {
        private Logger() { }

        private static Logger? _instance;
        private static readonly object _lock = new();

        public static Logger Instance
        {
            get 
            {           
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new();
                    }                
                }
                return _instance;
            }
        }

        public void Log(string message) =>
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}
