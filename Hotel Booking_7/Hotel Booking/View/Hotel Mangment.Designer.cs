namespace Hotel_Booking
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
            this.Coustmers = new System.Windows.Forms.Button();
            this.reservation = new System.Windows.Forms.Button();
            this.numOfCous = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Coustmers
            // 
            this.Coustmers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coustmers.Location = new System.Drawing.Point(29, 108);
            this.Coustmers.Name = "Coustmers";
            this.Coustmers.Size = new System.Drawing.Size(216, 73);
            this.Coustmers.TabIndex = 0;
            this.Coustmers.Text = "Coustmers";
            this.Coustmers.UseVisualStyleBackColor = true;
            this.Coustmers.Click += new System.EventHandler(this.Coustmers_Click);
            // 
            // reservation
            // 
            this.reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservation.Location = new System.Drawing.Point(29, 255);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(216, 87);
            this.reservation.TabIndex = 1;
            this.reservation.Text = "Reservation";
            this.reservation.UseVisualStyleBackColor = true;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // numOfCous
            // 
            this.numOfCous.AutoSize = true;
            this.numOfCous.Location = new System.Drawing.Point(290, 470);
            this.numOfCous.Name = "numOfCous";
            this.numOfCous.Size = new System.Drawing.Size(0, 17);
            this.numOfCous.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(29, 416);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(216, 91);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Booking.Properties.Resources._9c37a1385c59def72e2e3b470c49b475;
            this.pictureBox1.Location = new System.Drawing.Point(420, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.numOfCous);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.Coustmers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Coustmers;
        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.Label numOfCous;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

