namespace Hotel
{
    partial class BookingRegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.BackColor = System.Drawing.Color.White;
            this.comboBoxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(133, 77);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRooms.TabIndex = 2;
            this.comboBoxRooms.SelectedIndexChanged += new System.EventHandler(this.comboBoxRooms_SelectedIndexChanged);
            this.comboBoxRooms.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxRooms_Format);
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(133, 119);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kund";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ny bokning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Startdatum (fr. o.m.)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 160);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 201);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Slutdatum (t.o.m.)";
            // 
            // buttonCreateBooking
            // 
            this.buttonCreateBooking.BackColor = System.Drawing.Color.Black;
            this.buttonCreateBooking.FlatAppearance.BorderSize = 0;
            this.buttonCreateBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBooking.ForeColor = System.Drawing.Color.White;
            this.buttonCreateBooking.Location = new System.Drawing.Point(133, 285);
            this.buttonCreateBooking.Name = "buttonCreateBooking";
            this.buttonCreateBooking.Size = new System.Drawing.Size(200, 23);
            this.buttonCreateBooking.TabIndex = 14;
            this.buttonCreateBooking.Text = "Skapa bokning";
            this.buttonCreateBooking.UseVisualStyleBackColor = false;
            this.buttonCreateBooking.Click += new System.EventHandler(this.buttonCreateBooking_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 245);
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
            this.comboBoxExtraBeds.Location = new System.Drawing.Point(133, 242);
            this.comboBoxExtraBeds.Name = "comboBoxExtraBeds";
            this.comboBoxExtraBeds.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtraBeds.TabIndex = 13;
            // 
            // labelRoomException
            // 
            this.labelRoomException.AutoSize = true;
            this.labelRoomException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRoomException.Location = new System.Drawing.Point(130, 101);
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
            this.labelCustomerException.Location = new System.Drawing.Point(130, 142);
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
            this.labelDateException.Location = new System.Drawing.Point(130, 224);
            this.labelDateException.Name = "labelDateException";
            this.labelDateException.Size = new System.Drawing.Size(62, 13);
            this.labelDateException.TabIndex = 33;
            this.labelDateException.Text = "placeholder";
            this.labelDateException.Visible = false;
            // 
            // BookingRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 344);
            this.Controls.Add(this.labelDateException);
            this.Controls.Add(this.labelCustomerException);
            this.Controls.Add(this.labelRoomException);
            this.Controls.Add(this.buttonCreateBooking);
            this.Controls.Add(this.comboBoxExtraBeds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustomerSearch);
            this.Controls.Add(this.comboBoxRooms);
            this.Name = "BookingRegistrationForm";
            this.Text = "BookingRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
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
    }
}