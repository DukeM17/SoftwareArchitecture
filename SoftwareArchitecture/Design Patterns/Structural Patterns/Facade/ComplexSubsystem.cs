using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Design_Patterns.Structural_Patterns.Facade
{
    public class ComplexSubsystem
    {
    }

    public class InventoryService
    {
        public bool IsInStock(int productId) => true;

        public void Reserve(int productId, int qty) { }    
    }

    public class PaymentService
    {
        public bool ProcessPayment(string cardToken, decimal amount) => true;
    }

    public class ShippingService
    {
        public string CreateShipment(int orderId) => "TRACK-12345";
    }

    public class NotificationService
    {
        public void SendConfirmation(string email, string trackingCode) { }
    }
}
