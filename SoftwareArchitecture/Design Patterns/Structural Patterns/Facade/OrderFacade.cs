namespace SoftwareArchitecture.Design_Patterns.Structural_Patterns.Facade
{
    public class OrderFacade
    {
        private readonly InventoryService _inventoryService = new();
        private readonly PaymentService _paymentService = new();
        private readonly ShippingService _shippingService = new();
        private readonly NotificationService _notificationService = new();

        public string PlaceOrder(int productId, string cardToken, decimal amount, string emailAddress, int orderId)
        {
            if (!_inventoryService.IsInStock(productId))
            {
                throw new Exception($"Product {productId} not in stock");
            }

            _inventoryService.Reserve(productId, 1);

            _paymentService.ProcessPayment(cardToken, amount);

            var trackingCode = _shippingService.CreateShipment(orderId);
            _notificationService.SendConfirmation(emailAddress, trackingCode);

            return trackingCode;
        }
    }
}
