using Hotel_Booking.Controller;
using Hotel_Booking.Model;
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
    public partial class CoustmersUI : Form
    {
        // List that is going to save all the coustmers
        internal static List<CoustmerController> coustmers = new List<CoustmerController>();

        static CoustmersUI() // Constrcouter to pass coustmers list to ReservationForm
        {
            ReservationForm.SetCustomerList(coustmers);
        }





        public CoustmersUI()
        {
            InitializeComponent();
            
        }
    


     
     

        private void add_Click(object sender, EventArgs e)
        {
            CoustmerController coustmer = new CoustmerController();// Create a new object of CoustmerController


            if (InputChecker())
            {
                //set coustmer info
                coustmer.setCoustmerName(name.Text);
                coustmer.setCoustmerAge(int.Parse(age.Text));
                coustmer.setCoustmerPersonalNumber(int.Parse(personalNum.Text));
                coustmer.setCoustmerPhoneNumber(int.Parse(phone.Text));
                coustmer.setCoustmerAdress(adress.Text);

                //Add this coustmer to coustmers list
                coustmers.Add(coustmer);
                //Display all coustmerS
                displayCoustmers();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
           // Display the coustmer info to change it
            name.Text = coustmers[coustmersList.SelectedIndex].getCoustmerName();
            age.Text = coustmers[coustmersList.SelectedIndex].getCoustmerAge().ToString();
            personalNum.Text = coustmers[coustmersList.SelectedIndex].getCoustmerPersonalNumber().ToString();
            phone.Text = coustmers[coustmersList.SelectedIndex].getCoustmerPhoneNumber().ToString();
            adress.Text = coustmers[coustmersList.SelectedIndex].getCoustmerAdress();
        }



        private void changeValue ()
        {

            // create a new object that holds the new data
            CoustmerController selectedCoustmer = new CoustmerController();
           // Add the data
                selectedCoustmer.setCoustmerName(name.Text);
                selectedCoustmer.setCoustmerAge(int.Parse(age.Text));
                selectedCoustmer.setCoustmerPersonalNumber(int.Parse(personalNum.Text));
                selectedCoustmer.setCoustmerPhoneNumber(int.Parse(phone.Text));
                selectedCoustmer.setCoustmerAdress(adress.Text);

            //replace this object instead of the old one
                coustmers[coustmersList.SelectedIndex] = selectedCoustmer;
                displayCoustmers();
        }

       

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if Enter pressed go to changeValue method
            if (e.KeyCode == Keys.Enter)
            {
                changeValue();
               
            }
        }




        private void delete_Click(object sender, EventArgs e)
        {
            coustmers.RemoveAt(coustmersList.SelectedIndex);// Remove item from coustmers List
            coustmersList.Items.Remove(coustmersList.SelectedItem); // Remove item from the lsitBox
            defultValues();// initialize values to default after removing item
            displayCoustmers();
        }

  


        private void displayCoustmers()
        {
            coustmersList.Items.Clear(); // clear the list
            int ID = 1; // assign ID for each coustmer

            foreach (CoustmerController coustmer in coustmers) //Loop to display all the coustmers
            {
                coustmer.CoustmerID = ID;
                coustmersList.Items.Add(coustmer.CoustmerID.ToString() + new string(' ', 8) + coustmer.getCoustmerName() + new string(' ', 28) + coustmer.getCoustmerAge() + new string(' ', 41) + coustmer.getCoustmerPersonalNumber() + new string(' ', 62) + coustmer.getCoustmerPhoneNumber() + new string(' ', 43) + coustmer.getCoustmerAdress());
                ID++;
            }
        }

        private void defultValues()
        {
            //defult values
            name.Text = string.Empty;
            age.Text = string.Empty;
            personalNum.Text = string.Empty;
            phone.Text = string.Empty;
            adress.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationForm CF = new ReservationForm();
            CF.ShowDialog(); // Shows ReservationForm
        }

         private bool InputChecker()
        {
            bool inputValid = false;
            if (!string.IsNullOrEmpty(age.Text) && !string.IsNullOrEmpty(phone.Text)
                && !string.IsNullOrEmpty(personalNum.Text) && !string.IsNullOrEmpty(adress.Text) && !string.IsNullOrEmpty(name.Text))
            {
                if (age.Text.All(char.IsDigit) && phone.Text.All(char.IsDigit) && personalNum.Text.All(char.IsDigit) && !adress.Text.All(char.IsDigit) && !name.Text.Any(char.IsDigit))
                {
                    inputValid = true;
                }
                else
                    MessageBox.Show("Invalid input");
            }
            else
                MessageBox.Show("fields can not be empty");
            return inputValid;
        }
    }
}
