namespace assign_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.ZipC = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.Label();
            this.Mlist = new System.Windows.Forms.ListBox();
            this.Country = new System.Windows.Forms.DomainUpDown();
            this.NAME.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Street";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(141, 16);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(266, 22);
            this.Street.TabIndex = 8;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(141, 56);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(266, 22);
            this.City.TabIndex = 9;
            // 
            // ZipC
            // 
            this.ZipC.Location = new System.Drawing.Point(141, 94);
            this.ZipC.Name = "ZipC";
            this.ZipC.Size = new System.Drawing.Size(266, 22);
            this.ZipC.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.Color.ForestGreen;
            this.Add.Location = new System.Drawing.Point(654, 87);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(162, 45);
            this.Add.TabIndex = 13;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.ForeColor = System.Drawing.Color.Tomato;
            this.Change.Location = new System.Drawing.Point(654, 163);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(162, 48);
            this.Change.TabIndex = 14;
            this.Change.Text = "CHANGE";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(654, 241);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(162, 49);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(24, 26);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(76, 17);
            this.F.TabIndex = 0;
            this.F.Text = "First Name";
            this.F.Click += new System.EventHandler(this.label1_Click);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(24, 71);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(76, 17);
            this.L.TabIndex = 1;
            this.L.Text = "Last Name";
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(147, 26);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(266, 22);
            this.FName.TabIndex = 2;
            this.FName.TextChanged += new System.EventHandler(this.FName_TextChanged);
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(147, 71);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(266, 22);
            this.LName.TabIndex = 3;
            // 
            // NAME
            // 
            this.NAME.Controls.Add(this.LName);
            this.NAME.Controls.Add(this.FName);
            this.NAME.Controls.Add(this.L);
            this.NAME.Controls.Add(this.F);
            this.NAME.Location = new System.Drawing.Point(6, 30);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(480, 133);
            this.NAME.TabIndex = 16;
            this.NAME.TabStop = false;
            this.NAME.Text = "NAME";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Country);
            this.groupBox1.Controls.Add(this.ZipC);
            this.groupBox1.Controls.Add(this.City);
            this.groupBox1.Controls.Add(this.Street);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 182);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(788, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "No. of registerd records ";
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Location = new System.Drawing.Point(961, 325);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(0, 17);
            this.Records.TabIndex = 19;
            // 
            // Mlist
            // 
            this.Mlist.FormattingEnabled = true;
            this.Mlist.ItemHeight = 16;
            this.Mlist.Location = new System.Drawing.Point(24, 373);
            this.Mlist.Name = "Mlist";
            this.Mlist.Size = new System.Drawing.Size(1043, 196);
            this.Mlist.TabIndex = 20;
            // 
            // Country
            // 
            this.Country.ForeColor = System.Drawing.Color.Blue;
            this.Country.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Country.Location = new System.Drawing.Point(141, 126);
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Size = new System.Drawing.Size(266, 22);
            this.Country.TabIndex = 21;
            this.Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Country.Wrap = true;
            this.Country.SelectedItemChanged += new System.EventHandler(this.Country_SelectedItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.Mlist);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Contact registry";
            this.NAME.ResumeLayout(false);
            this.NAME.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox ZipC;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.GroupBox NAME;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.ListBox Mlist;
        private System.Windows.Forms.DomainUpDown Country;
    }
}

