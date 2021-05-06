using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double hight = 0;
        double weight = 0;
        String strname;
        public Form1()
        {
            InitializeComponent();
            strname = "NO NAME"; //Defult name
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            int curOdo = 0;
            int prevOdo = 0;
            int curAmount = 0;
            double price = 0.0;


            //Create an object of FuelController
            Controller.FuelController fControl = new Controller.FuelController(previousOdo.Text, curentOdo.Text, currentAmount.Text, priceLit.Text);

            // If the values are not empty and numeric
            if (fControl.checkIfEmptyFuel()&&fControl.checkIfNumericFuel())
            {
                //Convert values from string to int
                curOdo = Convert.ToInt32(curentOdo.Text);
                prevOdo = Convert.ToInt32(previousOdo.Text);
                curAmount = int.Parse(currentAmount.Text);
                price = Convert.ToDouble(priceLit.Text);


                if (curOdo > prevOdo && prevOdo >= 0 && price >= 0)
                {
                    //call createFuelController that creats an object of fuelCalculator and assign the values
                    fControl.createFuelController(curOdo, prevOdo, curAmount, price);
                    fuelCons_km_lit.Text = fControl.fuelCons_km_lit().ToString("n");
                    fuelCons_lit_km.Text = fControl.fuelCons_lit_km().ToString("n");
                    fuelCons_lit_met_mile.Text = fControl.fuelCons_lit_metric().ToString("n");
                    fuelCons_lit_swe_mil.Text = fControl.fuelCons_lit_swe().ToString("n");
                    CosPerKilometer.Text = fControl.costPerKilometer().ToString("n");
                }
                //If the above conidtion is false 
                else
                    MessageBox.Show("OBS ! something went wrong \n" +
                        "- Current odometer should be grater than previous odometer \n" +
                    "- Previous odometer should be grater or equal zero \n" +
                    "- Price should be grater or equal zero \n");

            }
            //If the first conidtion is false 
            else
                MessageBox.Show("OBS ! something went wrong \n" +
                    "* Programme rules :\n" +
                    "- Values cant be empty or string");

            
           
            }

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Exit Dialog
            DialogResult dr = MessageBox.Show("Are you sure you want to EXIT the programme", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void res_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void curentOdo_TextChanged(object sender, EventArgs e)
        {

    
        }

        private void BMIres_Click(object sender, EventArgs e)
        {
            //Assign the values
            strname = UserName.Text;
            String strHight = Hight.Text;
            String strWeight = Weight.Text;

            // Create a new object of BmiController to check the input. Here we call the constructor that takes two string 

            BmiController check = new BmiController(strHight, strWeight);

            //If the values are not empty and Numeric
            if (check.checkIbm())
            {
                //Convert from string to double
                hight = Convert.ToDouble(strHight);
                weight = Convert.ToDouble(strWeight);

                if (hight > 0 && weight > 0)
                {
                    //After check completed create a new object. Here we call the constructor that takes one string and two double
                    Controller.BmiController obj = new BmiController(strname, hight, weight);


                    if (Munit.Checked)
                    {
                        BMIres.Text = obj.metric().ToString("n");
                        Wcata.Text = obj.nutritionalStatus();
                    }
                    else if (Uunit.Checked)
                    {
                        BMIres.Text = obj.american().ToString("n");
                        Wcata.Text = obj.nutritionalStatus();
                    }
                    //If user didnt pick an option
                    else
                        MessageBox.Show("Choose an option");
                }
                //if the second condition is false
                else
                    MessageBox.Show("Values cant be less than or equal zero");

            }
            //if the first condition is false
            else
                MessageBox.Show("Values cant be empty or string ");
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void BMRcal_Click(object sender, EventArgs e)
        {
            //convert from string to int
            int age = Convert.ToInt32(userAge.Text);

            //Create a new object of maintainWeightCaloriesController 
            Controller.maintainWeightCaloriesController mwc = new Controller.maintainWeightCaloriesController(weight,hight,age);
            
            //if the name is empty assign it to defult name
            if (String.IsNullOrEmpty(strname))
            {
                strname = "NO NAME";
            }

            //Key words that we need to use
            BMRlist.Items.Add("BMR RESULTS FOR : "+strname);
            String BMR_Day = "Yout BMR (Calories/Day)  :";
            String ToMaintain = "Calories to maintain your weight  :";
            string lose50 = "Calories to lose 0.5 KG per week  :";
            string lose100 = "Calories to lose 1 KG per week  :";
            string gain50 = "Calories to gain 0.5 KG per week  :";
            string gain100 = "Calories to gain 1 KG per week  :";
           
            //options that the user can choose
            if (Sedentary.Checked && Female.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRFemale()); ;
                BMRlist.Items.Add(ToMaintain + mwc.sedentaryMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (LightlyActive.Checked && Female.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRFemale());
               BMRlist.Items.Add(ToMaintain + mwc.lightlyActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (ModeratelyActive.Checked && Female.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRFemale());
                BMRlist.Items.Add(ToMaintain + mwc.moderatelyActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (VeryActive.Checked && Female.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRFemale());
                BMRlist.Items.Add(ToMaintain + mwc.veryActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (ExtraActive.Checked && Female.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRFemale());
                BMRlist.Items.Add(ToMaintain + mwc.extraActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (Sedentary.Checked && Male.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRMale());
                BMRlist.Items.Add(BMR_Day + mwc.sedentaryMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (LightlyActive.Checked && Male.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRMale());
                BMRlist.Items.Add(ToMaintain + mwc.lightlyActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (ModeratelyActive.Checked && Male.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRMale());
                BMRlist.Items.Add(ToMaintain + mwc.moderatelyActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (VeryActive.Checked && Male.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRMale());
                BMRlist.Items.Add(ToMaintain + mwc.veryActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

            else if (ExtraActive.Checked && Male.Checked)
            {
                BMRlist.Items.Add(BMR_Day + mwc.BMRMale());
                BMRlist.Items.Add(ToMaintain + mwc.extraActiveMaintainWeightCalories());
                BMRlist.Items.Add(lose50 + mwc.lose500gr());
                BMRlist.Items.Add(lose100 + mwc.lose1000gr());
                BMRlist.Items.Add(gain50 + mwc.add500gr());
                BMRlist.Items.Add(gain100 + mwc.add1000gr());
            }

           //If the user didnt choose an option
            else
                MessageBox.Show("Please Select an option");


            BMRlist.Items.Add(mwc.loseOrGain());
        }

        private void Hight_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMRlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem.Text = BMRlist.SelectedIndex.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BMRlist.ClearSelected();
        }

        private void tryt_Click(object sender, EventArgs e)
        {
             
            tryt.Text = BMRlist.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BMRlist.SelectedIndex.ToString());
        }
    }
}
