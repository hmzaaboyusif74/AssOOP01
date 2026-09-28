using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP01
{
    public struct shipment
    {
        #region Q4
         public string TrackingCode;
         public string Description;
         public double Weight;
         public decimal DeliveryFee;
         public string Distination;

        #region Q4.1
        //public shipment(string Tcode, string Desc, double w, Decimal D)
        //{
        //    trackingcode = Tcode;
        //    description = Desc;
        //    weight = w;
        //    delivaryfe = D;
        //}
        //public string trackingcode
        //{
        //    set
        //    {
        //        TrackingCode = value == null ? TrackingCode : value;
        //    }
        //    get
        //    {
        //        return TrackingCode;
        //    }
        //}
        //public string description
        //{
        //    set
        //    {
        //        Description = value == null ? Description : value;
        //    }
        //    get
        //    {
        //        return Description;
        //    }
        //}
        //public double weight
        //{
        //    set
        //    {
        //        Weight = value < 0 ? Weight : value;
        //    }
        //    get
        //    {
        //        return Weight;
        //    }
        //}

        //public Decimal delivaryfe
        //{
        //    set
        //    {
        //        DeliveryFee = value < 0 ? DeliveryFee : value;
        //    }
        //    get
        //    {
        //        return DeliveryFee;
        //    }
        //}
        #endregion
        #region Q4.2
        //public shipment(string dis, double w, decimal deliver)
        //{
        //    distination = dis;

        //    TrackingCode = "SH-99283-EG";
        //    weight = w;
        //    setter();
        //}

        //public string trackingcode => TrackingCode;



        //public string distination
        //{
        //    set
        //    {
        //        Distination = value == null ? "invalidation" : value;
        //    }
        //    get
        //    {
        //        return Distination;
        //    }
        //}
        //public double weight
        //{
        //    set
        //    {
        //        Weight = value < 0 ? Weight : value;
        //    }
        //    get
        //    {
        //        return Weight;
        //    }
        //}

        //public Decimal getter()
        //{

        //    return DeliveryFee;
        //}
        //private Decimal setter()
        //{
        //    DeliveryFee = 20;
        //    return DeliveryFee;
        //}
        //public double EstimatedCost()
        //{
        //    double cost = (double)DeliveryFee + (Weight * 5);//20+100*5=520
        //    return cost;
        //}
        #endregion
        #region Q4.3

        //public shipment(string trackingCode)
        //{
        //    TrackingCode = trackingCode;
        //    Description = "Unknown";
        //    Weight = 1;
        //    DeliveryFee = 50;

        //}

        //public shipment(string trackingCode, string description, double weight, decimal deliveryFee, string distination)
        //{
        //    TrackingCode = trackingCode;
        //    Description = description;
        //    Weight = weight;
        //    DeliveryFee = deliveryFee;
        //    Distination = distination;
        //}
        #endregion
        #region Q4.4

        //public void UpdateDeliveryFee(decimal newFee)
        //{
        //    if (newFee > 0)
        //    {
        //        DeliveryFee = newFee;
        //    }
        //}
        //public void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight}");
        //    Console.WriteLine($"Delivery Fee: {DeliveryFee}");
        //    Console.WriteLine($"Destination: {Distination}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost()}");
        //}
        #endregion
        #endregion
    }
}


