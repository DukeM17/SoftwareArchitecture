namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.Builder
{
    public class Order
    {
        public string Item { get; init; } = "";
        public int Quantity { get; init; }
        public string Size { get; init; } = "";
        public string Crust { get; init; } = "regular";
        public List<string> Extras { get; init; } = new();
        public string DeliveryTime { get; init; } = "asap";
        public bool ContactlessDelivery { get; init; }

        public override string ToString() =>
            $"{Quantity}x {Size} {Item} ({Crust} crust)" +
            $"{(Extras.Any() ? " + " + string.Join(", ", Extras) : "")}" +
            $" — deliver at {DeliveryTime}{(ContactlessDelivery ? " (contactless)" : "")}";
    }
}
