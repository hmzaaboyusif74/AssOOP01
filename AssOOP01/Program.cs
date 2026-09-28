using System.Security.Cryptography.X509Certificates;

namespace AssOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // the first one is struct and it is value type then have copy of variable and main variable not change
            //the secound one is class and it is refrance type and any change can effect on it but string is special type becouse it is immutable any change create new data
            #endregion
            #region Q2
            /*problems
             1-can not create any validation on filed 
            2- public filed then any can can modify on it direct
            3-hard maintance after that
            */

            /*private int age;
              public int Age{
              set{age=value;}{
              get{return age}*/
            //1-make it private
            //2-can control and validation by set & get
            //3-can maintance later
            #endregion
            #region Q3
            //Dlivaryaddress location1= new Dlivaryaddress("shibin elKon", "elestaadStreet", 25) ;
            //Console.WriteLine($"{location1.BuildingNumber}      {location1.City}        {location1.Street}");//all constractor
            //Dlivaryaddress location2 = location1;
            //location2.City = "cairo";
            //location2.BuildingNumber = 18;
            //Console.WriteLine();
            //Console.WriteLine($"the location one{location1.BuildingNumber}      {location1.City}        {location1.Street}");
            //Console.WriteLine();
            //Console.WriteLine($"the location two :{location2.BuildingNumber}      {location2.City}        {location2.Street}");//after change by value type
            #endregion
            #region Q4.1
            //shipment data = new shipment("SH-99283-EG", "Electronics - Laptop", 50, 200);
            //Console.WriteLine($" the data is : {data.trackingcode}   {data.delivaryfe}   {data.weight}   {data.description}");
            ////check validation
            //shipment data01 = new shipment("SH-99283-EG", "Electronics - Laptop", 50, 200);
            //data01.trackingcode = null;
            //Console.WriteLine(data01.trackingcode);
            //data01.weight = -12;
            //Console.WriteLine(data01.weight);
            #endregion
            #region Q4.2
            //shipment Data = new shipment("shibin elkom", 100, 125);
            //Console.WriteLine(Data.trackingcode);
            //Console.WriteLine(Data.EstimatedCost());
            //Data.PrintShipment();  //Q4.4
            #endregion
            #region Q5
            DeliveryCenter Datacenter= new DeliveryCenter();
            for(int i=0; i<1; i++)
            {
                Console.WriteLine("enter trackingcode ");
                string? trackingcode=Console.ReadLine();
                Console.WriteLine("enter Description  ");
                string? descriptionsc = Console.ReadLine();
                Console.WriteLine("enter weight");
                Double weight = double.Parse( Console.ReadLine());
                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());
                Console.Write("Destination: ");
                string? destination = Console.ReadLine();
                Datacenter.getshippment(i,trackingcode,descriptionsc,weight,deliveryFee,destination);
            }
          
            shipment firstShipment = Datacenter[0];
            Console.WriteLine($"First Shipment Code: {firstShipment.TrackingCode}");

          
            Console.Write("Enter tracking code to search: ");
            string searchcode = Console.ReadLine()!;
            shipment searche = Datacenter[searchcode];

            Console.WriteLine($" Destination is : {searche.Distination}");
            #endregion
        }
    }
}
