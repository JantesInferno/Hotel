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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
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
            this.buttonCreateCustomer.Location = new System.Drawing.Point(74, 282);
            this.buttonCreateCustomer.Name = "buttonCreateCustomer";
            this.buttonCreateCustomer.Size = new System.Drawing.Size(200, 23);
            this.buttonCreateCustomer.TabIndex = 5;
            this.buttonCreateCustomer.Text = "Skapa kund";
            this.buttonCreateCustomer.UseVisualStyleBackColor = false;
            this.buttonCreateCustomer.Click += new System.EventHandler(this.buttonCreateCustomer_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(5, 203);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(39, 13);
            this.labelAddress.TabIndex = 24;
            this.labelAddress.Text = "Adress";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(5, 163);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(43, 13);
            this.labelPhone.TabIndex = 22;
            this.labelPhone.Text = "Telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(5, 122);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "Email";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(3, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(89, 25);
            this.labelMessage.TabIndex = 19;
            this.labelMessage.Text = "Ny kund";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Namn";
            // 
            // textBoxName
            // 
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxName.Location = new System.Drawing.Point(74, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxPhone.Location = new System.Drawing.Point(74, 160);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEmail.Location = new System.Drawing.Point(74, 119);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAddress.Location = new System.Drawing.Point(74, 200);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelNameException
            // 
            this.labelNameException.AutoSize = true;
            this.labelNameException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNameException.Location = new System.Drawing.Point(71, 100);
            this.labelNameException.Name = "labelNameException";
            this.labelNameException.Size = new System.Drawing.Size(62, 13);
            this.labelNameException.TabIndex = 30;
            this.labelNameException.Text = "placeholder";
            this.labelNameException.Visible = false;
            // 
            // labelEmailException
            // 
            this.labelEmailException.AutoSize = true;
            this.labelEmailException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEmailException.Location = new System.Drawing.Point(71, 142);
            this.labelEmailException.Name = "labelEmailException";
            this.labelEmailException.Size = new System.Drawing.Size(62, 13);
            this.labelEmailException.TabIndex = 31;
            this.labelEmailException.Text = "placeholder";
            this.labelEmailException.Visible = false;
            // 
            // labelPhoneException
            // 
            this.labelPhoneException.AutoSize = true;
            this.labelPhoneException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPhoneException.Location = new System.Drawing.Point(71, 183);
            this.labelPhoneException.Name = "labelPhoneException";
            this.labelPhoneException.Size = new System.Drawing.Size(62, 13);
            this.labelPhoneException.TabIndex = 32;
            this.labelPhoneException.Text = "placeholder";
            this.labelPhoneException.Visible = false;
            // 
            // labelAddressException
            // 
            this.labelAddressException.AutoSize = true;
            this.labelAddressException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAddressException.Location = new System.Drawing.Point(71, 223);
            this.labelAddressException.Name = "labelAddressException";
            this.labelAddressException.Size = new System.Drawing.Size(62, 13);
            this.labelAddressException.TabIndex = 33;
            this.labelAddressException.Text = "placeholder";
            this.labelAddressException.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
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
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 328);
            this.panel1.TabIndex = 34;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(176, 282);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Ta bort";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(72, 282);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(98, 23);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Uppdatera";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.listBoxCustomers);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.labelSearchMessage);
            this.panel2.Controls.Add(this.textBoxCustomerSearch);
            this.panel2.Location = new System.Drawing.Point(350, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 328);
            this.panel2.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kundnamn";
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(74, 119);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(286, 186);
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
            this.buttonSearch.Location = new System.Drawing.Point(316, 77);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 23);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "Visa";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchMessage
            // 
            this.labelSearchMessage.AutoSize = true;
            this.labelSearchMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchMessage.Location = new System.Drawing.Point(3, 9);
            this.labelSearchMessage.Name = "labelSearchMessage";
            this.labelSearchMessage.Size = new System.Drawing.Size(145, 25);
            this.labelSearchMessage.TabIndex = 19;
            this.labelSearchMessage.Text = "Sök efter kund";
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(74, 77);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(243, 23);
            this.textBoxCustomerSearch.TabIndex = 16;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(821, 340);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}