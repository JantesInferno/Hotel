using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class tempForm : Form
    {
        public tempForm()
        {
            InitializeComponent();
        }

        private void monthCalendarSearch_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendarSearch.SelectionRange.Start;

            DateTime[] dates = { date, date.AddDays(1), date.AddDays(2), date.AddDays(3), date.AddDays(4), date.AddDays(5), date.AddDays(6) };

            labelCalendarDate1.Text = date.ToShortDateString();
            labelCalendarDate2.Text = date.AddDays(1).ToShortDateString();
            labelCalendarDate3.Text = date.AddDays(2).ToShortDateString();
            labelCalendarDate4.Text = date.AddDays(3).ToShortDateString();
            labelCalendarDate5.Text = date.AddDays(4).ToShortDateString();
            labelCalendarDate6.Text = date.AddDays(5).ToShortDateString();
            labelCalendarDate7.Text = date.AddDays(6).ToShortDateString();

            var bookings = BookingRepo.GetBookingsByDate(date);

            int row = 0;
            int column = 0;
            int columnSpan = 0;

            foreach (var booking in bookings)
            {
                Button btn = CreateBookingButton();

                row = RoomIDToRow(booking.RoomID);
                column = BookingStartToCalendarDate(booking.StartDate, dates);
                columnSpan = BookingToCalendarColumnSpan(booking, dates);

                tableLayoutPanelCalendar.Controls.Add(btn);

                tableLayoutPanelCalendar.SetCellPosition(btn, new TableLayoutPanelCellPosition(row, column));

                tableLayoutPanelCalendar.SetColumnSpan(btn, columnSpan);
            }
        }

        private Button CreateBookingButton()
        {
            return new Button() { FlatStyle = FlatStyle.Flat, FlatAppearance = { BorderSize = 0 }, Margin = new Padding(0), BackColor = Color.Red, Dock = DockStyle.Fill };
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
                if (booking.StartDate >= dates[i] && booking.EndDate <= dates[i])
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
    }
}
