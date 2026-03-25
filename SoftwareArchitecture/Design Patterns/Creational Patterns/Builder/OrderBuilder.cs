namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.Builder
{
    public class OrderBuilder
    {
        private string _item = "";
        private int _quantity;
        private string _size = "medium";
        private string _crust = "regular";
        private List<string> _extras = new();
        private string _deliveryTime = "asap";
        private bool _contactlessDelivery;

        public OrderBuilder ForItem(string item) { _item = item; return this; }
        public OrderBuilder ForQuantity(int quantity) {_quantity = quantity; return this; }
        public OrderBuilder ForSize(string size) { _size = size; return this; }
        public OrderBuilder ForCrust(string crust) { _crust = crust; return this; }
        public OrderBuilder ForExtras(string extras) { _extras.Add(extras); return this; }
        public OrderBuilder ForDeliveryTime(string deliveryTime) { _deliveryTime = deliveryTime; return this; }
        public OrderBuilder ForContactlessDelivery(bool contactlessDelivery) { _contactlessDelivery = contactlessDelivery; return this; }

        public Order Build() 
        {
            if (string.IsNullOrWhiteSpace(_item))
                throw new InvalidOperationException("Item is required.");
            if (_quantity <= 0)
                throw new InvalidOperationException("Quantity must be at least 1.");

            Order order = new Order()
            {
                Item = _item,
                Quantity = _quantity,
                Size = _size,
                Crust = _crust,
                Extras = _extras,
                DeliveryTime = _deliveryTime,
                ContactlessDelivery = _contactlessDelivery,
            };            

            return order;            
        }
    }
}
