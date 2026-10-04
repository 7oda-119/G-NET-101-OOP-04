namespace C_OOP04;

internal class ExpressShipment : Shipment
{
    decimal extraFee;
    public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment 
    {
        ExtraFee = extraFee;
    }

    public decimal ExtraFee
    {
        get => extraFee;
        set
        {
            if (value >= 0)
                extraFee = value;
        }
    }

    public override decimal EstimatedCost => (DeliveryFee + (Weight * 5) + ExtraFee); 

    public override void PrintShipment()
    {
        Console.WriteLine("=== Express Shipment Details ===");
        Console.WriteLine($"TracingCode: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"DeliveryFee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"EstimatedCost: {EstimatedCost}");
        Console.WriteLine($"ExtraFee: {ExtraFee}");
    }

}
