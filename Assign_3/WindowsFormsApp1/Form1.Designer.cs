namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Munit = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.fuelRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.curentOdo = new System.Windows.Forms.TextBox();
            this.currentAmount = new System.Windows.Forms.TextBox();
            this.previousOdo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CosPerKilometer = new System.Windows.Forms.Label();
            this.fuelCons_lit_swe_mil = new System.Windows.Forms.Label();
            this.fuelCons_lit_met_mile = new System.Windows.Forms.Label();
            this.fuelCons_lit_km = new System.Windows.Forms.Label();
            this.fuelCons_km_lit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BMIres = new System.Windows.Forms.Label();
            this.Wcata = new System.Windows.Forms.Label();
            this.Uunit = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.BMIcalc = new System.Windows.Forms.Button();
            this.Hight = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.userAge = new System.Windows.Forms.TextBox();
            this.Sedentary = new System.Windows.Forms.RadioButton();
            this.LightlyActive = new System.Windows.Forms.RadioButton();
            this.ModeratelyActive = new System.Windows.Forms.RadioButton();
            this.VeryActive = new System.Windows.Forms.RadioButton();
            this.ExtraActive = new System.Windows.Forms.RadioButton();
            this.BMRcal = new System.Windows.Forms.Button();
            this.BMRlist = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectedItem = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.tryt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Munit
            // 
            this.Munit.AutoSize = true;
            this.Munit.ForeColor = System.Drawing.Color.Green;
            this.Munit.Location = new System.Drawing.Point(254, 113);
            this.Munit.Name = "Munit";
            this.Munit.Size = new System.Drawing.Size(153, 21);
            this.Munit.TabIndex = 4;
            this.Munit.TabStop = true;
            this.Munit.Text = "Metric unit (cm , kg)";
            this.Munit.UseVisualStyleBackColor = true;
            this.Munit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(21, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fuel consumption (km/lit)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fuelRes
            // 
            this.fuelRes.Location = new System.Drawing.Point(94, 166);
            this.fuelRes.Name = "fuelRes";
            this.fuelRes.Size = new System.Drawing.Size(150, 34);
            this.fuelRes.TabIndex = 0;
            this.fuelRes.Text = "Calculate";
            this.fuelRes.UseVisualStyleBackColor = true;
            this.fuelRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price per liter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceLit
            // 
            this.priceLit.Location = new System.Drawing.Point(342, 127);
            this.priceLit.Name = "priceLit";
            this.priceLit.Size = new System.Drawing.Size(57, 22);
            this.priceLit.TabIndex = 2;
            this.priceLit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current odometer reading (km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current amount of fuel tanked (liters)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Previous odometer reading (km)";
            // 
            // curentOdo
            // 
            this.curentOdo.Location = new System.Drawing.Point(299, 34);
            this.curentOdo.Name = "curentOdo";
            this.curentOdo.Size = new System.Drawing.Size(100, 22);
            this.curentOdo.TabIndex = 10;
            this.curentOdo.TextChanged += new System.EventHandler(this.curentOdo_TextChanged);
            // 
            // currentAmount
            // 
            this.currentAmount.Location = new System.Drawing.Point(342, 95);
            this.currentAmount.Name = "currentAmount";
            this.currentAmount.Size = new System.Drawing.Size(57, 22);
            this.currentAmount.TabIndex = 11;
            // 
            // previousOdo
            // 
            this.previousOdo.Location = new System.Drawing.Point(299, 62);
            this.previousOdo.Name = "previousOdo";
            this.previousOdo.Size = new System.Drawing.Size(100, 22);
            this.previousOdo.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.previousOdo);
            this.groupBox1.Controls.Add(this.currentAmount);
            this.groupBox1.Controls.Add(this.curentOdo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.priceLit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fuelRes);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 479);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(23, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fuel consumption (lit/km)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(21, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fuel consumption (lit/metric mil )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(21, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fuel consumption (lit/Swe mil)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(23, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cost per kilometer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CosPerKilometer);
            this.groupBox2.Controls.Add(this.fuelCons_lit_swe_mil);
            this.groupBox2.Controls.Add(this.fuelCons_lit_met_mile);
            this.groupBox2.Controls.Add(this.fuelCons_lit_km);
            this.groupBox2.Controls.Add(this.fuelCons_km_lit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 194);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CosPerKilometer
            // 
            this.CosPerKilometer.AutoSize = true;
            this.CosPerKilometer.ForeColor = System.Drawing.Color.Blue;
            this.CosPerKilometer.Location = new System.Drawing.Point(344, 152);
            this.CosPerKilometer.Name = "CosPerKilometer";
            this.CosPerKilometer.Size = new System.Drawing.Size(0, 17);
            this.CosPerKilometer.TabIndex = 28;
            // 
            // fuelCons_lit_swe_mil
            // 
            this.fuelCons_lit_swe_mil.AutoSize = true;
            this.fuelCons_lit_swe_mil.ForeColor = System.Drawing.Color.Blue;
            this.fuelCons_lit_swe_mil.Location = new System.Drawing.Point(343, 120);
            this.fuelCons_lit_swe_mil.Name = "fuelCons_lit_swe_mil";
            this.fuelCons_lit_swe_mil.Size = new System.Drawing.Size(0, 17);
            this.fuelCons_lit_swe_mil.TabIndex = 27;
            // 
            // fuelCons_lit_met_mile
            // 
            this.fuelCons_lit_met_mile.AutoSize = true;
            this.fuelCons_lit_met_mile.ForeColor = System.Drawing.Color.Blue;
            this.fuelCons_lit_met_mile.Location = new System.Drawing.Point(344, 87);
            this.fuelCons_lit_met_mile.Name = "fuelCons_lit_met_mile";
            this.fuelCons_lit_met_mile.Size = new System.Drawing.Size(0, 17);
            this.fuelCons_lit_met_mile.TabIndex = 26;
            // 
            // fuelCons_lit_km
            // 
            this.fuelCons_lit_km.AutoSize = true;
            this.fuelCons_lit_km.ForeColor = System.Drawing.Color.Blue;
            this.fuelCons_lit_km.Location = new System.Drawing.Point(343, 53);
            this.fuelCons_lit_km.Name = "fuelCons_lit_km";
            this.fuelCons_lit_km.Size = new System.Drawing.Size(0, 17);
            this.fuelCons_lit_km.TabIndex = 25;
            // 
            // fuelCons_km_lit
            // 
            this.fuelCons_km_lit.AutoSize = true;
            this.fuelCons_km_lit.ForeColor = System.Drawing.Color.Blue;
            this.fuelCons_km_lit.Location = new System.Drawing.Point(344, 18);
            this.fuelCons_km_lit.Name = "fuelCons_km_lit";
            this.fuelCons_km_lit.Size = new System.Drawing.Size(0, 17);
            this.fuelCons_km_lit.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Your BMI";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Weight Category";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(107, 403);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Normal BMI is between 18.5 and 24.9";
            // 
            // BMIres
            // 
            this.BMIres.AutoSize = true;
            this.BMIres.ForeColor = System.Drawing.Color.Blue;
            this.BMIres.Location = new System.Drawing.Point(233, 325);
            this.BMIres.Name = "BMIres";
            this.BMIres.Size = new System.Drawing.Size(0, 17);
            this.BMIres.TabIndex = 37;
            // 
            // Wcata
            // 
            this.Wcata.AutoSize = true;
            this.Wcata.ForeColor = System.Drawing.Color.Blue;
            this.Wcata.Location = new System.Drawing.Point(233, 359);
            this.Wcata.Name = "Wcata";
            this.Wcata.Size = new System.Drawing.Size(0, 17);
            this.Wcata.TabIndex = 38;
            // 
            // Uunit
            // 
            this.Uunit.AutoSize = true;
            this.Uunit.ForeColor = System.Drawing.Color.Green;
            this.Uunit.Location = new System.Drawing.Point(254, 149);
            this.Uunit.Name = "Uunit";
            this.Uunit.Size = new System.Drawing.Size(136, 21);
            this.Uunit.TabIndex = 5;
            this.Uunit.TabStop = true;
            this.Uunit.Text = "US Unit (inch ,lb)";
            this.Uunit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Your name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Hight";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Weight";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(187, 17);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(195, 22);
            this.UserName.TabIndex = 28;
            // 
            // BMIcalc
            // 
            this.BMIcalc.Location = new System.Drawing.Point(65, 137);
            this.BMIcalc.Name = "BMIcalc";
            this.BMIcalc.Size = new System.Drawing.Size(140, 32);
            this.BMIcalc.TabIndex = 29;
            this.BMIcalc.Text = "Calculate";
            this.BMIcalc.UseVisualStyleBackColor = true;
            this.BMIcalc.Click += new System.EventHandler(this.BMIres_Click);
            // 
            // Hight
            // 
            this.Hight.Location = new System.Drawing.Point(292, 50);
            this.Hight.Name = "Hight";
            this.Hight.Size = new System.Drawing.Size(90, 22);
            this.Hight.TabIndex = 30;
            this.Hight.TextChanged += new System.EventHandler(this.Hight_TextChanged);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(292, 78);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(90, 22);
            this.Weight.TabIndex = 31;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.Color.DarkGreen;
            this.Female.Location = new System.Drawing.Point(26, 14);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 21);
            this.Female.TabIndex = 39;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.ForeColor = System.Drawing.Color.DarkGreen;
            this.Male.Location = new System.Drawing.Point(236, 14);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(59, 21);
            this.Male.TabIndex = 40;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(32, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Age";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // userAge
            // 
            this.userAge.Location = new System.Drawing.Point(349, 48);
            this.userAge.Name = "userAge";
            this.userAge.Size = new System.Drawing.Size(56, 22);
            this.userAge.TabIndex = 42;
            // 
            // Sedentary
            // 
            this.Sedentary.AutoSize = true;
            this.Sedentary.ForeColor = System.Drawing.Color.DarkGreen;
            this.Sedentary.Location = new System.Drawing.Point(18, 16);
            this.Sedentary.Name = "Sedentary";
            this.Sedentary.Size = new System.Drawing.Size(227, 21);
            this.Sedentary.TabIndex = 43;
            this.Sedentary.TabStop = true;
            this.Sedentary.Text = "Sedentary(Little or no exercise)";
            this.Sedentary.UseVisualStyleBackColor = true;
            // 
            // LightlyActive
            // 
            this.LightlyActive.AutoSize = true;
            this.LightlyActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.LightlyActive.Location = new System.Drawing.Point(18, 43);
            this.LightlyActive.Name = "LightlyActive";
            this.LightlyActive.Size = new System.Drawing.Size(299, 21);
            this.LightlyActive.TabIndex = 44;
            this.LightlyActive.TabStop = true;
            this.LightlyActive.Text = "Lightly active(Exercise 1 to 3 times a week)";
            this.LightlyActive.UseVisualStyleBackColor = true;
            // 
            // ModeratelyActive
            // 
            this.ModeratelyActive.AutoSize = true;
            this.ModeratelyActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.ModeratelyActive.Location = new System.Drawing.Point(18, 70);
            this.ModeratelyActive.Name = "ModeratelyActive";
            this.ModeratelyActive.Size = new System.Drawing.Size(335, 21);
            this.ModeratelyActive.TabIndex = 45;
            this.ModeratelyActive.TabStop = true;
            this.ModeratelyActive.Text = "Moderately active(Exercises 4 to 5 times a week)";
            this.ModeratelyActive.UseVisualStyleBackColor = true;
            // 
            // VeryActive
            // 
            this.VeryActive.AutoSize = true;
            this.VeryActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.VeryActive.Location = new System.Drawing.Point(18, 97);
            this.VeryActive.Name = "VeryActive";
            this.VeryActive.Size = new System.Drawing.Size(294, 21);
            this.VeryActive.TabIndex = 46;
            this.VeryActive.TabStop = true;
            this.VeryActive.Text = "Very active(Exercises 6 to 7 times a week)";
            this.VeryActive.UseVisualStyleBackColor = true;
            // 
            // ExtraActive
            // 
            this.ExtraActive.AutoSize = true;
            this.ExtraActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.ExtraActive.Location = new System.Drawing.Point(18, 124);
            this.ExtraActive.Name = "ExtraActive";
            this.ExtraActive.Size = new System.Drawing.Size(294, 21);
            this.ExtraActive.TabIndex = 47;
            this.ExtraActive.TabStop = true;
            this.ExtraActive.Text = "Extra active(Hard exercise or physical job)";
            this.ExtraActive.UseVisualStyleBackColor = true;
            // 
            // BMRcal
            // 
            this.BMRcal.Location = new System.Drawing.Point(82, 264);
            this.BMRcal.Name = "BMRcal";
            this.BMRcal.Size = new System.Drawing.Size(150, 36);
            this.BMRcal.TabIndex = 48;
            this.BMRcal.Text = "Calculate";
            this.BMRcal.UseVisualStyleBackColor = true;
            this.BMRcal.Click += new System.EventHandler(this.BMRcal_Click);
            // 
            // BMRlist
            // 
            this.BMRlist.FormattingEnabled = true;
            this.BMRlist.ItemHeight = 16;
            this.BMRlist.Location = new System.Drawing.Point(529, 21);
            this.BMRlist.Name = "BMRlist";
            this.BMRlist.Size = new System.Drawing.Size(564, 244);
            this.BMRlist.TabIndex = 49;
            this.BMRlist.SelectedIndexChanged += new System.EventHandler(this.BMRlist_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.SelectedItem);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.BMRlist);
            this.groupBox3.Controls.Add(this.BMRcal);
            this.groupBox3.Controls.Add(this.userAge);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Male);
            this.groupBox3.Controls.Add(this.Female);
            this.groupBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 485);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1099, 316);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 53;
            this.button1.Text = "Unselect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SelectedItem
            // 
            this.SelectedItem.AutoSize = true;
            this.SelectedItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectedItem.Location = new System.Drawing.Point(516, 320);
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(0, 17);
            this.SelectedItem.TabIndex = 52;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ExtraActive);
            this.groupBox4.Controls.Add(this.VeryActive);
            this.groupBox4.Controls.Add(this.ModeratelyActive);
            this.groupBox4.Controls.Add(this.LightlyActive);
            this.groupBox4.Controls.Add(this.Sedentary);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(8, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 178);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Activity level per week";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Wcata);
            this.groupBox5.Controls.Add(this.BMIres);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.Weight);
            this.groupBox5.Controls.Add(this.Hight);
            this.groupBox5.Controls.Add(this.BMIcalc);
            this.groupBox5.Controls.Add(this.UserName);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.Uunit);
            this.groupBox5.Controls.Add(this.Munit);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(519, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(597, 479);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BMI";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(460, 807);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 28);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tryt
            // 
            this.tryt.AutoSize = true;
            this.tryt.Location = new System.Drawing.Point(474, 362);
            this.tryt.Name = "tryt";
            this.tryt.Size = new System.Drawing.Size(0, 17);
            this.tryt.TabIndex = 54;
            this.tryt.Click += new System.EventHandler(this.tryt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 839);
            this.Controls.Add(this.tryt);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Universal calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Munit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fuelRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceLit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox curentOdo;
        private System.Windows.Forms.TextBox currentAmount;
        private System.Windows.Forms.TextBox previousOdo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label fuelCons_km_lit;
        private System.Windows.Forms.Label fuelCons_lit_km;
        private System.Windows.Forms.Label CosPerKilometer;
        private System.Windows.Forms.Label fuelCons_lit_swe_mil;
        private System.Windows.Forms.Label fuelCons_lit_met_mile;
        private System.Windows.Forms.Label Wcata;
        private System.Windows.Forms.Label BMIres;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Hight;
        private System.Windows.Forms.Button BMIcalc;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Uunit;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox userAge;
        private System.Windows.Forms.RadioButton Sedentary;
        private System.Windows.Forms.RadioButton LightlyActive;
        private System.Windows.Forms.RadioButton ModeratelyActive;
        private System.Windows.Forms.RadioButton VeryActive;
        private System.Windows.Forms.RadioButton ExtraActive;
        private System.Windows.Forms.Button BMRcal;
        private System.Windows.Forms.ListBox BMRlist;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label SelectedItem;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tryt;
        private System.Windows.Forms.Button button2;
    }
}

