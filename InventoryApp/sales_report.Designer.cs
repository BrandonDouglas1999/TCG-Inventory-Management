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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.get_receipts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pop_cards = new System.Windows.Forms.DataGridView();
            this.cardPlot = new ScottPlot.FormsPlot();
            this.receipt_view = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.receipt_info = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pop_cards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_view)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_info)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 680);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.get_receipts);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pop_cards);
            this.tabPage1.Controls.Add(this.cardPlot);
            this.tabPage1.Controls.Add(this.receipt_view);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.end_date);
            this.tabPage1.Controls.Add(this.start_date);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1103, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // get_receipts
            // 
            this.get_receipts.Location = new System.Drawing.Point(642, 41);
            this.get_receipts.Name = "get_receipts";
            this.get_receipts.Size = new System.Drawing.Size(136, 23);
            this.get_receipts.TabIndex = 8;
            this.get_receipts.Text = "Get Receipt History";
            this.get_receipts.UseVisualStyleBackColor = true;
            this.get_receipts.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Top 5 Cards During This Period";
            // 
            // pop_cards
            // 
            this.pop_cards.AllowUserToAddRows = false;
            this.pop_cards.AllowUserToDeleteRows = false;
            this.pop_cards.AllowUserToResizeColumns = false;
            this.pop_cards.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.pop_cards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pop_cards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pop_cards.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pop_cards.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pop_cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pop_cards.Location = new System.Drawing.Point(6, 379);
            this.pop_cards.Name = "pop_cards";
            this.pop_cards.ReadOnly = true;
            this.pop_cards.RowTemplate.Height = 25;
            this.pop_cards.Size = new System.Drawing.Size(469, 161);
            this.pop_cards.TabIndex = 6;
            // 
            // cardPlot
            // 
            this.cardPlot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPlot.Location = new System.Drawing.Point(482, 320);
            this.cardPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cardPlot.Name = "cardPlot";
            this.cardPlot.Size = new System.Drawing.Size(506, 329);
            this.cardPlot.TabIndex = 5;
            // 
            // receipt_view
            // 
            this.receipt_view.AllowUserToAddRows = false;
            this.receipt_view.AllowUserToDeleteRows = false;
            this.receipt_view.AllowUserToResizeColumns = false;
            this.receipt_view.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.receipt_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.receipt_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receipt_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receipt_view.BackgroundColor = System.Drawing.SystemColors.Control;
            this.receipt_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receipt_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.receipt_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipt_view.Location = new System.Drawing.Point(6, 72);
            this.receipt_view.Name = "receipt_view";
            this.receipt_view.ReadOnly = true;
            this.receipt_view.RowTemplate.Height = 25;
            this.receipt_view.Size = new System.Drawing.Size(1050, 239);
            this.receipt_view.TabIndex = 4;
            this.receipt_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receipt_view_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(374, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // end_date
            // 
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(407, 43);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 23);
            this.end_date.TabIndex = 1;
            // 
            // start_date
            // 
            this.start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date.Location = new System.Drawing.Point(103, 43);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 23);
            this.start_date.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.receipt_info);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receipt info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // receipt_info
            // 
            this.receipt_info.AllowUserToAddRows = false;
            this.receipt_info.AllowUserToDeleteRows = false;
            this.receipt_info.AllowUserToResizeColumns = false;
            this.receipt_info.AllowUserToResizeRows = false;
            this.receipt_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receipt_info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.receipt_info.BackgroundColor = System.Drawing.Color.White;
            this.receipt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receipt_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipt_info.GridColor = System.Drawing.SystemColors.Control;
            this.receipt_info.Location = new System.Drawing.Point(6, 118);
            this.receipt_info.Name = "receipt_info";
            this.receipt_info.ReadOnly = true;
            this.receipt_info.RowHeadersVisible = false;
            this.receipt_info.RowHeadersWidth = 51;
            this.receipt_info.RowTemplate.Height = 25;
            this.receipt_info.Size = new System.Drawing.Size(1091, 528);
            this.receipt_info.TabIndex = 8;
            // 
            // sales_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "sales_report";
            this.Size = new System.Drawing.Size(1111, 680);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pop_cards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_view)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receipt_info)).EndInit();
            this.ResumeLayout(false);

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
    }
}
