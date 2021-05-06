using Hotel_Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking.Controller
{
    class ReservationController
    {
        //Declare and initialize local values
        RoomController roomC = new RoomController();
        string IDandName;
        int nightsNum;


        private List<ReservationController> reservations = new List<ReservationController>(50);
          Reservation res = new Reservation();
       

      

        public void addIDandName(string str)
        {
            IDandName = str;
        }
      
        public string getIDandName()
        {
            return IDandName;
        }


        public void addReservation(ReservationController Reservation)
        {
          
            reservations.Add(Reservation);
        }

        public ReservationController getReservationAtIndex(int index)
        {
            return reservations[index];
        }

        public int getAllReservationsIndex()
        {
            return reservations.Count;
        }

      



        public List<ReservationController> getReservationsList()
        {
            return reservations;
        }


        public void setCheckeINTime(DateTime dateTime)
        {
            res.CheckeINTime = dateTime;
        }

        public DateTime getCheckeINTime()
        {
            return res.CheckeINTime;
        }

        public void setPaymnet (bool paid)
        {
            res.Paid = paid;
        }

        public bool paidOrNot()
        {
            return res.Paid;
        }

        public string getPyamnetStatues()
        {
            if (res.Paid)
            {
                return "Paid";
            }
            else
                return "Not Paid";
        }

        public int getPrice(RoomType roomType)
        {
            return res.Price(roomType);
        }


        //public RoomType getRoomType()
        //{
        //    return roomC.getRoomType();
        //}

        public RoomType getRoomType(RoomController room)
        {
            return room.getRoomType();
        }

        public void setHowManyNights(int num)
        {
            nightsNum = num;
             
        }

        public int getHowManyNights()
        {
            return nightsNum;
        }
    }
}
