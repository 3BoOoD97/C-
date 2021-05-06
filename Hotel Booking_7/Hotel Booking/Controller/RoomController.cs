using Hotel_Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking.Controller
{
    class RoomController
    {
    //Declare and initialize local values
        private Room room = new Room();
        //private int SingleBooked = 0;
        //private int DoubleBooked = 6;
        //private int TripleBooked = 11;
        //private int QuadBooked = 16;
        //private int QueenBooked = 21;
        //private int KingBooked = 26;


        

        public void setRoomTybe(RoomType roomType)
        {
            room.RoomTybe = roomType;
        }

        public RoomType getRoomType()
        {
            return room.RoomTybe;
        }

        //Get room description from room in model package
        public string getRoomDescription(RoomType roomType)
        {
            return room.RoomDescription(roomType);
        }

        //If the there is enough rooms return true   
        //public bool isAvilable()
        //{
        //    bool check = false;

        //    if (SingleBooked + 1 < 6 && DoubleBooked + 1 < 11 && TripleBooked + 1 < 16 && QuadBooked + 1 < 21 && KingBooked + 1 < 26)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}


        // Assign room number
        //public int roomNumber(RoomType roomType, List<ReservationController> reservations)
        //{
        //    int  num = 0; 

        //    foreach (ReservationController reservation in reservations)
        //    {

        //        if (reservation.getRoomType() == RoomType.Single)
        //        {
        //            SingleBooked++;
        //            num = SingleBooked;
        //        }
        //        else if (reservation.getRoomType() == RoomType.Double)
        //        {
        //            DoubleBooked++;
        //            num = DoubleBooked;
        //        }
        //        else if (reservation.getRoomType() == RoomType.Triple)
        //        {
        //            TripleBooked++;
        //            num = TripleBooked;
        //        }
        //        else if (reservation.getRoomType() == RoomType.Quad)
        //        {
        //            QuadBooked++;
        //            num = QuadBooked;
        //        }
        //        else if (reservation.getRoomType() == RoomType.Queen)
        //        {

        //            QueenBooked++;
        //            num = QueenBooked;
        //        }
        //        else if (reservation.getRoomType() == RoomType.King)
        //        {
        //            KingBooked++;
        //            num = KingBooked;
        //        }
        //    }
        //    return num;
        //}

    }

    }


    enum RoomType
    {
        Single,
        Double,
        Triple,
        Quad,
        Queen,
        King

    }

