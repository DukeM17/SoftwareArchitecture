
using SoftwareArchitecture.Design_Patterns.Structural_Patterns.Adapter;
var logMessage = "Order placed successfully";

ILogger logger = new ThirdPartyLoggerAdapter();
logger.Log(logMessage);


ILogger stdLogger = new Logger();
stdLogger.Log(logMessage);