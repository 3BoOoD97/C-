using assign_5.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign_5
{
    public partial class Form1 : Form
    {
        public NameController nameC= new NameController();
        public UpdateListController updateC = new UpdateListController();
        public AdressController adressC = new AdressController();
        public ArrayList tr;
        public Form1()
        {
            InitializeComponent();
            Country.Text = "Select Country ";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void showList()    //print the contact list method

        {
            Mlist.Items.Clear();
            int count = 0;
            for (int i = 0; i < tr.Count; i++)
            {
                count++;
                Mlist.Items.Add(count + "  -  " + tr[i].ToString());
            }
            int leangth = tr.Count;
            Records.Text = Convert.ToString(leangth.ToString());
        }


        private void Add_Click(object sender, EventArgs e) // add 
        {
            
            string firstName = FName.Text;
            string lastNmae = LName.Text;
            string street = Street.Text;
            string zip = ZipC.Text;
            string city = City.Text;
            int countryIndex = Country.SelectedIndex;

            nameC.SetFirstName(firstName);
            nameC.SetLastName(lastNmae);
            adressC.setCity(city);
            adressC.setStreet(street);
            adressC.setZip(zip);
            // After initialize values we  add it to the array and update it
            tr = updateC.updateList(nameC, adressC, countryIndex); 

            //show the list after add
            showList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int deleteIndex = Mlist.SelectedIndex ;
            updateC.Remove(deleteIndex);
            showList();

        }

        private void Change_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change values and press ENTER once you are done!");

            int changeIndex = Mlist.SelectedIndex;
            // print an element of the array with apecifc index divided into FirstName,LastName,Street,City,Country. So user can adjust more easily  
            FName.Text = updateC.getFirstNameFromList(changeIndex);
            LName.Text = updateC.getLastNameFromList();
            Street.Text = updateC.getStreetFromList();
            City.Text = updateC.getCityFromList();
            ZipC.Text = updateC.getZipFromList();
            Country.SelectedIndex = updateC.getCountryFromList();


            //When the user click ENTER it means he/she changes and now it is ready to be changed in the arraylist
            this.FName.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnter);

            this.LName.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnter);


            this.Street.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnter);

            this.City.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnter);

            this.ZipC.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.Country.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(CheckEnter);

        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int changeIndex = Mlist.SelectedIndex;

                //Gather every values in the fields and initialize it to one string and then replace the old string by this one
                string str = FName.Text + "," + LName.Text + "-" + Street.Text + "-" + City.Text + "-" + ZipC.Text;
                updateC.changeInfo(changeIndex, str);

                showList();
            }
        }
        private void Country_SelectedItemChanged(object sender, EventArgs e)
        {
            Country.Items.Add("United States Of America");
            Country.Items.Add("Sweden");
            Country.Items.Add("Jamaica");
            Country.Items.Add("The Netherlands");
            Country.Items.Add("Spain");
            Country.Items.Add("Somewhere Else");
          

        }
    }
}
