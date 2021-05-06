using Hotel_Booking.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking
{
    public partial class ReservationForm : Form
    {

        RoomController roomC = new RoomController();
        ReservationController res = new ReservationController(); // an object that holds values 
        ReservationController reservations = new ReservationController(); // an object to use it to save values

        private static List<CoustmerController> cousmters;

        public static void SetCustomerList(List<CoustmerController> CustomersList)
        {
            // Get coustmers list from CoustmersUI
            cousmters = CustomersList;
        }

        public ReservationForm()
        {

            InitializeComponent();

            //Defult 
            roomType.DataSource = Enum.GetValues(typeof(RoomType)); // initialize roomType by passing RoomType values 
            checkInTime.Enabled = false; 
            paidYes.Enabled = false;
            paidNo.Enabled = false;
            HoManyN.Enabled = false;
            checkedInList.BackColor = Color.LightGray;

            if (cousmters != null) // If there is at least a coustmer Display
            {
                display(); 
            }
            else
                MessageBox.Show("You need to add Coustmers First !");
        }



        private void display()
        {
            coustmersList.Items.Clear();
            int ID = 1;
            foreach (CoustmerController coustmer in cousmters) //Loop to display all the coustmers
            {
                coustmersList.Items.Add(coustmer.CoustmerID.ToString() + new string(' ', 8)
                 + coustmer.getCoustmerName());
                ID++;
            }
        }
 

        private void coustmersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            coustmerName.Text = cousmters[coustmersList.SelectedIndex].getCoustmerName();
            coustmerID.Text = cousmters[coustmersList.SelectedIndex].CoustmerID.ToString();
        }



        private void CheckedIn_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CheckedIn.Checked)
            {
                // If the user Checked the CheckedIn check box enable all the following:
                checkInTime.Enabled = true;
                paidYes.Enabled = true;
                paidNo.Enabled = true;
                HoManyN.Enabled = true;
            }

            if (!CheckedIn.Checked)
            {
                // If the user not Checked the  CheckedIn check box disable all the following:

                checkInTime.Enabled = false;
                paidYes.Enabled = false;
                paidNo.Enabled = false;

            }
        }

        private void paidNo_CheckedChanged(object sender, EventArgs e)
        {
            if (paidNo.Checked)
            {
                //If not paid is chacked set false
                res.setPaymnet(false);
            }
        }

        private void paidYes_CheckedChanged(object sender, EventArgs e)
        {
            if (paidYes.Checked)
            {
                //If not paid is chacked set true
                res.setPaymnet(true);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected room description depnding on it's type
            roomDescription.Text = roomC.getRoomDescription((RoomType)roomType.SelectedItem);
            // Get the price of this room
            roomPrice.Text = res.getPrice((RoomType)roomType.SelectedItem).ToString() + " €";
        }

       


        private void checkInTime_ValueChanged(object sender, EventArgs e)
        {
           
            res.setCheckeINTime(this.checkInTime.Value.Date);// Set checkInTime

        }

        private void addRes_Click(object sender, EventArgs e)
        {
            // Set the room type
            roomC.setRoomTybe((RoomType)Enum.Parse(typeof(RoomType), roomType.Text));
            // Get the coustmer name and ID from the selected coustmer in coustmersList and set it in res object 
            res.addIDandName(coustmersList.SelectedItem.ToString());
            //set how many nights the coustmer want to stay
            res.setHowManyNights(int.Parse(HoManyN.Text));
            //Add this resveration to reservations so we can use it as a list
            reservations.addReservation(res);

            checkedInList.Items.Clear();
            //Display all the coustmers in the list
            for (int i = 0; i < reservations.getAllReservationsIndex(); i++)
            {
                checkedInList.Items.Add(reservations.getReservationAtIndex(i).getIDandName() + "      " + reservations.getReservationAtIndex(i).getPyamnetStatues() + "            " + reservations.getReservationAtIndex(i).getCheckeINTime() + "                 " + reservations.getReservationAtIndex(i).getRoomType(roomC).ToString()+ "                   " + reservations.getReservationAtIndex(i).getHowManyNights().ToString());
            }

            //After adding res to the list clear it's data so we can add a new coustmer 
            res = new ReservationController();
        }

     
        private void HoManyN_SelectedIndexChanged(object sender, EventArgs e)
        {
         
          
            if (HoManyN.SelectedItem != null)
            {
                //Get totall price depanding on the room price per night and the totall nights a coustmer wants to stay
                int x = int.Parse(HoManyN.SelectedItem.ToString());
                x = x * res.getPrice((RoomType)roomType.SelectedItem);
                totalPrice.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("no value");
            }
        }
    }
}
