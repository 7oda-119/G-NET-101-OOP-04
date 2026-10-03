namespace C_OOP04;

internal class Program
{
    static void Main(string[] args)
    {
        #region Theoretical Questions
        #region Question01
        //a)  What is the difference between Method Overloading and Method Overriding?
        /*
         * Method Overloading: Allows a class to declare sevsrel methods with the same name name but different parameters (count, type or order)
         *                     Resolved entirely at compile-time
         * Method Overriding: Lets a derived class supply its own implementation of a method that the base class already defined
         *                    Base method must be virsual, abstract or already an override
         *                    The derived method must use override keyword
         *                    The method segnature(name, return type and parameters) must be exactly
         *                    Resolved at run-time
         */

        //b)  What is the difference between Static Binding and Dynamic Binding?
        /*
         * Static Binding: Resolved at compile-time by the compiler so its faster
         *                 The reference type decides
         *                 Occurs with method overloading, method hiding, non-virsual methods and static methods
         * Dynamic Binding: Resolved at run-time by CLR so its slower
         *                  The actual object in memory decides 
         *                  Occurs with method overriding, abstract methods and interface methods
         */


        #endregion
        #endregion

        #region Practical Questions
        //a. Create a Driver.
        Driver driver = new Driver("Ahmed");

        //  b. Create a DeliveryCenter.
        DeliveryCenter deliveryCenter = new DeliveryCenter("Cairo Main Center");

        //c. Assign the Driver to the DeliveryCenter.
        deliveryCenter.AssignDriver(driver);

        // d. Create one StandardShipment.
        StandardShipment standardShipment = new StandardShipment("T01", "Books", 3.5, 30, new DeliveryAddress("Cairo", "Tahrir street", 10));

        // e. Create one ExpressShipment.
        ExpressShipment expressShipment = new ExpressShipment("T02", "Laptop", 2.0, 40, new DeliveryAddress("Giza", "Nile street", 5), 20);

        // f. Create one InternationalShipment.
        InternationalShipment internationalShipment = new InternationalShipment("T03", "Clothes", 4.5, 50, new DeliveryAddress("Alex", "Corniche", 8), "France", 60);

        // g. Add all shipments to the DeliveryCenter.
        deliveryCenter.AddShipment(standardShipment);
        deliveryCenter.AddShipment(expressShipment);
        deliveryCenter.AddShipment(internationalShipment);

        // h. Print all shipments using PrintAllShipments().
        deliveryCenter.PrintAllShipments();

        Console.WriteLine("\n-----------------------------------\n");

        // i. Call DeliveryHelper.PrintShipmentDetails() for each shipment.
        Console.WriteLine("------Printing usig DeliveryHelper");
        DeliveryHelper.PrintShipmentDetails(standardShipment);
        DeliveryHelper.PrintShipmentDetails(expressShipment);
        DeliveryHelper.PrintShipmentDetails(internationalShipment);

        Console.WriteLine("\n-----------------------------------\n");

        // j.Demonstrate both versions of UpdateWeight().
        Console.WriteLine($"Original weight: {standardShipment.Weight}");

        standardShipment.UpdateWeight(4);      // version 1
        Console.WriteLine($"Updated weight: {standardShipment.Weight}");

        standardShipment.UpdateWeight(2, 2.5);  // version 2
        Console.WriteLine($"Updated weight after packing: {standardShipment.Weight}");

        Console.WriteLine("\n-----------------------------------\n");

        // k. Build a Shipment[] holding mixed types and print all of them in a loop.
        Shipment[] mixShipments = { standardShipment, expressShipment, internationalShipment };

        foreach (Shipment shipment in mixShipments)
            shipment.PrintShipment();

        #endregion
    }
}
