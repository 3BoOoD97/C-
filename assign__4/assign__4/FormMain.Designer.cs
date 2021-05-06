namespace assign__4
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CostPerPerson = new System.Windows.Forms.TextBox();
            this.NumOfGuest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddToList = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.numGuest = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.guesList = new System.Windows.Forms.ListBox();
            this.isDeleted = new System.Windows.Forms.Label();
            this.changeInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per person";
            // 
            // CreateList
            // 
            this.CreateList.ForeColor = System.Drawing.Color.Teal;
            this.CreateList.Location = new System.Drawing.Point(127, 125);
            this.CreateList.Name = "CreateList";
            this.CreateList.Size = new System.Drawing.Size(109, 37);
            this.CreateList.TabIndex = 2;
            this.CreateList.Text = "Create list";
            this.CreateList.UseVisualStyleBackColor = true;
            this.CreateList.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CostPerPerson);
            this.groupBox1.Controls.Add(this.NumOfGuest);
            this.groupBox1.Controls.Add(this.CreateList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Party";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CostPerPerson
            // 
            this.CostPerPerson.Location = new System.Drawing.Point(195, 52);
            this.CostPerPerson.Name = "CostPerPerson";
            this.CostPerPerson.Size = new System.Drawing.Size(144, 22);
            this.CostPerPerson.TabIndex = 4;
            // 
            // NumOfGuest
            // 
            this.NumOfGuest.Location = new System.Drawing.Point(195, 24);
            this.NumOfGuest.Name = "NumOfGuest";
            this.NumOfGuest.Size = new System.Drawing.Size(144, 22);
            this.NumOfGuest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(121, 136);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(109, 38);
            this.AddToList.TabIndex = 6;
            this.AddToList.Text = "Add";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // FirstName
            // 
            this.FirstName.AcceptsReturn = true;
            this.FirstName.AcceptsTab = true;
            this.FirstName.AllowDrop = true;
            this.FirstName.Location = new System.Drawing.Point(189, 25);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(144, 22);
            this.FirstName.TabIndex = 7;
            this.FirstName.TabStop = false;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(189, 54);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(144, 22);
            this.LastName.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeInfo);
            this.groupBox2.Controls.Add(this.LastName);
            this.groupBox2.Controls.Add(this.FirstName);
            this.groupBox2.Controls.Add(this.AddToList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(19, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invite Guest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number Of guests";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(237, 492);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(0, 17);
            this.TotalCost.TabIndex = 12;
            // 
            // numGuest
            // 
            this.numGuest.AutoSize = true;
            this.numGuest.Location = new System.Drawing.Point(237, 519);
            this.numGuest.Name = "numGuest";
            this.numGuest.Size = new System.Drawing.Size(0, 17);
            this.numGuest.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Guest List";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(628, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // guesList
            // 
            this.guesList.FormattingEnabled = true;
            this.guesList.ItemHeight = 16;
            this.guesList.Location = new System.Drawing.Point(472, 88);
            this.guesList.Name = "guesList";
            this.guesList.Size = new System.Drawing.Size(291, 372);
            this.guesList.TabIndex = 18;
            // 
            // isDeleted
            // 
            this.isDeleted.AutoSize = true;
            this.isDeleted.Location = new System.Drawing.Point(477, 471);
            this.isDeleted.Name = "isDeleted";
            this.isDeleted.Size = new System.Drawing.Size(0, 17);
            this.isDeleted.TabIndex = 19;
            // 
            // changeInfo
            // 
            this.changeInfo.AutoSize = true;
            this.changeInfo.ForeColor = System.Drawing.Color.Red;
            this.changeInfo.Location = new System.Drawing.Point(67, 101);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(0, 17);
            this.changeInfo.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.isDeleted);
            this.Controls.Add(this.guesList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numGuest);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Party Organizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CostPerPerson;
        private System.Windows.Forms.TextBox NumOfGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label numGuest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox guesList;
        private System.Windows.Forms.Label isDeleted;
        private System.Windows.Forms.Label changeInfo;
    }
}

