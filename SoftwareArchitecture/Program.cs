using SoftwareArchitecture.Design_Patterns.Structural_Patterns.Facade;

var facade = new OrderFacade();
var tracking = facade.PlaceOrder(42, "tok_visa", 29.99m, "user@example.com", 42);

Console.WriteLine(tracking);