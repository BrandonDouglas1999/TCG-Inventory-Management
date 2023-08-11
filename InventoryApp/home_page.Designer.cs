namespace InventoryApp
{
    partial class home_page
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_label = new System.Windows.Forms.Label();
            this.logged_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rate_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.chart2 = new ScottPlot.FormsPlot();
            this.chart = new ScottPlot.FormsPlot();
            this.increaseTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.increaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_label.Location = new System.Drawing.Point(31, 22);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(57, 23);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "User:";
            // 
            // logged_user
            // 
            this.logged_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logged_user.AutoSize = true;
            this.logged_user.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logged_user.Location = new System.Drawing.Point(95, 22);
            this.logged_user.Name = "logged_user";
            this.logged_user.Size = new System.Drawing.Size(61, 23);
            this.logged_user.TabIndex = 2;
            this.logged_user.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(970, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(764, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date: ";
            // 
            // rate_label
            // 
            this.rate_label.AutoSize = true;
            this.rate_label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rate_label.ForeColor = System.Drawing.Color.White;
            this.rate_label.Location = new System.Drawing.Point(1019, 51);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(0, 19);
            this.rate_label.TabIndex = 13;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_label.ForeColor = System.Drawing.Color.White;
            this.date_label.Location = new System.Drawing.Point(816, 51);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 19);
            this.date_label.TabIndex = 12;
            // 
            // chart2
            // 
            this.chart2.ForeColor = System.Drawing.SystemColors.Control;
            this.chart2.Location = new System.Drawing.Point(77, 65);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(525, 359);
            this.chart2.TabIndex = 11;
            // 
            // chart
            // 
            this.chart.ForeColor = System.Drawing.SystemColors.Control;
            this.chart.Location = new System.Drawing.Point(625, 65);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(611, 359);
            this.chart.TabIndex = 10;
            // 
            // increaseTable
            // 
            this.increaseTable.AllowUserToAddRows = false;
            this.increaseTable.AllowUserToDeleteRows = false;
            this.increaseTable.AllowUserToResizeColumns = false;
            this.increaseTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.increaseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.increaseTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.increaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.increaseTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.increaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.increaseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(76)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.increaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.increaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.increaseTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.increaseTable.Location = new System.Drawing.Point(95, 430);
            this.increaseTable.Name = "increaseTable";
            this.increaseTable.ReadOnly = true;
            this.increaseTable.RowHeadersVisible = false;
            this.increaseTable.RowTemplate.Height = 25;
            this.increaseTable.Size = new System.Drawing.Size(1248, 237);
            this.increaseTable.TabIndex = 16;
            this.increaseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.increaseTable_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Noticeable Price Changes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(248, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Exchange Rate History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(849, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Card Rate History";
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.increaseTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rate_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.logged_user);
            this.Controls.Add(this.user_label);
            this.Name = "home_page";
            this.Size = new System.Drawing.Size(1500, 850);
            ((System.ComponentModel.ISupportInitialize)(this.increaseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label user_label;
        private Label logged_user;
        private Label label2;
        private Label label1;
        private Label rate_label;
        private Label date_label;
        private ScottPlot.FormsPlot chart2;
        private ScottPlot.FormsPlot chart;
        private DataGridView increaseTable;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
