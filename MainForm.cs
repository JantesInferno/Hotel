using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Timer = System.Timers.Timer;

namespace Hotel
{
    public partial class MainForm : Form
    {
        static Timer _timer;

        static List<Booking> dueDates;

        static int dueDatesCount;

        public MainForm()
        {
            InitializeComponent();

            labelCurrentDateTime.Text = DateTime.Now.ToShortTimeString() + "  :  " + DateTime.Now.ToShortDateString();

            dateTimePickerSearch.Value = DateTime.Now;

            _timer = new Timer(60000);
            _timer.Elapsed += UpdateClock;
            _timer.Start();

            // Varje gång receptionisten startar programmet kollar det om en faktura har förfallodatum idag
            dueDates = BookingRepo.CheckDueDates();
            dueDatesCount = dueDates.Count;
            labelTodaysDueDates.Text = $"Bokingar vars faktura förfaller idag: {dueDatesCount} st";
        }

        // EVENTS

        public void UpdateClock(object sender, ElapsedEventArgs e)
        {
            labelCurrentDateTime.Text = DateTime.Now.ToShortTimeString() + "  :  " + DateTime.Now.ToShortDateString();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (dueDatesCount > 0)
            {
                labelTodaysDueDates.Visible = true;
                linkLabelCancelBookings.Visible = true;
            }
            else
            {
                labelTodaysDueDates.Visible = false;
                linkLabelCancelBookings.Visible = false;
            }
            tableLayoutPanelCalendar.Visible = false;
            PopulateTableLayoutPanel();
            tableLayoutPanelCalendar.Visible = true;
        }

        private void labelManageInvoice_MouseEnter(object sender, EventArgs e)
        {
            panelInvoice.Visible = true;
            panelCustomer.Visible = false;
            panelBooking.Visible = false;
        }

        private void labelManageCustomer_MouseEnter(object sender, EventArgs e)
        {
            panelCustomer.Visible = true;
            panelInvoice.Visible = false;
            panelBooking.Visible = false;
        }

        private void labelManageBooking_MouseEnter(object sender, EventArgs e)
        {
            panelBooking.Visible = true;
            panelInvoice.Visible = false;
            panelCustomer.Visible = false;
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            panelInvoice.Visible = false;
            panelCustomer.Visible = false;
            panelBooking.Visible = false;
        }

        private void buttonCustomerCreate_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm frm = new CustomerRegistrationForm();
            frm.Show();
        }

        private void buttonBookingCreate_Click(object sender, EventArgs e)
        {
            labelTodaysDueDates.Visible = false;
            BookingRegistrationForm frm = new BookingRegistrationForm();
            frm.Show();
        }

