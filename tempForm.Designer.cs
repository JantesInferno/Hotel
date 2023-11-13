namespace Hotel
{
    partial class tempForm
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
            this.linkLabelCancelBookings = new System.Windows.Forms.LinkLabel();
            this.labelTodaysDueDates = new System.Windows.Forms.Label();
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.buttonRegisterPayment = new System.Windows.Forms.Button();
            this.buttonCancelBooking = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.buttonCustomerCreate = new System.Windows.Forms.Button();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.buttonBookingCreate = new System.Windows.Forms.Button();
            this.buttonBookingSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManageInvoice = new System.Windows.Forms.Label();
            this.labelCurrentDateTime = new System.Windows.Forms.Label();
            this.labelManageBooking = new System.Windows.Forms.Label();
            this.labelManageCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInvoice.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelBooking.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelCancelBookings
            // 
            this.linkLabelCancelBookings.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabelCancelBookings.AutoSize = true;
            this.linkLabelCancelBookings.LinkColor = System.Drawing.Color.Red;
            this.linkLabelCancelBookings.Location = new System.Drawing.Point(489, 280);
            this.linkLabelCancelBookings.Name = "linkLabelCancelBookings";
            this.linkLabelCancelBookings.Size = new System.Drawing.Size(101, 13);
            this.linkLabelCancelBookings.TabIndex = 48;
            this.linkLabelCancelBookings.TabStop = true;
            this.linkLabelCancelBookings.Text = "Annullera bokningar";
            this.linkLabelCancelBookings.Visible = false;
            this.linkLabelCancelBookings.VisitedLinkColor = System.Drawing.Color.DarkRed;
            // 
            // labelTodaysDueDates
            // 
            this.labelTodaysDueDates.AutoSize = true;
            this.labelTodaysDueDates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodaysDueDates.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTodaysDueDates.Location = new System.Drawing.Point(187, 279);
            this.labelTodaysDueDates.Name = "labelTodaysDueDates";
            this.labelTodaysDueDates.Size = new System.Drawing.Size(296, 15);
            this.labelTodaysDueDates.TabIndex = 47;
            this.labelTodaysDueDates.Text = "Bokingar vars faktura förfaller idag: {dueDatesCount} st";
            this.labelTodaysDueDates.Visible = false;
            // 
            // panelInvoice
            // 
            this.panelInvoice.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelInvoice.Controls.Add(this.buttonRegisterPayment);
            this.panelInvoice.Controls.Add(this.buttonCancelBooking);
            this.panelInvoice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInvoice.Location = new System.Drawing.Point(796, 270);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.Size = new System.Drawing.Size(121, 47);
            this.panelInvoice.TabIndex = 46;
            this.panelInvoice.Visible = false;
            // 
            // buttonRegisterPayment
            // 
            this.buttonRegisterPayment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonRegisterPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterPayment.FlatAppearance.BorderSize = 0;
            this.buttonRegisterPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonRegisterPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterPayment.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterPayment.Location = new System.Drawing.Point(0, 0);
            this.buttonRegisterPayment.Name = "buttonRegisterPayment";
            this.buttonRegisterPayment.Size = new System.Drawing.Size(121, 23);
            this.buttonRegisterPayment.TabIndex = 13;
            this.buttonRegisterPayment.Text = "Registrera betalning";
            this.buttonRegisterPayment.UseVisualStyleBackColor = false;
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelBooking.FlatAppearance.BorderSize = 0;
            this.buttonCancelBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelBooking.ForeColor = System.Drawing.Color.White;
            this.buttonCancelBooking.Location = new System.Drawing.Point(0, 24);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(121, 23);
            this.buttonCancelBooking.TabIndex = 14;
            this.buttonCancelBooking.Text = "Annullera bokning";
            this.buttonCancelBooking.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(189, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 30);
            this.label10.TabIndex = 45;
            this.label10.Text = "Översikt bokningar ";
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCustomer.Controls.Add(this.buttonCustomerCreate);
            this.panelCustomer.Controls.Add(this.buttonCustomerSearch);
            this.panelCustomer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomer.Location = new System.Drawing.Point(926, 270);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(95, 47);
            this.panelCustomer.TabIndex = 43;
            this.panelCustomer.Visible = false;
            // 
            // buttonCustomerCreate
            // 
            this.buttonCustomerCreate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCustomerCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerCreate.FlatAppearance.BorderSize = 0;
            this.buttonCustomerCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonCustomerCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCustomerCreate.Location = new System.Drawing.Point(0, 0);
            this.buttonCustomerCreate.Name = "buttonCustomerCreate";
            this.buttonCustomerCreate.Size = new System.Drawing.Size(95, 23);
            this.buttonCustomerCreate.TabIndex = 13;
            this.buttonCustomerCreate.Text = "Ny kund";
            this.buttonCustomerCreate.UseVisualStyleBackColor = false;
            // 
            // buttonCustomerSearch
            // 
            this.buttonCustomerSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerSearch.FlatAppearance.BorderSize = 0;
            this.buttonCustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.buttonCustomerSearch.Location = new System.Drawing.Point(0, 24);
            this.buttonCustomerSearch.Name = "buttonCustomerSearch";
            this.buttonCustomerSearch.Size = new System.Drawing.Size(95, 23);
            this.buttonCustomerSearch.TabIndex = 14;
            this.buttonCustomerSearch.Text = "Sök kund";
            this.buttonCustomerSearch.UseVisualStyleBackColor = false;
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelBooking.Controls.Add(this.buttonBookingCreate);
            this.panelBooking.Controls.Add(this.buttonBookingSearch);
            this.panelBooking.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBooking.Location = new System.Drawing.Point(1030, 270);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(117, 47);
            this.panelBooking.TabIndex = 44;
            this.panelBooking.Visible = false;
            // 
            // buttonBookingCreate
            // 
            this.buttonBookingCreate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBookingCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookingCreate.FlatAppearance.BorderSize = 0;
            this.buttonBookingCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonBookingCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookingCreate.ForeColor = System.Drawing.Color.White;
            this.buttonBookingCreate.Location = new System.Drawing.Point(0, 0);
            this.buttonBookingCreate.Name = "buttonBookingCreate";
            this.buttonBookingCreate.Size = new System.Drawing.Size(117, 23);
            this.buttonBookingCreate.TabIndex = 13;
            this.buttonBookingCreate.Text = "Ny bokning";
            this.buttonBookingCreate.UseVisualStyleBackColor = false;
            // 
            // buttonBookingSearch
            // 
            this.buttonBookingSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBookingSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookingSearch.FlatAppearance.BorderSize = 0;
            this.buttonBookingSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonBookingSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookingSearch.ForeColor = System.Drawing.Color.White;
            this.buttonBookingSearch.Location = new System.Drawing.Point(0, 24);
            this.buttonBookingSearch.Name = "buttonBookingSearch";
            this.buttonBookingSearch.Size = new System.Drawing.Size(117, 23);
            this.buttonBookingSearch.TabIndex = 14;
            this.buttonBookingSearch.Text = "Sök bokning";
            this.buttonBookingSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.labelManageInvoice);
            this.panel1.Controls.Add(this.labelCurrentDateTime);
            this.panel1.Controls.Add(this.labelManageBooking);
            this.panel1.Controls.Add(this.labelManageCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(187, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 100);
            this.panel1.TabIndex = 42;
            // 
            // labelManageInvoice
            // 
            this.labelManageInvoice.AutoSize = true;
            this.labelManageInvoice.ForeColor = System.Drawing.Color.White;
            this.labelManageInvoice.Location = new System.Drawing.Point(606, 75);
            this.labelManageInvoice.Name = "labelManageInvoice";
            this.labelManageInvoice.Size = new System.Drawing.Size(124, 17);
            this.labelManageInvoice.TabIndex = 39;
            this.labelManageInvoice.Text = "Hantera betalningar";
            // 
            // labelCurrentDateTime
            // 
            this.labelCurrentDateTime.AutoSize = true;
            this.labelCurrentDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDateTime.ForeColor = System.Drawing.Color.White;
            this.labelCurrentDateTime.Location = new System.Drawing.Point(3, 71);
            this.labelCurrentDateTime.Name = "labelCurrentDateTime";
            this.labelCurrentDateTime.Size = new System.Drawing.Size(57, 21);
            this.labelCurrentDateTime.TabIndex = 12;
            this.labelCurrentDateTime.Text = "Datum";
            // 
            // labelManageBooking
            // 
            this.labelManageBooking.AutoSize = true;
            this.labelManageBooking.ForeColor = System.Drawing.Color.White;
            this.labelManageBooking.Location = new System.Drawing.Point(840, 74);
            this.labelManageBooking.Name = "labelManageBooking";
            this.labelManageBooking.Size = new System.Drawing.Size(117, 17);
            this.labelManageBooking.TabIndex = 13;
            this.labelManageBooking.Text = "Hantera bokningar";
            // 
            // labelManageCustomer
            // 
            this.labelManageCustomer.AutoSize = true;
            this.labelManageCustomer.ForeColor = System.Drawing.Color.White;
            this.labelManageCustomer.Location = new System.Drawing.Point(736, 74);
            this.labelManageCustomer.Name = "labelManageCustomer";
            this.labelManageCustomer.Size = new System.Drawing.Size(98, 17);
            this.labelManageCustomer.TabIndex = 12;
            this.labelManageCustomer.Text = "Hantera kunder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GOST Common", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL1";
            // 
            // tempForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 528);
            this.Controls.Add(this.linkLabelCancelBookings);
            this.Controls.Add(this.labelTodaysDueDates);
            this.Controls.Add(this.panelInvoice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelBooking);
            this.Controls.Add(this.panel1);
            this.Name = "tempForm";
            this.Text = "tempForm";
            this.panelInvoice.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelBooking.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCancelBookings;
        private System.Windows.Forms.Label labelTodaysDueDates;
        private System.Windows.Forms.Panel panelInvoice;
        private System.Windows.Forms.Button buttonRegisterPayment;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button buttonCustomerCreate;
        private System.Windows.Forms.Button buttonCustomerSearch;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Button buttonBookingCreate;
        private System.Windows.Forms.Button buttonBookingSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageInvoice;
        private System.Windows.Forms.Label labelCurrentDateTime;
        private System.Windows.Forms.Label labelManageBooking;
        private System.Windows.Forms.Label labelManageCustomer;
        private System.Windows.Forms.Label label1;
    }
}