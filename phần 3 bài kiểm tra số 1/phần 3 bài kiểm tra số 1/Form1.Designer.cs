namespace phần_3_bài_kiểm_tra_số_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnChooseImage = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            picAvatar = new PictureBox();
            cboCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dgvProducts = new DataGridView();
            txtSearch = new TextBox();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChooseImage);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(picAvatar);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtUnitPrice);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(txtProductId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 444);
            panel1.TabIndex = 0;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(174, 394);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(94, 29);
            btnChooseImage.TabIndex = 16;
            btnChooseImage.Text = "Chọn Ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(148, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(18, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(117, 247);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(125, 62);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 12;
            picAvatar.TabStop = false;
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(117, 99);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(117, 194);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Location = new Point(117, 146);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 9;
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Location = new Point(117, 58);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 7;
            // 
            // txtProductId
            // 
            txtProductId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductId.Location = new Point(117, 18);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 247);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Ảnh đại diện\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 201);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Số lượng\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 153);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 107);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Danh mục\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên SP\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SP\r\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(statusStrip1);
            panel2.Controls.Add(dgvProducts);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(283, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 444);
            panel2.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(514, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(145, 20);
            lblStatus.Text = "Tổng số sản phẩm: 0";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(166, 79);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(300, 188);
            dgvProducts.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(166, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 21);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Tìm kiếm:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(514, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCSVToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.Size = new Size(165, 26);
            exportCSVToolStripMenuItem.Text = "Export CSV";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Button btnChooseImage;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox picAvatar;
        private ComboBox cboCategory;
        private Panel panel2;
        private TextBox txtSearch;
        private Label label7;
        private DataGridView dgvProducts;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
