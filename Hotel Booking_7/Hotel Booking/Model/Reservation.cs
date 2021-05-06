using Hotel_Booking.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking.Model
{
    class Reservation
    {
        //Declare values
        private bool paid;
        private DateTime checkeINTime;

        //Set and get properties of the declared values
        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public DateTime CheckeINTime
        {
            get { return checkeINTime; }
            set { checkeINTime = value; }
        }

        //Get a price depending on RoomType
        public int Price(RoomType roomType)
        {
            int price = 0;

            if (roomType == RoomType.Single)
            {
                price = 70;
            }
            else if (roomType == RoomType.Double)
            {
                price = 130;
            }
            else if (roomType == RoomType.Triple)
            {
                price = 180;
            }
            else if (roomType == RoomType.Quad)
            {
                price = 220;
            }
            else if (roomType == RoomType.Queen)
            {
                price = 260;
            }
            else if (roomType == RoomType.King)
            {
                price = 300;
            }
            return price;
        }

    }
}
