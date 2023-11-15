using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel
{
    public partial class BookingDetailsForm : Form
    {
        private Booking _currentBooking;

        private AutoCompleteStringCollection _data;

        private Room _currentRoomSelected;

        private List<Room> _comboBoxRooms;

        private DateTime _start;
        private DateTime _end;

        public BookingDetailsForm(Booking booking)
        {
            InitializeComponent();
            _currentBooking = booking;

            dateTimePickerCheckIn.Value = _currentBooking.StartDate;
            dateTimePickerCheckOut.Value = _currentBooking.EndDate;
            comboBoxRooms.SelectedValue = _currentBooking.RoomID;
            textBoxBookingCustomer.Text = _currentBooking.Customer.Name;
            comboBoxExtraBeds.SelectedValue = _currentBooking.ExtraBeds;

            textBoxCustomerName.Text = _currentBooking.Customer.Name;
            textBoxCustomerEmail.Text = _currentBooking.Customer.Email;
            textBoxCustomerPhone.Text = _currentBooking.Customer.Phone;
            textBoxCustomerAddress.Text = _currentBooking.Customer.Address;

            if (_currentBooking.Invoice.DueDate != null)
            {
                textBoxInvoiceID.Text = _currentBooking.InvoiceID.ToString();
                textBoxTotalCost.Text = ((int)_currentBooking.Invoice.TotalCost).ToString() + ":-";
                dateTimePickerDueDate.Value = (DateTime)_currentBooking.Invoice.DueDate;
            }
            else
            {
                textBoxInvoiceID.Text = _currentBooking.InvoiceID.ToString();
                textBoxTotalCost.Text = "0:-";
                labelDueDate.Visible = false;
                dateTimePickerDueDate.Visible = false;
                buttonPaymentDeclined.Visible = false;
                buttonPaymentFulfilled.Visible = false;

                buttonBookingUpdate.Visible = false;
                buttonBookingDelete.Visible = false;

                this.Enabled = false;
            }

            _comboBoxRooms = RoomRepo.GetAllRooms();

            comboBoxRooms.DisplayMember = "Name";
            comboBoxRooms.ValueMember = "RoomID";
            comboBoxRooms.DataSource = _comboBoxRooms;

            comboBoxExtraBeds.Items.Add(0);
            comboBoxExtraBeds.SelectedIndex = 0;
            _currentRoomSelected = RoomRepo.GetRoomByID((int)comboBoxRooms.SelectedValue);

            dateTimePickerCheckIn.MinDate = DateTime.Today;
            dateTimePickerCheckOut.MinDate = DateTime.Today;

            _data = new AutoCompleteStringCollection();

            _data.AddRange(CustomerRepo.GetAllCustomersAutoComplete().ToArray());

            textBoxBookingCustomer.AutoCompleteCustomSource = _data;
        }

        private void comboBoxRooms_Format(object sender, ListControlConvertEventArgs e)
        {
            Room room = ((Room)e.ListItem);
            int roomID = (int)room.RoomID;
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

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (ValidateInputBooking())
            {
                Booking booking = new Booking();
                booking.RoomID = _currentRoomSelected.RoomID;
                booking.CustomerID = CustomerRepo.GetCustomersBySearch(textBoxBookingCustomer.Text.Trim()).FirstOrDefault().CustomerID;
                booking.StartDate = _start;
                booking.EndDate = _end;
                booking.ExtraBeds = Convert.ToInt32(comboBoxExtraBeds.Text);

                BookingRepo.CreateBooking(booking, _currentRoomSelected);

                MessageBox.Show("Bokning skapad");
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort bokningen?", "Varning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BookingRepo.DeleteBooking(_currentBooking);

                MessageBox.Show("Bokning borttagen");
            }
        }

        private bool ValidateInputBooking()
        {
            _start = dateTimePickerCheckIn.Value.Date;
            _end = dateTimePickerCheckOut.Value.Date;

            if (_start > _end)
            {
                labelDateException.Text = "Slutdatum kan inte vara före startdatum.";
                labelDateException.Visible = true;
            }
            else
                labelDateException.Visible = false;
            if (!_data.Contains(textBoxBookingCustomer.Text.Trim()))
            {
                labelCustomerException.Text = "Ogiltigt kundnamn.";
                labelCustomerException.Visible = true;
            }
            else if (textBoxBookingCustomer.Text.Trim().Length <= 0)
            {
                labelCustomerException.Text = "Obligatoriskt fält.";
                labelCustomerException.Visible = true;
            }
            else
            {
                labelCustomerException.Visible = false;
            }

            if (!RoomRepo.CheckRoomAvailability(_currentRoomSelected, _start, _end))
            {
                labelRoomException.Text = "Rummet är upptaget den tidsperioden.";
                labelRoomException.Visible = true;
            }
            else
                labelRoomException.Visible = false;

            if (labelCustomerException.Visible || labelDateException.Visible || labelRoomException.Visible)
            {
                return false;
            }

            return true;
        }

        private void buttonPaymentFulfilled_Click(object sender, EventArgs e)
        {
            MainForm._dueDates.Remove(_currentBooking);

            _currentBooking.Invoice.DueDate = null;

            InvoiceRepo.UpdateInvoice(_currentBooking.Invoice);

            MessageBox.Show("Faktura markerad som betald");
        }

        private void buttonPaymentDeclined_Click(object sender, EventArgs e)
        {
            MainForm._dueDates.Remove(_currentBooking);

            BookingRepo.DeleteBooking(_currentBooking);

            MessageBox.Show("Bokning annullerad");

        }
    }
}
