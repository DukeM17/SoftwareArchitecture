namespace SoftwareArchitecture.Design_Patterns.Structural_Patterns.Adapter
{
    public interface IThirdPartyLogger
    {
        void WriteEntry(string message);
    }

    public class ThirdPartyLogger : IThirdPartyLogger
    {
        public void WriteEntry(string message)
        {
            Console.WriteLine($"Logging using Third party logger.\nMessage: {message}");
        }
    }
}
