namespace SoftwareArchitecture.Design_Patterns.Structural_Patterns.Adapter
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        public void Log(string message) { Console.WriteLine($"Logging using standard Logger.\nMessage { message}"); }
    }
}
