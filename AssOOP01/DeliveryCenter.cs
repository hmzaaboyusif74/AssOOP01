using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP01
{
    internal struct DeliveryCenter
    #region Q5
    {
        private shipment[] _Shipment = new shipment[10];
        public DeliveryCenter() { }

        public void getshippment(int postion, string trackingcode, string description, double weight, decimal deliveryFee, string distination)
        {
            _Shipment[postion].TrackingCode = trackingcode;
            _Shipment[postion].Description = description;
            _Shipment[postion].Weight = weight;
            _Shipment[postion].DeliveryFee = deliveryFee;
            _Shipment[postion].Distination = distination;
        }

        public shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _Shipment.Length)
                {
                    return _Shipment[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < _Shipment.Length)
                {
                    _Shipment[index] = value;
                }
            }
        }
        public shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _Shipment.Length; i++)
                {
                    if (_Shipment[i].TrackingCode == trackingCode)
                    {
                        return _Shipment[i];
                    }
                }
                return default;
            }
        }

        public bool AddShipment(shipment newShipment)
        {
            for (int i = 0; i < _Shipment.Length; i++)
            {

                if (string.IsNullOrEmpty(_Shipment[i].TrackingCode))
                {
                    _Shipment[i] = newShipment;
                    return true;
                }

            }
            return false;
        }
    } 
#endregion
}

