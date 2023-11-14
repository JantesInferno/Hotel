using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hotel
{
    public partial class BookingsForm : Form
    {
        private AutoCompleteStringCollection _data;

        private Room _currentRoomSelected;

        private List<Room> _comboBoxRooms;

        private int _selectedBooking;

        public BookingsForm()
        {
            InitializeComponent();

            _comboBoxRooms = RoomRepo.GetAllRooms();

            comboBoxRooms.DisplayMember = "Name";
            comboBoxRooms.ValueMember = "RoomID";
            comboBoxRooms.DataSource = _comboBoxRooms;

            comboBoxExtraBeds.Items.Add(0);
            comboBoxExtraBeds.SelectedIndex = 0;
            _currentRoomSelected = RoomRepo.GetRoomByID((int)comboBoxRooms.SelectedValue);

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;

            _data = new AutoCompleteStringCollection();

            _data.AddRange(CustomerRepo.GetAllCustomersAutoComplete().ToArray());

            textBoxCustomerSearch.AutoCompleteCustomSource = _data;
            textBoxSearch.AutoCompleteCustomSource = _data;
        }

        private void comboBoxRooms_Format(object sender, ListControlConvertEventArgs e)
        {
            Room room = ((Room)e.ListItem);
            int roomID =(int)room.RoomID;
            string roomDescription = room.RoomType.RoomTypeName;
            int roomSize = room.RoomType.Size;
            int roomDailyRate = (int)room.RoomType.DailyRate;
            e.Value = roomID + " - " + roomDescription + " - " + roomSize + " kvm - " + roomDailyRate + ":-/natt";
        }
        
        private void comboBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRoomSelected = RoomRepo.GetRoomByID((int)comboBoxRooms.SelectedValue);

            comboBoxExtraBeds.Items.Clear();

            comboBoxExtraBeds.Items.Add(0);

            if (_currentRoomSelected.RoomType.Size > 14)
            {
                comboBoxExtraBeds.Items.Add(1);
            } 
            if (_currentRoomSelected.RoomType.Size > 20)
            {
                comboBoxExtraBeds.Items.Add(2);
            }
        }

        private void buttonCreateBooking_Click(object sender, EventArgs e)
        {
            if (!_data.Contains(textBoxCustomerSearch.Text.Trim()))
            {
                labelCustomerException.Text = "Ogiltigt kundnamn.";
                labelCustomerException.Visible = true;
            }
            else if (textBoxCustomerSearch.Text.Trim().Length <= 0)
            {
                labelCustomerException.Text = "Obligatoriskt fält.";
                labelCustomerException.Visible = true;
            }
            else
                labelCustomerException.Visible = false;

            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date;

            if (start > end)
            {
                labelDateException.Text = "Slutdatum kan inte vara före startdatum.";
                labelDateException.Visible = true;
                return;
            }
            else
                labelDateException.Visible = false;

            if (!RoomRepo.CheckRoomAvailability(_currentRoomSelected, start, end))
            {
                labelRoomException.Text = "Rummet är upptaget den tidsperioden.";
                labelRoomException.Visible = true;
            }
            else
            {
                labelRoomException.Visible = false;
                Booking booking = new Booking();
                booking.RoomID = _currentRoomSelected.RoomID;
                booking.CustomerID = CustomerRepo.GetCustomersBySearch(textBoxCustomerSearch.Text.Trim()).FirstOrDefault().CustomerID;
                booking.StartDate = start;
                booking.EndDate = end;
                booking.ExtraBeds = Convert.ToInt32(comboBoxExtraBeds.Text);

                BookingRepo.CreateBooking(booking, _currentRoomSelected);

                MessageBox.Show("Bokning skapad!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxBookings.DisplayMember = "BookingID";
            listBoxBookings.ValueMember = "BookingID";
            listBoxBookings.DataSource = BookingRepo.GetBookingsByCustomerSearch(textBoxSearch.Text.Trim());
        }

        private void listBoxBookings_Format(object sender, ListControlConvertEventArgs e)
        {
            string id = ((Booking)e.ListItem).BookingID.ToString();
            string start = ((Booking)e.ListItem).StartDate.ToShortDateString();
            string end = ((Booking)e.ListItem).EndDate.ToShortDateString();

            e.Value = "Bokningsnummer: " + id + " - Datum: " + start + " till " + end;
        }

        private void listBoxBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBookings.SelectedIndex >= 0)
            {
                _selectedBooking = listBoxBookings.SelectedIndex;

                Booking booking = BookingRepo.GetBookingByID((int)listBoxBookings.SelectedValue);

                dateTimePicker1.MinDate = DateTime.Now.AddYears(-10);
                dateTimePicker2.MinDate = DateTime.Now.AddYears(-10);

                textBoxCustomerSearch.Text = booking.Customer.Name;
                comboBoxRooms.SelectedValue = (int)booking.RoomID;
                dateTimePicker1.Value = booking.StartDate;
                dateTimePicker2.Value = booking.EndDate;
                comboBoxExtraBeds.SelectedIndex = (int)booking.ExtraBeds;

                labelNewMessage.Text = "Redigera bokning";
                buttonCreateBooking.Text = "Uppdatera bokning";
            }
        }

        private void listBoxBookings_Click(object sender, EventArgs e)
        {
            if (_selectedBooking == listBoxBookings.SelectedIndex)
            {
                listBoxBookings.ClearSelected();

                _selectedBooking = -1;

                dateTimePicker1.Value = DateTime.Now.AddDays(14);
                dateTimePicker2.Value = DateTime.Now.AddDays(14);

                dateTimePicker1.MinDate = DateTime.Now.AddDays(14);
                dateTimePicker2.MinDate = DateTime.Now.AddDays(14);

                comboBoxRooms.SelectedIndex = 0;
                textBoxCustomerSearch.Clear();
                dateTimePicker1.Value = DateTime.Now.Date;
                dateTimePicker2.Value = DateTime.Now.Date;
                comboBoxExtraBeds.SelectedIndex = 0;

                labelNewMessage.Text = "Ny bokning";
                buttonCreateBooking.Text = "Skapa bokning";
            }
        }
    }
}
