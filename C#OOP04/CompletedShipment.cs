namespace C_OOP04;

internal sealed class CompletedShipment : Shipment
{
    public CompletedShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }
}
