using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AggregationService.Model
{
    [DataContract(Namespace=Namespaces.Hotelpopcorn)]
    public class HotelDetail
    {
        private int id;
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string hotelName;
        [DataMember]
        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }


        private int rating;
        [DataMember]
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private string address;
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string geoCode;
        [DataMember]
        public string Geocode
        {
            get { return geoCode; }
            set { geoCode = value; }
        }

        private RoomInfo roomdetails;
        [DataMember]
        public RoomInfo RoomDetails
        {
            get { return roomdetails; }
            set { roomdetails = value; }
        }


    }
}
