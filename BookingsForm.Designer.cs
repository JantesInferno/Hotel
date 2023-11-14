namespace Hotel
{
    partial class BookingsForm
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
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNewMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateBooking = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxExtraBeds = new System.Windows.Forms.ComboBox();
            this.labelRoomException = new System.Windows.Forms.Label();
            this.labelCustomerException = new System.Windows.Forms.Label();
            this.labelDateException = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchMessage = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.BackColor = System.Drawing.Color.White;
            this.comboBoxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(158, 115);
            this.comboBoxRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(298, 28);
            this.comboBoxRooms.TabIndex = 2;
            this.comboBoxRooms.SelectedIndexChanged += new System.EventHandler(this.comboBoxRooms_SelectedIndexChanged);
            this.comboBoxRooms.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxRooms_Format);
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(158, 180);
            this.textBoxCustomerSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(298, 26);
            this.textBoxCustomerSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kund";
            // 
            // labelNewMessage
            // 
            this.labelNewMessage.AutoSize = true;
            this.labelNewMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMessage.Location = new System.Drawing.Point(4, 11);
            this.labelNewMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewMessage.Name = "labelNewMessage";
            this.labelNewMessage.Size = new System.Drawing.Size(165, 40);
            this.labelNewMessage.TabIndex = 7;
            this.labelNewMessage.Text = "Ny bokning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Check-in";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 243);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(158, 306);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Check-out";
            // 
            // buttonCreateBooking
            // 
            this.buttonCreateBooking.BackColor = System.Drawing.Color.Black;
            this.buttonCreateBooking.FlatAppearance.BorderSize = 0;
            this.buttonCreateBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBooking.ForeColor = System.Drawing.Color.White;
            this.buttonCreateBooking.Location = new System.Drawing.Point(158, 435);
            this.buttonCreateBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateBooking.Name = "buttonCreateBooking";
            this.buttonCreateBooking.Size = new System.Drawing.Size(300, 35);
            this.buttonCreateBooking.TabIndex = 14;
            this.buttonCreateBooking.Text = "Skapa bokning";
            this.buttonCreateBooking.UseVisualStyleBackColor = false;
            this.buttonCreateBooking.Click += new System.EventHandler(this.buttonCreateBooking_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Extrasängar";
            // 
            // comboBoxExtraBeds
            // 
            this.comboBoxExtraBeds.BackColor = System.Drawing.Color.White;
            this.comboBoxExtraBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtraBeds.FormattingEnabled = true;
            this.comboBoxExtraBeds.Location = new System.Drawing.Point(158, 369);
            this.comboBoxExtraBeds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxExtraBeds.Name = "comboBoxExtraBeds";
            this.comboBoxExtraBeds.Size = new System.Drawing.Size(180, 28);
            this.comboBoxExtraBeds.TabIndex = 13;
            // 
            // labelRoomException
            // 
            this.labelRoomException.AutoSize = true;
            this.labelRoomException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRoomException.Location = new System.Drawing.Point(153, 152);
            this.labelRoomException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomException.Name = "labelRoomException";
            this.labelRoomException.Size = new System.Drawing.Size(91, 20);
            this.labelRoomException.TabIndex = 31;
            this.labelRoomException.Text = "placeholder";
            this.labelRoomException.Visible = false;
            // 
            // labelCustomerException
            // 
            this.labelCustomerException.AutoSize = true;
            this.labelCustomerException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCustomerException.Location = new System.Drawing.Point(153, 215);
            this.labelCustomerException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerException.Name = "labelCustomerException";
            this.labelCustomerException.Size = new System.Drawing.Size(91, 20);
            this.labelCustomerException.TabIndex = 32;
            this.labelCustomerException.Text = "placeholder";
            this.labelCustomerException.Visible = false;
            // 
            // labelDateException
            // 
            this.labelDateException.AutoSize = true;
            this.labelDateException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDateException.Location = new System.Drawing.Point(153, 342);
            this.labelDateException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateException.Name = "labelDateException";
            this.labelDateException.Size = new System.Drawing.Size(91, 20);
            this.labelDateException.TabIndex = 33;
            this.labelDateException.Text = "placeholder";
            this.labelDateException.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelNewMessage);
            this.panel1.Controls.Add(this.labelDateException);
            this.panel1.Controls.Add(this.comboBoxRooms);
            this.panel1.Controls.Add(this.labelCustomerException);
            this.panel1.Controls.Add(this.textBoxCustomerSearch);
            this.panel1.Controls.Add(this.labelRoomException);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCreateBooking);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxExtraBeds);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 504);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.listBoxBookings);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.labelSearchMessage);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Location = new System.Drawing.Point(525, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 503);
            this.panel2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kundnamn";
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.ItemHeight = 20;
            this.listBoxBookings.Location = new System.Drawing.Point(111, 183);
            this.listBoxBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(427, 284);
            this.listBoxBookings.TabIndex = 28;
            this.listBoxBookings.Click += new System.EventHandler(this.listBoxBookings_Click);
            this.listBoxBookings.SelectedIndexChanged += new System.EventHandler(this.listBoxBookings_SelectedIndexChanged);
            this.listBoxBookings.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxBookings_Format);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(474, 118);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(66, 35);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "Visa";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchMessage
            // 
            this.labelSearchMessage.AutoSize = true;
            this.labelSearchMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchMessage.Location = new System.Drawing.Point(4, 14);
            this.labelSearchMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchMessage.Name = "labelSearchMessage";
            this.labelSearchMessage.Size = new System.Drawing.Size(242, 40);
            this.labelSearchMessage.TabIndex = 19;
            this.labelSearchMessage.Text = "Sök efter bokning";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(111, 118);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(362, 31);
            this.textBoxSearch.TabIndex = 16;
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookingsForm";
            this.Text = "BookingRegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNewMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateBooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxExtraBeds;
        private System.Windows.Forms.Label labelRoomException;
        private System.Windows.Forms.Label labelCustomerException;
        private System.Windows.Forms.Label labelDateException;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxBookings;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchMessage;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label7;
    }
}