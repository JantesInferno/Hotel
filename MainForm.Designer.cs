namespace Hotel
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelManageCustomer = new System.Windows.Forms.Label();
            this.labelManageBooking = new System.Windows.Forms.Label();
            this.labelCurrentDateTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCustomerUpdate = new System.Windows.Forms.Button();
            this.buttonCustomerCreate = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.buttonBookingCreate = new System.Windows.Forms.Button();
            this.buttonBookingUpdate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCalendarDate7 = new System.Windows.Forms.Label();
            this.labelCalendarDate6 = new System.Windows.Forms.Label();
            this.labelCalendarDate5 = new System.Windows.Forms.Label();
            this.labelCalendarDate4 = new System.Windows.Forms.Label();
            this.labelCalendarDate3 = new System.Windows.Forms.Label();
            this.labelCalendarDate2 = new System.Windows.Forms.Label();
            this.labelCalendarDate1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanelCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSearchDate = new System.Windows.Forms.Button();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTipTest = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelBooking.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // labelManageCustomer
            // 
            this.labelManageCustomer.AutoSize = true;
            this.labelManageCustomer.ForeColor = System.Drawing.Color.White;
            this.labelManageCustomer.Location = new System.Drawing.Point(760, 75);
            this.labelManageCustomer.Name = "labelManageCustomer";
            this.labelManageCustomer.Size = new System.Drawing.Size(86, 17);
            this.labelManageCustomer.TabIndex = 12;
            this.labelManageCustomer.Text = "Hantera kund";
            this.labelManageCustomer.MouseEnter += new System.EventHandler(this.labelManageCustomer_MouseEnter);
            // 
            // labelManageBooking
            // 
            this.labelManageBooking.AutoSize = true;
            this.labelManageBooking.ForeColor = System.Drawing.Color.White;
            this.labelManageBooking.Location = new System.Drawing.Point(852, 75);
            this.labelManageBooking.Name = "labelManageBooking";
            this.labelManageBooking.Size = new System.Drawing.Size(105, 17);
            this.labelManageBooking.TabIndex = 13;
            this.labelManageBooking.Text = "Hantera bokning";
            this.labelManageBooking.MouseEnter += new System.EventHandler(this.labelManageBooking_MouseEnter);
            // 
            // labelCurrentDateTime
            // 
            this.labelCurrentDateTime.AutoSize = true;
            this.labelCurrentDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDateTime.ForeColor = System.Drawing.Color.White;
            this.labelCurrentDateTime.Location = new System.Drawing.Point(6, 71);
            this.labelCurrentDateTime.Name = "labelCurrentDateTime";
            this.labelCurrentDateTime.Size = new System.Drawing.Size(57, 21);
            this.labelCurrentDateTime.TabIndex = 12;
            this.labelCurrentDateTime.Text = "Datum";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.labelCurrentDateTime);
            this.panel1.Controls.Add(this.labelManageBooking);
            this.panel1.Controls.Add(this.labelManageCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 100);
            this.panel1.TabIndex = 11;
            // 
            // buttonCustomerUpdate
            // 
            this.buttonCustomerUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerUpdate.FlatAppearance.BorderSize = 0;
            this.buttonCustomerUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCustomerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonCustomerUpdate.Location = new System.Drawing.Point(0, 30);
            this.buttonCustomerUpdate.Name = "buttonCustomerUpdate";
            this.buttonCustomerUpdate.Size = new System.Drawing.Size(83, 23);
            this.buttonCustomerUpdate.TabIndex = 14;
            this.buttonCustomerUpdate.Text = "Sök kund";
            this.buttonCustomerUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonCustomerCreate
            // 
            this.buttonCustomerCreate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerCreate.FlatAppearance.BorderSize = 0;
            this.buttonCustomerCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCustomerCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCustomerCreate.Location = new System.Drawing.Point(0, 1);
            this.buttonCustomerCreate.Name = "buttonCustomerCreate";
            this.buttonCustomerCreate.Size = new System.Drawing.Size(83, 23);
            this.buttonCustomerCreate.TabIndex = 13;
            this.buttonCustomerCreate.Text = "Ny kund";
            this.buttonCustomerCreate.UseVisualStyleBackColor = false;
            this.buttonCustomerCreate.Click += new System.EventHandler(this.buttonCustomerCreate_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelCustomer.Controls.Add(this.buttonCustomerCreate);
            this.panelCustomer.Controls.Add(this.buttonCustomerUpdate);
            this.panelCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomer.Location = new System.Drawing.Point(775, 111);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(83, 53);
            this.panelCustomer.TabIndex = 16;
            this.panelCustomer.Visible = false;
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelBooking.Controls.Add(this.buttonBookingCreate);
            this.panelBooking.Controls.Add(this.buttonBookingUpdate);
            this.panelBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBooking.Location = new System.Drawing.Point(867, 111);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(105, 53);
            this.panelBooking.TabIndex = 17;
            this.panelBooking.Visible = false;
            // 
            // buttonBookingCreate
            // 
            this.buttonBookingCreate.BackColor = System.Drawing.Color.Transparent;
            this.buttonBookingCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookingCreate.FlatAppearance.BorderSize = 0;
            this.buttonBookingCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBookingCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookingCreate.ForeColor = System.Drawing.Color.White;
            this.buttonBookingCreate.Location = new System.Drawing.Point(0, 1);
            this.buttonBookingCreate.Name = "buttonBookingCreate";
            this.buttonBookingCreate.Size = new System.Drawing.Size(106, 23);
            this.buttonBookingCreate.TabIndex = 13;
            this.buttonBookingCreate.Text = "Ny bokning";
            this.buttonBookingCreate.UseVisualStyleBackColor = false;
            this.buttonBookingCreate.Click += new System.EventHandler(this.buttonBookingCreate_Click);
            // 
            // buttonBookingUpdate
            // 
            this.buttonBookingUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonBookingUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookingUpdate.FlatAppearance.BorderSize = 0;
            this.buttonBookingUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBookingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookingUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonBookingUpdate.Location = new System.Drawing.Point(0, 30);
            this.buttonBookingUpdate.Name = "buttonBookingUpdate";
            this.buttonBookingUpdate.Size = new System.Drawing.Size(106, 23);
            this.buttonBookingUpdate.TabIndex = 14;
            this.buttonBookingUpdate.Text = "Sök bokning";
            this.buttonBookingUpdate.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Rumsnr";
            // 
            // labelCalendarDate7
            // 
            this.labelCalendarDate7.AutoSize = true;
            this.labelCalendarDate7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate7.Location = new System.Drawing.Point(839, 262);
            this.labelCalendarDate7.Name = "labelCalendarDate7";
            this.labelCalendarDate7.Size = new System.Drawing.Size(42, 17);
            this.labelCalendarDate7.TabIndex = 26;
            this.labelCalendarDate7.Text = "date7";
            // 
            // labelCalendarDate6
            // 
            this.labelCalendarDate6.AutoSize = true;
            this.labelCalendarDate6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate6.Location = new System.Drawing.Point(718, 262);
            this.labelCalendarDate6.Name = "labelCalendarDate6";
            this.labelCalendarDate6.Size = new System.Drawing.Size(42, 17);
            this.labelCalendarDate6.TabIndex = 25;
            this.labelCalendarDate6.Text = "date6";
            // 
            // labelCalendarDate5
            // 
            this.labelCalendarDate5.AutoSize = true;
            this.labelCalendarDate5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate5.Location = new System.Drawing.Point(596, 262);
            this.labelCalendarDate5.Name = "labelCalendarDate5";
            this.labelCalendarDate5.Size = new System.Drawing.Size(42, 17);
            this.labelCalendarDate5.TabIndex = 24;
            this.labelCalendarDate5.Text = "date5";
            // 
            // labelCalendarDate4
            // 
            this.labelCalendarDate4.AutoSize = true;
            this.labelCalendarDate4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate4.Location = new System.Drawing.Point(474, 262);
            this.labelCalendarDate4.Name = "labelCalendarDate4";
            this.labelCalendarDate4.Size = new System.Drawing.Size(42, 17);
            this.labelCalendarDate4.TabIndex = 23;
            this.labelCalendarDate4.Text = "date4";
            // 
            // labelCalendarDate3
            // 
            this.labelCalendarDate3.AutoSize = true;
            this.labelCalendarDate3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate3.Location = new System.Drawing.Point(352, 262);
            this.labelCalendarDate3.Name = "labelCalendarDate3";
            this.labelCalendarDate3.Size = new System.Drawing.Size(42, 17);
            this.labelCalendarDate3.TabIndex = 22;
            this.labelCalendarDate3.Text = "date3";
            // 
            // labelCalendarDate2
            // 
            this.labelCalendarDate2.AutoSize = true;
            this.labelCalendarDate2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate2.Location = new System.Drawing.Point(230, 262);
            this.labelCalendarDate2.Name = "labelCalendarDate2";
            this.labelCalendarDate2.Size = new System.Drawing.Size(42, 17);
            this.labelCalendarDate2.TabIndex = 21;
            this.labelCalendarDate2.Text = "date2";
            // 
            // labelCalendarDate1
            // 
            this.labelCalendarDate1.AutoSize = true;
            this.labelCalendarDate1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarDate1.Location = new System.Drawing.Point(109, 262);
            this.labelCalendarDate1.Name = "labelCalendarDate1";
            this.labelCalendarDate1.Size = new System.Drawing.Size(40, 17);
            this.labelCalendarDate1.TabIndex = 20;
            this.labelCalendarDate1.Text = "date1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 559);
            this.panel2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "23";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "22";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "21";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "10";
            // 
            // tableLayoutPanelCalendar
            // 
            this.tableLayoutPanelCalendar.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelCalendar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanelCalendar.ColumnCount = 7;
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelCalendar.Location = new System.Drawing.Point(108, 283);
            this.tableLayoutPanelCalendar.Name = "tableLayoutPanelCalendar";
            this.tableLayoutPanelCalendar.RowCount = 8;
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelCalendar.Size = new System.Drawing.Size(861, 559);
            this.tableLayoutPanelCalendar.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 30);
            this.label10.TabIndex = 29;
            this.label10.Text = "Översikt bokningar ";
            // 
            // buttonSearchDate
            // 
            this.buttonSearchDate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonSearchDate.FlatAppearance.BorderSize = 0;
            this.buttonSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchDate.ForeColor = System.Drawing.Color.White;
            this.buttonSearchDate.Location = new System.Drawing.Point(317, 218);
            this.buttonSearchDate.Name = "buttonSearchDate";
            this.buttonSearchDate.Size = new System.Drawing.Size(48, 22);
            this.buttonSearchDate.TabIndex = 38;
            this.buttonSearchDate.Text = "Sök";
            this.buttonSearchDate.UseVisualStyleBackColor = false;
            this.buttonSearchDate.Click += new System.EventHandler(this.buttonSearchDate_Click);
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSearch.Location = new System.Drawing.Point(118, 218);
            this.dateTimePickerSearch.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSearch.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Välj datum";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 854);
            this.Controls.Add(this.buttonSearchDate);
            this.Controls.Add(this.dateTimePickerSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelCalendarDate7);
            this.Controls.Add(this.labelCalendarDate6);
            this.Controls.Add(this.labelCalendarDate5);
            this.Controls.Add(this.labelCalendarDate4);
            this.Controls.Add(this.labelCalendarDate3);
            this.Controls.Add(this.labelCalendarDate2);
            this.Controls.Add(this.labelCalendarDate1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanelCalendar);
            this.Controls.Add(this.panelBooking);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelBooking.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelManageCustomer;
        private System.Windows.Forms.Label labelManageBooking;
        private System.Windows.Forms.Label labelCurrentDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCustomerUpdate;
        private System.Windows.Forms.Button buttonCustomerCreate;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Button buttonBookingCreate;
        private System.Windows.Forms.Button buttonBookingUpdate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCalendarDate7;
        private System.Windows.Forms.Label labelCalendarDate6;
        private System.Windows.Forms.Label labelCalendarDate5;
        private System.Windows.Forms.Label labelCalendarDate4;
        private System.Windows.Forms.Label labelCalendarDate3;
        private System.Windows.Forms.Label labelCalendarDate2;
        private System.Windows.Forms.Label labelCalendarDate1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCalendar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTipTest;
    }
}