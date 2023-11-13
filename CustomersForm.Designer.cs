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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelNameException = new System.Windows.Forms.Label();
            this.labelEmailException = new System.Windows.Forms.Label();
            this.labelPhoneException = new System.Windows.Forms.Label();
            this.labelAddressException = new System.Windows.Forms.Label();
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
            this.buttonCreateCustomer.Location = new System.Drawing.Point(102, 242);
            this.buttonCreateCustomer.Name = "buttonCreateCustomer";
            this.buttonCreateCustomer.Size = new System.Drawing.Size(200, 23);
            this.buttonCreateCustomer.TabIndex = 26;
            this.buttonCreateCustomer.Text = "Skapa kund";
            this.buttonCreateCustomer.UseVisualStyleBackColor = false;
            this.buttonCreateCustomer.Click += new System.EventHandler(this.buttonCreateCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ny kund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Namn";
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(102, 77);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerSearch.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.Location = new System.Drawing.Point(102, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.Location = new System.Drawing.Point(102, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.Location = new System.Drawing.Point(102, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 29;
            // 
            // labelNameException
            // 
            this.labelNameException.AutoSize = true;
            this.labelNameException.Location = new System.Drawing.Point(99, 100);
            this.labelNameException.Name = "labelNameException";
            this.labelNameException.Size = new System.Drawing.Size(62, 13);
            this.labelNameException.TabIndex = 30;
            this.labelNameException.Text = "placeholder";
            // 
            // labelEmailException
            // 
            this.labelEmailException.AutoSize = true;
            this.labelEmailException.Location = new System.Drawing.Point(99, 142);
            this.labelEmailException.Name = "labelEmailException";
            this.labelEmailException.Size = new System.Drawing.Size(62, 13);
            this.labelEmailException.TabIndex = 31;
            this.labelEmailException.Text = "placeholder";
            // 
            // labelPhoneException
            // 
            this.labelPhoneException.AutoSize = true;
            this.labelPhoneException.Location = new System.Drawing.Point(99, 183);
            this.labelPhoneException.Name = "labelPhoneException";
            this.labelPhoneException.Size = new System.Drawing.Size(62, 13);
            this.labelPhoneException.TabIndex = 32;
            this.labelPhoneException.Text = "placeholder";
            // 
            // labelAddressException
            // 
            this.labelAddressException.AutoSize = true;
            this.labelAddressException.Location = new System.Drawing.Point(99, 223);
            this.labelAddressException.Name = "labelAddressException";
            this.labelAddressException.Size = new System.Drawing.Size(62, 13);
            this.labelAddressException.TabIndex = 33;
            this.labelAddressException.Text = "placeholder";
            // 
            // CustomerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 344);
            this.Controls.Add(this.labelAddressException);
            this.Controls.Add(this.labelPhoneException);
            this.Controls.Add(this.labelEmailException);
            this.Controls.Add(this.labelNameException);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreateCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCustomerSearch);
            this.Name = "CustomerRegistrationForm";
            this.Text = "CustomerRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelNameException;
        private System.Windows.Forms.Label labelEmailException;
        private System.Windows.Forms.Label labelPhoneException;
        private System.Windows.Forms.Label labelAddressException;
    }
}