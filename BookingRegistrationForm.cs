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
    public partial class BookingRegistrationForm : Form
    {
        private AutoCompleteStringCollection _data;

        private Room _currentRoomSelected;

        private List<Room> _comboBoxRooms;

        public BookingRegistrationForm()
        {
            InitializeComponent();

            _comboBoxRooms = RoomRepo.GetAllRooms();

            comboBoxRooms.DisplayMember = "Name";
            comboBoxRooms.ValueMember = "RoomID";
            comboBoxRooms.DataSource = _comboBoxRooms;

            comboBoxExtraBeds.Items.Add(0);
            comboBoxExtraBeds.SelectedIndex = 0;
            _currentRoomSelected = RoomRepo.GetRoomByID((int)comboBoxRooms.SelectedValue);

            _data = new AutoCompleteStringCollection();

            _data.AddRange(CustomerRepo.GetAllCustomersAutoComplete().ToArray());

            textBoxCustomerSearch.AutoCompleteCustomSource = _data;
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

            if (!RoomRepo.CheckRoomAvailability(_currentRoomSelected, start, end))
            {
                labelRoomException.Text = "Rummet är upptaget mellan den tidsperioden.";
                labelRoomException.Visible = true;
                _comboBoxRooms.Remove(_currentRoomSelected);
                _currentRoomSelected = null;
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
    }
}
