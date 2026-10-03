namespace C_OOP04;

internal class ExpressShipment : Shipment
{
    decimal extraFee;
    public ExpressShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment 
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

    public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;  // Adde from Assignment02

    public override void PrintShipment()
    {
        Console.WriteLine("=== Express Shipment Details ===");
        base.PrintShipment();
        Console.WriteLine($"ExtraFee: {ExtraFee}");
    }

}