        protected void buttonBooking_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            BookingDetailsForm bookingDetailsForm = new BookingDetailsForm((Booking)button.Tag);
            bookingDetailsForm.Show();
            // identify which button was clicked and perform necessary actions
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)
        {
            tableLayoutPanelCalendar.Visible = false;
            PopulateTableLayoutPanel();
            tableLayoutPanelCalendar.Visible = true;
        }

        // METODER

        private void PopulateTableLayoutPanel()
        {
            tableLayoutPanelCalendar.Controls.Clear();

            DateTime date;

            if (dateTimePickerSearch.Value.Date == null)
                date = DateTime.Now;
            else
                date = dateTimePickerSearch.Value.Date;

            DateTime[] dates = { date, date.AddDays(1), date.AddDays(2), date.AddDays(3), date.AddDays(4), date.AddDays(5), date.AddDays(6) };

            labelCalendarDate1.Text = date.ToShortDateString();
            labelCalendarDate2.Text = date.AddDays(1).ToShortDateString();
            labelCalendarDate3.Text = date.AddDays(2).ToShortDateString();
            labelCalendarDate4.Text = date.AddDays(3).ToShortDateString();
            labelCalendarDate5.Text = date.AddDays(4).ToShortDateString();
            labelCalendarDate6.Text = date.AddDays(5).ToShortDateString();
            labelCalendarDate7.Text = date.AddDays(6).ToShortDateString();

            var bookings = BookingRepo.GetBookingsByDate(dates);

            int row = 0;
            int column = 0;
            int columnSpan = 0;

            foreach (var booking in bookings)
            {
                Button buttonBooking;
                if (booking.EndDate.Date.Equals(DateTime.Now.Date))
                    buttonBooking = CreateBookingButton(Color.Red);
                else if (booking.EndDate.Date < DateTime.Now.Date)
                    buttonBooking = CreateBookingButton(Color.Gray);
                else if (booking.StartDate.Date > DateTime.Now.Date)
                    buttonBooking = CreateBookingButton(Color.Blue);
                else
                    buttonBooking = CreateBookingButton(Color.Green);

                string extraBeds = booking.ExtraBeds > 0 ? $"Extrasängar: {booking.ExtraBeds.ToString()}st á 200:-\n" : "";

                toolTipTest.SetToolTip(buttonBooking, 
                    $"Rum: {booking.RoomID} - {booking.Room.RoomType.RoomTypeName} {booking.Room.RoomType.Size}kvm - {(int)booking.Room.RoomType.DailyRate}:-/natt \n" +
                    $"{extraBeds}" +
                    $"Kundnamn: {booking.Customer.Name}\n" +
                    $"Check-in: {booking.StartDate.ToShortDateString()}\n" +
                    $"Check-out: {booking.EndDate.ToShortDateString()}\n" +
                    $"Att betala: {(int)booking.Invoice.TotalCost}:-\n" +
                    $"Faktura refnr: {booking.InvoiceID}\n" +
                    $"Förfallodatum: {booking.Invoice.DueDate}");

                buttonBooking.Tag = booking;
                buttonBooking.Text = booking.Customer.Name;
                buttonBooking.ForeColor = Color.White;
                buttonBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                buttonBooking.Click += new EventHandler(buttonBooking_Click);

                

                row = RoomIDToRow(booking.RoomID);
                column = BookingStartToCalendarDate(booking.StartDate, dates);
                columnSpan = BookingToCalendarColumnSpan(booking, dates);

                tableLayoutPanelCalendar.Controls.Add(buttonBooking);

                tableLayoutPanelCalendar.SetCellPosition(buttonBooking, new TableLayoutPanelCellPosition(column, row));

                tableLayoutPanelCalendar.SetColumnSpan(buttonBooking, columnSpan);
            }
        }

        private Button CreateBookingButton(Color color)
        {
            return new Button() { FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0 }, Margin = new Padding(0), BackColor = color, Dock = DockStyle.Fill };
        }

        private int BookingStartToCalendarDate(DateTime bookingDate, DateTime[] dates)
        {
            int index = 0;

            for (int i = 0; i < dates.Length; i++)
            {
                if (bookingDate.Equals(dates[i]))
                    index = i;
            }

            return index;
        }

        private int BookingToCalendarColumnSpan(Booking booking, DateTime[] dates)
        {
            int columnSpan = 0;

            for (int i = 0; i < dates.Length; i++)
            {
                if (booking.StartDate <= dates[i] && booking.EndDate >= dates[i])
                    columnSpan++;
            }

            return columnSpan;
        }

        private int RoomIDToRow(int roomID)
        {
            int row = 0;

            switch (roomID)
            {
                case 10:
                    break;
                case 11:
                    row = 1;
                    break;
                case 12:
                    row = 2;
                    break;
                case 13:
                    row = 3;
                    break;
                case 20:
                    row = 4;
                    break;
                case 21:
                    row = 5;
                    break;
                case 22:
                    row = 6;
                    break;
                case 23:
                    row = 7;
                    break;
            }

            return row;
        }

        private void linkLabelCancelBookings_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegisterPayment_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            // Annullera bokning
        }

        private void buttonCustomerSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonBookingSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
