namespace C_OOP04;

internal class StandardShipment : Shipment, ITrackable, IInsurable
{
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment
    {
    }

    public override decimal EstimatedCost => (DeliveryFee + (Weight * 5));

    public override void PrintShipment()
    {
        Console.WriteLine("=== Standard Shipment Details ===");
        Console.WriteLine($"TracingCode: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"DeliveryFee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"EstimatedCost: {EstimatedCost}");
    }

    public string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} is Ready";
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.05m;
    }
}
