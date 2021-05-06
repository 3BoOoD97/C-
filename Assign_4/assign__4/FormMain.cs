using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign__4
{
    public partial class FormMain : Form
    {
        Party party;
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }
        public void InitializeGUI()
        {
            NumOfGuest.Text = string.Empty;
            CostPerPerson.Text = "0.0";
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfguests = Convert.ToInt32(NumOfGuest.Text);
                party = new Party(numOfguests);
                double cost = Convert.ToDouble(CostPerPerson.Text);
                party.setCost(cost);
            }

            catch (FormatException)
            {
                MessageBox.Show("INVALID INPUT");
            }
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            try
            {
                if (party.vacantPlace())
                {
                    string first_name = Convert.ToString(FirstName.Text);
                    string last_name = Convert.ToString(LastName.Text);
                        party.addGuest(first_name, last_name);
                        string str = party.print();
                        TotalCost.Text = party.getTotalCost().ToString("n");
                        numGuest.Text = party.getIndex().ToString();
                        guesList.Items.Add(str); 
                }

                else
                    MessageBox.Show(party.maxNumOfGuest());
            } 
            catch (FormatException)
            {
                MessageBox.Show("INVALID INPUT");
            }
            catch (System.IndexOutOfRangeException )
            {     
                MessageBox.Show("INVALID INPUT");
            }
        }

            
           
        

        private void button4_Click(object sender, EventArgs e)
        {

            string selected = guesList.SelectedItem.ToString();
            int num = guesList.SelectedIndex;
            party.delteAt(num);
            TotalCost.Text = num.ToString();
            guesList.Items.Remove(guesList.SelectedItem);
            TotalCost.Text = party.getTotalCost().ToString();
            numGuest.Text = party.getIndex().ToString();
            isDeleted.Text = selected + " Is Deleted";
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            guesList.Refresh();


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeInfo.Text = ("Change the name and press ENTER to save");
            int num = guesList.SelectedIndex; // Get the index
                this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
            
            
            }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            string str = FirstName.Text;
            int num = guesList.SelectedIndex; 
            if (e.KeyChar == (char)13)
            {
                guesList.Items.RemoveAt(num);
                guesList.Items.Insert(num, party.separatorIndex(str, num).ToString());
                FirstName.Text = string.Empty;
                LastName.Text = string.Empty;
                changeInfo.Text = "";

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }

    
}

