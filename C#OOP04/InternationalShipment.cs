namespace C_OOP04;

internal class InternationalShipment : Shipment
{
    string destinationCountry;
    decimal customsFee;
    public string DestinationCountry
    {
        get => destinationCountry;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                destinationCountry = value;
        }
    }
    public decimal CustomsFee
    {
        get => customsFee;
        set
        {
            if (value >= 0)
                customsFee = value;
        }
    }

    public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;  // Adde from Assignment02
    public InternationalShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }

    public override void PrintShipment()
    {
        Console.WriteLine("=== International Shipment Details ===");
        base.PrintShipment();
        Console.WriteLine($"DestinationCountry: {DestinationCountry}");
        Console.WriteLine($"CustomsFee: {CustomsFee}");
    }

    public virtual void GenerateCustomsReport()
    {
       
    }

}
