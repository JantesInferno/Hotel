using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel
{
    public partial class CustomersForm : Form
    {
        private int _selectedIndex;

        private Customer _currentCustomer;


        public CustomersForm()
        {
            InitializeComponent();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.AddRange(CustomerRepo.GetAllCustomersAutoComplete().ToArray());

            textBoxCustomerSearch.AutoCompleteCustomSource = data;
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            if (ValidatedInput())
            {
                Customer customer = new Customer();
                customer.Name = textBoxName.Text;
                customer.Email = textBoxEmail.Text;
                customer.Phone = textBoxPhone.Text;
                customer.Address = textBoxAddress.Text;

                try
                {
                    CustomerRepo.CreateCustomer(customer);

                    MessageBox.Show("Kund " + customer.Name + " registrerad");
                }
                catch (Exception)
                {
                    labelEmailException.Text = "En kund är redan kopplad till den här email-adressen";
                    labelEmailException.Visible = true;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxCustomers.DisplayMember = "Name";
            listBoxCustomers.ValueMember = "CustomerID";
            listBoxCustomers.DataSource = CustomerRepo.GetCustomersBySearch(textBoxCustomerSearch.Text.Trim());
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex >= 0)
            {
                _selectedIndex = listBoxCustomers.SelectedIndex;

                _currentCustomer = CustomerRepo.GetCustomerById((int)listBoxCustomers.SelectedValue);

                textBoxName.Text = _currentCustomer.Name;
                textBoxEmail.Text = _currentCustomer.Email;
                textBoxPhone.Text = _currentCustomer.Phone;
                textBoxAddress.Text = _currentCustomer.Address;

                buttonCreateCustomer.Visible = false;
                buttonUpdate.Visible = true;
                buttonDelete.Visible = true;
            }
        }

        private void listBoxCustomers_Click(object sender, EventArgs e)
        {
            if (_selectedIndex == listBoxCustomers.SelectedIndex)
            {
                listBoxCustomers.ClearSelected();

                _selectedIndex = -1;

                textBoxName.Clear();
                textBoxEmail.Clear();
                textBoxPhone.Clear();
                textBoxAddress.Clear();

                buttonCreateCustomer.Visible = true;
                buttonUpdate.Visible = false;
                buttonDelete.Visible = false;
            }
        }

        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ValidatedInput())
            {
                _currentCustomer.Name = textBoxName.Text;
                _currentCustomer.Email = textBoxEmail.Text;
                _currentCustomer.Phone = textBoxPhone.Text;
                _currentCustomer.Address = textBoxAddress.Text;
                CustomerRepo.UpdateCustomer(_currentCustomer);

                MessageBox.Show("Kund " + _currentCustomer.Name + " uppdaterad");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort kunden?", "Varning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (CustomerRepo.DeleteCustomer(_currentCustomer))
                    MessageBox.Show("Kund " + _currentCustomer.Name + " borttagen");
                else
                    MessageBox.Show("Kund " + _currentCustomer.Name + " har en aktiv bokning");

                _currentCustomer = null;
            }
        }

        private bool ValidatedInput()
        {
            TextBox[] textBox = { textBoxName, textBoxEmail, textBoxPhone, textBoxAddress };
            Label[] label = { labelNameException, labelEmailException, labelPhoneException, labelAddressException };

            int i = 0;
            string requiredField = "Obligatoriskt fält";

            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    label[i].Text = requiredField;
                    label[i].Visible = true;
                }
                else if (txt.Equals(textBoxEmail) && !(new EmailAddressAttribute().IsValid(textBoxEmail.Text)))
                {
                    label[i].Text = "Ogiltig mailadress";
                    label[i].Visible = true;
                }
                else if (txt.Equals(textBoxPhone) && txt.Text.Count(x => Char.IsDigit(x)) < 9 || txt.Text.Count(x => Char.IsDigit(x)) > 10)
                {
                    label[i].Text = "9-10 siffror (inkl. riktnummer)";
                    label[i].Visible = true;
                }
                else if (txt.Text.Length > 40)
                {
                    label[i].Text = "Max längd: 40 (inklusive blanksteg)";
                    label[i].Visible = true;
                }
                else
                {
                    label[i].Visible = false;
                }
                i++;
            }

            if (label.Any(x => x.Visible))
                return false;

            return true;
        }
    }
}
