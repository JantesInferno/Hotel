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
            this.comboBoxRooms.Location = new System.Drawing.Point(105, 75);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRooms.TabIndex = 1;
            this.comboBoxRooms.SelectedIndexChanged += new System.EventHandler(this.comboBoxRooms_SelectedIndexChanged);
            this.comboBoxRooms.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxRooms_Format);
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(105, 117);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kund";
            // 
            // labelNewMessage
            // 
            this.labelNewMessage.AutoSize = true;
            this.labelNewMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewMessage.Location = new System.Drawing.Point(3, 7);
            this.labelNewMessage.Name = "labelNewMessage";
            this.labelNewMessage.Size = new System.Drawing.Size(109, 25);
            this.labelNewMessage.TabIndex = 7;
            this.labelNewMessage.Text = "Ny bokning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Check-in";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 158);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(105, 199);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
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
            this.buttonCreateBooking.Location = new System.Drawing.Point(105, 283);
            this.buttonCreateBooking.Name = "buttonCreateBooking";
            this.buttonCreateBooking.Size = new System.Drawing.Size(200, 23);
            this.buttonCreateBooking.TabIndex = 6;
            this.buttonCreateBooking.Text = "Skapa bokning";
            this.buttonCreateBooking.UseVisualStyleBackColor = false;
            this.buttonCreateBooking.Click += new System.EventHandler(this.buttonCreateBooking_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Extrasängar";
            // 
            // comboBoxExtraBeds
            // 
            this.comboBoxExtraBeds.BackColor = System.Drawing.Color.White;
            this.comboBoxExtraBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtraBeds.FormattingEnabled = true;
            this.comboBoxExtraBeds.Location = new System.Drawing.Point(105, 240);
            this.comboBoxExtraBeds.Name = "comboBoxExtraBeds";
            this.comboBoxExtraBeds.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtraBeds.TabIndex = 5;
            // 
            // labelRoomException
            // 
            this.labelRoomException.AutoSize = true;
            this.labelRoomException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRoomException.Location = new System.Drawing.Point(102, 99);
            this.labelRoomException.Name = "labelRoomException";
            this.labelRoomException.Size = new System.Drawing.Size(62, 13);
            this.labelRoomException.TabIndex = 31;
            this.labelRoomException.Text = "placeholder";
            this.labelRoomException.Visible = false;
            // 
            // labelCustomerException
            // 
            this.labelCustomerException.AutoSize = true;
            this.labelCustomerException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCustomerException.Location = new System.Drawing.Point(102, 140);
            this.labelCustomerException.Name = "labelCustomerException";
            this.labelCustomerException.Size = new System.Drawing.Size(62, 13);
            this.labelCustomerException.TabIndex = 32;
            this.labelCustomerException.Text = "placeholder";
            this.labelCustomerException.Visible = false;
            // 
            // labelDateException
            // 
            this.labelDateException.AutoSize = true;
            this.labelDateException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDateException.Location = new System.Drawing.Point(102, 222);
            this.labelDateException.Name = "labelDateException";
            this.labelDateException.Size = new System.Drawing.Size(62, 13);
            this.labelDateException.TabIndex = 33;
            this.labelDateException.Text = "placeholder";
            this.labelDateException.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 328);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.listBoxBookings);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.labelSearchMessage);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Location = new System.Drawing.Point(350, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 328);
            this.panel2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kundnamn";
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.Location = new System.Drawing.Point(74, 119);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(286, 186);
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
            this.buttonSearch.Location = new System.Drawing.Point(316, 77);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 23);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "Visa";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchMessage
            // 
            this.labelSearchMessage.AutoSize = true;
            this.labelSearchMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchMessage.Location = new System.Drawing.Point(3, 9);
            this.labelSearchMessage.Name = "labelSearchMessage";
            this.labelSearchMessage.Size = new System.Drawing.Size(160, 25);
            this.labelSearchMessage.TabIndex = 19;
            this.labelSearchMessage.Text = "Sök efter bokning";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(74, 77);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(243, 23);
            this.textBoxSearch.TabIndex = 16;
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(821, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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