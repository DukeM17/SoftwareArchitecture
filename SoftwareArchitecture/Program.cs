
using SoftwareArchitecture.Design_Patterns.Structural_Patterns.Adapter;

ILogger logger = new ThirdPartyLoggerAdapter();
logger.Log("test");


ILogger stdLogger = new Logger();
stdLogger.Log("test");