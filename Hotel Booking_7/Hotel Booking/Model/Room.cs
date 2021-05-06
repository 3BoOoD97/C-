using Hotel_Booking.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking.Model
{


    class Room
    {
        //Declare values
        private int roomNumber;
        private RoomType roomTybe;


        //Set and get properties of the declared values
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public RoomType RoomTybe
        {
            get { return roomTybe; }
            set { roomTybe = value; }
        }



        // Get room description depending on RoomType
        public string RoomDescription(RoomType roomType)
        {
            string type="";
            if (roomType == RoomType.Single) {
                type = " A room assigned to one person";
            }
            else if (roomType == RoomType.Double) {
                type = "A room assigned to two people"; 
            }
            else if (roomType == RoomType.Triple) {
                type = "A room assigned to three people.";   
            }
            else if (roomType == RoomType.Quad) {
                type = "A room assigned to four people.";
            }
            else if (roomType == RoomType.Queen) {
                type = "A room with a queen-sized bed.";
            }
            else if (roomType == RoomType.King) {
                type = "A room with a king-sized bed.";
            }
            return type;
        }
    }



}
