namespace HotelManagement.Forms
{
    partial class HomeFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlTabHome = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.txtRoomDes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.comboRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateNewRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numbericRoomCapacity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtRoomId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new HotelManagement.HotelManagementDataSet();
            this.tabRoomBooking = new System.Windows.Forms.TabPage();
            this.imgBookingFindCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvBookingSelectedRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colBookRoomIdInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookRoomTypeInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookRoomPriceInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookRoomRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgvBookingRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colBookRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookRoomTyope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookRoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookRoomAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbBookingRoomType = new System.Windows.Forms.GroupBox();
            this.radBookingTypeSuite = new System.Windows.Forms.RadioButton();
            this.radBookingTypeDeluxe = new System.Windows.Forms.RadioButton();
            this.radBookingTypeStandard = new System.Windows.Forms.RadioButton();
            this.gbBookingCapacity = new System.Windows.Forms.GroupBox();
            this.radBookingDoubleRoom = new System.Windows.Forms.RadioButton();
            this.radBookingSingleRoom = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBookingCustomerGenderInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtBookingStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtBookingEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBookingCustomerPhoneInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBookingCustomerIAddressnfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBookingCustomerIdInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBookingCustomerNameInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2ImageButton9 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tabRegisterCustomer = new System.Windows.Forms.TabPage();
            this.txtRegisCustomerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegisAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.gbRegisCustomerGender = new System.Windows.Forms.GroupBox();
            this.radioRegisGenderFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioRegisGenderMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtRegisCustomerDateJoined = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtRegisCustomerBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtRegisCustomerEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisCustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisCustomerNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisCustomerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCustomerDetail = new System.Windows.Forms.TabPage();
            this.btnInfoCustomerRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnInfoFindCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInfoContentFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboInfoCriteria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtgvInfoCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerDateJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustmerEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCheckout = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInvoiceFind = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtInvoiceContentFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboInvoiceCriteria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radInvoiceAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radInvoiceNotPaid = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radInvoicePaid = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtgvInvoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillCheckinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillPay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.tabEmpInfo = new System.Windows.Forms.TabPage();
            this.txtInfoEmpStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dtInfoEmpDateHired = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtInfoEmpPos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtInfoEmpPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInfoEmpUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnInfoUpdateEmpInfo = new Guna.UI2.WinForms.Guna2Button();
            this.txtInfoEmpGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInfoEmpPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInfoEmpAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInfoEmpId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInfoEmpName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton10 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton11 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton12 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.roomsTableAdapter = new HotelManagement.HotelManagementDataSetTableAdapters.RoomsTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.controlTabHome.SuspendLayout();
            this.tabRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericRoomCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            this.tabRoomBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookingSelectedRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookingRoom)).BeginInit();
            this.gbBookingRoomType.SuspendLayout();
            this.gbBookingCapacity.SuspendLayout();
            this.tabRegisterCustomer.SuspendLayout();
            this.gbRegisCustomerGender.SuspendLayout();
            this.tabCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoCustomer)).BeginInit();
            this.tabCheckout.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoice)).BeginInit();
            this.tabEmpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlTabHome
            // 
            this.controlTabHome.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.controlTabHome.Controls.Add(this.tabRoom);
            this.controlTabHome.Controls.Add(this.tabRoomBooking);
            this.controlTabHome.Controls.Add(this.tabRegisterCustomer);
            this.controlTabHome.Controls.Add(this.tabCustomerDetail);
            this.controlTabHome.Controls.Add(this.tabCheckout);
            this.controlTabHome.Controls.Add(this.tabStat);
            this.controlTabHome.Controls.Add(this.tabEmpInfo);
            this.controlTabHome.ItemSize = new System.Drawing.Size(180, 100);
            this.controlTabHome.Location = new System.Drawing.Point(-3, 25);
            this.controlTabHome.Name = "controlTabHome";
            this.controlTabHome.SelectedIndex = 0;
            this.controlTabHome.Size = new System.Drawing.Size(1410, 792);
            this.controlTabHome.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.controlTabHome.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.controlTabHome.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTabHome.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.controlTabHome.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.controlTabHome.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.controlTabHome.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.controlTabHome.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTabHome.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.controlTabHome.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.controlTabHome.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.controlTabHome.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.controlTabHome.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTabHome.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.controlTabHome.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.controlTabHome.TabButtonSize = new System.Drawing.Size(180, 100);
            this.controlTabHome.TabIndex = 2;
            this.controlTabHome.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.controlTabHome.SelectedIndexChanged += new System.EventHandler(this.controlTabHome_SelectedIndexChanged);
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.txtRoomDes);
            this.tabRoom.Controls.Add(this.label33);
            this.tabRoom.Controls.Add(this.comboRoomType);
            this.tabRoom.Controls.Add(this.btnDeleteRoom);
            this.tabRoom.Controls.Add(this.btnUpdateRoom);
            this.tabRoom.Controls.Add(this.btnAddNewRoom);
            this.tabRoom.Controls.Add(this.btnCreateNewRoom);
            this.tabRoom.Controls.Add(this.txtRoomPrice);
            this.tabRoom.Controls.Add(this.label6);
            this.tabRoom.Controls.Add(this.numbericRoomCapacity);
            this.tabRoom.Controls.Add(this.txtRoomId);
            this.tabRoom.Controls.Add(this.label5);
            this.tabRoom.Controls.Add(this.label4);
            this.tabRoom.Controls.Add(this.label3);
            this.tabRoom.Controls.Add(this.c);
            this.tabRoom.Controls.Add(this.label1);
            this.tabRoom.Controls.Add(this.dtgvRoom);
            this.tabRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabRoom.Location = new System.Drawing.Point(184, 4);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(1222, 784);
            this.tabRoom.TabIndex = 0;
            this.tabRoom.Text = "Quản Lý Phòng";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // txtRoomDes
            // 
            this.txtRoomDes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomDes.DefaultText = "";
            this.txtRoomDes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomDes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomDes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomDes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomDes.Enabled = false;
            this.txtRoomDes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomDes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomDes.ForeColor = System.Drawing.Color.Black;
            this.txtRoomDes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomDes.Location = new System.Drawing.Point(129, 596);
            this.txtRoomDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomDes.Name = "txtRoomDes";
            this.txtRoomDes.PasswordChar = '\0';
            this.txtRoomDes.PlaceholderText = "";
            this.txtRoomDes.SelectedText = "";
            this.txtRoomDes.Size = new System.Drawing.Size(751, 166);
            this.txtRoomDes.TabIndex = 20;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(19, 615);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 21);
            this.label33.TabIndex = 19;
            this.label33.Tag = "";
            this.label33.Text = "Mô tả:";
            // 
            // comboRoomType
            // 
            this.comboRoomType.BackColor = System.Drawing.Color.Transparent;
            this.comboRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomType.Enabled = false;
            this.comboRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRoomType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboRoomType.ForeColor = System.Drawing.Color.Black;
            this.comboRoomType.ItemHeight = 30;
            this.comboRoomType.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Suite"});
            this.comboRoomType.Location = new System.Drawing.Point(129, 525);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(373, 36);
            this.comboRoomType.TabIndex = 18;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BorderRadius = 10;
            this.btnDeleteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteRoom.Enabled = false;
            this.btnDeleteRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRoom.Location = new System.Drawing.Point(949, 677);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(232, 52);
            this.btnDeleteRoom.TabIndex = 17;
            this.btnDeleteRoom.Text = "Xóa Phòng";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BorderRadius = 10;
            this.btnUpdateRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRoom.Enabled = false;
            this.btnUpdateRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdateRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRoom.Location = new System.Drawing.Point(949, 596);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(232, 52);
            this.btnUpdateRoom.TabIndex = 16;
            this.btnUpdateRoom.Text = "Cập Nhật Phòng";
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.BorderRadius = 10;
            this.btnAddNewRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewRoom.Enabled = false;
            this.btnAddNewRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewRoom.Location = new System.Drawing.Point(949, 515);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Size = new System.Drawing.Size(232, 52);
            this.btnAddNewRoom.TabIndex = 15;
            this.btnAddNewRoom.Text = "Thêm Phòng";
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click);
            // 
            // btnCreateNewRoom
            // 
            this.btnCreateNewRoom.BorderRadius = 10;
            this.btnCreateNewRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateNewRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateNewRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateNewRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateNewRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateNewRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewRoom.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewRoom.Location = new System.Drawing.Point(949, 434);
            this.btnCreateNewRoom.Name = "btnCreateNewRoom";
            this.btnCreateNewRoom.Size = new System.Drawing.Size(232, 52);
            this.btnCreateNewRoom.TabIndex = 14;
            this.btnCreateNewRoom.Text = "Tạo Mới";
            this.btnCreateNewRoom.Click += new System.EventHandler(this.btnCreateNewRoom_Click);
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomPrice.DefaultText = "";
            this.txtRoomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomPrice.Enabled = false;
            this.txtRoomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomPrice.Location = new System.Drawing.Point(684, 523);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.PasswordChar = '\0';
            this.txtRoomPrice.PlaceholderText = "";
            this.txtRoomPrice.SelectedText = "";
            this.txtRoomPrice.Size = new System.Drawing.Size(188, 43);
            this.txtRoomPrice.TabIndex = 13;
            this.txtRoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "VNĐ";
            // 
            // numbericRoomCapacity
            // 
            this.numbericRoomCapacity.BackColor = System.Drawing.Color.Transparent;
            this.numbericRoomCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numbericRoomCapacity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.numbericRoomCapacity.Enabled = false;
            this.numbericRoomCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbericRoomCapacity.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numbericRoomCapacity.Location = new System.Drawing.Point(684, 434);
            this.numbericRoomCapacity.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numbericRoomCapacity.Name = "numbericRoomCapacity";
            this.numbericRoomCapacity.Size = new System.Drawing.Size(100, 43);
            this.numbericRoomCapacity.TabIndex = 10;
            this.numbericRoomCapacity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // txtRoomId
            // 
            this.txtRoomId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomId.DefaultText = "";
            this.txtRoomId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomId.Enabled = false;
            this.txtRoomId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomId.ForeColor = System.Drawing.Color.Black;
            this.txtRoomId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomId.Location = new System.Drawing.Point(129, 434);
            this.txtRoomId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.PasswordChar = '\0';
            this.txtRoomId.PlaceholderText = "";
            this.txtRoomId.SelectedText = "";
            this.txtRoomId.Size = new System.Drawing.Size(381, 43);
            this.txtRoomId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá Phòng/Đêm(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sức Chứa(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại Phòng(*):";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(490, 376);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(236, 37);
            this.c.TabIndex = 2;
            this.c.Text = "Thông Tin Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng(*):";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.AllowUserToAddRows = false;
            this.dtgvRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvRoom.AutoGenerateColumns = false;
            this.dtgvRoom.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRoom.ColumnHeadersHeight = 25;
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dtgvRoom.DataSource = this.roomsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvRoom.Location = new System.Drawing.Point(6, 6);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.ReadOnly = true;
            this.dtgvRoom.RowHeadersVisible = false;
            this.dtgvRoom.Size = new System.Drawing.Size(1205, 341);
            this.dtgvRoom.TabIndex = 0;
            this.dtgvRoom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dtgvRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvRoom.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dtgvRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvRoom.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgvRoom.ThemeStyle.ReadOnly = true;
            this.dtgvRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dtgvRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvRoom.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dtgvRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvRoom.SelectionChanged += new System.EventHandler(this.dtgvRoom_SelectionChanged);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Mã Phòng";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Loại Phòng";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Sức Chứa";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá Phòng/Đêm";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Mô Tả";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabRoomBooking
            // 
            this.tabRoomBooking.Controls.Add(this.imgBookingFindCustomer);
            this.tabRoomBooking.Controls.Add(this.btnBooking);
            this.tabRoomBooking.Controls.Add(this.dtgvBookingSelectedRoom);
            this.tabRoomBooking.Controls.Add(this.dtgvBookingRoom);
            this.tabRoomBooking.Controls.Add(this.gbBookingRoomType);
            this.tabRoomBooking.Controls.Add(this.gbBookingCapacity);
            this.tabRoomBooking.Controls.Add(this.label24);
            this.tabRoomBooking.Controls.Add(this.label23);
            this.tabRoomBooking.Controls.Add(this.txtBookingCustomerGenderInfo);
            this.tabRoomBooking.Controls.Add(this.label20);
            this.tabRoomBooking.Controls.Add(this.label21);
            this.tabRoomBooking.Controls.Add(this.dtBookingStart);
            this.tabRoomBooking.Controls.Add(this.dtBookingEnd);
            this.tabRoomBooking.Controls.Add(this.txtBookingCustomerPhoneInfo);
            this.tabRoomBooking.Controls.Add(this.txtBookingCustomerIAddressnfo);
            this.tabRoomBooking.Controls.Add(this.txtBookingCustomerIdInfo);
            this.tabRoomBooking.Controls.Add(this.txtBookingCustomerNameInfo);
            this.tabRoomBooking.Controls.Add(this.label19);
            this.tabRoomBooking.Controls.Add(this.label18);
            this.tabRoomBooking.Controls.Add(this.guna2ImageButton9);
            this.tabRoomBooking.Controls.Add(this.guna2ImageButton8);
            this.tabRoomBooking.Controls.Add(this.guna2ImageButton7);
            this.tabRoomBooking.Controls.Add(this.guna2ImageButton6);
            this.tabRoomBooking.Controls.Add(this.guna2ImageButton2);
            this.tabRoomBooking.Location = new System.Drawing.Point(184, 4);
            this.tabRoomBooking.Name = "tabRoomBooking";
            this.tabRoomBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoomBooking.Size = new System.Drawing.Size(1222, 784);
            this.tabRoomBooking.TabIndex = 5;
            this.tabRoomBooking.Text = "Đặt Phòng";
            this.tabRoomBooking.UseVisualStyleBackColor = true;
            // 
            // imgBookingFindCustomer
            // 
            this.imgBookingFindCustomer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgBookingFindCustomer.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.imgBookingFindCustomer.Image = global::HotelManagement.Properties.Resources.find;
            this.imgBookingFindCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgBookingFindCustomer.ImageRotate = 0F;
            this.imgBookingFindCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.imgBookingFindCustomer.Location = new System.Drawing.Point(421, 111);
            this.imgBookingFindCustomer.Name = "imgBookingFindCustomer";
            this.imgBookingFindCustomer.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.imgBookingFindCustomer.Size = new System.Drawing.Size(63, 61);
            this.imgBookingFindCustomer.TabIndex = 36;
            this.imgBookingFindCustomer.Click += new System.EventHandler(this.imgBookingFindCustomer_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BorderRadius = 10;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.Location = new System.Drawing.Point(769, 711);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(232, 52);
            this.btnBooking.TabIndex = 34;
            this.btnBooking.Text = "Đặt phòng";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // dtgvBookingSelectedRoom
            // 
            this.dtgvBookingSelectedRoom.AllowUserToAddRows = false;
            this.dtgvBookingSelectedRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvBookingSelectedRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBookingSelectedRoom.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookingSelectedRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBookingSelectedRoom.ColumnHeadersHeight = 44;
            this.dtgvBookingSelectedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBookingSelectedRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookRoomIdInfo,
            this.colBookRoomTypeInfo,
            this.colBookRoomPriceInfo,
            this.colBookRoomRemove});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBookingSelectedRoom.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBookingSelectedRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvBookingSelectedRoom.Location = new System.Drawing.Point(853, 368);
            this.dtgvBookingSelectedRoom.Name = "dtgvBookingSelectedRoom";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookingSelectedRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvBookingSelectedRoom.RowHeadersVisible = false;
            this.dtgvBookingSelectedRoom.Size = new System.Drawing.Size(358, 328);
            this.dtgvBookingSelectedRoom.TabIndex = 33;
            this.dtgvBookingSelectedRoom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dtgvBookingSelectedRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvBookingSelectedRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBookingSelectedRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBookingSelectedRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBookingSelectedRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBookingSelectedRoom.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvBookingSelectedRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvBookingSelectedRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dtgvBookingSelectedRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBookingSelectedRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookingSelectedRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBookingSelectedRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBookingSelectedRoom.ThemeStyle.HeaderStyle.Height = 44;
            this.dtgvBookingSelectedRoom.ThemeStyle.ReadOnly = false;
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dtgvBookingSelectedRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBookingSelectedRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBookingSelectedRoom_CellContentClick);
            // 
            // colBookRoomIdInfo
            // 
            this.colBookRoomIdInfo.HeaderText = "Mã phòng";
            this.colBookRoomIdInfo.Name = "colBookRoomIdInfo";
            this.colBookRoomIdInfo.ReadOnly = true;
            this.colBookRoomIdInfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colBookRoomTypeInfo
            // 
            this.colBookRoomTypeInfo.HeaderText = "Loại phòng";
            this.colBookRoomTypeInfo.Name = "colBookRoomTypeInfo";
            this.colBookRoomTypeInfo.ReadOnly = true;
            // 
            // colBookRoomPriceInfo
            // 
            this.colBookRoomPriceInfo.HeaderText = "Giá phòng";
            this.colBookRoomPriceInfo.Name = "colBookRoomPriceInfo";
            this.colBookRoomPriceInfo.ReadOnly = true;
            // 
            // colBookRoomRemove
            // 
            this.colBookRoomRemove.HeaderText = "Bỏ";
            this.colBookRoomRemove.Name = "colBookRoomRemove";
            this.colBookRoomRemove.ReadOnly = true;
            this.colBookRoomRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtgvBookingRoom
            // 
            this.dtgvBookingRoom.AllowUserToAddRows = false;
            this.dtgvBookingRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvBookingRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvBookingRoom.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookingRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvBookingRoom.ColumnHeadersHeight = 44;
            this.dtgvBookingRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBookingRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookRoomId,
            this.colBookRoomTyope,
            this.colBookRoomPrice,
            this.colBookRoomAdd});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBookingRoom.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvBookingRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvBookingRoom.Location = new System.Drawing.Point(479, 368);
            this.dtgvBookingRoom.Name = "dtgvBookingRoom";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookingRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvBookingRoom.RowHeadersVisible = false;
            this.dtgvBookingRoom.Size = new System.Drawing.Size(358, 328);
            this.dtgvBookingRoom.TabIndex = 32;
            this.dtgvBookingRoom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dtgvBookingRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvBookingRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBookingRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBookingRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBookingRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBookingRoom.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvBookingRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvBookingRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dtgvBookingRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBookingRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookingRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBookingRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBookingRoom.ThemeStyle.HeaderStyle.Height = 44;
            this.dtgvBookingRoom.ThemeStyle.ReadOnly = false;
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dtgvBookingRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvBookingRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBookingRoom_CellContentClick);
            // 
            // colBookRoomId
            // 
            this.colBookRoomId.HeaderText = "Mã phòng";
            this.colBookRoomId.Name = "colBookRoomId";
            this.colBookRoomId.ReadOnly = true;
            // 
            // colBookRoomTyope
            // 
            this.colBookRoomTyope.HeaderText = "Loại phòng";
            this.colBookRoomTyope.Name = "colBookRoomTyope";
            this.colBookRoomTyope.ReadOnly = true;
            // 
            // colBookRoomPrice
            // 
            this.colBookRoomPrice.HeaderText = "Giá phòng";
            this.colBookRoomPrice.Name = "colBookRoomPrice";
            this.colBookRoomPrice.ReadOnly = true;
            // 
            // colBookRoomAdd
            // 
            this.colBookRoomAdd.HeaderText = "Thêm";
            this.colBookRoomAdd.Name = "colBookRoomAdd";
            this.colBookRoomAdd.ReadOnly = true;
            this.colBookRoomAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gbBookingRoomType
            // 
            this.gbBookingRoomType.Controls.Add(this.radBookingTypeSuite);
            this.gbBookingRoomType.Controls.Add(this.radBookingTypeDeluxe);
            this.gbBookingRoomType.Controls.Add(this.radBookingTypeStandard);
            this.gbBookingRoomType.Location = new System.Drawing.Point(853, 181);
            this.gbBookingRoomType.Name = "gbBookingRoomType";
            this.gbBookingRoomType.Size = new System.Drawing.Size(345, 109);
            this.gbBookingRoomType.TabIndex = 31;
            this.gbBookingRoomType.TabStop = false;
            this.gbBookingRoomType.Text = "Loại phòng";
            // 
            // radBookingTypeSuite
            // 
            this.radBookingTypeSuite.AutoSize = true;
            this.radBookingTypeSuite.Location = new System.Drawing.Point(267, 46);
            this.radBookingTypeSuite.Name = "radBookingTypeSuite";
            this.radBookingTypeSuite.Size = new System.Drawing.Size(63, 25);
            this.radBookingTypeSuite.TabIndex = 4;
            this.radBookingTypeSuite.TabStop = true;
            this.radBookingTypeSuite.Text = "Suite";
            this.radBookingTypeSuite.UseVisualStyleBackColor = true;
            this.radBookingTypeSuite.CheckedChanged += new System.EventHandler(this.radTypeRoom_CheckedChanged);
            // 
            // radBookingTypeDeluxe
            // 
            this.radBookingTypeDeluxe.AutoSize = true;
            this.radBookingTypeDeluxe.Location = new System.Drawing.Point(148, 46);
            this.radBookingTypeDeluxe.Name = "radBookingTypeDeluxe";
            this.radBookingTypeDeluxe.Size = new System.Drawing.Size(75, 25);
            this.radBookingTypeDeluxe.TabIndex = 3;
            this.radBookingTypeDeluxe.TabStop = true;
            this.radBookingTypeDeluxe.Text = "Deluxe";
            this.radBookingTypeDeluxe.UseVisualStyleBackColor = true;
            this.radBookingTypeDeluxe.CheckedChanged += new System.EventHandler(this.radTypeRoom_CheckedChanged);
            // 
            // radBookingTypeStandard
            // 
            this.radBookingTypeStandard.AutoSize = true;
            this.radBookingTypeStandard.Location = new System.Drawing.Point(14, 46);
            this.radBookingTypeStandard.Name = "radBookingTypeStandard";
            this.radBookingTypeStandard.Size = new System.Drawing.Size(90, 25);
            this.radBookingTypeStandard.TabIndex = 2;
            this.radBookingTypeStandard.TabStop = true;
            this.radBookingTypeStandard.Text = "Standard";
            this.radBookingTypeStandard.UseVisualStyleBackColor = true;
            this.radBookingTypeStandard.CheckedChanged += new System.EventHandler(this.radTypeRoom_CheckedChanged);
            // 
            // gbBookingCapacity
            // 
            this.gbBookingCapacity.Controls.Add(this.radBookingDoubleRoom);
            this.gbBookingCapacity.Controls.Add(this.radBookingSingleRoom);
            this.gbBookingCapacity.Location = new System.Drawing.Point(527, 181);
            this.gbBookingCapacity.Name = "gbBookingCapacity";
            this.gbBookingCapacity.Size = new System.Drawing.Size(276, 109);
            this.gbBookingCapacity.TabIndex = 30;
            this.gbBookingCapacity.TabStop = false;
            this.gbBookingCapacity.Text = "Sức chứa";
            // 
            // radBookingDoubleRoom
            // 
            this.radBookingDoubleRoom.AutoSize = true;
            this.radBookingDoubleRoom.Location = new System.Drawing.Point(151, 46);
            this.radBookingDoubleRoom.Name = "radBookingDoubleRoom";
            this.radBookingDoubleRoom.Size = new System.Drawing.Size(99, 25);
            this.radBookingDoubleRoom.TabIndex = 1;
            this.radBookingDoubleRoom.TabStop = true;
            this.radBookingDoubleRoom.Text = "Phòng đôi";
            this.radBookingDoubleRoom.UseVisualStyleBackColor = true;
            this.radBookingDoubleRoom.CheckedChanged += new System.EventHandler(this.radCapacity_CheckedChanged);
            // 
            // radBookingSingleRoom
            // 
            this.radBookingSingleRoom.AutoSize = true;
            this.radBookingSingleRoom.Location = new System.Drawing.Point(26, 46);
            this.radBookingSingleRoom.Name = "radBookingSingleRoom";
            this.radBookingSingleRoom.Size = new System.Drawing.Size(105, 25);
            this.radBookingSingleRoom.TabIndex = 0;
            this.radBookingSingleRoom.TabStop = true;
            this.radBookingSingleRoom.Text = "Phòng đơn";
            this.radBookingSingleRoom.UseVisualStyleBackColor = true;
            this.radBookingSingleRoom.CheckedChanged += new System.EventHandler(this.radCapacity_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(884, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 21);
            this.label24.TabIndex = 29;
            this.label24.Text = "Trả phòng:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(521, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 21);
            this.label23.TabIndex = 28;
            this.label23.Text = "Nhận phòng:";
            // 
            // txtBookingCustomerGenderInfo
            // 
            this.txtBookingCustomerGenderInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingCustomerGenderInfo.DefaultText = "";
            this.txtBookingCustomerGenderInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingCustomerGenderInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingCustomerGenderInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerGenderInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerGenderInfo.Enabled = false;
            this.txtBookingCustomerGenderInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerGenderInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingCustomerGenderInfo.ForeColor = System.Drawing.Color.Black;
            this.txtBookingCustomerGenderInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerGenderInfo.Location = new System.Drawing.Point(157, 500);
            this.txtBookingCustomerGenderInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingCustomerGenderInfo.Name = "txtBookingCustomerGenderInfo";
            this.txtBookingCustomerGenderInfo.PasswordChar = '\0';
            this.txtBookingCustomerGenderInfo.PlaceholderText = "Giới tính";
            this.txtBookingCustomerGenderInfo.SelectedText = "";
            this.txtBookingCustomerGenderInfo.Size = new System.Drawing.Size(257, 45);
            this.txtBookingCustomerGenderInfo.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(557, 319);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(218, 30);
            this.label20.TabIndex = 18;
            this.label20.Text = "Thông tin các phòng";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(908, 319);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(236, 30);
            this.label21.TabIndex = 15;
            this.label21.Text = "Thông tin phòng chọn";
            // 
            // dtBookingStart
            // 
            this.dtBookingStart.Checked = true;
            this.dtBookingStart.CustomFormat = "dd/MM/yyyy";
            this.dtBookingStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtBookingStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBookingStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBookingStart.Location = new System.Drawing.Point(637, 111);
            this.dtBookingStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBookingStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBookingStart.Name = "dtBookingStart";
            this.dtBookingStart.Size = new System.Drawing.Size(200, 36);
            this.dtBookingStart.TabIndex = 13;
            this.dtBookingStart.Value = new System.DateTime(2024, 7, 12, 13, 31, 30, 220);
            // 
            // dtBookingEnd
            // 
            this.dtBookingEnd.Checked = true;
            this.dtBookingEnd.CustomFormat = "dd/MM/yyyy";
            this.dtBookingEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtBookingEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBookingEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBookingEnd.Location = new System.Drawing.Point(981, 111);
            this.dtBookingEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtBookingEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtBookingEnd.Name = "dtBookingEnd";
            this.dtBookingEnd.Size = new System.Drawing.Size(200, 36);
            this.dtBookingEnd.TabIndex = 12;
            this.dtBookingEnd.Value = new System.DateTime(2024, 7, 12, 13, 31, 30, 220);
            // 
            // txtBookingCustomerPhoneInfo
            // 
            this.txtBookingCustomerPhoneInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingCustomerPhoneInfo.DefaultText = "";
            this.txtBookingCustomerPhoneInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingCustomerPhoneInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingCustomerPhoneInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerPhoneInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerPhoneInfo.Enabled = false;
            this.txtBookingCustomerPhoneInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerPhoneInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingCustomerPhoneInfo.ForeColor = System.Drawing.Color.Black;
            this.txtBookingCustomerPhoneInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerPhoneInfo.Location = new System.Drawing.Point(157, 408);
            this.txtBookingCustomerPhoneInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingCustomerPhoneInfo.Name = "txtBookingCustomerPhoneInfo";
            this.txtBookingCustomerPhoneInfo.PasswordChar = '\0';
            this.txtBookingCustomerPhoneInfo.PlaceholderText = "SĐT";
            this.txtBookingCustomerPhoneInfo.SelectedText = "";
            this.txtBookingCustomerPhoneInfo.Size = new System.Drawing.Size(257, 45);
            this.txtBookingCustomerPhoneInfo.TabIndex = 11;
            // 
            // txtBookingCustomerIAddressnfo
            // 
            this.txtBookingCustomerIAddressnfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingCustomerIAddressnfo.DefaultText = "";
            this.txtBookingCustomerIAddressnfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingCustomerIAddressnfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingCustomerIAddressnfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerIAddressnfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerIAddressnfo.Enabled = false;
            this.txtBookingCustomerIAddressnfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerIAddressnfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingCustomerIAddressnfo.ForeColor = System.Drawing.Color.Black;
            this.txtBookingCustomerIAddressnfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerIAddressnfo.Location = new System.Drawing.Point(157, 316);
            this.txtBookingCustomerIAddressnfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingCustomerIAddressnfo.Name = "txtBookingCustomerIAddressnfo";
            this.txtBookingCustomerIAddressnfo.PasswordChar = '\0';
            this.txtBookingCustomerIAddressnfo.PlaceholderText = "Địa chỉ";
            this.txtBookingCustomerIAddressnfo.SelectedText = "";
            this.txtBookingCustomerIAddressnfo.Size = new System.Drawing.Size(257, 45);
            this.txtBookingCustomerIAddressnfo.TabIndex = 9;
            // 
            // txtBookingCustomerIdInfo
            // 
            this.txtBookingCustomerIdInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingCustomerIdInfo.DefaultText = "";
            this.txtBookingCustomerIdInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingCustomerIdInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingCustomerIdInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerIdInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerIdInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerIdInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingCustomerIdInfo.ForeColor = System.Drawing.Color.Black;
            this.txtBookingCustomerIdInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerIdInfo.Location = new System.Drawing.Point(157, 122);
            this.txtBookingCustomerIdInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingCustomerIdInfo.Name = "txtBookingCustomerIdInfo";
            this.txtBookingCustomerIdInfo.PasswordChar = '\0';
            this.txtBookingCustomerIdInfo.PlaceholderText = "CCCD/CMND/Hộ chiếu";
            this.txtBookingCustomerIdInfo.SelectedText = "";
            this.txtBookingCustomerIdInfo.Size = new System.Drawing.Size(257, 45);
            this.txtBookingCustomerIdInfo.TabIndex = 8;
            // 
            // txtBookingCustomerNameInfo
            // 
            this.txtBookingCustomerNameInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingCustomerNameInfo.DefaultText = "";
            this.txtBookingCustomerNameInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingCustomerNameInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingCustomerNameInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerNameInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingCustomerNameInfo.Enabled = false;
            this.txtBookingCustomerNameInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerNameInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingCustomerNameInfo.ForeColor = System.Drawing.Color.Black;
            this.txtBookingCustomerNameInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingCustomerNameInfo.Location = new System.Drawing.Point(157, 217);
            this.txtBookingCustomerNameInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingCustomerNameInfo.Name = "txtBookingCustomerNameInfo";
            this.txtBookingCustomerNameInfo.PasswordChar = '\0';
            this.txtBookingCustomerNameInfo.PlaceholderText = "Họ tên";
            this.txtBookingCustomerNameInfo.SelectedText = "";
            this.txtBookingCustomerNameInfo.Size = new System.Drawing.Size(257, 45);
            this.txtBookingCustomerNameInfo.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(762, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(236, 37);
            this.label19.TabIndex = 5;
            this.label19.Text = "Thông Tin Phòng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(307, 37);
            this.label18.TabIndex = 4;
            this.label18.Text = "Thông Tin Khách Hàng";
            // 
            // guna2ImageButton9
            // 
            this.guna2ImageButton9.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton9.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton9.Image = global::HotelManagement.Properties.Resources.gender;
            this.guna2ImageButton9.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton9.ImageRotate = 0F;
            this.guna2ImageButton9.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton9.Location = new System.Drawing.Point(59, 500);
            this.guna2ImageButton9.Name = "guna2ImageButton9";
            this.guna2ImageButton9.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton9.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton9.TabIndex = 27;
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.Image = global::HotelManagement.Properties.Resources.phone_call;
            this.guna2ImageButton8.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton8.ImageRotate = 0F;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton8.Location = new System.Drawing.Point(59, 408);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton8.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton8.TabIndex = 25;
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.Image = global::HotelManagement.Properties.Resources.address;
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton7.Location = new System.Drawing.Point(59, 316);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton7.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton7.TabIndex = 24;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Image = global::HotelManagement.Properties.Resources.id_card;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton6.Location = new System.Drawing.Point(59, 122);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton6.TabIndex = 23;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = global::HotelManagement.Properties.Resources.user;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton2.Location = new System.Drawing.Point(59, 213);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton2.TabIndex = 6;
            // 
            // tabRegisterCustomer
            // 
            this.tabRegisterCustomer.Controls.Add(this.txtRegisCustomerAddress);
            this.tabRegisterCustomer.Controls.Add(this.label10);
            this.tabRegisterCustomer.Controls.Add(this.btnRegisAddNewCustomer);
            this.tabRegisterCustomer.Controls.Add(this.gbRegisCustomerGender);
            this.tabRegisterCustomer.Controls.Add(this.dtRegisCustomerDateJoined);
            this.tabRegisterCustomer.Controls.Add(this.dtRegisCustomerBirthDate);
            this.tabRegisterCustomer.Controls.Add(this.txtRegisCustomerEmail);
            this.tabRegisterCustomer.Controls.Add(this.txtRegisCustomerPhone);
            this.tabRegisterCustomer.Controls.Add(this.txtRegisCustomerNote);
            this.tabRegisterCustomer.Controls.Add(this.txtRegisCustomerName);
            this.tabRegisterCustomer.Controls.Add(this.txtRegisCustomerId);
            this.tabRegisterCustomer.Controls.Add(this.label14);
            this.tabRegisterCustomer.Controls.Add(this.label13);
            this.tabRegisterCustomer.Controls.Add(this.label12);
            this.tabRegisterCustomer.Controls.Add(this.label11);
            this.tabRegisterCustomer.Controls.Add(this.label9);
            this.tabRegisterCustomer.Controls.Add(this.label8);
            this.tabRegisterCustomer.Controls.Add(this.label7);
            this.tabRegisterCustomer.Controls.Add(this.label2);
            this.tabRegisterCustomer.ForeColor = System.Drawing.Color.Black;
            this.tabRegisterCustomer.Location = new System.Drawing.Point(184, 4);
            this.tabRegisterCustomer.Name = "tabRegisterCustomer";
            this.tabRegisterCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegisterCustomer.Size = new System.Drawing.Size(1222, 784);
            this.tabRegisterCustomer.TabIndex = 1;
            this.tabRegisterCustomer.Text = "Đăng Ký Khách Hàng";
            this.tabRegisterCustomer.UseVisualStyleBackColor = true;
            // 
            // txtRegisCustomerAddress
            // 
            this.txtRegisCustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisCustomerAddress.DefaultText = "";
            this.txtRegisCustomerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisCustomerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisCustomerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisCustomerAddress.ForeColor = System.Drawing.Color.Black;
            this.txtRegisCustomerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerAddress.Location = new System.Drawing.Point(785, 89);
            this.txtRegisCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisCustomerAddress.Name = "txtRegisCustomerAddress";
            this.txtRegisCustomerAddress.PasswordChar = '\0';
            this.txtRegisCustomerAddress.PlaceholderText = "";
            this.txtRegisCustomerAddress.SelectedText = "";
            this.txtRegisCustomerAddress.Size = new System.Drawing.Size(387, 41);
            this.txtRegisCustomerAddress.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(652, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Địa chỉ:";
            // 
            // btnRegisAddNewCustomer
            // 
            this.btnRegisAddNewCustomer.BorderRadius = 10;
            this.btnRegisAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegisAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegisAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegisAddNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRegisAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisAddNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnRegisAddNewCustomer.Location = new System.Drawing.Point(495, 706);
            this.btnRegisAddNewCustomer.Name = "btnRegisAddNewCustomer";
            this.btnRegisAddNewCustomer.Size = new System.Drawing.Size(232, 52);
            this.btnRegisAddNewCustomer.TabIndex = 21;
            this.btnRegisAddNewCustomer.Text = "Thêm Khách Hàng";
            this.btnRegisAddNewCustomer.Click += new System.EventHandler(this.btnRegisAddNewCustomer_Click);
            // 
            // gbRegisCustomerGender
            // 
            this.gbRegisCustomerGender.Controls.Add(this.radioRegisGenderFemale);
            this.gbRegisCustomerGender.Controls.Add(this.radioRegisGenderMale);
            this.gbRegisCustomerGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegisCustomerGender.Location = new System.Drawing.Point(656, 327);
            this.gbRegisCustomerGender.Name = "gbRegisCustomerGender";
            this.gbRegisCustomerGender.Size = new System.Drawing.Size(516, 102);
            this.gbRegisCustomerGender.TabIndex = 19;
            this.gbRegisCustomerGender.TabStop = false;
            this.gbRegisCustomerGender.Text = "Giới Tính:";
            // 
            // radioRegisGenderFemale
            // 
            this.radioRegisGenderFemale.AutoSize = true;
            this.radioRegisGenderFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioRegisGenderFemale.CheckedState.BorderThickness = 0;
            this.radioRegisGenderFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioRegisGenderFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioRegisGenderFemale.CheckedState.InnerOffset = -4;
            this.radioRegisGenderFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegisGenderFemale.Location = new System.Drawing.Point(357, 41);
            this.radioRegisGenderFemale.Name = "radioRegisGenderFemale";
            this.radioRegisGenderFemale.Size = new System.Drawing.Size(49, 25);
            this.radioRegisGenderFemale.TabIndex = 1;
            this.radioRegisGenderFemale.Text = "Nữ";
            this.radioRegisGenderFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioRegisGenderFemale.UncheckedState.BorderThickness = 2;
            this.radioRegisGenderFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioRegisGenderFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioRegisGenderMale
            // 
            this.radioRegisGenderMale.AutoSize = true;
            this.radioRegisGenderMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioRegisGenderMale.CheckedState.BorderThickness = 0;
            this.radioRegisGenderMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioRegisGenderMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioRegisGenderMale.CheckedState.InnerOffset = -4;
            this.radioRegisGenderMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegisGenderMale.Location = new System.Drawing.Point(111, 41);
            this.radioRegisGenderMale.Name = "radioRegisGenderMale";
            this.radioRegisGenderMale.Size = new System.Drawing.Size(62, 25);
            this.radioRegisGenderMale.TabIndex = 0;
            this.radioRegisGenderMale.Text = "Nam";
            this.radioRegisGenderMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioRegisGenderMale.UncheckedState.BorderThickness = 2;
            this.radioRegisGenderMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioRegisGenderMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtRegisCustomerDateJoined
            // 
            this.dtRegisCustomerDateJoined.Checked = true;
            this.dtRegisCustomerDateJoined.CustomFormat = "dd/MM/yyyy";
            this.dtRegisCustomerDateJoined.Enabled = false;
            this.dtRegisCustomerDateJoined.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtRegisCustomerDateJoined.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRegisCustomerDateJoined.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRegisCustomerDateJoined.Location = new System.Drawing.Point(241, 356);
            this.dtRegisCustomerDateJoined.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtRegisCustomerDateJoined.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtRegisCustomerDateJoined.Name = "dtRegisCustomerDateJoined";
            this.dtRegisCustomerDateJoined.Size = new System.Drawing.Size(372, 36);
            this.dtRegisCustomerDateJoined.TabIndex = 18;
            this.dtRegisCustomerDateJoined.Value = new System.DateTime(2024, 7, 12, 9, 58, 42, 443);
            // 
            // dtRegisCustomerBirthDate
            // 
            this.dtRegisCustomerBirthDate.Checked = true;
            this.dtRegisCustomerBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtRegisCustomerBirthDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtRegisCustomerBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRegisCustomerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRegisCustomerBirthDate.Location = new System.Drawing.Point(241, 262);
            this.dtRegisCustomerBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtRegisCustomerBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtRegisCustomerBirthDate.Name = "dtRegisCustomerBirthDate";
            this.dtRegisCustomerBirthDate.Size = new System.Drawing.Size(372, 36);
            this.dtRegisCustomerBirthDate.TabIndex = 17;
            this.dtRegisCustomerBirthDate.Value = new System.DateTime(2024, 7, 12, 9, 59, 44, 548);
            // 
            // txtRegisCustomerEmail
            // 
            this.txtRegisCustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisCustomerEmail.DefaultText = "";
            this.txtRegisCustomerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisCustomerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisCustomerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisCustomerEmail.ForeColor = System.Drawing.Color.Black;
            this.txtRegisCustomerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerEmail.Location = new System.Drawing.Point(785, 245);
            this.txtRegisCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisCustomerEmail.Name = "txtRegisCustomerEmail";
            this.txtRegisCustomerEmail.PasswordChar = '\0';
            this.txtRegisCustomerEmail.PlaceholderText = "";
            this.txtRegisCustomerEmail.SelectedText = "";
            this.txtRegisCustomerEmail.Size = new System.Drawing.Size(387, 41);
            this.txtRegisCustomerEmail.TabIndex = 16;
            // 
            // txtRegisCustomerPhone
            // 
            this.txtRegisCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisCustomerPhone.DefaultText = "";
            this.txtRegisCustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisCustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisCustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisCustomerPhone.ForeColor = System.Drawing.Color.Black;
            this.txtRegisCustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerPhone.Location = new System.Drawing.Point(785, 167);
            this.txtRegisCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisCustomerPhone.Name = "txtRegisCustomerPhone";
            this.txtRegisCustomerPhone.PasswordChar = '\0';
            this.txtRegisCustomerPhone.PlaceholderText = "";
            this.txtRegisCustomerPhone.SelectedText = "";
            this.txtRegisCustomerPhone.Size = new System.Drawing.Size(387, 41);
            this.txtRegisCustomerPhone.TabIndex = 15;
            // 
            // txtRegisCustomerNote
            // 
            this.txtRegisCustomerNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisCustomerNote.DefaultText = "";
            this.txtRegisCustomerNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisCustomerNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisCustomerNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisCustomerNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerNote.Location = new System.Drawing.Point(241, 446);
            this.txtRegisCustomerNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisCustomerNote.Name = "txtRegisCustomerNote";
            this.txtRegisCustomerNote.PasswordChar = '\0';
            this.txtRegisCustomerNote.PlaceholderText = "";
            this.txtRegisCustomerNote.SelectedText = "";
            this.txtRegisCustomerNote.Size = new System.Drawing.Size(925, 238);
            this.txtRegisCustomerNote.TabIndex = 14;
            // 
            // txtRegisCustomerName
            // 
            this.txtRegisCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisCustomerName.DefaultText = "";
            this.txtRegisCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtRegisCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerName.Location = new System.Drawing.Point(241, 171);
            this.txtRegisCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisCustomerName.Name = "txtRegisCustomerName";
            this.txtRegisCustomerName.PasswordChar = '\0';
            this.txtRegisCustomerName.PlaceholderText = "";
            this.txtRegisCustomerName.SelectedText = "";
            this.txtRegisCustomerName.Size = new System.Drawing.Size(372, 41);
            this.txtRegisCustomerName.TabIndex = 13;
            // 
            // txtRegisCustomerId
            // 
            this.txtRegisCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisCustomerId.DefaultText = "";
            this.txtRegisCustomerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisCustomerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisCustomerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisCustomerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisCustomerId.ForeColor = System.Drawing.Color.Black;
            this.txtRegisCustomerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegisCustomerId.Location = new System.Drawing.Point(241, 89);
            this.txtRegisCustomerId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisCustomerId.Name = "txtRegisCustomerId";
            this.txtRegisCustomerId.PasswordChar = '\0';
            this.txtRegisCustomerId.PlaceholderText = "";
            this.txtRegisCustomerId.SelectedText = "";
            this.txtRegisCustomerId.Size = new System.Drawing.Size(372, 41);
            this.txtRegisCustomerId.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ghi Chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(46, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Ngày Tham Gia:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(652, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(652, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Số Điện Thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Họ Tên Khách Hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "CCCD/CMND/Hộ chiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng Ký Khách Hàng";
            // 
            // tabCustomerDetail
            // 
            this.tabCustomerDetail.Controls.Add(this.btnInfoCustomerRefresh);
            this.tabCustomerDetail.Controls.Add(this.btnInfoFindCustomer);
            this.tabCustomerDetail.Controls.Add(this.label17);
            this.tabCustomerDetail.Controls.Add(this.txtInfoContentFind);
            this.tabCustomerDetail.Controls.Add(this.comboInfoCriteria);
            this.tabCustomerDetail.Controls.Add(this.label16);
            this.tabCustomerDetail.Controls.Add(this.label15);
            this.tabCustomerDetail.Controls.Add(this.dtgvInfoCustomer);
            this.tabCustomerDetail.ForeColor = System.Drawing.Color.Black;
            this.tabCustomerDetail.Location = new System.Drawing.Point(184, 4);
            this.tabCustomerDetail.Name = "tabCustomerDetail";
            this.tabCustomerDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerDetail.Size = new System.Drawing.Size(1222, 784);
            this.tabCustomerDetail.TabIndex = 2;
            this.tabCustomerDetail.Text = "Thông Tin Khách Hàng";
            this.tabCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // btnInfoCustomerRefresh
            // 
            this.btnInfoCustomerRefresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInfoCustomerRefresh.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnInfoCustomerRefresh.Image = global::HotelManagement.Properties.Resources.loading_arrow;
            this.btnInfoCustomerRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInfoCustomerRefresh.ImageRotate = 0F;
            this.btnInfoCustomerRefresh.ImageSize = new System.Drawing.Size(32, 32);
            this.btnInfoCustomerRefresh.Location = new System.Drawing.Point(1164, 76);
            this.btnInfoCustomerRefresh.Name = "btnInfoCustomerRefresh";
            this.btnInfoCustomerRefresh.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnInfoCustomerRefresh.Size = new System.Drawing.Size(52, 50);
            this.btnInfoCustomerRefresh.TabIndex = 10;
            this.btnInfoCustomerRefresh.Click += new System.EventHandler(this.btnInfoCustomerRefresh_Click);
            // 
            // btnInfoFindCustomer
            // 
            this.btnInfoFindCustomer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInfoFindCustomer.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnInfoFindCustomer.Image = global::HotelManagement.Properties.Resources.find;
            this.btnInfoFindCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInfoFindCustomer.ImageRotate = 0F;
            this.btnInfoFindCustomer.ImageSize = new System.Drawing.Size(32, 32);
            this.btnInfoFindCustomer.Location = new System.Drawing.Point(1109, 76);
            this.btnInfoFindCustomer.Name = "btnInfoFindCustomer";
            this.btnInfoFindCustomer.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnInfoFindCustomer.Size = new System.Drawing.Size(52, 50);
            this.btnInfoFindCustomer.TabIndex = 9;
            this.btnInfoFindCustomer.Click += new System.EventHandler(this.btnInfoFindCustomer_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(587, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 21);
            this.label17.TabIndex = 8;
            this.label17.Text = "Thông tin tìm kiếm:";
            // 
            // txtInfoContentFind
            // 
            this.txtInfoContentFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoContentFind.DefaultText = "";
            this.txtInfoContentFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoContentFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoContentFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoContentFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoContentFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoContentFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoContentFind.ForeColor = System.Drawing.Color.Black;
            this.txtInfoContentFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoContentFind.Location = new System.Drawing.Point(754, 90);
            this.txtInfoContentFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoContentFind.Name = "txtInfoContentFind";
            this.txtInfoContentFind.PasswordChar = '\0';
            this.txtInfoContentFind.PlaceholderText = "";
            this.txtInfoContentFind.SelectedText = "";
            this.txtInfoContentFind.Size = new System.Drawing.Size(348, 36);
            this.txtInfoContentFind.TabIndex = 7;
            // 
            // comboInfoCriteria
            // 
            this.comboInfoCriteria.BackColor = System.Drawing.Color.Transparent;
            this.comboInfoCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboInfoCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInfoCriteria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboInfoCriteria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboInfoCriteria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboInfoCriteria.ForeColor = System.Drawing.Color.Black;
            this.comboInfoCriteria.ItemHeight = 30;
            this.comboInfoCriteria.Items.AddRange(new object[] {
            "Tìm theo CCCD",
            "Tìm theo tên KH",
            "Tìm theo ngày sinh",
            "Tìm theo giới tính",
            "Tìm theo SĐT",
            "Tìm theo Email",
            "Tìm theo ngày tham gia"});
            this.comboInfoCriteria.Location = new System.Drawing.Point(194, 90);
            this.comboInfoCriteria.Name = "comboInfoCriteria";
            this.comboInfoCriteria.Size = new System.Drawing.Size(350, 36);
            this.comboInfoCriteria.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(42, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "Tiêu chí tìm kiếm:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(307, 37);
            this.label15.TabIndex = 4;
            this.label15.Text = "Thông Tin Khách Hàng";
            // 
            // dtgvInfoCustomer
            // 
            this.dtgvInfoCustomer.AllowUserToAddRows = false;
            this.dtgvInfoCustomer.AllowUserToDeleteRows = false;
            this.dtgvInfoCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvInfoCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvInfoCustomer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInfoCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvInfoCustomer.ColumnHeadersHeight = 44;
            this.dtgvInfoCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInfoCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerId,
            this.colCustomerName,
            this.colCustomerBirthDate,
            this.colCustomerGender,
            this.colCustomerEmail,
            this.colCustomerPhone,
            this.colCustomerDateJoin,
            this.colCustomerNote,
            this.colCustmerEdit});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInfoCustomer.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvInfoCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvInfoCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvInfoCustomer.Location = new System.Drawing.Point(3, 161);
            this.dtgvInfoCustomer.Name = "dtgvInfoCustomer";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInfoCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvInfoCustomer.RowHeadersVisible = false;
            this.dtgvInfoCustomer.Size = new System.Drawing.Size(1216, 620);
            this.dtgvInfoCustomer.TabIndex = 0;
            this.dtgvInfoCustomer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dtgvInfoCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvInfoCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvInfoCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvInfoCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvInfoCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvInfoCustomer.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvInfoCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvInfoCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dtgvInfoCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvInfoCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInfoCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvInfoCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInfoCustomer.ThemeStyle.HeaderStyle.Height = 44;
            this.dtgvInfoCustomer.ThemeStyle.ReadOnly = false;
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dtgvInfoCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FillWeight = 121.8274F;
            this.colCustomerId.HeaderText = "CCCD/CMND/Hộ chiếu";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colCustomerName
            // 
            this.colCustomerName.FillWeight = 96.8818F;
            this.colCustomerName.HeaderText = "Họ tên KH";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colCustomerBirthDate
            // 
            this.colCustomerBirthDate.FillWeight = 96.8818F;
            this.colCustomerBirthDate.HeaderText = "Ngày sinh ";
            this.colCustomerBirthDate.Name = "colCustomerBirthDate";
            this.colCustomerBirthDate.ReadOnly = true;
            // 
            // colCustomerGender
            // 
            this.colCustomerGender.FillWeight = 96.8818F;
            this.colCustomerGender.HeaderText = "Giới tính";
            this.colCustomerGender.Name = "colCustomerGender";
            this.colCustomerGender.ReadOnly = true;
            // 
            // colCustomerEmail
            // 
            this.colCustomerEmail.FillWeight = 96.8818F;
            this.colCustomerEmail.HeaderText = "Email";
            this.colCustomerEmail.Name = "colCustomerEmail";
            this.colCustomerEmail.ReadOnly = true;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.HeaderText = "SĐT";
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.ReadOnly = true;
            // 
            // colCustomerDateJoin
            // 
            this.colCustomerDateJoin.FillWeight = 96.8818F;
            this.colCustomerDateJoin.HeaderText = "Ngày tham gia";
            this.colCustomerDateJoin.Name = "colCustomerDateJoin";
            this.colCustomerDateJoin.ReadOnly = true;
            // 
            // colCustomerNote
            // 
            this.colCustomerNote.FillWeight = 96.8818F;
            this.colCustomerNote.HeaderText = "Ghi chú";
            this.colCustomerNote.Name = "colCustomerNote";
            this.colCustomerNote.ReadOnly = true;
            // 
            // colCustmerEdit
            // 
            this.colCustmerEdit.FillWeight = 96.8818F;
            this.colCustmerEdit.HeaderText = "Sửa thông tin";
            this.colCustmerEdit.Name = "colCustmerEdit";
            this.colCustmerEdit.Text = "Sửa";
            // 
            // tabCheckout
            // 
            this.tabCheckout.Controls.Add(this.groupBox4);
            this.tabCheckout.Controls.Add(this.groupBox3);
            this.tabCheckout.Controls.Add(this.dtgvInvoice);
            this.tabCheckout.Location = new System.Drawing.Point(184, 4);
            this.tabCheckout.Name = "tabCheckout";
            this.tabCheckout.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckout.Size = new System.Drawing.Size(1222, 784);
            this.tabCheckout.TabIndex = 4;
            this.tabCheckout.Text = "Thanh Toán";
            this.tabCheckout.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInvoiceFind);
            this.groupBox4.Controls.Add(this.txtInvoiceContentFind);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.comboInvoiceCriteria);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(535, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(620, 190);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnInvoiceFind
            // 
            this.btnInvoiceFind.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInvoiceFind.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnInvoiceFind.Image = global::HotelManagement.Properties.Resources.find;
            this.btnInvoiceFind.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInvoiceFind.ImageRotate = 0F;
            this.btnInvoiceFind.ImageSize = new System.Drawing.Size(32, 32);
            this.btnInvoiceFind.Location = new System.Drawing.Point(485, 94);
            this.btnInvoiceFind.Name = "btnInvoiceFind";
            this.btnInvoiceFind.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.btnInvoiceFind.Size = new System.Drawing.Size(52, 50);
            this.btnInvoiceFind.TabIndex = 11;
            // 
            // txtInvoiceContentFind
            // 
            this.txtInvoiceContentFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceContentFind.DefaultText = "";
            this.txtInvoiceContentFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoiceContentFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoiceContentFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceContentFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceContentFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceContentFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceContentFind.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceContentFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceContentFind.Location = new System.Drawing.Point(130, 103);
            this.txtInvoiceContentFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvoiceContentFind.Name = "txtInvoiceContentFind";
            this.txtInvoiceContentFind.PasswordChar = '\0';
            this.txtInvoiceContentFind.PlaceholderText = "";
            this.txtInvoiceContentFind.SelectedText = "";
            this.txtInvoiceContentFind.Size = new System.Drawing.Size(348, 36);
            this.txtInvoiceContentFind.TabIndex = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(37, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 21);
            this.label26.TabIndex = 2;
            this.label26.Text = "Nội dung:";
            // 
            // comboInvoiceCriteria
            // 
            this.comboInvoiceCriteria.BackColor = System.Drawing.Color.Transparent;
            this.comboInvoiceCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboInvoiceCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInvoiceCriteria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboInvoiceCriteria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboInvoiceCriteria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboInvoiceCriteria.ForeColor = System.Drawing.Color.Black;
            this.comboInvoiceCriteria.ItemHeight = 30;
            this.comboInvoiceCriteria.Items.AddRange(new object[] {
            "Mã HĐ",
            "Mã KH",
            "Tên KH",
            "Mã Phòng"});
            this.comboInvoiceCriteria.Location = new System.Drawing.Point(132, 48);
            this.comboInvoiceCriteria.Name = "comboInvoiceCriteria";
            this.comboInvoiceCriteria.Size = new System.Drawing.Size(262, 36);
            this.comboInvoiceCriteria.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(37, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "Tiêu chí:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radInvoiceAll);
            this.groupBox3.Controls.Add(this.radInvoiceNotPaid);
            this.groupBox3.Controls.Add(this.radInvoicePaid);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 93);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình trạng";
            // 
            // radInvoiceAll
            // 
            this.radInvoiceAll.AutoSize = true;
            this.radInvoiceAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radInvoiceAll.CheckedState.BorderThickness = 0;
            this.radInvoiceAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radInvoiceAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radInvoiceAll.CheckedState.InnerOffset = -4;
            this.radInvoiceAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInvoiceAll.Location = new System.Drawing.Point(380, 41);
            this.radInvoiceAll.Name = "radInvoiceAll";
            this.radInvoiceAll.Size = new System.Drawing.Size(68, 25);
            this.radInvoiceAll.TabIndex = 2;
            this.radInvoiceAll.Text = "Tất cả";
            this.radInvoiceAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radInvoiceAll.UncheckedState.BorderThickness = 2;
            this.radInvoiceAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radInvoiceAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radInvoiceNotPaid
            // 
            this.radInvoiceNotPaid.AutoSize = true;
            this.radInvoiceNotPaid.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radInvoiceNotPaid.CheckedState.BorderThickness = 0;
            this.radInvoiceNotPaid.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radInvoiceNotPaid.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radInvoiceNotPaid.CheckedState.InnerOffset = -4;
            this.radInvoiceNotPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInvoiceNotPaid.Location = new System.Drawing.Point(201, 41);
            this.radInvoiceNotPaid.Name = "radInvoiceNotPaid";
            this.radInvoiceNotPaid.Size = new System.Drawing.Size(143, 25);
            this.radInvoiceNotPaid.TabIndex = 1;
            this.radInvoiceNotPaid.Text = "Chưa thanh toán";
            this.radInvoiceNotPaid.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radInvoiceNotPaid.UncheckedState.BorderThickness = 2;
            this.radInvoiceNotPaid.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radInvoiceNotPaid.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radInvoicePaid
            // 
            this.radInvoicePaid.AutoSize = true;
            this.radInvoicePaid.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radInvoicePaid.CheckedState.BorderThickness = 0;
            this.radInvoicePaid.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radInvoicePaid.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radInvoicePaid.CheckedState.InnerOffset = -4;
            this.radInvoicePaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInvoicePaid.Location = new System.Drawing.Point(39, 41);
            this.radInvoicePaid.Name = "radInvoicePaid";
            this.radInvoicePaid.Size = new System.Drawing.Size(126, 25);
            this.radInvoicePaid.TabIndex = 0;
            this.radInvoicePaid.Text = "Đã thanh toán";
            this.radInvoicePaid.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radInvoicePaid.UncheckedState.BorderThickness = 2;
            this.radInvoicePaid.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radInvoicePaid.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dtgvInvoice
            // 
            this.dtgvInvoice.AllowUserToAddRows = false;
            this.dtgvInvoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvInvoice.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvInvoice.ColumnHeadersHeight = 44;
            this.dtgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillId,
            this.colBillCustomerId,
            this.colBillCustomerName,
            this.colBillRoomId,
            this.colBillCheckinDate,
            this.colBillStatus,
            this.colBillPay});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInvoice.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgvInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvInvoice.Location = new System.Drawing.Point(3, 263);
            this.dtgvInvoice.Name = "dtgvInvoice";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvInvoice.RowHeadersVisible = false;
            this.dtgvInvoice.Size = new System.Drawing.Size(1216, 518);
            this.dtgvInvoice.TabIndex = 1;
            this.dtgvInvoice.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvInvoice.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvInvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dtgvInvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dtgvInvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvInvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInvoice.ThemeStyle.HeaderStyle.Height = 44;
            this.dtgvInvoice.ThemeStyle.ReadOnly = false;
            this.dtgvInvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dtgvInvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvInvoice.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvInvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dtgvInvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // colBillId
            // 
            this.colBillId.HeaderText = "Mã HĐ";
            this.colBillId.Name = "colBillId";
            this.colBillId.ReadOnly = true;
            // 
            // colBillCustomerId
            // 
            this.colBillCustomerId.HeaderText = "Mã KH";
            this.colBillCustomerId.Name = "colBillCustomerId";
            this.colBillCustomerId.ReadOnly = true;
            // 
            // colBillCustomerName
            // 
            this.colBillCustomerName.HeaderText = "Tên KH";
            this.colBillCustomerName.Name = "colBillCustomerName";
            this.colBillCustomerName.ReadOnly = true;
            // 
            // colBillRoomId
            // 
            this.colBillRoomId.HeaderText = "Mã phòng";
            this.colBillRoomId.Name = "colBillRoomId";
            this.colBillRoomId.ReadOnly = true;
            // 
            // colBillCheckinDate
            // 
            this.colBillCheckinDate.HeaderText = "Ngày đặt phòng";
            this.colBillCheckinDate.Name = "colBillCheckinDate";
            this.colBillCheckinDate.ReadOnly = true;
            // 
            // colBillStatus
            // 
            this.colBillStatus.HeaderText = "Tình trạng";
            this.colBillStatus.Name = "colBillStatus";
            this.colBillStatus.ReadOnly = true;
            // 
            // colBillPay
            // 
            this.colBillPay.HeaderText = "Thanh toán";
            this.colBillPay.Name = "colBillPay";
            this.colBillPay.Text = "Thanh toán";
            // 
            // tabStat
            // 
            this.tabStat.Location = new System.Drawing.Point(184, 4);
            this.tabStat.Name = "tabStat";
            this.tabStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat.Size = new System.Drawing.Size(1222, 784);
            this.tabStat.TabIndex = 6;
            this.tabStat.Text = "Thống Kê";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // tabEmpInfo
            // 
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpStatus);
            this.tabEmpInfo.Controls.Add(this.label32);
            this.tabEmpInfo.Controls.Add(this.dtInfoEmpDateHired);
            this.tabEmpInfo.Controls.Add(this.label31);
            this.tabEmpInfo.Controls.Add(this.linkLabel1);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpPos);
            this.tabEmpInfo.Controls.Add(this.label28);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpPassword);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpUsername);
            this.tabEmpInfo.Controls.Add(this.label29);
            this.tabEmpInfo.Controls.Add(this.label30);
            this.tabEmpInfo.Controls.Add(this.label22);
            this.tabEmpInfo.Controls.Add(this.btnInfoUpdateEmpInfo);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpGender);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpPhone);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpAddress);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpId);
            this.tabEmpInfo.Controls.Add(this.txtInfoEmpName);
            this.tabEmpInfo.Controls.Add(this.label27);
            this.tabEmpInfo.Controls.Add(this.guna2ImageButton4);
            this.tabEmpInfo.Controls.Add(this.guna2ImageButton5);
            this.tabEmpInfo.Controls.Add(this.guna2ImageButton10);
            this.tabEmpInfo.Controls.Add(this.guna2ImageButton11);
            this.tabEmpInfo.Controls.Add(this.guna2ImageButton12);
            this.tabEmpInfo.Location = new System.Drawing.Point(184, 4);
            this.tabEmpInfo.Name = "tabEmpInfo";
            this.tabEmpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpInfo.Size = new System.Drawing.Size(1222, 784);
            this.tabEmpInfo.TabIndex = 3;
            this.tabEmpInfo.Text = "Trang Cá Nhân";
            this.tabEmpInfo.UseVisualStyleBackColor = true;
            // 
            // txtInfoEmpStatus
            // 
            this.txtInfoEmpStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpStatus.DefaultText = "";
            this.txtInfoEmpStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpStatus.Enabled = false;
            this.txtInfoEmpStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpStatus.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpStatus.Location = new System.Drawing.Point(694, 525);
            this.txtInfoEmpStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpStatus.Name = "txtInfoEmpStatus";
            this.txtInfoEmpStatus.PasswordChar = '●';
            this.txtInfoEmpStatus.PlaceholderText = "";
            this.txtInfoEmpStatus.SelectedText = "";
            this.txtInfoEmpStatus.Size = new System.Drawing.Size(372, 45);
            this.txtInfoEmpStatus.TabIndex = 53;
            this.txtInfoEmpStatus.UseSystemPasswordChar = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(530, 537);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 21);
            this.label32.TabIndex = 52;
            this.label32.Text = "Trạng thái:";
            // 
            // dtInfoEmpDateHired
            // 
            this.dtInfoEmpDateHired.Checked = true;
            this.dtInfoEmpDateHired.CustomFormat = "dd/MM/yyyy";
            this.dtInfoEmpDateHired.Enabled = false;
            this.dtInfoEmpDateHired.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtInfoEmpDateHired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInfoEmpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInfoEmpDateHired.Location = new System.Drawing.Point(694, 442);
            this.dtInfoEmpDateHired.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInfoEmpDateHired.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInfoEmpDateHired.Name = "dtInfoEmpDateHired";
            this.dtInfoEmpDateHired.Size = new System.Drawing.Size(372, 36);
            this.dtInfoEmpDateHired.TabIndex = 51;
            this.dtInfoEmpDateHired.Value = new System.DateTime(2024, 7, 12, 9, 59, 44, 548);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(530, 451);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(150, 21);
            this.label31.TabIndex = 50;
            this.label31.Text = "Ngày bắt đầu làm:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(1090, 256);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 21);
            this.linkLabel1.TabIndex = 49;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đổi mật khẩu";
            // 
            // txtInfoEmpPos
            // 
            this.txtInfoEmpPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpPos.DefaultText = "";
            this.txtInfoEmpPos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpPos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpPos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpPos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpPos.Enabled = false;
            this.txtInfoEmpPos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpPos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpPos.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpPos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpPos.Location = new System.Drawing.Point(694, 341);
            this.txtInfoEmpPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpPos.Name = "txtInfoEmpPos";
            this.txtInfoEmpPos.PasswordChar = '●';
            this.txtInfoEmpPos.PlaceholderText = "";
            this.txtInfoEmpPos.SelectedText = "";
            this.txtInfoEmpPos.Size = new System.Drawing.Size(372, 45);
            this.txtInfoEmpPos.TabIndex = 48;
            this.txtInfoEmpPos.UseSystemPasswordChar = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(530, 352);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 21);
            this.label28.TabIndex = 47;
            this.label28.Text = "Vị trí:";
            // 
            // txtInfoEmpPassword
            // 
            this.txtInfoEmpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpPassword.DefaultText = "";
            this.txtInfoEmpPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpPassword.Enabled = false;
            this.txtInfoEmpPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpPassword.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpPassword.Location = new System.Drawing.Point(694, 241);
            this.txtInfoEmpPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpPassword.Name = "txtInfoEmpPassword";
            this.txtInfoEmpPassword.PasswordChar = '●';
            this.txtInfoEmpPassword.PlaceholderText = "";
            this.txtInfoEmpPassword.SelectedText = "";
            this.txtInfoEmpPassword.Size = new System.Drawing.Size(372, 45);
            this.txtInfoEmpPassword.TabIndex = 45;
            this.txtInfoEmpPassword.UseSystemPasswordChar = true;
            // 
            // txtInfoEmpUsername
            // 
            this.txtInfoEmpUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpUsername.DefaultText = "";
            this.txtInfoEmpUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpUsername.Enabled = false;
            this.txtInfoEmpUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpUsername.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpUsername.Location = new System.Drawing.Point(694, 153);
            this.txtInfoEmpUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpUsername.Name = "txtInfoEmpUsername";
            this.txtInfoEmpUsername.PasswordChar = '\0';
            this.txtInfoEmpUsername.PlaceholderText = "";
            this.txtInfoEmpUsername.SelectedText = "";
            this.txtInfoEmpUsername.Size = new System.Drawing.Size(372, 45);
            this.txtInfoEmpUsername.TabIndex = 44;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(530, 256);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 21);
            this.label29.TabIndex = 43;
            this.label29.Text = "Mật khẩu:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(530, 164);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(127, 21);
            this.label30.TabIndex = 42;
            this.label30.Text = "Tên đăng nhập:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(602, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(268, 37);
            this.label22.TabIndex = 41;
            this.label22.Text = "Thông tin tài khoản";
            // 
            // btnInfoUpdateEmpInfo
            // 
            this.btnInfoUpdateEmpInfo.BorderRadius = 10;
            this.btnInfoUpdateEmpInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfoUpdateEmpInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfoUpdateEmpInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfoUpdateEmpInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfoUpdateEmpInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnInfoUpdateEmpInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoUpdateEmpInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfoUpdateEmpInfo.Location = new System.Drawing.Point(159, 638);
            this.btnInfoUpdateEmpInfo.Name = "btnInfoUpdateEmpInfo";
            this.btnInfoUpdateEmpInfo.Size = new System.Drawing.Size(232, 52);
            this.btnInfoUpdateEmpInfo.TabIndex = 40;
            this.btnInfoUpdateEmpInfo.Text = "Sửa thông tin cá nhân";
            // 
            // txtInfoEmpGender
            // 
            this.txtInfoEmpGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpGender.DefaultText = "";
            this.txtInfoEmpGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpGender.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpGender.Location = new System.Drawing.Point(181, 525);
            this.txtInfoEmpGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpGender.Name = "txtInfoEmpGender";
            this.txtInfoEmpGender.PasswordChar = '\0';
            this.txtInfoEmpGender.PlaceholderText = "Giới tính";
            this.txtInfoEmpGender.SelectedText = "";
            this.txtInfoEmpGender.Size = new System.Drawing.Size(257, 45);
            this.txtInfoEmpGender.TabIndex = 38;
            // 
            // txtInfoEmpPhone
            // 
            this.txtInfoEmpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpPhone.DefaultText = "";
            this.txtInfoEmpPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpPhone.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpPhone.Location = new System.Drawing.Point(181, 433);
            this.txtInfoEmpPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpPhone.Name = "txtInfoEmpPhone";
            this.txtInfoEmpPhone.PasswordChar = '\0';
            this.txtInfoEmpPhone.PlaceholderText = "SĐT";
            this.txtInfoEmpPhone.SelectedText = "";
            this.txtInfoEmpPhone.Size = new System.Drawing.Size(257, 45);
            this.txtInfoEmpPhone.TabIndex = 33;
            // 
            // txtInfoEmpAddress
            // 
            this.txtInfoEmpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpAddress.DefaultText = "";
            this.txtInfoEmpAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpAddress.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpAddress.Location = new System.Drawing.Point(181, 341);
            this.txtInfoEmpAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpAddress.Name = "txtInfoEmpAddress";
            this.txtInfoEmpAddress.PasswordChar = '\0';
            this.txtInfoEmpAddress.PlaceholderText = "Địa chỉ";
            this.txtInfoEmpAddress.SelectedText = "";
            this.txtInfoEmpAddress.Size = new System.Drawing.Size(257, 45);
            this.txtInfoEmpAddress.TabIndex = 31;
            // 
            // txtInfoEmpId
            // 
            this.txtInfoEmpId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpId.DefaultText = "";
            this.txtInfoEmpId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpId.Enabled = false;
            this.txtInfoEmpId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpId.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpId.Location = new System.Drawing.Point(181, 249);
            this.txtInfoEmpId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpId.Name = "txtInfoEmpId";
            this.txtInfoEmpId.PasswordChar = '\0';
            this.txtInfoEmpId.PlaceholderText = "CCCD/CMND/Hộ chiếu";
            this.txtInfoEmpId.SelectedText = "";
            this.txtInfoEmpId.Size = new System.Drawing.Size(257, 45);
            this.txtInfoEmpId.TabIndex = 30;
            // 
            // txtInfoEmpName
            // 
            this.txtInfoEmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfoEmpName.DefaultText = "";
            this.txtInfoEmpName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInfoEmpName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInfoEmpName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInfoEmpName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoEmpName.ForeColor = System.Drawing.Color.Black;
            this.txtInfoEmpName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInfoEmpName.Location = new System.Drawing.Point(181, 157);
            this.txtInfoEmpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfoEmpName.Name = "txtInfoEmpName";
            this.txtInfoEmpName.PasswordChar = '\0';
            this.txtInfoEmpName.PlaceholderText = "Họ tên";
            this.txtInfoEmpName.SelectedText = "";
            this.txtInfoEmpName.Size = new System.Drawing.Size(257, 45);
            this.txtInfoEmpName.TabIndex = 29;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(35, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(204, 37);
            this.label27.TabIndex = 4;
            this.label27.Text = "Trang Cá Nhân";
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Image = global::HotelManagement.Properties.Resources.gender;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton4.Location = new System.Drawing.Point(83, 525);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton4.TabIndex = 39;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Image = global::HotelManagement.Properties.Resources.phone_call;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton5.Location = new System.Drawing.Point(83, 433);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton5.TabIndex = 37;
            // 
            // guna2ImageButton10
            // 
            this.guna2ImageButton10.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton10.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton10.Image = global::HotelManagement.Properties.Resources.address;
            this.guna2ImageButton10.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton10.ImageRotate = 0F;
            this.guna2ImageButton10.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton10.Location = new System.Drawing.Point(83, 341);
            this.guna2ImageButton10.Name = "guna2ImageButton10";
            this.guna2ImageButton10.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton10.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton10.TabIndex = 36;
            // 
            // guna2ImageButton11
            // 
            this.guna2ImageButton11.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton11.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton11.Image = global::HotelManagement.Properties.Resources.id_card;
            this.guna2ImageButton11.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton11.ImageRotate = 0F;
            this.guna2ImageButton11.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton11.Location = new System.Drawing.Point(83, 249);
            this.guna2ImageButton11.Name = "guna2ImageButton11";
            this.guna2ImageButton11.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton11.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton11.TabIndex = 35;
            // 
            // guna2ImageButton12
            // 
            this.guna2ImageButton12.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton12.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton12.Image = global::HotelManagement.Properties.Resources.user;
            this.guna2ImageButton12.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton12.ImageRotate = 0F;
            this.guna2ImageButton12.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton12.Location = new System.Drawing.Point(83, 153);
            this.guna2ImageButton12.Name = "guna2ImageButton12";
            this.guna2ImageButton12.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton12.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton12.TabIndex = 28;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1362, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1317, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Thêm";
            this.dataGridViewImageColumn1.Image = global::HotelManagement.Properties.Resources.plus;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 83;
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 815);
            this.Controls.Add(this.controlTabHome);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeFrm";
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            this.controlTabHome.ResumeLayout(false);
            this.tabRoom.ResumeLayout(false);
            this.tabRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericRoomCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            this.tabRoomBooking.ResumeLayout(false);
            this.tabRoomBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookingSelectedRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookingRoom)).EndInit();
            this.gbBookingRoomType.ResumeLayout(false);
            this.gbBookingRoomType.PerformLayout();
            this.gbBookingCapacity.ResumeLayout(false);
            this.gbBookingCapacity.PerformLayout();
            this.tabRegisterCustomer.ResumeLayout(false);
            this.tabRegisterCustomer.PerformLayout();
            this.gbRegisCustomerGender.ResumeLayout(false);
            this.gbRegisCustomerGender.PerformLayout();
            this.tabCustomerDetail.ResumeLayout(false);
            this.tabCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfoCustomer)).EndInit();
            this.tabCheckout.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoice)).EndInit();
            this.tabEmpInfo.ResumeLayout(false);
            this.tabEmpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TabControl controlTabHome;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabRegisterCustomer;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.TabPage tabCustomerDetail;
        private System.Windows.Forms.TabPage tabEmpInfo;
        private System.Windows.Forms.TabPage tabCheckout;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomId;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown numbericRoomCapacity;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomPrice;
        private Guna.UI2.WinForms.Guna2Button btnAddNewRoom;
        private Guna.UI2.WinForms.Guna2Button btnCreateNewRoom;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRoom;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtRegisCustomerBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisCustomerEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisCustomerPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisCustomerNote;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisCustomerId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbRegisCustomerGender;
        private Guna.UI2.WinForms.Guna2RadioButton radioRegisGenderFemale;
        private Guna.UI2.WinForms.Guna2RadioButton radioRegisGenderMale;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtRegisCustomerDateJoined;
        private Guna.UI2.WinForms.Guna2Button btnRegisAddNewCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisCustomerAddress;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox comboRoomType;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvInfoCustomer;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoContentFind;
        private Guna.UI2.WinForms.Guna2ComboBox comboInfoCriteria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ImageButton btnInfoFindCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabRoomBooking;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBookingStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBookingEnd;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingCustomerPhoneInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingCustomerIAddressnfo;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingCustomerIdInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingCustomerNameInfo;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton9;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingCustomerGenderInfo;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gbBookingRoomType;
        private System.Windows.Forms.GroupBox gbBookingCapacity;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBookingRoom;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBookingSelectedRoom;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillCheckinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colBillPay;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2ImageButton btnInvoiceFind;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceContentFind;
        private System.Windows.Forms.Label label26;
        private Guna.UI2.WinForms.Guna2ComboBox comboInvoiceCriteria;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2RadioButton radInvoiceAll;
        private Guna.UI2.WinForms.Guna2RadioButton radInvoiceNotPaid;
        private Guna.UI2.WinForms.Guna2RadioButton radInvoicePaid;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpGender;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton10;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton11;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpId;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpName;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton12;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2Button btnInfoUpdateEmpInfo;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpStatus;
        private System.Windows.Forms.Label label32;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtInfoEmpDateHired;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpPos;
        private System.Windows.Forms.Label label28;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtInfoEmpUsername;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private HotelManagementDataSet hotelManagementDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelManagementDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomDes;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2ImageButton imgBookingFindCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookRoomTyope;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookRoomPrice;
        private System.Windows.Forms.DataGridViewButtonColumn colBookRoomAdd;
        private System.Windows.Forms.RadioButton radBookingTypeSuite;
        private System.Windows.Forms.RadioButton radBookingTypeDeluxe;
        private System.Windows.Forms.RadioButton radBookingTypeStandard;
        private System.Windows.Forms.RadioButton radBookingDoubleRoom;
        private System.Windows.Forms.RadioButton radBookingSingleRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookRoomIdInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookRoomTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookRoomPriceInfo;
        private System.Windows.Forms.DataGridViewButtonColumn colBookRoomRemove;
        private Guna.UI2.WinForms.Guna2ImageButton btnInfoCustomerRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerDateJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerNote;
        private System.Windows.Forms.DataGridViewButtonColumn colCustmerEdit;
    }
}