namespace Hotel
{
    partial class CustomersForm
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
            this.buttonCreateCustomer = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelNameException = new System.Windows.Forms.Label();
            this.labelEmailException = new System.Windows.Forms.Label();
            this.labelPhoneException = new System.Windows.Forms.Label();
            this.labelAddressException = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTest = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchMessage = new System.Windows.Forms.Label();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateCustomer
            // 
            this.buttonCreateCustomer.BackColor = System.Drawing.Color.Black;
            this.buttonCreateCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCreateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonCreateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonCreateCustomer.Location = new System.Drawing.Point(111, 372);
            this.buttonCreateCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateCustomer.Name = "buttonCreateCustomer";
            this.buttonCreateCustomer.Size = new System.Drawing.Size(300, 35);
            this.buttonCreateCustomer.TabIndex = 26;
            this.buttonCreateCustomer.Text = "Skapa kund";
            this.buttonCreateCustomer.UseVisualStyleBackColor = false;
            this.buttonCreateCustomer.Click += new System.EventHandler(this.buttonCreateCustomer_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(8, 312);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 20);
            this.labelAddress.TabIndex = 24;
            this.labelAddress.Text = "Adress";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(8, 251);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(62, 20);
            this.labelPhone.TabIndex = 22;
            this.labelPhone.Text = "Telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(8, 188);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "Email";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(4, 14);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(124, 40);
            this.labelMessage.TabIndex = 19;
            this.labelMessage.Text = "Ny kund";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 123);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Namn";
            // 
            // textBoxName
            // 
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxName.Location = new System.Drawing.Point(111, 118);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(298, 26);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxPhone.Location = new System.Drawing.Point(111, 246);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(298, 26);
            this.textBoxPhone.TabIndex = 27;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEmail.Location = new System.Drawing.Point(111, 183);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(298, 26);
            this.textBoxEmail.TabIndex = 28;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAddress.Location = new System.Drawing.Point(111, 308);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(298, 26);
            this.textBoxAddress.TabIndex = 29;
            // 
            // labelNameException
            // 
            this.labelNameException.AutoSize = true;
            this.labelNameException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNameException.Location = new System.Drawing.Point(106, 154);
            this.labelNameException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameException.Name = "labelNameException";
            this.labelNameException.Size = new System.Drawing.Size(91, 20);
            this.labelNameException.TabIndex = 30;
            this.labelNameException.Text = "placeholder";
            this.labelNameException.Visible = false;
            // 
            // labelEmailException
            // 
            this.labelEmailException.AutoSize = true;
            this.labelEmailException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEmailException.Location = new System.Drawing.Point(106, 218);
            this.labelEmailException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailException.Name = "labelEmailException";
            this.labelEmailException.Size = new System.Drawing.Size(91, 20);
            this.labelEmailException.TabIndex = 31;
            this.labelEmailException.Text = "placeholder";
            this.labelEmailException.Visible = false;
            // 
            // labelPhoneException
            // 
            this.labelPhoneException.AutoSize = true;
            this.labelPhoneException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPhoneException.Location = new System.Drawing.Point(106, 282);
            this.labelPhoneException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneException.Name = "labelPhoneException";
            this.labelPhoneException.Size = new System.Drawing.Size(91, 20);
            this.labelPhoneException.TabIndex = 32;
            this.labelPhoneException.Text = "placeholder";
            this.labelPhoneException.Visible = false;
            // 
            // labelAddressException
            // 
            this.labelAddressException.AutoSize = true;
            this.labelAddressException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAddressException.Location = new System.Drawing.Point(106, 343);
            this.labelAddressException.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddressException.Name = "labelAddressException";
            this.labelAddressException.Size = new System.Drawing.Size(91, 20);
            this.labelAddressException.TabIndex = 33;
            this.labelAddressException.Text = "placeholder";
            this.labelAddressException.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTest);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.labelAddressException);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelPhoneException);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelEmailException);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelNameException);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.buttonCreateCustomer);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 456);
            this.panel1.TabIndex = 34;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(332, 45);
            this.labelTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(51, 20);
            this.labelTest.TabIndex = 34;
            this.labelTest.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBoxCustomers);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.labelSearchMessage);
            this.panel2.Controls.Add(this.textBoxCustomerSearch);
            this.panel2.Location = new System.Drawing.Point(534, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 456);
            this.panel2.TabIndex = 35;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 20;
            this.listBoxCustomers.Location = new System.Drawing.Point(111, 183);
            this.listBoxCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(427, 244);
            this.listBoxCustomers.TabIndex = 28;
            this.listBoxCustomers.Click += new System.EventHandler(this.listBoxCustomers_Click);
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(474, 118);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(66, 35);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "Visa";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchMessage
            // 
            this.labelSearchMessage.AutoSize = true;
            this.labelSearchMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchMessage.Location = new System.Drawing.Point(4, 14);
            this.labelSearchMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchMessage.Name = "labelSearchMessage";
            this.labelSearchMessage.Size = new System.Drawing.Size(201, 40);
            this.labelSearchMessage.TabIndex = 19;
            this.labelSearchMessage.Text = "Sök efter kund";
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(111, 118);
            this.textBoxCustomerSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(362, 31);
            this.textBoxCustomerSearch.TabIndex = 16;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomersForm";
            this.Text = "CustomerRegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCustomer;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelNameException;
        private System.Windows.Forms.Label labelEmailException;
        private System.Windows.Forms.Label labelPhoneException;
        private System.Windows.Forms.Label labelAddressException;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSearchMessage;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Label labelTest;
    }
}