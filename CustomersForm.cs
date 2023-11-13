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
        private int _selectedCustomer;
        public CustomersForm()
        {
            InitializeComponent();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.AddRange(CustomerRepo.GetAllCustomersAutoComplete().ToArray());

            textBoxCustomerSearch.AutoCompleteCustomSource = data;
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { textBoxName, textBoxEmail, textBoxPhone, textBoxAddress};
            Label[] label = { labelName, labelEmail, labelPhone, labelAddress};

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


            if (!label.Any(x => x.Visible))
            {
                Customer customer = new Customer();
                customer.Name = textBoxEmail.Text;
                customer.Email = textBoxPhone.Text;
                customer.Phone = textBoxEmail.Text;
                customer.Address = textBoxAddress.Text;

                if (listBoxCustomers.SelectedIndex >= 0)
                {
                    CustomerRepo.UpdateCustomer(customer);
                }
                else
                {
                    try
                    {
                        CustomerRepo.CreateCustomer(customer);

                        MessageBox.Show("Kund: " + customer.Name + " finns redan registrerad");

                        this.Close();
                    }
                    catch (Exception)
                    {
                        labelNameException.Text = "Användarnamn upptaget";
                        labelNameException.Visible = true;
                    }
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
                _selectedCustomer = listBoxCustomers.SelectedIndex;

                Customer customer = CustomerRepo.GetCustomerById((int)listBoxCustomers.SelectedValue);

                textBoxName.Text = customer.Name;
                textBoxEmail.Text = customer.Email;
                textBoxPhone.Text = customer.Phone;
                textBoxAddress.Text = customer.Address;

                labelMessage.Text = "Redigera kund";
                buttonCreateCustomer.Text = "Uppdatera kund";
            }
        }

        private void listBoxCustomers_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == listBoxCustomers.SelectedIndex)
            {
                listBoxCustomers.ClearSelected();

                _selectedCustomer = -1;

                textBoxName.Clear();
                textBoxEmail.Clear();
                textBoxPhone.Clear();
                textBoxAddress.Clear();

                labelMessage.Text = "Ny kund";
                buttonCreateCustomer.Text = "Skapa kund";
            }
        }
    }
}
