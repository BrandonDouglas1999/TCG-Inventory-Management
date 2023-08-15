namespace InventoryApp
{
    partial class sales_report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_report));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            separator = new Label();
            panel2 = new Panel();
            start_date = new DateTimePicker();
            end_date = new DateTimePicker();
            get_receipts = new Button();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label22 = new Label();
            label3 = new Label();
            pop_cards = new DataGridView();
            cardPlot = new ScottPlot.FormsPlot();
            receipt_view = new DataGridView();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            label23 = new Label();
            receipt_info = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pop_cards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receipt_view).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)receipt_info).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1500, 850);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(separator);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(pop_cards);
            tabPage1.Controls.Add(cardPlot);
            tabPage1.Controls.Add(receipt_view);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1492, 822);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sales Report";
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(735, 140);
            separator.Name = "separator";
            separator.Size = new Size(2, 600);
            separator.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(start_date);
            panel2.Controls.Add(end_date);
            panel2.Controls.Add(get_receipts);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(56, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(617, 100);
            panel2.TabIndex = 24;
            // 
            // start_date
            // 
            start_date.Format = DateTimePickerFormat.Custom;
            start_date.Location = new Point(66, 13);
            start_date.Name = "start_date";
            start_date.Size = new Size(200, 23);
            start_date.TabIndex = 0;
            // 
            // end_date
            // 
            end_date.Format = DateTimePickerFormat.Custom;
            end_date.Location = new Point(66, 55);
            end_date.Name = "end_date";
            end_date.Size = new Size(200, 23);
            end_date.TabIndex = 1;
            // 
            // get_receipts
            // 
            get_receipts.BackColor = Color.FromArgb(50, 55, 143);
            get_receipts.Cursor = Cursors.Hand;
            get_receipts.FlatStyle = FlatStyle.Popup;
            get_receipts.ForeColor = Color.White;
            get_receipts.Location = new Point(348, 55);
            get_receipts.Name = "get_receipts";
            get_receipts.Size = new Size(169, 23);
            get_receipts.TabIndex = 8;
            get_receipts.Text = "Get Receipt History";
            get_receipts.UseVisualStyleBackColor = false;
            get_receipts.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 55);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 3;
            label2.Text = "To";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 55, 143);
            panel3.Controls.Add(label22);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1497, 63);
            panel3.TabIndex = 23;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(17, 22);
            label22.Name = "label22";
            label22.Size = new Size(130, 25);
            label22.TabIndex = 0;
            label22.Text = "Sales Reports";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(787, 149);
            label3.Name = "label3";
            label3.Size = new Size(321, 25);
            label3.TabIndex = 7;
            label3.Text = "Top 5 Best Sellers During This Period";
            // 
            // pop_cards
            // 
            pop_cards.AllowUserToAddRows = false;
            pop_cards.AllowUserToDeleteRows = false;
            pop_cards.AllowUserToResizeColumns = false;
            pop_cards.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            pop_cards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            pop_cards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pop_cards.BackgroundColor = SystemColors.Control;
            pop_cards.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pop_cards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pop_cards.Location = new Point(787, 205);
            pop_cards.Name = "pop_cards";
            pop_cards.ReadOnly = true;
            pop_cards.RowTemplate.Height = 25;
            pop_cards.Size = new Size(469, 161);
            pop_cards.TabIndex = 6;
            // 
            // cardPlot
            // 
            cardPlot.Anchor = AnchorStyles.None;
            cardPlot.Location = new Point(787, 411);
            cardPlot.Margin = new Padding(4, 3, 4, 3);
            cardPlot.Name = "cardPlot";
            cardPlot.Size = new Size(517, 329);
            cardPlot.TabIndex = 5;
            // 
            // receipt_view
            // 
            receipt_view.AllowUserToAddRows = false;
            receipt_view.AllowUserToDeleteRows = false;
            receipt_view.AllowUserToResizeColumns = false;
            receipt_view.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 239, 249);
            receipt_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            receipt_view.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            receipt_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            receipt_view.BackgroundColor = SystemColors.Control;
            receipt_view.BorderStyle = BorderStyle.None;
            receipt_view.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            receipt_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receipt_view.Location = new Point(56, 205);
            receipt_view.Name = "receipt_view";
            receipt_view.ReadOnly = true;
            receipt_view.RowTemplate.Height = 25;
            receipt_view.Size = new Size(667, 535);
            receipt_view.TabIndex = 4;
            receipt_view.CellContentClick += receipt_view_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(receipt_info);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1492, 822);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Receipt info";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 55, 143);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label23);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 63);
            panel1.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(6, 14);
            button1.Name = "button1";
            button1.Size = new Size(74, 33);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(78, 22);
            label23.Name = "label23";
            label23.Size = new Size(133, 25);
            label23.TabIndex = 1;
            label23.Text = "View Receipt";
            // 
            // receipt_info
            // 
            receipt_info.AllowUserToAddRows = false;
            receipt_info.AllowUserToDeleteRows = false;
            receipt_info.AllowUserToResizeColumns = false;
            receipt_info.AllowUserToResizeRows = false;
            receipt_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            receipt_info.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            receipt_info.BackgroundColor = Color.White;
            receipt_info.BorderStyle = BorderStyle.None;
            receipt_info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receipt_info.GridColor = SystemColors.Control;
            receipt_info.Location = new Point(133, 114);
            receipt_info.Name = "receipt_info";
            receipt_info.ReadOnly = true;
            receipt_info.RowHeadersVisible = false;
            receipt_info.RowHeadersWidth = 51;
            receipt_info.RowTemplate.Height = 25;
            receipt_info.Size = new Size(747, 378);
            receipt_info.TabIndex = 8;
            // 
            // sales_report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "sales_report";
            Size = new Size(1500, 850);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pop_cards).EndInit();
            ((System.ComponentModel.ISupportInitialize)receipt_view).EndInit();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)receipt_info).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ScottPlot.FormsPlot cardPlot;
        private DataGridView receipt_view;
        private Label label2;
        private Label label1;
        private DateTimePicker end_date;
        private DateTimePicker start_date;
        private TabPage tabPage2;
        private Label label3;
        private DataGridView pop_cards;
        private DataGridView receipt_info;
        private Button get_receipts;
        private Button button1;
        private Panel panel1;
        private Label label23;
        private Panel panel3;
        private Label label22;
        private Panel panel2;
        private Label separator;
    }
}
