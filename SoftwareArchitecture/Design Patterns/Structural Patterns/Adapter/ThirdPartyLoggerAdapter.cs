namespace SoftwareArchitecture.Design_Patterns.Structural_Patterns.Adapter
{
    internal class ThirdPartyLoggerAdapter : ILogger
    {
        private readonly ThirdPartyLogger _tpLogger = new();

        public void Log(string message)
        {
            _tpLogger.WriteEntry(message);
        }
    }
}
