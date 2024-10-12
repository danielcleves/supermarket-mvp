namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            tabControl1 = new TabControl();
            tabPageCustomerList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomers = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetail = new TabPage();
            TxtEmail = new TextBox();
            label11 = new Label();
            TxtPhoneNumber = new TextBox();
            label10 = new Label();
            DtpBirthday = new DateTimePicker();
            label9 = new Label();
            TxtAddress = new TextBox();
            label8 = new Label();
            TxtLastName = new TextBox();
            label7 = new Label();
            TxtFirstName = new TextBox();
            label6 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtDocumentNumber = new TextBox();
            label4 = new Label();
            TxtCustomerId = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomerDetail.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(895, 414);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomers);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 34);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(887, 376);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Provider List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(727, 291);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(152, 64);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(727, 221);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(152, 64);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(727, 151);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(152, 64);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(727, 81);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(152, 64);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(11, 81);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 62;
            DgCustomers.Size = new Size(710, 287);
            DgCustomers.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(671, 24);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 51);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(11, 34);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(654, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 6);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Provider";
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(TxtEmail);
            tabPageCustomerDetail.Controls.Add(label11);
            tabPageCustomerDetail.Controls.Add(TxtPhoneNumber);
            tabPageCustomerDetail.Controls.Add(label10);
            tabPageCustomerDetail.Controls.Add(DtpBirthday);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(TxtAddress);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(TxtLastName);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(TxtFirstName);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(TxtDocumentNumber);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Location = new Point(4, 34);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(887, 376);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Provider Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(440, 276);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(412, 31);
            TxtEmail.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(440, 248);
            label11.Name = "label11";
            label11.Size = new Size(54, 25);
            label11.TabIndex = 18;
            label11.Text = "Email";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(440, 214);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.PlaceholderText = "Phone Number";
            TxtPhoneNumber.Size = new Size(412, 31);
            TxtPhoneNumber.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(440, 186);
            label10.Name = "label10";
            label10.Size = new Size(132, 25);
            label10.TabIndex = 16;
            label10.Text = "Phone Number";
            // 
            // DtpBirthday
            // 
            DtpBirthday.Format = DateTimePickerFormat.Custom;
            DtpBirthday.Location = new Point(440, 150);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(300, 31);
            DtpBirthday.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(440, 124);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 14;
            label9.Text = "Birthday";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(440, 90);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.PlaceholderText = "Address";
            TxtAddress.Size = new Size(412, 31);
            TxtAddress.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(440, 62);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 12;
            label8.Text = "Address";
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(8, 214);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.PlaceholderText = "Last Number";
            TxtLastName.Size = new Size(412, 31);
            TxtLastName.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 186);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 10;
            label7.Text = "Last Name";
            // 
            // TxtFirstName
            // 
            TxtFirstName.Location = new Point(8, 152);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.PlaceholderText = "First Name";
            TxtFirstName.Size = new Size(412, 31);
            TxtFirstName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 124);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 8;
            label6.Text = "First Name";
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(135, 251);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(121, 63);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(8, 251);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(121, 63);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtDocumentNumber
            // 
            TxtDocumentNumber.Location = new Point(8, 90);
            TxtDocumentNumber.Name = "TxtDocumentNumber";
            TxtDocumentNumber.PlaceholderText = "Document Number";
            TxtDocumentNumber.Size = new Size(412, 31);
            TxtDocumentNumber.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 65);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 2;
            label4.Text = "Document Number";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(8, 31);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(209, 31);
            TxtCustomerId.TabIndex = 1;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 3);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 0;
            label3.Text = "Provider ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 150);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 47);
            label1.Name = "label1";
            label1.Size = new Size(184, 54);
            label1.TabIndex = 0;
            label1.Text = "Provider";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 564);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "CustomerView";
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCustomerDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtDocumentNumber;
        private Label label4;
        private TextBox TxtCustomerId;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TxtFirstName;
        private Label label6;
        private TextBox TxtLastName;
        private Label label7;
        private TextBox TxtAddress;
        private Label label8;
        private Label label9;
        private DateTimePicker DtpBirthday;
        private TextBox TxtPhoneNumber;
        private Label label10;
        private TextBox TxtEmail;
        private Label label11;
    }
}