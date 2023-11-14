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

        private List<Booking> _dueDates = new List<Booking>();

        private DateTime[] _dates;

        public MainForm()
        {
            InitializeComponent();

            labelCurrentDateTime.Text = DateTime.Now.ToShortTimeString() + "  :  " + DateTime.Now.ToShortDateString();

            dateTimePickerSearch.Value = DateTime.Now;

            _timer = new Timer(60000);
            _timer.Elapsed += UpdateClock;
            _timer.Start();

            // Varje gång receptionisten startar programmet kollar det om en faktura har förfallodatum idag
            _dueDates = BookingRepo.CheckDueDates();
            labelTodaysDueDates.Text = $"Bokingar vars faktura förfaller idag: {_dueDates.Count} st";

            PopulateTableLayoutPanel();
        }

        // EVENTS

        public void UpdateClock(object sender, ElapsedEventArgs e)
        {
            labelCurrentDateTime.Text = DateTime.Now.ToShortTimeString() + "  :  " + DateTime.Now.ToShortDateString();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (_dueDates.Count > 0)
            {
                labelTodaysDueDates.Text = $"Bokingar vars faktura förfaller idag: {_dueDates.Count} st";
                labelTodaysDueDates.Visible = true;
            }
            else
            {
                labelTodaysDueDates.Visible = false;
            }

            //PopulateTableLayoutPanel();
        }

        private void dateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            PopulateTableLayoutPanel();
        }

        protected void buttonBooking_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            BookingDetailsForm bookingDetailsForm = new BookingDetailsForm((Booking)button.Tag);
            bookingDetailsForm.Show();
        }


        // METODER

        private void PopulateTableLayoutPanel()
        {
            tableLayoutPanelCalendar.Visible = false;

            tableLayoutPanelCalendar.Controls.Clear();

            DateTime date;

            if (dateTimePickerSearch.Value.Date == null)
                date = DateTime.Now;
            else
                date = dateTimePickerSearch.Value.Date;

            _dates = new DateTime[] { date, date.AddDays(1), date.AddDays(2), date.AddDays(3), date.AddDays(4), date.AddDays(5), date.AddDays(6) };

            labelCalendarDate1.Text = date.ToShortDateString();
            labelCalendarDate2.Text = date.AddDays(1).ToShortDateString();
            labelCalendarDate3.Text = date.AddDays(2).ToShortDateString();
            labelCalendarDate4.Text = date.AddDays(3).ToShortDateString();
            labelCalendarDate5.Text = date.AddDays(4).ToShortDateString();
            labelCalendarDate6.Text = date.AddDays(5).ToShortDateString();
            labelCalendarDate7.Text = date.AddDays(6).ToShortDateString();

            var bookings = BookingRepo.GetBookingsByDate(_dates);

            int row = 0;
            int column = 0;
            int columnSpan = 0;

            foreach (var booking in bookings)
            {

                Button buttonBooking;

                if (booking.EndDate.Date.Equals(DateTime.Now.Date))
                    buttonBooking = CreateBookingButton(Color.Yellow, Color.Black);
                else if (booking.EndDate.Date < DateTime.Now.Date)
                    buttonBooking = CreateBookingButton(Color.Red, Color.White);
                else if (booking.StartDate.Date > DateTime.Now.Date)
                    buttonBooking = CreateBookingButton(Color.Blue, Color.White);
                else
                    buttonBooking = CreateBookingButton(Color.Green, Color.White);

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
                buttonBooking.Click += new EventHandler(buttonBooking_Click);

                row = RoomIDToRow(booking.RoomID);
                column = BookingStartToCalendarDate(booking.StartDate, _dates);
                //columnSpan = BookingToCalendarColumnSpan(booking, _dates);
                columnSpan = Convert.ToInt32((booking.EndDate - booking.StartDate).TotalDays * 2);
                if (booking.StartDate.Date < dateTimePickerSearch.Value.Date)
                    columnSpan = (int)((booking.EndDate - dateTimePickerSearch.Value).TotalDays) * 2 + 1;

                tableLayoutPanelCalendar.Controls.Add(buttonBooking);
                tableLayoutPanelCalendar.SetCellPosition(buttonBooking, new TableLayoutPanelCellPosition(column, row));

                if (column + columnSpan >= 14)
                {
                    columnSpan = 14 - column;
                }

                tableLayoutPanelCalendar.SetColumnSpan(buttonBooking, columnSpan);
            }

            tableLayoutPanelCalendar.Visible = true;
        }

        private Button CreateBookingButton(Color backColor, Color forecolor)
        {
            Button button = new Button() { FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 1, BorderColor = Color.Black }, Margin = new Padding(0), BackColor = backColor, ForeColor = forecolor, Dock = DockStyle.Fill };

            button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            return button;
        }

        private int BookingStartToCalendarDate(DateTime bookingDate, DateTime[] dates)
        {
            int index = 0;

            for (int i = 0; i < dates.Length; i++)
            {
                if (bookingDate.Equals(dates[i]))
                    index = i * 2 + 1;
            }

            return index;
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

        private void buttonNavBookings_Click(object sender, EventArgs e)
        {
            BookingsForm frm = new BookingsForm();
            frm.Show();
        }

        private void buttonNavCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.Show();
        }

        private void buttonNavPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm frm = new PaymentsForm(_dueDates);
            frm.Show();
        }

        private void linkLabelCancelBookings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //PaymentsForm frm = new PaymentsForm();
            //frm.Show(true);
        }

        private void buttonNextDate_Click(object sender, EventArgs e)
        {
            dateTimePickerSearch.Value = dateTimePickerSearch.Value.Date.AddDays(1);
            PopulateTableLayoutPanel();
        }

        private void buttonPreviousDate_Click(object sender, EventArgs e)
        {
            dateTimePickerSearch.Value = dateTimePickerSearch.Value.Date.AddDays(-1);
            PopulateTableLayoutPanel();
        }

        private Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void tableLayoutPanelCalendar_Click(object sender, EventArgs e)
        {
            var cellPos = GetRowColIndex(
                tableLayoutPanelCalendar,
                tableLayoutPanelCalendar.PointToClient(Cursor.Position));

            Label[] roomLabels = { labelRoom10, labelRoom11, labelRoom12, labelRoom13, labelRoom20, labelRoom21, labelRoom22, labelRoom23 };

            DateTime startDate = _dates[cellPos.Value.X / 2];
            int roomID = Convert.ToInt32(roomLabels[cellPos.Value.Y].Text);

            BookingsForm bookingsForm = new BookingsForm(startDate, roomID);
            bookingsForm.Show();
        }
    }
}
