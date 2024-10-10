namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            tabPageCategoryList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategory = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoryDescription = new TextBox();
            label5 = new Label();
            TxtCategoryName = new TextBox();
            label4 = new Label();
            TxtCategoryId = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(885, 518);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnClose);
            tabPageCategoryList.Controls.Add(BtnDelete);
            tabPageCategoryList.Controls.Add(BtnEdit);
            tabPageCategoryList.Controls.Add(BtnNew);
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(BtnSearch);
            tabPageCategoryList.Controls.Add(TxtSearch);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Location = new Point(4, 34);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(877, 480);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(719, 291);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(152, 64);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(719, 221);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(152, 64);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(719, 151);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(152, 64);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(719, 81);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(152, 64);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.AllowUserToAddRows = false;
            DgCategory.AllowUserToDeleteRows = false;
            DgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(11, 81);
            DgCategory.Name = "DgCategory";
            DgCategory.ReadOnly = true;
            DgCategory.RowHeadersWidth = 62;
            DgCategory.Size = new Size(702, 391);
            DgCategory.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(663, 24);
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
            TxtSearch.Size = new Size(646, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 6);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Category";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCancel);
            tabPageCategoryDetail.Controls.Add(BtnSave);
            tabPageCategoryDetail.Controls.Add(TxtCategoryDescription);
            tabPageCategoryDetail.Controls.Add(label5);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Location = new Point(4, 34);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(877, 480);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(135, 410);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(121, 63);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(8, 410);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(121, 63);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(8, 216);
            TxtCategoryDescription.Multiline = true;
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.PlaceholderText = "Category Description";
            TxtCategoryDescription.Size = new Size(412, 188);
            TxtCategoryDescription.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 191);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 4;
            label5.Text = "Category Description";
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(8, 119);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Category Name";
            TxtCategoryName.Size = new Size(412, 31);
            TxtCategoryName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 94);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 2;
            label4.Text = "Category Name";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(8, 31);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(209, 31);
            TxtCategoryId.TabIndex = 1;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 6);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 0;
            label3.Text = "Category Id";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 150);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.category;
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
            label1.Size = new Size(197, 54);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 668);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoryView";
            Text = "CategoryView";
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategory;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCategoryDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoryDescription;
        private Label label5;
        private TextBox TxtCategoryName;
        private Label label4;
        private TextBox TxtCategoryId;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}