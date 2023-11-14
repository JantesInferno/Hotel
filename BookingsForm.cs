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

        private Booking _currentBooking;

        private List<Room> _comboBoxRooms;

        private int _selectedIndex;

        public BookingsForm(DateTime? startDate = null, int? roomID = null)
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

            if (startDate != null && roomID != null)
            {
                dateTimePicker1.Value = startDate.Value;
                dateTimePicker2.Value = startDate.Value;
                comboBoxRooms.SelectedValue = roomID.Value;
            }
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

            comboBoxExtraBeds.SelectedIndex = 0;
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
                _selectedIndex = listBoxBookings.SelectedIndex;

                _currentBooking = BookingRepo.GetBookingByID((int)listBoxBookings.SelectedValue);

                dateTimePicker1.MinDate = DateTime.Now.AddYears(-10);
                dateTimePicker2.MinDate = DateTime.Now.AddYears(-10);

                textBoxCustomerSearch.Text = _currentBooking.Customer.Name;
                comboBoxRooms.SelectedValue = (int)_currentBooking.RoomID;
                dateTimePicker1.Value = _currentBooking.StartDate;
                dateTimePicker2.Value = _currentBooking.EndDate;
                comboBoxExtraBeds.SelectedIndex = (int)_currentBooking.ExtraBeds;

                buttonUpdate.Visible = true;
                buttonDelete.Visible = true;
                buttonCreateBooking.Visible = false;
            }
        }

        private void listBoxBookings_Click(object sender, EventArgs e)
        {
            if (_selectedIndex == listBoxBookings.SelectedIndex)
            {
                listBoxBookings.ClearSelected();

                _selectedIndex = -1;

                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker2.Value = DateTime.Today;

                dateTimePicker1.MinDate = DateTime.Today;
                dateTimePicker2.MinDate = DateTime.Today;

                comboBoxRooms.SelectedIndex = 0;
                textBoxCustomerSearch.Clear();
                dateTimePicker1.Value = DateTime.Now.Date;
                dateTimePicker2.Value = DateTime.Now.Date;
                comboBoxExtraBeds.SelectedIndex = 0;

                buttonCreateBooking.Visible = true;
                buttonUpdate.Visible = false;
                buttonDelete.Visible = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            BookingRepo.UpdateBooking(_currentBooking);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort bokningen?", "Varning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BookingRepo.DeleteBooking(_currentBooking);
            }
        }
    }
}
