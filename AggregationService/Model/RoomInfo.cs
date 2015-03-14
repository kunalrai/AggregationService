using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AggregationService.Model
{
    [DataContract(Namespace=Namespaces.Hotelpopcorn)]
    public class RoomInfo
    {
        private int roomPrice;

        [DataMember]
        public int RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }

    }
}
