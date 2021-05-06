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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Coustmers_Click(object sender, EventArgs e)
        {
            //If the User clicked on Coustmers go to CoustmersUI
            CoustmersUI CF = new CoustmersUI();
            CF.ShowDialog(); // Shows CoustmerForm
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            //If the User clicked on Coustmers go to ReservationForm
            ReservationForm RF = new ReservationForm();
            RF.ShowDialog(); // Shows CoustmerForm
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Exit Confirmation
            var dlgResult = MessageBox.Show("Are You Sure ?", "?", MessageBoxButtons.YesNo);
            //If the user clicked Yes
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); // close the connection setup form
            }   
        }
    }
}
