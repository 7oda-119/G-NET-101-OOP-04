namespace C_OOP04;

internal class StandardShipment : Shipment
{
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment
    {
    }

    public override decimal EstimatedCost => base.EstimatedCost;

    public override void PrintShipment()
    {
        Console.WriteLine("=== standard Shipment Details ===");
        base.PrintShipment();
    }
}
