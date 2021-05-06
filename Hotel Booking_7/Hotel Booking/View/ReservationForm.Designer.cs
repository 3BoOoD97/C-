namespace Hotel_Booking
{
    partial class ReservationForm
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
            this.CheckedIn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkInTime = new System.Windows.Forms.DateTimePicker();
            this.paidYes = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paidNo = new System.Windows.Forms.CheckBox();
            this.coustmersList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coustmerName = new System.Windows.Forms.TextBox();
            this.coustmerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HoManyN = new System.Windows.Forms.ComboBox();
            this.addRes = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.checkedInList = new System.Windows.Forms.ListBox();
            this.C = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckedIn
            // 
            this.CheckedIn.AutoSize = true;
            this.CheckedIn.Location = new System.Drawing.Point(12, 300);
            this.CheckedIn.Name = "CheckedIn";
            this.CheckedIn.Size = new System.Drawing.Size(102, 21);
            this.CheckedIn.TabIndex = 1;
            this.CheckedIn.Text = "Checked IN";
            this.CheckedIn.UseVisualStyleBackColor = true;
            this.CheckedIn.CheckedChanged += new System.EventHandler(this.CheckedIn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coustmer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coustmer ID";
            // 
            // checkInTime
            // 
            this.checkInTime.Location = new System.Drawing.Point(12, 337);
            this.checkInTime.Name = "checkInTime";
            this.checkInTime.Size = new System.Drawing.Size(316, 22);
            this.checkInTime.TabIndex = 4;
            this.checkInTime.ValueChanged += new System.EventHandler(this.checkInTime_ValueChanged);
            // 
            // paidYes
            // 
            this.paidYes.AutoSize = true;
            this.paidYes.ForeColor = System.Drawing.Color.ForestGreen;
            this.paidYes.Location = new System.Drawing.Point(12, 463);
            this.paidYes.Name = "paidYes";
            this.paidYes.Size = new System.Drawing.Size(54, 21);
            this.paidYes.TabIndex = 5;
            this.paidYes.Text = "Yes";
            this.paidYes.UseVisualStyleBackColor = true;
            this.paidYes.CheckedChanged += new System.EventHandler(this.paidYes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paid?";
            // 
            // paidNo
            // 
            this.paidNo.AutoSize = true;
            this.paidNo.ForeColor = System.Drawing.Color.Red;
            this.paidNo.Location = new System.Drawing.Point(81, 463);
            this.paidNo.Name = "paidNo";
            this.paidNo.Size = new System.Drawing.Size(48, 21);
            this.paidNo.TabIndex = 7;
            this.paidNo.Text = "No";
            this.paidNo.UseVisualStyleBackColor = true;
            this.paidNo.CheckedChanged += new System.EventHandler(this.paidNo_CheckedChanged);
            // 
            // coustmersList
            // 
            this.coustmersList.FormattingEnabled = true;
            this.coustmersList.ItemHeight = 16;
            this.coustmersList.Location = new System.Drawing.Point(602, 46);
            this.coustmersList.Name = "coustmersList";
            this.coustmersList.Size = new System.Drawing.Size(534, 212);
            this.coustmersList.TabIndex = 8;
            this.coustmersList.SelectedIndexChanged += new System.EventHandler(this.coustmersList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(810, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Coustmers List";
            // 
            // coustmerName
            // 
            this.coustmerName.Location = new System.Drawing.Point(158, 38);
            this.coustmerName.Name = "coustmerName";
            this.coustmerName.ReadOnly = true;
            this.coustmerName.Size = new System.Drawing.Size(188, 22);
            this.coustmerName.TabIndex = 10;
            // 
            // coustmerID
            // 
            this.coustmerID.Location = new System.Drawing.Point(480, 38);
            this.coustmerID.Name = "coustmerID";
            this.coustmerID.ReadOnly = true;
            this.coustmerID.Size = new System.Drawing.Size(83, 22);
            this.coustmerID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Room Type";
            // 
            // roomType
            // 
            this.roomType.FormattingEnabled = true;
            this.roomType.Location = new System.Drawing.Point(158, 140);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(421, 24);
            this.roomType.TabIndex = 13;
            this.roomType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price";
            // 
            // roomPrice
            // 
            this.roomPrice.Location = new System.Drawing.Point(158, 230);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.ReadOnly = true;
            this.roomPrice.Size = new System.Drawing.Size(79, 22);
            this.roomPrice.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Room Description";
            // 
            // roomDescription
            // 
            this.roomDescription.Location = new System.Drawing.Point(158, 183);
            this.roomDescription.Name = "roomDescription";
            this.roomDescription.ReadOnly = true;
            this.roomDescription.Size = new System.Drawing.Size(421, 22);
            this.roomDescription.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "How Many Nights";
            // 
            // HoManyN
            // 
            this.HoManyN.FormattingEnabled = true;
            this.HoManyN.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "",
            ""});
            this.HoManyN.Location = new System.Drawing.Point(15, 398);
            this.HoManyN.Name = "HoManyN";
            this.HoManyN.Size = new System.Drawing.Size(121, 24);
            this.HoManyN.TabIndex = 19;
            this.HoManyN.SelectedIndexChanged += new System.EventHandler(this.HoManyN_SelectedIndexChanged);
            // 
            // addRes
            // 
            this.addRes.Location = new System.Drawing.Point(107, 517);
            this.addRes.Name = "addRes";
            this.addRes.Size = new System.Drawing.Size(300, 51);
            this.addRes.TabIndex = 20;
            this.addRes.Text = "button1";
            this.addRes.UseVisualStyleBackColor = true;
            this.addRes.Click += new System.EventHandler(this.addRes_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total Price";
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(334, 405);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(73, 22);
            this.totalPrice.TabIndex = 23;
            // 
            // checkedInList
            // 
            this.checkedInList.FormattingEnabled = true;
            this.checkedInList.ItemHeight = 16;
            this.checkedInList.Location = new System.Drawing.Point(602, 346);
            this.checkedInList.Name = "checkedInList";
            this.checkedInList.Size = new System.Drawing.Size(534, 212);
            this.checkedInList.TabIndex = 24;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.Color.Green;
            this.C.Location = new System.Drawing.Point(784, 273);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(197, 22);
            this.C.TabIndex = 25;
            this.C.Text = "Checked In Coustmers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(629, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1026, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Totall Nights";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(825, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Check In Time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(689, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Paymnet Statues";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(939, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Room Type";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 580);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.C);
            this.Controls.Add(this.checkedInList);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addRes);
            this.Controls.Add(this.HoManyN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roomDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roomPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coustmerID);
            this.Controls.Add(this.coustmerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coustmersList);
            this.Controls.Add(this.paidNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paidYes);
            this.Controls.Add(this.checkInTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckedIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckedIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker checkInTime;
        private System.Windows.Forms.CheckBox paidYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox paidNo;
        private System.Windows.Forms.ListBox coustmersList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coustmerName;
        private System.Windows.Forms.TextBox coustmerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox HoManyN;
        private System.Windows.Forms.Button addRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.ListBox checkedInList;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}