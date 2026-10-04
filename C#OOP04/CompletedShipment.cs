namespace C_OOP04;

internal sealed class CompletedShipment : Shipment
{
    public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override decimal EstimatedCost => (DeliveryFee + (Weight * 5));

    public override void PrintShipment()
    {
        Console.WriteLine("=== Completed Shipment Details ===");
        Console.WriteLine($"TracingCode: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"DeliveryFee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"EstimatedCost: {EstimatedCost}");
    }
}
