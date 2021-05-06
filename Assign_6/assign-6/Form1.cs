using assign_6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace assign_6
{
    public partial class Form1 : Form
    {
        List<TaskManager> taskList = new List<TaskManager>();
        DateTime dateT;
        string description;
        TaskManager item;
        int itemIndex;
        PriorityType prioType;

        public Form1()
        {

            InitializeComponent();
            time.Text = DateTime.Now.ToString("HH: mm:ss"); //  time right now
            dateT = dataTime.Value;  //Defult dateTime value 
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(dataTime, "Click to open calendar for date, write in time here."); // toolTip for dataTime

            proior.DataSource = System.Enum.GetValues(typeof(PriorityType)); //Get all values from PriorityType and add them to proior
            Delete.Enabled = false;
            //Change.Enabled = false;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // When the user clicks alt+F4 it will asks if the user wants to exit
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                if (MessageBox.Show("Exit app?", "Exit message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            description = todo.Text;

        }


        private void proior_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.proior.GetItemText(this.proior.SelectedItem); //Get selected item and save it as string
            foreach (PriorityType suit in (PriorityType[])Enum.GetValues(typeof(PriorityType))) // Loop to check what PriorityType equals this string
            {
                if (string.Equals(suit.ToString(), selected)) // if the string equals to PriorityType value
                {
                    prioType = suit;    // intillize prioType value to this string
                    break; // exit the loop   
                }
            }
        }


        private void dataTime_ValueChanged(object sender, EventArgs e)
        {
            dateT = dataTime.Value; //Date and time
        }

        private void add_Click(object sender, EventArgs e) // Add a new task to the list 
        {
            Delete.Enabled = true;


            tasks.Items.Clear();
            TaskManager creatTask = new TaskManager(dateT, prioType, description); // New Task object
            taskList.Add(creatTask); // add this object to a list


            listBox1_Display(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Display(object sender, EventArgs e)
        {
            tasks.Items.Clear();
            foreach (TaskManager item in taskList)   //Get the all items in the array
            {
                tasks.Items.Add(item.getDate() + "                     -                                  " + item.getTime() + "                -            " + item.getPriorityType() + "                                     " +
                    "               -        " + item.getDescription());
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();      //When user press New the programe will restert 
            Environment.Exit(0);
        }




        private void exitALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitConformation();    //If user pressed exit go to exitConformation() method
        }


        public void exitConformation()     // Conformation Exit
        {
            if
             (
     MessageBox.Show
                         (
                             "Quit the Application",
                             "Exit Application Dialog",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning,
                             MessageBoxDefaultButton.Button2 // hit Enter == No !
                         )
                         == DialogResult.Yes
                     )
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Created by: ABOD \n Email: Abodn70@hotmail.com \n Version: 1.0");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Delete ", MessageBoxButtons.YesNo);//S tart a new  DialogResult


            if (dialogResult == DialogResult.Yes && taskList.Count >= 0)// If user pressed Yes 
            {
                int index = tasks.SelectedIndex;//Get the selected index
                taskList.RemoveAt(index);//Remove the elment that corresponding to the index
                listBox1_Display(sender, e); // Display the list after removing 

                if (taskList.Count == 0) //disable  Delete button if there are no elements in the list
                {
                    Delete.Enabled = false;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //Dont do anything if user pressed No
            }



        }

        private void Change_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After Change Press Enter To Save");
            itemIndex = tasks.SelectedIndex;//Get the selected index
            item = taskList[itemIndex];// Get the task from the list
            todo.Text = item.getDescription().ToString();
            

            this.todo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(EnterChane);
            this.proior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(EnterChane);
           this.dataTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(EnterChane);


        
                proior.SelectedIndex = proior.FindStringExact(item.getPriorityType().ToString());
                dataTime.Value = item.getDateTime();

            }
        

        private void EnterChane(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tasks.Items.Clear();

            

                description = todo.Text;
                dateT = dataTime.Value;
                proior_SelectedIndexChanged(sender, e);
                TaskManager creatTask = new TaskManager(dateT, prioType, description); // New Task object
                taskList[itemIndex] = creatTask;
             


                foreach (TaskManager item in taskList)   //Get the all items in the array
                {
                    tasks.Items.Add(item.getDate() + "                     -                                  " + item.getTime() + "                -            " + item.getPriorityType() + "                                     " +
                        "               -        " + item.getDescription());
                }
            }
        }


        }
    } 

    

