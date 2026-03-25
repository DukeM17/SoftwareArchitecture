using SoftwareArchitecture.Design_Patterns.Creational_Patterns.Builder;

var order = new OrderBuilder()
    .ForItem("pizza")
    .ForQuantity(1)
    .ForSize("large")
    .ForCrust("stuffed")
    .ForExtras("Dough balls")
    .ForDeliveryTime("asap")
    .ForContactlessDelivery(true)
    .Build();

Console.WriteLine(order.ToString());
